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
using MyProgram;

namespace HomePageUI
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
                ClsRecord.StaffID = user.userID;
                ClsRecord.Record(sender, this.Name);

                Form f = new HomePageUI.HomePage();
                f.Show();               
            }
            else
            {
                loginError();
            }

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
      

        private void btn_ForgetPwd_Click(object sender, EventArgs e)
        {
            FrmSendPwd f = new FrmSendPwd();
            f.ShowDialog();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定離開系統？", "Leave Message", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void txb_UserAccount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txb_UserPwd.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.btn_Cancel_Click(this, null);
            }
        }

        private void txb_UserPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btn_Cancel_Click(this, null);
            }
        }
    }
}
