using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommonHealthModify : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myC = Request.Cookies["Job"];
        if (myC == null || myC.Value != "4")
        {
            Response.Redirect("Index.aspx");
        }


        if (!IsPostBack)
        {
            this.Table2.Style.Add("display", "none");
            this.Table1.Style.Add("display", "none");
        }





    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        if (
            this.TextBox1.Text != ""
                       && this.TextBox2.Text != ""
                       && this.TextBox3.Text != "")
        {
            string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "";
                if (this.FileUpload3.HasFile)
                {
                    string extName = System.IO.Path.GetExtension(FileUpload3.PostedFile.FileName).ToLower();
                    string mine = "";

                    switch (extName)
                    {
                        case ".gif": mine = "image/gif"; break;
                        case ".jpg": mine = "image/jpg"; break;
                        case ".png": mine = "image/png"; break;

                        default: break;

                    }
                    if (mine != "")
                    {
                        strCmd = "insert into HealthKnowledge (Health_Type,Health_Title,Health_Cont,Health_img) Values(@Htype,@Htitle,@Hcont,@Himg)";
                    }
                    else
                    {
                        this.Page.Form.Controls.Add(new LiteralControl("<script>alert('請選擇正確格式之圖片檔!')</script>"));
                        strCmd = "insert into HealthKnowledge (Health_Type,Health_Title,Health_Cont) Values(@Htype,@Htitle,@Hcont)";
                    }
                }

                else
                {
                    strCmd = "insert into HealthKnowledge (Health_Type,Health_Title,Health_Cont) Values(@Htype,@Htitle,@Hcont)";
                }
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    byte[] imagebyte = new byte[this.FileUpload3.PostedFile.InputStream.Length];
                    this.FileUpload3.PostedFile.InputStream.Read(imagebyte, 0, imagebyte.Length);

                    cmd.Parameters.AddWithValue("@Htype", this.TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Htitle", this.TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Hcont", this.TextBox3.Text);
                    if (this.FileUpload3.HasFile)
                    {
                        cmd.Parameters.AddWithValue("@Himg", imagebyte);
                    }
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result == 0)
                    {
                        this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('新增失敗,請重新輸入!')</script>"));

                    }
                    else
                    {
                        this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('新增資料成功!')</script>"));
                        this.GridView1.DataBind();
                    }

                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox3.Text = "";
                }

            }
        }
        else
        {
            this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('新增失敗,不能有空白資料!')</script>"));
        }
    }

    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {






        if (e.Row.RowType == DataControlRowType.DataRow)
        {



            if (e.Row.RowIndex % 2 == 0)
            {
                e.Row.BackColor = System.Drawing.Color.LightPink;
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#FF8880'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFB6C1'");

            }
            else
            {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#FF8880'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF'");


            }



        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //內文遇到英文字也要自動換行
            e.Row.Cells[3].Style.Add("word-break", "break-all");
        }
    }



    private static string sidx = "";
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "mys")
        {
            int i = Convert.ToInt32(e.CommandArgument);
            sidx = this.sindx.Text = this.GridView1.Rows[i].Cells[0].Text;
            this.TextBox4.Text = this.GridView1.Rows[i].Cells[1].Text;
            this.TextBox5.Text = this.GridView1.Rows[i].Cells[2].Text;
            this.TextBox6.Text = this.GridView1.Rows[i].Cells[3].Text;
            this.Image2.ImageUrl = "~/Handlers/HealthPic.ashx?Health_ID=" + sidx;
            this.Table2.Style.Add("display", "block");



        }

    }
    protected void btnupdata_Click(object sender, EventArgs e)
    {
        if (sidx != "")
        {
            string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "";
                byte[] imagebyte = null;
                if (this.FileUpload1.HasFile)
                {

                    imagebyte = new byte[this.FileUpload1.PostedFile.InputStream.Length];
                    this.FileUpload1.PostedFile.InputStream.Read(imagebyte, 0, imagebyte.Length);
                    string extName = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower();
                    string mine = "";

                    switch (extName)
                    {
                        case ".gif": mine = "image/gif"; break;
                        case ".jpg": mine = "image/jpg"; break;
                        case ".png": mine = "image/png"; break;

                        default: break;

                    }
                    if (mine != "")
                    {

                        strCmd = "UPDATE HealthKnowledge SET Health_Type=@Htype,Health_Title=@Htitle,Health_Cont=@Hcont,Health_img =@Himg where Health_ID=" + sidx;
                    }
                    else
                    {
                        this.Page.Form.Controls.Add(new LiteralControl("<script>alert('圖片更新失敗,請選擇正確格式之圖片檔!')</script>"));
                        strCmd = "UPDATE HealthKnowledge SET Health_Type=@Htype,Health_Title=@Htitle,Health_Cont=@Hcont where Health_ID=" + sidx;
                    }
                }

                else
                {
                    strCmd = "UPDATE HealthKnowledge SET Health_Type='" + this.TextBox4.Text + "',Health_Title='" + this.TextBox5.Text + "',Health_Cont='" + this.TextBox6.Text + "' where Health_ID=" + sidx;
                }
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@Htype", this.TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Htitle", this.TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Hcont", this.TextBox6.Text);
                    if (this.FileUpload1.HasFile)
                    {
                        cmd.Parameters.AddWithValue("@Himg", imagebyte);
                    }

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result == 0)
                    {
                        this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('修改失敗,請重新修改!')</script>"));

                    }
                    else { this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('修改資料成功!')</script>")); }

                    this.sindx.Text = this.TextBox4.Text = this.TextBox5.Text = this.TextBox6.Text = "";
                    this.Image2.ImageUrl = "";
                    this.GridView1.DataBind();
                }

            }
        }
        else { this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('修改失敗,請先選取編輯項目!')</script>")); }

        sidx = "";
    }

    protected void btndeleteConfirm_Click(object sender, EventArgs e) { 
    this.Page.Form.Controls.Add(new LiteralControl("<script>myconfirm('確定要?','btndelete_Click()')</script>"));
    }




    protected void btndelete_Click(object sender, EventArgs e)
    {



        
            if (sidx != "")
            {
                string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(strConn))
                {

                    string strCmd = "DELETE FROM HealthKnowledge where Health_ID=" + sidx;
                    using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                    {


                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (result != 0)
                        {
                            this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('刪除資料成功')</script>"));
                            this.sindx.Text = this.TextBox4.Text = this.TextBox5.Text = this.TextBox6.Text = "";
                            this.Image2.ImageUrl = "";
                            this.GridView1.DataBind();
                        }
                    }


                }
            }
            else
            {
                this.Page.Form.Controls.Add(new LiteralControl("<script>sAlert('修改失敗,請先選取編輯項目!')</script>"));
            }
            sidx = "";
        }
      
    
    
}