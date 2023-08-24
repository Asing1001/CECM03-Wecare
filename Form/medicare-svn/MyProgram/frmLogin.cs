using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace MyProgram
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static int count = 3;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            count--;
            clsUser user = new clsUser(this.txb_UserAccount.Text, this.txb_UserPwd.Text);

            if (user.Login() != null)
            {
                this.Close();
                ClsRecord.CurrentUser = user;
                showHomePage(user);
            }
            else
            {
                loginError();
            }

            ClsRecord.StaffID = user.userID;
            ClsRecord.Record(sender, this.Name);
        }

        private void loginError()
        {
            if (count > 0)
            {
                MessageBox.Show(string.Format("帳號密碼錯誤，請重新輸入\n您還有 {0} 次機會!", count),
                    "登入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("登入失敗，請通知管理員", "Byebye", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void showHomePage(clsUser user)
        {

            if (user.userJobID==4)
            {
                
            }
            else
            {

            }
            //switch (user.userJobID)
            //{
            //    case 1:
            //        {
            //            frmDoctorHomePage f = new frmDoctorHomePage(user);
            //            f.Show();
            //            break;
            //        }
            //    case 2:
            //        {
            //            frmCounselorHomePage f = new frmCounselorHomePage(user);
            //            f.Show();
            //            break;
            //        }
            //    case 3:
            //        {
            //            frmNurseHomePage f = new frmNurseHomePage(user);
            //            f.Show();
            //            break;
            //        }
            //    case 4:
            //        {
            //            frmAdminHomePage f = new frmAdminHomePage(user);
            //            f.Show();
            //            break;
            //        }
            //    default:
            //        break;
            //}
        }

        private void btn_ForgetPwd_Click(object sender, EventArgs e)
        {
            FrmSendPwd f = new FrmSendPwd();
            f.ShowDialog();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
