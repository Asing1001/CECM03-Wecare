using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CtrAnnou : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string txtList = "";
        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmd = "select * from News where News_Type='重要' ORDER BY News_Date DESC";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtList += "<li><a class='mya' href='NewsManagement.aspx?News_ID=" + dr["News_ID"] + "'>" + ((DateTime)dr["News_Date"]).ToShortDateString()  +"  &nbsp; &nbsp; <img src='images/star_icons04.gif' style='width:16px;height:16px' />    [" + dr["News_Type"] + "]  &nbsp;    " + dr["News_Title"] + "</a></li>";
                
                
                }
                conn.Close();
                this.Literal1.Text ="<ul>"+ txtList+"</ul>";           
            }
        }       
    }
}