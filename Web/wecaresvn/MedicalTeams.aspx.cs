using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class MedicalTeams : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string t = null;
        t= Request.QueryString["drName"];
        //Request.Url.Query

        if (t != null)
        {
            GridView1.DataSourceID = "drName";

        }
        else
        {
            GridView1.DataSourceID = "SqlDataSource1";
        }
    }

   

}