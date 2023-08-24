using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class report1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["login"] == null)
        {
            Server.Transfer("Index.aspx");
        }

        GridView1.DataSourceID = null;
        if (DateDDL.SelectedValue == "1" && ExamDDL.SelectedValue == "1")
        {
                GridView1.DataSourceID = "GetAllData";
        }
        else if(ExamDDL.SelectedValue != "1")
        {
            GridView1.DataSourceID = "reportExamData";
        }
        else if (DateDDL.SelectedValue != "1")
        {
            GridView1.DataSourceID = "reportYearData";
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (Request.Cookies["login"] != null)
        {
                GetAllData.SelectParameters["病患名稱"].DefaultValue =
                reportExamDLL.SelectParameters["病患名稱"].DefaultValue = 
                reportYearDLL.SelectParameters["病患名稱"].DefaultValue =
                reportExamData.SelectParameters["病患名稱"].DefaultValue =
                reportYearData.SelectParameters["病患名稱"].DefaultValue = 
                Server.UrlDecode(Request.Cookies["login"].Value);
        }
        else
        {
           // Server.Transfer("Index.aspx");
        }

    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                if (e.Row.Cells[5].Text.Contains("過"))
                {
                    //e.Row.Cells[4].BackColor = System.Drawing.Color.Red;
                    e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        HiddenField1.Value =(Convert.ToInt32(e.NewPageIndex)+1).ToString();
    }

    protected void reportExamDLL_Selected(object sender, SqlDataSourceStatusEventArgs e)
    {
        GridView1.PageIndex = 1;
        HiddenField1.Value = "1";
    }
}