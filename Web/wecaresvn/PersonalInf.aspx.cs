using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PersonalInf : System.Web.UI.Page
{
    protected void Page_Init(object sender,EventArgs e)
    {
        //Response.Cookies["account"].Value = "aaa";
        if (Request.Cookies["login"]!=null)
        {
            UnchangeableData.SelectParameters["StaffAccount"].DefaultValue = ChangeableDataSource.SelectParameters["Staff_Acc"].DefaultValue = Request.Cookies["login"].Value;
    
        }
        else
        {
           Response.Redirect("Index.aspx");    
        }
       
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void editpwd_Click(object sender, EventArgs e)
    {
        //btn...  oldpwd newpwd confirmpwd

        MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        string account = Request.Cookies["login"].Value;

        //取出目前使用者的相關INFO
        var info = db.Staffs.Where(n=>n.Staff_Acc==account)
            .Select(n=>new { acc=n.Staff_Acc , pwd = n.Staff_Pwd, salt = n.Staff_Salt }).Single();


        string strJS = "";
        //輸入的pw和資料庫的salt做成pwd比對
        string SaltedPwd= clsUser.CreatePwd(txtoldpwd.Text,info.salt);
        if (SaltedPwd == info.pwd && txtnewpwd.Text == txtconfirmpwd.Text)//若成功
        {
            string newsalt= clsUser.CreateSalt();
            string newpassword = clsUser.CreatePwd(txtnewpwd.Text, newsalt);

            db.Staffs.Where(n => n.Staff_Acc == account).Single().Staff_Pwd = newpassword;

            db.Staffs.Where(n => n.Staff_Acc == account).Single().Staff_Salt = newsalt;

            db.SubmitChanges();

            
            strJS= " alert('修改成功!!')";
            
        }
        else
        {
            strJS = " alert('原密碼不正確!!')";
        }

        Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJS, true);

    }
}