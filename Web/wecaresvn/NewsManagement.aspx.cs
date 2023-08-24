using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _wecaresvn_NewsManagement : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myC = Request.Cookies["Job"];
        if (myC == null || myC.Value != "4")
        {   
            this.dv1.Visible = true;
            this.dv2.Visible = false;
            
        }
        else {
            this.dv1.Visible = false;
            this.dv2.Visible = true;
        }
       
            String strC1 = (String)Cache["c1"];
            String Newstype = (String)Cache["c2"];
            if (strC1 != null && Newstype != null)
            {

                SqlDataSource1.SelectCommand = "SELECT * FROM [News] Where " + Newstype + " LIKE '%" + strC1 + "%'";
                SqlDataSource1.DataBind();
                this.GridView1.DataBind();
            }
        }
        
    


    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
       //HttpCookie myC = Request.Cookies["Job"];


       // if (myC == null || myC.Value != "4")
       // {
       //     if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
       //     {

       //         e.Row.Cells[0].Visible = false;
               
       //     }
       // }
    }
    
    
    
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        string SType = this.DropDownList1.SelectedValue;
        string Stext = this.TextBox1.Text;

       
        Cache.Insert("c1", Stext);
        Cache.Insert("c2", SType);


        this.SqlDataSource1.SelectCommand = "SELECT * FROM [News] Where "+SType +" LIKE '%"+ Stext+"%'";
        this.SqlDataSource1.DataBind();
        this.GridView1.DataBind();


      
       
    }
    //protected void btnAll_Click(object sender, EventArgs e)
    //{
    //    Cache.Remove("c1");
    //    Cache.Remove("c2");
    //    string test = (String)Cache["c1"];

    //    this.SqlDataSource1.SelectCommand = "SELECT * FROM [News] ORDER BY [News_Date] DESC";
    //    this.SqlDataSource1.DataBind();
    //    this.GridView1.DataBind();
    //}

    protected void btndelete_Click(object sender, EventArgs e)
    {
        string sidx = this.dv2.Rows[0].Cells[1].Text;
         if (sidx != "")
            {
                string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(strConn))
                {

                    string strCmd = "DELETE FROM News where News_ID=" + sidx;
                    using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                    {


                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (result != 0)
                        {
                            this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('刪除資料成功')</script>"));
                           
                            this.GridView1.DataBind();
                        }
                    }


                }
            }
            else
            {
                this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('修改失敗,請先選取編輯項目!')</script>"));
            }
         this.dv2.DataBind();
         this.GridView1.DataBind();
        }
    
}