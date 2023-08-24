using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientInf : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        //Response.Cookies["PttID"].Value = "1";
        if (Request.Cookies["PttID"] != null)
        {
            //UnchangeableData.SelectParameters["StaffAccount"].DefaultValue = ChangeableDataSource.SelectParameters["Staff_Acc"].DefaultValue = Request.Cookies["login"].Value;

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
        int pttid = Convert.ToInt32(Request.Cookies["PttID"].Value);

        //取出目前使用者的相關INFO
        var info = db.Patients.Where(n => n.Ptt_ID == pttid)
            .Select(n => new { pid = n.Ptt_ID, pwd = n.Ptt_Pwd, salt = n.Ptt_Salt }).Single();


        string strJS = "";
        //輸入的pw和資料庫的salt做成pwd比對
        string SaltedPwd = clsUser.CreatePwd(txtoldpwd.Text, info.salt);
        if (SaltedPwd == info.pwd && txtnewpwd.Text == txtconfirmpwd.Text)//若比對成功
        {
            string newsalt = clsUser.CreateSalt();
            string newpassword = clsUser.CreatePwd(txtnewpwd.Text, newsalt);

            db.Patients.Where(n => n.Ptt_ID == pttid).Single().Ptt_Pwd = newpassword;

            db.Patients.Where(n => n.Ptt_ID == pttid).Single().Ptt_Salt = newsalt;

            db.SubmitChanges();


            strJS = " alert('修改成功!!')";

        }
        else
        {
            strJS = " alert('原密碼不正確!!')";
        }

        Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJS, true);

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int pid = Convert.ToInt32(Response.Cookies["PttID"].Value);
        MediCareDataClassesDataContext DB = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        DB.Patients.Where(N => N.Ptt_ID == pid).Single().Ptt_TN = ((TextBox)DetailsView2.Rows[0].FindControl("TextBox1")).Text;
        DB.Patients.Where(N => N.Ptt_ID == pid).Single().Ptt_Addr = ((TextBox)DetailsView2.Rows[0].FindControl("TextBox2")).Text;
        DB.Patients.Where(N => N.Ptt_ID == pid).Single().Ptt_Email = ((TextBox)DetailsView2.Rows[0].FindControl("TextBox3")).Text;
        DB.Patients.Where(N => N.Ptt_ID == pid).Single().Ptt_ExamRmd = ((CheckBox)DetailsView2.Rows[0].FindControl("CheckBox1")).Checked;
        DB.Patients.Where(N => N.Ptt_ID == pid).Single().Ptt_DrugRmd = ((CheckBox)DetailsView2.Rows[0].FindControl("CheckBox2")).Checked;
        DB.SubmitChanges();
    }
}