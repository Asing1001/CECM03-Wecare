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
using System.Security.Cryptography;

namespace MyProgram
{
    public partial class FrmNewStaffs : Form
    {
        public FrmNewStaffs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            user.userAccount = this.txb_Account.Text;

            if (user.checkUser())
            {
                MessageBox.Show("帳號已被使用，請重新輸入新帳號!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txb_Account.Focus();
                this.txb_Account.SelectAll();
            }
            else
            {
                user.userPhoneNumber = Convert.ToInt32(this.txb_UserPhoneNumber.Text);
                user.userDivisionID = Convert.ToInt32(this.txb_UserDivisionID.Text);
                user.userEmail = this.txb_Email.Text;
                user.userJobID = Convert.ToInt32(this.txb_UserJobID.Text);
                user.userName = this.txb_UserName.Text;
                user.userSalt = user.CreateSalt();

                if (this.txb_UserPwd.Text == this.txb_UserPwdCheck.Text)
                {
                    user.userPwd = user.CreatePwd(user.userPwd, user.userSalt);
                }

                if (clsUser.addUser(user))
                {
                    MessageBox.Show("帳號新增成功", "新增成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("發生錯誤", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
