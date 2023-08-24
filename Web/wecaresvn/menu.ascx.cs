using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSearchDr_Click(object sender, EventArgs e)
    {
        var name = keyword.Text;
        MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        
        var q = db.Staffs.Where(p => p.Staff_Name == name).Select(p => p.Staff_Name).FirstOrDefault();
        if (q == null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('查無此人')", true);
        }
        else
        {
            HttpContext.Current.Response.Redirect("MedicalTeams.aspx?drname=" + name);
        }
    }
}