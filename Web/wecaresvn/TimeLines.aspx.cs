using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;

public partial class TimeLines : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        string PttID = "1";
        if (Request.Cookies["PttID"] != null)
        {
            PttID = Request.Cookies["PttID"].Value;
        }
        if (Request.Cookies["login"] == null)
        {
            Server.Transfer("Index.aspx");
        }

        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        string Block = "";   //時間軸結點標籤
        List<Recordevent> Recordlist = new List<Recordevent>();
        using (SqlConnection Conn = new SqlConnection(strConn))
        {
            string strCmd = "select timeline_Date,timeline_title,timeline_Des,TimeLine_Bytes,TimeLine_ID  from TimeLines WHERE [Ptt_ID] = @Ptt_ID union SELECT ExamCalendar.ExamSch_DoE, ExamCategories.ExamCat_Name,ExamOverview.Exam_NameCH + '：' + ExamCalendar.ExamSch_Rlt AS Description,null ,RegisterInformation.Ptt_ID FROM Diagnosis INNER JOIN ExamOverview INNER JOIN ExamCategories ON ExamOverview.ExamCat_ID = ExamCategories.ExamCat_ID INNER JOIN ExamSchedules ON ExamOverview.Exam_ID = ExamSchedules.Exam_ID INNER JOIN ExamCalendar ON ExamSchedules.ExamSch_ID = ExamCalendar.ExamSch_ID ON Diagnosis.Diag_ID = ExamSchedules.Diag_ID INNER JOIN RegisterInformation ON Diagnosis.RegInfo_ID = RegisterInformation.RegInfo_ID INNER JOIN Patients INNER JOIN TimeLines ON Patients.Ptt_ID = TimeLines.Ptt_ID ON RegisterInformation.Ptt_ID = Patients.Ptt_ID WHERE ExamCalendar.ExamSch_Rlt < > '尚未檢測' and TimeLines.Ptt_ID = @Ptt_ID order by timeline_Date asc";
                            //"select timeline_Date,timeline_title,timeline_Des,TimeLine_Bytes,TimeLine_ID  from TimeLines WHERE [Ptt_ID] = @Ptt_ID order by timeline_Date asc";
            string strCmd2 = "INSERT INTO [TimeLines] ([Ptt_ID], [TimeLine_Date], [TimeLine_Title], [TimeLine_Des]) VALUES (@Ptt_ID, @TimeLine_Date, @TimeLine_Title, @TimeLine_Des)";
            Conn.Open();
            using (SqlCommand Cmd = new SqlCommand(strCmd, Conn))
            {
                Cmd.Parameters.AddWithValue("@Ptt_ID", PttID);
                DataTable dt = new DataTable();
                dt.Load(Cmd.ExecuteReader());
                if(dt.Rows.Count==0)
                {
                    using (SqlCommand Cmd2 = new SqlCommand(strCmd2,Conn))
                    {
                        string firstdate=DateTime.Now.ToShortDateString();
                        string firsttitle="啟用時間軸";
                        string firstdes="歡迎使用WeCare時間軸編輯器，您可以使用此工具來記錄自己的健康狀況";
                        Cmd2.Parameters.AddWithValue("@Ptt_ID",PttID);
                        Cmd2.Parameters.AddWithValue("@TimeLine_Date",firstdate);
                        Cmd2.Parameters.AddWithValue("@TimeLine_Title",firsttitle);
                        Cmd2.Parameters.AddWithValue("@TimeLine_Des",firstdes);
                        Cmd2.ExecuteNonQuery();
                    }
                    dt.Load(Cmd.ExecuteReader());
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string myyear = dt.Rows[i].Field<DateTime>("TimeLine_Date").Year.ToString();
                    string monthday = string.Format("{0}", (dt.Rows[i].Field<DateTime>("TimeLine_Date").ToString("MM/dd")));
                    string mytitle, mydes, myphoto;  //此三個變數需要判斷是否允許空值，運用三元運算式
                    mytitle = (dt.Rows[i].Field<string>("TimeLine_Title") != null) ? dt.Rows[i].Field<string>("TimeLine_Title").ToString() : "";
                    mydes = (dt.Rows[i].Field<string>("TimeLine_Des") != null) ? dt.Rows[i].Field<string>("TimeLine_Des").ToString() : "";
                    myphoto = (dt.Rows[i].Field<byte[]>("TimeLine_Bytes") != null) ? dt.Rows[i].Field<byte[]>("TimeLine_Bytes").ToString() : "";
                    int myid = dt.Rows[i].Field<int>("TimeLine_ID");
                    Recordlist.Add(new Recordevent(myyear, monthday, mytitle, mydes, myphoto, myid));
                                      
                }
                SqlDataReader dr = Cmd.ExecuteReader();
                #region
                //while (dr.Read())
                //{
                //    string monthday = string.Format("{0}", ((DateTime)dr[0]).ToString("MM/dd"));
                //    Recordlist.Add(new Recordevent(((DateTime)dr[0]).Year.ToString(), monthday, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), (int)dr[4]));
                //}
                //dr.Close();
                //dr.Dispose();
                #endregion
                Conn.Close();
                Conn.Dispose();
            }

        }

        string py = "";
        string PhotoError = ""; //判斷是否有圖片;
        foreach (var item in Recordlist)
        {
            if (item.Year != py)      //判斷是否為同一年
            {
                Block += "<div class='step year'>" +
                          "<div class='dsk-titlenode'>" + item.Year + "</div>" +
                            "<div class='dsk-content'>" +
                            "<p class='dsk-year-info'></p>" +
                            "</div></div>";
                py = item.Year;              //將新的一年記起來以利判斷
            }
            if (item.PhotoName != "")
            {
                PhotoError = "<img src='HandlerTimeImg.ashx?timelineID=" + item.TimeLineID + "' alt='' /></div></div>";
            }
            else
            {
                PhotoError = "<img src='TiemlineJquery/wecare-02.png' alt='' /></div></div>";
            }
            Block += "<div class='step'>" +
                "<div class='dsk-circle'>" + item.MonthDay + "</div>" +
                "<h2 class='dsk-circle-title'>" + item.Title + "</h2>" +
                "<div class='dsk-content'>" +
                "<div class='dsk-info'>" +
                    "<h2 class='timeh2'>" + item.Title + " </h2>" +
                    "<p>" + item.Description + "</p>" +
                "<a href='../TimeLinesEdit.aspx' class='dsk-link'>編輯</a> </div>" + PhotoError;
        }
        Literal1.Text = Block;
     //   "<a href='../TimeLinesEdit.aspx?ID=" + PttID + "' class='dsk-link'>編輯</a> </div>" + PhotoError;
    }
    public class Recordevent
    {
        public Recordevent(string Years,string MonthDays, string Titles, string Descrip, string Photo, int timeid)
        {
            this.Year = Years;
            this.MonthDay = MonthDays;
            this.Title = Titles;
            this.Description = Descrip;
            this.PhotoName = Photo;
            this.TimeLineID = timeid;
        }
        public string Year { get; set; }
        public string MonthDay { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoName { get; set; }
        public int TimeLineID { get; set; }
    }
}