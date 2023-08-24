using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCareWeb.App_Code;

public partial class WeekCalendar : System.Web.UI.UserControl
{
    DateTime _today;

    protected void Page_Load(object sender, EventArgs e)
    {

        _today = (DateTime)Cache["tDay"];
        
        string pa = "";

        if (Request.Cookies["Job"] != null)
        {
            pa = Request.Cookies["login"].Value;
        }
        else if (Request.Cookies["PttID"] != null)
        {
            pa = Request.Cookies["PttID"].Value;
        }
        else
        {
            Response.Redirect("Index.aspx");
        }
     
        //DateTime _today = DateTime.Today;
        DateTime _firstDay = _today.AddDays(-(_today.DayOfWeek - DayOfWeek.Sunday));

        using (MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
        {
            for (int i = 0; i < 7; i++)
            {
                string s = "";

                if (Request.Cookies["Job"] != null)
                {
                    string name = db.Staffs.Where(n => n.Staff_Acc == pa).Single().Staff_Name;
                    int id = db.Staffs.Where(n => n.Staff_Acc == pa).Single().Staff_ID;

                    var q = db.View_ExamCalendars.Where(n => n.檢驗日期 == _firstDay.AddDays(i).Date &&
                            (n.主治醫師 == name || n.護士ID == id || n.諮詢師ID == id));

                    foreach (var item in q)
                    {
                        s += "<div class='divItemExam'>"
                                + item.病患名稱 + "&nbsp;" + item.檢驗項目 + "&nbsp;"
                                + "<span style='display:none;'>" + item.行事曆ID + "&nbsp;1</span>"
                                + "<span style='display:none;'>&nbsp;" + item.檢驗日期.ToShortDateString() + "</span></div>";
                    }

                    var p = db.View_DrugCalendars.Where(n => n.用藥日期 == _firstDay.AddDays(i) &&
                            (n.主治醫師 == name || n.護士ID == id || n.諮詢師ID == id));

                    foreach (var item in p)
                    {
                        s += "<div class='divItemDrug'>"
                                + item.病患姓名 + "&nbsp;" + item.特殊藥物 + "&nbsp;"
                                + "<span style='display:none;'>" + item.ID + "&nbsp;2</span>"
                                + "<span name='date' style='display:none'>&nbsp;" + item.用藥日期.ToShortDateString() + "</span></div>";
                    }
                }
                else
                {
                    string loginPtt = db.Patients.Where(n => n.Ptt_ID == Convert.ToInt32(pa)).Single().Ptt_Name;

                    var q = db.View_ExamCalendars.Where(n => n.檢驗日期 == _firstDay.AddDays(i).Date && n.病患名稱 == loginPtt);

                    foreach (var item in q)
                    {
                        s += "<div class='divItemExam'>"
                                + item.病患名稱 + "&nbsp;" + item.檢驗項目 + "&nbsp;"
                                + "<span style='display:none;'>" + item.行事曆ID + "&nbsp;1</span>"
                                + "<span style='display:none;'>&nbsp;" + item.檢驗日期.ToShortDateString() + "</span></div>";
                    }

                    var p = db.View_DrugCalendars.Where(n => n.用藥日期 == _firstDay.AddDays(i) && n.病患姓名 == loginPtt);

                    foreach (var item in p)
                    {
                        s += "<div class='divItemDrug'>"
                                + item.病患姓名 + "&nbsp;" + item.特殊藥物 + "&nbsp;"
                                + "<span style='display:none;'>" + item.ID + "&nbsp;2</span>"
                                + "<span name='date' style='display:none'>&nbsp;" + item.用藥日期.ToShortDateString() + "</span></div>";
                    }
                }

                switch (i)
                {
                    case 0:
                        this.Literal0.Text = "<div id='divSunWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label0.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    case 1:
                        this.Literal1.Text = "<div id='divMonWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label1.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    case 2:
                        this.Literal2.Text = "<div id='divTueWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label2.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    case 3:
                        this.Literal3.Text = "<div id='divWenWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label3.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    case 4:
                        this.Literal4.Text = "<div id='divThuWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label4.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    case 5:
                        this.Literal5.Text = "<div id='divFriWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label5.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    case 6:
                        this.Literal6.Text = "<div id='divSatWeek' name='" + _firstDay.AddDays(i).ToShortDateString() + "' class='divWCal'>" + s + "</div>";
                        this.Label6.Text = _firstDay.AddDays(i).ToShortDateString();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}