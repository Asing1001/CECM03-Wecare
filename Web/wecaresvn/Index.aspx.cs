using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string txtList = "";
        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmd = "select top 6  * from News ORDER BY News_Date DESC ";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["News_Type"].ToString() == "重要")
                    {
                        txtList += "<tr><td>" + ((DateTime)dr["News_Date"]).ToShortDateString() + "</td><td>  <img src='images/star_icons04.gif' style='width:16px;height:16px' /> </td><td>   [" + dr["News_Type"] + "] </td><td><a class='mya' href='NewsManagement.aspx?News_ID=" + dr["News_ID"] + "'> &nbsp;    " + dr["News_Title"] + "</a></td></tr>";
                    }
                    else
                    {


                        txtList += "<tr><td>" + ((DateTime)dr["News_Date"]).ToShortDateString() + "</td><td>  </td><td>  [" + dr["News_Type"] + "]</td><td><a class='mya' href='NewsManagement.aspx?News_ID=" + dr["News_ID"] + "'> &nbsp; " + dr["News_Title"] + "</a></td></tr>";
                    }

                }
                conn.Close();
                this.Literal2.Text = txtList ;
            }
        }       



    }
}