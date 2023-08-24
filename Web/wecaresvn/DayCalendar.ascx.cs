using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebCareWeb.App_Code;

public partial class DayCalendar : System.Web.UI.UserControl
{
    DateTime _today;

    protected void Page_Load(object sender, EventArgs e)
    {
        _today = (DateTime)Cache["tDay"];
        string pa = Server.UrlDecode(Request.Cookies["login"].Value);

        if (Request.Cookies["Job"] != null)
        {
            ClsDrugCalendar dCal = new ClsDrugCalendar();
            ClsExamCalender eCal = new ClsExamCalender();            

            this.drugCalList.DataSource = dCal.GetData(_today, pa, 1);
            this.eCal.DataSource = eCal.GetData(_today, pa, 1);

            this.drugCalList.DataBind();
            this.eCal.DataBind();
        }
        else
        {
            ClsDrugCalendar dCal = new ClsDrugCalendar();
            ClsExamCalender eCal = new ClsExamCalender();

            this.drugCalList.DataSource = dCal.GetData(_today, pa, 0);
            this.eCal.DataSource = eCal.GetData(_today, pa, 0);

            this.drugCalList.DataBind();
            this.eCal.DataBind();
        }
    }
}