using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class SatisfactionQuestionnaire : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["login"] == null)
        {
            Server.Transfer("Index.aspx");
        }

        GridView1.DataSourceID = "SqlDataSource1";
        string txtList = "";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand("Select Ptt_Name,Eva_Rlt from View_Evaluation where Eva_Rlt='商城購物金'or Eva_Rlt='活性碳口罩'or Eva_Rlt='3M乾洗手'", conn))
            {

                cmd.Parameters.AddWithValue("@EvaRlt", "" );
                 conn.Open();
                 SqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                    {
                        txtList += "<li>" + dr[0] + "&nbsp; &nbsp;" + dr[1] + "</li>";
                    }
                conn.Close();
                this.Literal1.Text ="<ul>"+ txtList+"</ul>";    
            
            }
            
            
  
        }
        

    }

    protected void UpdateButton_Click(object sender, EventArgs e)
    {
        FormView1.Visible = false;

        GridView1.DataSourceID = "SqlDataSource1";
        //GridView1.DataSource = SqlDataSource1
        //GridView1.DataBind()
        
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        //分頁
    }
}