using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;



/// <summary>
/// clsUser 的摘要描述
/// </summary>
public class clsUser
{
    private string pwd;
    public string userAccount { get; set; }
    public string userSalt { get; set; }
    public string userPwd { get; set; }
    public string userName { get; set; }
    public string userEmail { get; set; }
    public int userJobID { get; set; }

    public int userPttID { get; set; }

	public clsUser()
	{
		//
		// TODO: 在這裡新增建構函式邏輯
		//
	}
    public clsUser(string account, string Keyinpwd)
    {
        this.userAccount = account;
        this.pwd = Keyinpwd;
    }
    public clsUser(string account, string Keyinpwd,string email)
    {
        this.userAccount = account;
        this.pwd = Keyinpwd;
        this.userEmail = email;
    }
    string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
    public string Checksignin()
    {
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmdcheckID = "select count(*) from Patients where [Ptt_PID]=@identity";
            using (SqlCommand cmd = new SqlCommand(strCmdcheckID, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@identity", SqlDbType.NVarChar));
                cmd.Parameters["@identity"].Value = userAccount;

                conn.Open();

                //Ptt_PID 在Patients中 
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    string strSQL = "CheckPwd";
                    using (SqlCommand cmdexist = new SqlCommand(strSQL, conn))
                    {
                        cmdexist.CommandType = System.Data.CommandType.StoredProcedure;
                        //若pwd不是1(預設值) 不能註冊
                        cmdexist.Parameters.Add(new SqlParameter("@PttPID", SqlDbType.NVarChar));
                        cmdexist.Parameters["@PttPID"].Value = userAccount;

                        SqlParameter UserExist = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                        UserExist.Direction = ParameterDirection.ReturnValue;
                        cmdexist.Parameters.Add(UserExist);

                        cmdexist.ExecuteNonQuery();

                        int n = (int)cmdexist.Parameters["@RETURN_VALUE"].Value;
                        //
                        if (n == 1)
                        {
                            //新拿1組鹽,加入DB,並雜湊密碼
                            return "signed";
                        }
                        else
                        {
                            return "notyet";
                        }
                    }
                }
                else { return "notregister"; }
            }
        }
    }
        public void addUser()
        {
            string salt = clsUser.CreateSalt();
            string pwdSalted = clsUser.CreatePwd(pwd, salt);
            string strCmd = "Update Patients  set Ptt_Pwd= @PttPwd,Ptt_Salt= @PttSalt,Ptt_Email=@PttEmail where Ptt_PID=@identity";
            using (SqlConnection conn = new SqlConnection(strConn))
            { 
                using (SqlCommand cmdupdate = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    cmdupdate.Parameters.AddWithValue("@identity", userAccount);
                    cmdupdate.Parameters.AddWithValue("@PttPwd", pwdSalted);
                    cmdupdate.Parameters.AddWithValue("@PttSalt", salt);
                    cmdupdate.Parameters.AddWithValue("@PttEmail", userEmail);
                    cmdupdate.ExecuteNonQuery();
                }
            }
        }

    string UserHP;
    public clsUser Login(string UserHP)
    {
        if (checkUser(UserHP))
        {
            //判斷USER是 病患/醫護 
            if (UserHP == "CheckUser")
            {
                string strCmd = "GetUserH";

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@StaffAcc", userAccount);
                        cmd.Parameters.Add(new SqlParameter("@StaffAcc", SqlDbType.NVarChar));
                        cmd.Parameters["@StaffAcc"].Value = userAccount;

                        cmd.Parameters.Add(new SqlParameter("@Salt", SqlDbType.NVarChar,40));
                        cmd.Parameters["@Salt"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@UserPwd", SqlDbType.NVarChar,40));
                        cmd.Parameters["@UserPwd"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@UserJobID", SqlDbType.Int));
                        cmd.Parameters["@UserJobID"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@UserEmail", SqlDbType.NVarChar,50));
                        cmd.Parameters["@UserEmail"].Direction = ParameterDirection.Output;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        this.userSalt = cmd.Parameters["@Salt"].Value.ToString();
                        this.userPwd = cmd.Parameters["@UserPwd"].Value.ToString();
                        this.userJobID = (int)(cmd.Parameters["@UserJobID"].Value);
                        this.userEmail = cmd.Parameters["@UserEmail"].Value.ToString();
                    }
                }
                if (checkpassword())
                {
                    return this ;
                }
                else  { return null; }
            }
            else
            {
                //病患
                string strCmd = "GetUserP";
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                    {
                        conn.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@PttPID", userAccount);
                        cmd.Parameters.Add(new SqlParameter("@PttPID", SqlDbType.NVarChar));
                        cmd.Parameters["@PttPID"].Value = userAccount;

                        cmd.Parameters.Add(new SqlParameter("@PttID", SqlDbType.Int));
                        cmd.Parameters["@PttID"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@Salt", SqlDbType.NVarChar,40));
                        cmd.Parameters["@Salt"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@PttPwd", SqlDbType.NVarChar,40));
                        cmd.Parameters["@PttPwd"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@PttName", SqlDbType.NVarChar,10));
                        cmd.Parameters["@PttName"].Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(new SqlParameter("@PttEmail", SqlDbType.NVarChar,50));
                        cmd.Parameters["@PttEmail"].Direction = ParameterDirection.Output;

                        
                        cmd.ExecuteNonQuery();

                        this.userPttID = (int)cmd.Parameters["@PttID"].Value;
                        this.userSalt = cmd.Parameters["@Salt"].Value.ToString();
                        this.userPwd = cmd.Parameters["@PttPwd"].Value.ToString();
                        this.userName = cmd.Parameters["@PttName"].Value.ToString();
                        this.userEmail = cmd.Parameters["@PttEmail"].Value.ToString();
                    }
                }

                if (checkpassword())
                {
                    return this;
                }
                else  { return null; }
            }
            
        }
        else
        {
            //查無此人
            return null;
        }
  }


    public bool checkUser(string UserHP)  //醫護/病患
    {
        string strSQL = UserHP; //呼叫不同預存程序

        using (SqlConnection conn = new SqlConnection(strConn))
        {
            using (SqlCommand cmd = new SqlCommand(strSQL, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@UserAccount", userAccount);
                cmd.Parameters.Add(new SqlParameter("@UserAccount", SqlDbType.NVarChar));
                cmd.Parameters["@UserAccount"].Value = userAccount;

                SqlParameter UserExist = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                UserExist.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(UserExist);

                conn.Open();
                cmd.ExecuteNonQuery();

                int n = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                if (n == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }


    public bool checkpassword()
    {
        this.pwd = this.pwd + this.userSalt;
        this.pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(this.pwd, "sha1");

        if (this.userPwd == this.pwd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string CreateSalt()
    {
        //生成一個加密的隨機數
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        byte[] buff = new byte[4];
        rng.GetBytes(buff);
        //返回一個Base64隨機數的字符串
        return Convert.ToBase64String(buff);
    }
    public static string CreatePwd(string pwd, string salt)
    {
        pwd = pwd + salt;

        return FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "sha1");
    }

    public static bool checkForgetEmail(string email, string pid)
    {
        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmdcheckID = "select count(*) from Patients where Ptt_Email=@email and Ptt_PID=@PttPID";
            using (SqlCommand cmd = new SqlCommand(strCmdcheckID, conn))
            {
                cmd.Parameters.AddWithValue("@PttPID", pid);
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    //改密碼
                    string Newpwd = clsUser.SyschangePWD(pid);

                    SendMail(email,pid,Newpwd);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public static string SyschangePWD(string pid)
    {
        Random rmd = new Random();
        string Newpwd=rmd.Next(1000, 9999).ToString();
        string salt = clsUser.CreateSalt();
        string pwdSalted = clsUser.CreatePwd(Newpwd, salt);
        string strCmd = "Update Patients  set Ptt_Pwd= @PttPwd,Ptt_Salt= @PttSalt where Ptt_PID=@identity";
        
        string strConn = ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            using (SqlCommand cmdupdate = new SqlCommand(strCmd, conn))
            {
                conn.Open();
                cmdupdate.Parameters.AddWithValue("@identity", pid);
                cmdupdate.Parameters.AddWithValue("@PttPwd", pwdSalted);
                cmdupdate.Parameters.AddWithValue("@PttSalt", salt);
                cmdupdate.ExecuteNonQuery();
            }
        }
        return Newpwd;
    }
    public static void SendMail(string Email, string Pid,string NewPwd)
    {
        SmtpClient client = new SmtpClient();
        

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("cecmwecare@gmail.com", "WeCare");
        mail.To.Add(new MailAddress(Email));

        mail.Subject = "[WeCare Medicare System] 密碼重發通知 !!";
        mail.IsBodyHtml = true;
        string strMsg = @"<h5>" + Pid + " 您好:</h5><p>此封電子郵件是" + DateTime.Now.ToLocalTime() + "請求密碼重置，若不是您發出的請求則您可以忽略此封郵件的訊息內容。</p>";
        strMsg += @"<ul><li>電子郵件位址: " + Email + "</li><li>使用者名稱: " + Pid + "</li><li>帳號啟用碼:" + NewPwd + "</li></ul><p>重新進入本站網頁 WeCare: http://localhost:56254/Index.aspx </p>";
        mail.Body = strMsg;
        client.Send(mail);
    }

    
    public static void SendCouponMail(string Email, string pttname, string coupon)
    {
       
        SmtpClient client = new SmtpClient();

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("cecmwecare@gmail.com", "WeCare");
        mail.To.Add(new MailAddress(Email));

        mail.Subject = "[WeCare Medicare System]恭喜您抽中 MeCare Store 商城購物金序號!!! ";
        mail.IsBodyHtml = true;
        string strMsg = @"<h4>" + pttname + "您好:</h4><p>感謝您參加 滿意度調查-幸運瘋狂轉盤活動，恭喜您中獎!!!</p>";
        strMsg += @"<ul><li>購物金序號: " + coupon + "</li><li>中獎人名稱: " + pttname + "</li></ul> <p>WeCare Store商城: wecarestore.azurewebsites.net/ 歡迎您!<br/><br/>此封電子郵件是" + DateTime.Now.ToLocalTime() + "發出。</p>";
        mail.Body = strMsg;
        client.Send(mail);
    }
    
}
