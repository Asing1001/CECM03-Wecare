using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimeLinesEdit : System.Web.UI.Page
{
    //string pttid = "1";
    //protected void Page_Init(object sender, EventArgs e)
    //{
    //    //Response.Cookies["PttID"].Value = Request.QueryString["ID"].ToString();
    //    if (Response.Cookies["PttID"] != null)
    //    {
    //       // Response.Cookies["PttID"].Value;
    //    }
    //}
    static string PttID = "1";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["PttID"] != null)
        {
            PttID = Request.Cookies["PttID"].Value;
        }
        if (Request.Cookies["login"] == null)
        {
            Server.Transfer("Index.aspx");
        }
    
    }
    protected void LbtnBack_Click(object sender, EventArgs e)
    {
        this.GridViewTimExit.DataSourceID="SqlDataSource1";
    }
    
    protected void GridViewTimExit_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "New")
        {
            GridViewTimExit.DataSourceID = null;
           
        }
        if (e.CommandName == "Edit")
        {
            rowindex = Convert.ToInt32(e.CommandArgument); //利用RowCommand取得Rowindex
        }
        if (e.CommandName == "Update")
        {
            

        }
    }

    //FindControl
    public FileUpload file;
    public Table GridViewTimExitTable
    {
        get
        {
            return ((Table)GridViewTimExit.Controls[0]);
        }
    }
    public DetailsView DetailsViewInsert
    {
        get
        {
            return (DetailsView)GridViewTimExitTable.Rows[0].FindControl("DetailsViewInsert");
        }
    }
    public Calendar UpdateCalendar
    {
        get
        {
           return (Calendar)GridViewTimExit.Rows[rowindex].FindControl("UpdateCalendar");
        }
        set { }
    }
    public TextBox txtUpCalder
    {
        get
        {
            return (TextBox)GridViewTimExit.Rows[rowindex].FindControl("txtUpCalder");
        }
        set { }
    }
    public static int rowindex; //記住Rowindex
    //=======================================================================================================================

    protected void GridViewTimExit_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        file = (FileUpload)GridViewTimExit.Rows[Convert.ToInt32(rowindex)].FindControl("UpFileUpload");
        if (file.HasFile)
        {
            string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                string strCmd = "UPDATE[TimeLines] set TimeLine_Bytes=@TimeLineBytes where [TimeLine_ID]=@TimeLineID";
                using (SqlCommand Cmd = new SqlCommand(strCmd, Conn))
                {
                    //Cmd.Parameters.AddWithValue("@TimeLineBytes", file.FileBytes);
                    SqlParameter pTimeLineBytes = new SqlParameter("@TimeLineBytes", SqlDbType.VarBinary);
                    pTimeLineBytes.Direction = ParameterDirection.Input;
                    pTimeLineBytes.Value = file.FileBytes;
                    Cmd.Parameters.Add(pTimeLineBytes);
                    string id = ((Label)GridViewTimExit.Rows[rowindex].FindControl("LabTimeIdedit")).Text;  //為了抓到TimeLine_ID ，先將其轉為Template，在FindControl
                    Cmd.Parameters.AddWithValue("@TimeLineID",id);
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();

                }
            }

        }
    }


    protected void DetailsViewInsert_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (file.FileName.Length > 0)
        {
            string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
            using (SqlConnection Conn = new SqlConnection(strConn))
            {
                string strCmd = "UPDATE[TimeLines] set TimeLine_Bytes=@TimeLineBytes where [TimeLine_ID]= (select max(TimeLine_ID) from TimeLines )";
                using (SqlCommand Cmd = new SqlCommand(strCmd, Conn))
                {
                    //Cmd.Parameters.AddWithValue("@TimeLineBytes", file.FileBytes);
                    SqlParameter pTimeLineBytes = new SqlParameter("@TimeLineBytes", SqlDbType.VarBinary);
                    pTimeLineBytes.Direction = ParameterDirection.Input;
                    pTimeLineBytes.Value = file.FileBytes;
                    Cmd.Parameters.Add(pTimeLineBytes);

                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();

                }
            }
        }
        Response.Write("<script>alert('新增成功')</script>");
        LbtnBack_Click(sender, e);
        
        
    }
    protected void DetailsViewInsert_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
         if (e.CommandName == "Insert")
                {
                    //Table GridViewTable = ((Table)GridViewTimExit.Controls[0]);
                    //DetailsView MyDetailsView = (DetailsView)GridViewTable.Rows[0].FindControl("DetailsViewInsert");
                    file = (FileUpload)DetailsViewInsert.FindControl("InsFileUpload");
                }
    }

}