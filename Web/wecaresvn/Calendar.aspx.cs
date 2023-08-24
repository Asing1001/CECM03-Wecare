using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calendar : System.Web.UI.Page
{
    //DateTime _today = DateTime.Today.Date;

    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Label1.Text = ((DateTime)Cache["tDay"]).Month.ToString();
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        DateTime _today = (DateTime)Cache["tDay"];
        string _caltype = Request.Cookies["caltype"].Value;
        int _days = 0;
        if (_caltype == "day")
        {
            _days = 1;
        }
        else if (_caltype == "week")
        {
            _days = 7;
        }
        else
        {
            _days = 30;
        }

        Cache.Insert("tDay", _today.AddDays(_days));
        Response.Redirect("calendar.aspx");
    }
    protected void btnToday_Click(object sender, EventArgs e)
    {
        //Cache.Remove("tDay");
        Cache.Insert("tDay", DateTime.Today);
        Response.Redirect("calendar.aspx");
    }
    protected void btnLast_Click(object sender, EventArgs e)
    {
        DateTime _today = (DateTime)Cache["tDay"];
        string _caltype = Request.Cookies["caltype"].Value;
        int _days = 0;
        if (_caltype == "day")
        {
            _days = 1;
        }
        else if (_caltype == "week")
        {
            _days = 7;
        }
        else
        {
            _days = 30;
        }

        Cache.Insert("tDay", _today.AddDays(-_days));
        Response.Redirect("calendar.aspx");
    }
}