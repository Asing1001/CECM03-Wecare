using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary.Properties;
using System.Data;
using System.Web.Security;
using System.Security.Cryptography;
using System.Collections;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class clsUser
    {
        public clsUser() { }

        public clsUser(string account, string pwd)
        {
            this.userAccount = account;
            this.pwd = pwd;
        }

        private string pwd;

        public string userAccount { get; set; }
        public string userPwd { get; set; }
        public string userSalt { get; set; }
        public int userID { get; set; }
        public string userName { get; set; }
        public int userJobID { get; set; }
        public int userDivisionID { get; set; }
        public string userPhoneNumber { get; set; }
        public string userEmail { get; set; }
        public byte[] userImage { get; set; }

        public static BindingSource GetAllUser()
        {
            BindingSource bs = new BindingSource();
            using (MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext())
            {
                var q = from p in db.Staffs
                        select new
                        {
                            userAccount = p.Staff_Acc,
                            userDivisionID = p.Div_ID,
                            userEmail = p.Staff_Email,
                            userID = p.Staff_ID,
                            userImage = (byte[])p.Staff_Pix.ToArray(),
                            userJobID = p.Job_ID,
                            userName = p.Staff_Name,
                            userPhoneNumber = p.Staff_TN,
                            userPwd = p.Staff_Pwd,
                            userSalt = p.Staff_Salt
                        };

                bs.DataSource = q.ToList();
            }

            return bs;
        }

        public static clsUser GetUserData(int id)
        {
            clsUser user = null;

            using (MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext())
            {
                var q = db.Staffs.Where(n => n.Staff_ID == id).Single();

                user = new clsUser
                {
                    userAccount = q.Staff_Acc,
                    userDivisionID = q.Div_ID,
                    userEmail = q.Staff_Email,
                    userID = id,
                    userImage = (byte[])q.Staff_Pix.ToArray(),
                    userJobID = q.Job_ID,
                    userName = q.Staff_Name,
                    userPhoneNumber = q.Staff_TN,
                    userPwd = q.Staff_Pwd,
                    userSalt = q.Staff_Salt
                };
            }

            return user;
        }

        public clsUser Login()
        {
            if (checkUser())
            {
                string strSQL = "GetUser";

                List<SqlParam> inputParam = new List<SqlParam>();
                List<SqlParam> outputParam = new List<SqlParam>();

                //Input Parameters adding
                inputParam.Add(new SqlParam { Param = "@UserAccount", Type = SqlDbType.NVarChar, sValue = this.userAccount });

                //Output Parameters adding
                outputParam.Add(new SqlParam("@UserId", SqlDbType.Int));
                outputParam.Add(new SqlParam("@UserPwd", SqlDbType.NVarChar, 40, ParameterDirection.Output));
                outputParam.Add(new SqlParam("@Salt", SqlDbType.NVarChar, 16, ParameterDirection.Output));
                outputParam.Add(new SqlParam("@UserName", SqlDbType.NVarChar, 10, ParameterDirection.Output));
                outputParam.Add(new SqlParam("@UserJobID", SqlDbType.Int));
                outputParam.Add(new SqlParam("@UserDivisionID", SqlDbType.Int));
                outputParam.Add(new SqlParam("@UserEmail", SqlDbType.NVarChar, 50, ParameterDirection.Output));
                outputParam.Add(new SqlParam("@UserPhoneNumber", SqlDbType.NVarChar, 15, ParameterDirection.Output));
                outputParam.Add(new SqlParam("@UserImage", SqlDbType.VarBinary, 4096, ParameterDirection.Output));

                List<SqlParameter> param = new List<SqlParameter>();
                param = this.addInputParam(param, inputParam);
                param = this.addOutputParam(param, outputParam);

                using (SqlConnection conn = new SqlConnection(Resources.MedicareConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        foreach (SqlParameter each in param)
                        {
                            cmd.Parameters.Add(each);
                        }
                        //cmd.Parameters.Add(param.ToList());

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        this.userID = (int)(cmd.Parameters["@UserId"].Value);
                        this.userPwd = cmd.Parameters["@UserPwd"].Value.ToString();
                        this.userSalt = cmd.Parameters["@Salt"].Value.ToString();
                        this.userName = cmd.Parameters["@UserName"].Value.ToString();
                        this.userJobID = (int)(cmd.Parameters["@UserJobID"].Value);
                        this.userDivisionID = (int)(cmd.Parameters["@UserDivisionID"].Value);
                        this.userEmail = cmd.Parameters["@UserEmail"].Value.ToString();
                        this.userPhoneNumber = cmd.Parameters["@UserPhoneNumber"].Value.ToString();
                        if (cmd.Parameters["@UserImage"].Value is byte[])
                        {
                            this.userImage = (byte[])cmd.Parameters["@UserImage"].Value;
                        }
                        else
                        {
                            this.userImage = null;
                        }
                    }
                    }

                    if (checkPassword())
                    {
                    return this;
                        }
                        else
                        {
                            return null;
                        }
                
            }
            else
            {
                return null;
            }
        }

        public bool checkPassword()
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

        public bool checkPassword(string s)
        {
            this.pwd = s;
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

        public bool checkUser()
        {
            string strSQL = "CheckUser";

            List<SqlParam> inputParam = new List<SqlParam>();
            List<SqlParam> outputParam = new List<SqlParam>();

            //Input Parameters adding
            inputParam.Add(new SqlParam { Param = "@UserAccount", Type = SqlDbType.NVarChar, sValue = this.userAccount });

            //Output Parameters adding
            outputParam.Add(new SqlParam { Param = "@RETURN_VALUE", Type = SqlDbType.Int, Direction = ParameterDirection.ReturnValue });

            List<SqlParameter> param = new List<SqlParameter>();
            param = this.addInputParam(param, inputParam);
            param = this.addOutputParam(param, outputParam);

            using (SqlConnection conn = new SqlConnection(Resources.MedicareConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(sp);

                    foreach (SqlParameter each in param)
                    {
                        cmd.Parameters.Add(each);
                    }

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

        private List<SqlParameter> addOutputParam(List<SqlParameter> param, List<SqlParam> outputParam)
        {
            SqlParameter sp = null;

            foreach (SqlParam each in outputParam)
            {
                if (each.Size != 0)
                {
                    sp = new SqlParameter(each.Param, each.Type, each.Size);
                }
                else
                {
                    sp = new SqlParameter(each.Param, each.Type);
                }

                sp.Direction = each.Direction;
                param.Add(sp);
            }

            return param;
        }

        private List<SqlParameter> addInputParam(List<SqlParameter> param, List<SqlParam> inputParam)
        {
            SqlParameter sp;

            foreach (SqlParam each in inputParam)
            {
                if (each.image != null)
                {
                    sp = new SqlParameter(each.Param, SqlDbType.VarBinary);
                    sp.Value = each.image;
                }
                else if (each.sValue != null)
                {
                    sp = new SqlParameter(each.Param, SqlDbType.NVarChar);
                    sp.Value = each.sValue;
                }
                else
                { 
                    sp = new SqlParameter(each.Param, SqlDbType.Int);
                    sp.Value = each.iValue;
                }

                sp.Direction = ParameterDirection.Input;
                param.Add(sp);
            }

            return param;
        }

        public string CreateSalt()
        {
            //生成一個加密的隨機數
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[4];
            rng.GetBytes(buff);
            //返回一個Base64隨機數的字符串
            return Convert.ToBase64String(buff);
        }

        public string CreatePwd(string pwd, string salt)
        {
            pwd = pwd + salt;

            return FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "sha1");
        }

        public static bool addUser(clsUser user)
        {
            string strSQL = "InsertUser";

            List<SqlParam> inputParam = new List<SqlParam>();
            List<SqlParam> outputParam = new List<SqlParam>();

            //Input Parameters adding
            //inputParam.Add(new SqlParam { Param = "@UserImage", Type = SqlDbType.VarBinary, image = user.userImage });
            inputParam.Add(new SqlParam { Param = "@UserAccount", Type = SqlDbType.NVarChar, sValue = user.userAccount});
            inputParam.Add(new SqlParam { Param = "@UserPwd", Type = SqlDbType.NVarChar, sValue = user.userPwd });
            inputParam.Add(new SqlParam { Param = "@Salt", Type = SqlDbType.NVarChar, sValue = user.userSalt });
            inputParam.Add(new SqlParam { Param = "@UserName", Type = SqlDbType.NVarChar, sValue = user.userName });
            inputParam.Add(new SqlParam { Param = "@UserJobID", Type = SqlDbType.Int, iValue = user.userJobID });
            inputParam.Add(new SqlParam { Param = "@UserDivisionID", Type = SqlDbType.Int, iValue = user.userDivisionID });
            inputParam.Add(new SqlParam { Param = "@UserEmail", Type = SqlDbType.NVarChar, sValue = user.userEmail });
            inputParam.Add(new SqlParam { Param = "@UserPhoneNumber", Type = SqlDbType.NVarChar, sValue = user.userPhoneNumber });

            //Output Parameters adding
            outputParam.Add(new SqlParam { Param = "@RETURN_VALUE", Type = SqlDbType.Int, Direction = ParameterDirection.ReturnValue });

            List<SqlParameter> param = new List<SqlParameter>();
            param = user.addInputParam(param, inputParam);
            param = user.addOutputParam(param, outputParam);

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MedicareConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    foreach (SqlParameter each in param)
                    {
                        cmd.Parameters.Add(each);
                    }

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

        public bool updateUserProfile()
        {
            string strSQL = "UpdateUser";

            List<SqlParam> inputParam = new List<SqlParam>();
            List<SqlParam> outputParam = new List<SqlParam>();

            //Input Parameters adding
            inputParam.Add(new SqlParam { Param = "@UserPwd", Type = SqlDbType.NVarChar, sValue = this.userPwd });
            inputParam.Add(new SqlParam { Param = "@UserJobID", Type = SqlDbType.Int, iValue = this.userJobID });
            inputParam.Add(new SqlParam { Param = "@UserDivisionID", Type = SqlDbType.Int, iValue = this.userDivisionID });
            inputParam.Add(new SqlParam { Param = "@UserEmail", Type = SqlDbType.NVarChar, sValue = this.userEmail });
            inputParam.Add(new SqlParam { Param = "@UserPhoneNumber", Type = SqlDbType.NVarChar, sValue = this.userPhoneNumber });
            inputParam.Add(new SqlParam { Param = "@UserId", Type = SqlDbType.Int, iValue = this.userID });
            inputParam.Add(new SqlParam { Param = "@UserImage", Type = SqlDbType.VarBinary, image = this.userImage });

            //Output Parameters adding
            outputParam.Add(new SqlParam { Param = "@RETURN_VALUE", Type = SqlDbType.Int, Direction = ParameterDirection.ReturnValue });

            List<SqlParameter> param = new List<SqlParameter>();
            param = this.addInputParam(param, inputParam);
            param = this.addOutputParam(param, outputParam);

            using (SqlConnection conn = new SqlConnection(Resources.MedicareConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    foreach (SqlParameter each in param)
                    {
                        cmd.Parameters.Add(each);
                    }

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

        public List<string> divisionType()
        {
            string strSQL = "GetDivisionType";

            List<SqlParam> outputParam = new List<SqlParam>();

            //Output Parameters adding
            outputParam.Add(new SqlParam { Param = "@DivisionType", Type = SqlDbType.NVarChar, Direction = ParameterDirection.Output, Size = 10 });

            List<SqlParameter> param = new List<SqlParameter>();
            param = this.addOutputParam(param, outputParam);

            using (SqlConnection conn = new SqlConnection(Resources.MedicareConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    foreach (SqlParameter each in param)
                    {
                        cmd.Parameters.Add(each);
                    }

                    conn.Open();

                    List<string> divisionType = new List<string>();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            if (!sdr[0].Equals(DBNull.Value))
                            {
                                divisionType.Add(sdr[0].ToString());
                            }
                        }
                    }

                    return divisionType;
                }
            }
        }

        public List<string> jobTitles()
        {
            string strSQL = "GetJobTitles";

            List<SqlParam> outputParam = new List<SqlParam>();

            //Output Parameters adding
            outputParam.Add(new SqlParam { Param = "@JobTitleName", Type = SqlDbType.NVarChar, Direction = ParameterDirection.Output, Size = 10 });

            List<SqlParameter> param = new List<SqlParameter>();
            param = this.addOutputParam(param, outputParam);

            using (SqlConnection conn = new SqlConnection(Resources.MedicareConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    foreach (SqlParameter each in param)
                    {
                        cmd.Parameters.Add(each);
                    }

                    conn.Open();

                    List<string> jobTitleNames = new List<string>();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            if (!sdr[0].Equals(DBNull.Value))
                            {
                                jobTitleNames.Add(sdr[0].ToString());
                            }
                        }
                    }

                    return jobTitleNames;
                }
            }
        }
    }
}
