using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            linkbtnLogoutOK.Visible = false;  //隱藏登出
            loginFunction.Visible = false;    //功能選單

            //examSchedule.Visible = false;
            //drugSchedule.Visible = false;
            showreport.Visible = false;

            illhistory.Visible = false;
            command.Visible = false;
            calendar.Visible = false;
            news.Visible = false;
            report.Visible = false;

            news.Visible = false;
            Knowledge.Visible = false;
            PatientInf.Visible = false;
            this.getCookieOrNot();
        }
    }
    
    public string strJSwrongpwd = "$('#login').modal('show');";
    public string strJSwrongemail = "$('#forgetPwd').modal('show');";
    public string strJSwrongValidate = "$('#signup').modal('show');";

    public void getCookieOrNot()
    {


        if (Request.Cookies["login"] != null)
        {
            loginFunction.Visible = true;
            loginpopup.Attributes["name"] = "logined"; //登入成功 不跳出 登入註冊視窗
            linkbtnLogoutOK.Visible = true;
            loginpopup.Text = Server.UrlDecode(Request.Cookies["login"].Value) + "  登入";

            if (Request.Cookies["Job"] == null) //權限
            {
                //病人
                illhistory.Visible = true;
                report.Visible = true;
                command.Visible = true;
                PatientInf.Visible = true;
                calendar.Visible = true;
                personalInf.Visible = false;

            }
            else if (Request.Cookies["Job"].Value == "4") //管理員
            {
                news.Visible = true;
                Knowledge.Visible = true;
            }
            else
            {
                //醫護人員
                //examSchedule.Visible = true;
                //drugSchedule.Visible = true;
                showreport.Visible = true;
                calendar.Visible = true;
                //PatientInf.Visible = false;
            }

        }
        else
        {
            loginpopup.Attributes["name"] = null;
            loginpopup.Text = "登入 / 註冊";
            linkbtnLogoutOK.Visible = false;
        }


    }
    

    protected void linkbtnLogoutOK_Click(object sender, EventArgs e)
    {
        Response.Cookies["login"].Expires = DateTime.Now.AddSeconds(-1);
        Response.Cookies["Job"].Expires = DateTime.Now.AddSeconds(-1);
        Response.Cookies["PttID"].Expires = DateTime.Now.AddSeconds(-1);
        Response.Cookies["Email"].Expires = DateTime.Now.AddSeconds(-1);
        Cache.Remove("tDay");

        //string thePath = HttpContext.Current.Request.Url.PathAndQuery;
        HttpContext.Current.Response.Redirect("/Index.aspx");      //倒回首頁
        //HttpContext.Current.Response.Redirect(thePath);
        //this.getCookieOrNot();
    }
    protected void btnHLoginOK_Click(object sender, EventArgs e)
    {
        if (HTextBoxAccount.Text == "" || HTextBoxPwd.Text == "")
        {
            LoginResult.Text = "請輸入內容";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongpwd, true);
            return;
        }
        else //醫護
        {
            string UserHP = "CheckUser";
            clsUser user = new clsUser(this.HTextBoxAccount.Text, this.HTextBoxPwd.Text);
            if (user.Login(UserHP) == null)
            {
                //登入失敗
                LoginResult.Text = "密碼錯誤";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongpwd, true);
            }
            else
            {
                //有user
                DateTime TDT = DateTime.Today;
                Response.Cookies["login"].Value = Server.UrlEncode(user.userAccount);
                Response.Cookies["Job"].Value = user.userJobID.ToString();
                Cache.Insert("tDay", TDT);
                Response.Cookies["caltype"].Value = "day";

                //記住我
                if (CheckBoxAutoLogin.Checked)
                {
                    Response.Cookies["login"].Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies["Job"].Expires = DateTime.Now.AddMonths(6);
                    //Cache.Insert("tDay", TDT);
                }
                //轉跳 原頁或首頁
                //string thePath = HttpContext.Current.Request.Url.PathAndQuery;
                //HttpContext.Current.Response.Redirect(thePath);
                if (Response.Cookies["Job"].Value != "4")
                {
                    Response.Redirect("~/Calendar.aspx");
                }
                else
                {
                    Response.Redirect("~/Index.aspx"); //管理員沒行事曆                
                }

            }
        }

        
                
    }
       protected void btnPLoginOK_Click(object sender, EventArgs e)
    {
             //登入 空白沒填
             if (TextBoxAccount.Text == "" || TextBoxPwd.Text == "")
             {
                 LoginResult.Text = "請填入內容" + Patients.Attributes["name"];
                 Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongpwd, true);
                 return;
             }
             else //病人
             {

                 string UserHP = "CheckUserP";
                 clsUser user = new clsUser(this.TextBoxAccount.Text, this.TextBoxPwd.Text);
                 if (user.Login(UserHP) == null)
                 {
                     //登入失敗
                     LoginResult.Text = "密碼錯誤";
                     Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongpwd, true);
                 }
                 else
                 {
                     //有user
                     DateTime TDT = DateTime.Today;
                     Response.Cookies["login"].Value = Server.UrlEncode(user.userName);
                     Response.Cookies["PttID"].Value = user.userPttID.ToString();
                     Response.Cookies["Email"].Value = user.userEmail;
                     Cache.Insert("tDay", TDT);
                     Response.Cookies["caltype"].Value = "day";
                    
                     //記住我
                     if (CheckBoxAutoLogin.Checked)
                     {
                         Response.Cookies["login"].Expires = DateTime.Now.AddMonths(6);
                         Response.Cookies["PttID"].Expires = DateTime.Now.AddMonths(6);
                         Response.Cookies["Email"].Expires = DateTime.Now.AddMonths(6);
                     }
                     //轉跳 原頁或首頁
                     //string thePath = HttpContext.Current.Request.Url.PathAndQuery;
                     //HttpContext.Current.Response.Redirect(thePath);
                     Response.Redirect("~/Calendar.aspx");
                 }
             }
     }
        
   
    protected void btnSigninOK_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //    //病患要曾經 在本醫院掛號過,Patients 有資料才可註冊
            //    //病患註冊帳號,規定用PID=>檢查此欄位值 是否存在Patients中
            //    // 判斷:Ptt_PID是否存在Patients中 
            clsUser user = new clsUser(this.TextBoxSigninAC.Text, this.TextBoxSigninPwd.Text,this.TextBoxSigninEmail.Text);
            if (user.Checksignin()=="notyet")
            {
                user.addUser();
                string strSigninSuccese = "alert('註冊成功')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", strSigninSuccese, true);
            }
            else if (user.Checksignin() == "signed")
            {
                string strSigninFailed = "alert('此帳號已註冊')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", strSigninFailed, true);
            }
            else  
            {
                string strNotPatient = "alert('請入掛號系統,註冊為本院病患')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", strNotPatient, true);
            }
        }
        else
        {
            //動態產生JavaScript到Client端
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongValidate, true);
        }
    }
    protected void btnFogetOK_Click(object sender, EventArgs e)
    {
        //忘記密碼 空白沒填
        if (TextBoxEmailAC.Text == "" || TextBoxEmail.Text == "")
        {
            LabelEmail.Text = "請填入欄位內容";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongemail, true);
            return;
        }

        //判斷 email和帳號 是否屬同一個人
        //連線 staff 
        if (clsUser.checkForgetEmail(TextBoxEmail.Text, TextBoxEmailAC.Text))
        {
            string strSent = "alert('已發送至信箱')";//todo 美工視窗
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", strSent, true);
        }
        else
        {
            LabelEmail.Text = "查無符合的 信箱/帳號";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongemail, true);
        }
        
    }
    protected void btnForgetClear_Click(object sender, EventArgs e)
    {
        TextBoxEmail.Text = string.Empty;
        TextBoxEmailAC.Text = string.Empty;
        LabelEmail.Text = string.Empty;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "", strJSwrongemail, true);
    }

   

}
