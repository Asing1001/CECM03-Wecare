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
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using MyProgram.Properties;


namespace MyProgram
{
    public partial class FrmNewStaff : Form
    {
        internal clsUser user = null;

        public FrmNewStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_UserName.Text == "" || txb_UserName.Text == "請輸入「真實姓名」" ||
                cbb_UserJobID.Text == "" || ccb_UserDivisionID.Text == "" ||
                txb_UserAccount.Text == "" || txb_UserAccount.Text == "請輸入「帳號」" ||
                txb_UserPwd.Text == "" || txb_UserPwd.Text == "請輸入「密碼」" ||
                txb_UserPwdCheck.Text == "" || txb_UserPwdCheck.Text == "請「確認密碼」" ||
                txb_UserEmail.Text == "" || txb_UserEmail.Text == "請輸入「Email」" ||
                txb_UserPhoneNumber.Text == "" || txb_UserPhoneNumber.Text == "請輸入「電話」")
            {
                if (txb_UserName.Text == "")
                {
                    txb_UserName.ForeColor = Color.Red;
                    txb_UserName.Text = "請輸入「真實姓名」";
                    txb_UserName.Click += textBox6_Click;
                }
                if (cbb_UserJobID.Text == "")
                {
                    errorProvider1.SetError(this.cbb_UserJobID, "請輸入正確的值");
                }
                if (ccb_UserDivisionID.Text == "")
                {
                    errorProvider1.SetError(this.ccb_UserDivisionID, "請輸入正確的值");
                }
                if (txb_UserAccount.Text == "")
                {
                    txb_UserAccount.ForeColor = Color.Red;
                    txb_UserAccount.Text = "請輸入「帳號」";
                    txb_UserAccount.Click += textBox7_Click;
                }
                if (txb_UserPwd.Text == "")
                {
                    txb_UserPwd.ForeColor = Color.Red;
                    txb_UserPwd.Text = "請輸入「密碼」";
                    txb_UserPwd.Click += textBox2_Click;
                }
                if (txb_UserPwdCheck.Text == "")
                {
                    txb_UserPwdCheck.ForeColor = Color.Red;
                    txb_UserPwdCheck.Text = "請「確認密碼」";
                    txb_UserPwdCheck.Click += textBox3_Click;
                }
                if (txb_UserEmail.Text == "")
                {
                    txb_UserEmail.ForeColor = Color.Red;
                    txb_UserEmail.Text = "請輸入「Email」";
                    txb_UserEmail.Click += textBox5_Click;
                }
                if (txb_UserPhoneNumber.Text == "")
                {
                    txb_UserPhoneNumber.ForeColor = Color.Red;
                    txb_UserPhoneNumber.Text = "請輸入「電話」";
                    txb_UserPhoneNumber.Click += textBox8_Click;
                }
                if (txb_UserPwd.Text != "" && txb_UserPwd.Text != "請輸入「密碼」" && txb_UserPwdCheck.Text != "" && txb_UserPwdCheck.Text != "請「確認密碼」" && txb_UserPwd.Text != txb_UserPwdCheck.Text)
                {
                    MessageBox.Show("兩次輸入密碼不相同，請重新輸入");
                    txb_UserPwd.Clear();
                    txb_UserPwdCheck.Clear();
                    txb_UserPwd.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("確定新增使用者？", "確認新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    user = new clsUser();
                    user.userSalt = user.CreateSalt();
                    user.userPwd = user.CreatePwd(this.txb_UserPwd.Text, user.userSalt);
                    user.userAccount = this.txb_UserAccount.Text;
                    user.userDivisionID = this.ccb_UserDivisionID.SelectedIndex + 1;
                    user.userEmail = this.txb_UserEmail.Text;
                    user.userJobID = this.cbb_UserJobID.SelectedIndex + 1;
                    user.userName = this.txb_UserName.Text;
                    
                    try
                    {
                        user.userPhoneNumber = this.txb_UserPhoneNumber.Text;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("電話格式輸入錯誤，請重新輸入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txb_UserPwd.Clear();
                        txb_UserPhoneNumber.Clear();
                        txb_UserPwdCheck.Clear();
                        txb_UserPwd.Focus();
                        return;
                    }

                    user.userImage = buf;

                    if (clsUser.addUser(user))
                    {
                        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
                        int ID = DB.Staffs.Select(n => n.Staff_ID).Max();
                        DB.Staffs.Where(n => n.Staff_ID == ID).First().Staff_Pix = buf;
                        DB.SubmitChanges();

                        ClsRecord.Record(sender, this.Name);

                        MessageBox.Show("資料新增成功!!");
                        this.Close();

                        //foreach (Control each in this.Controls)
                        //{
                        //    if (each is TextBox)
                        //    {
                        //        ((TextBox)each).Clear();
                        //    }
                        //    else if (each is ComboBox)
                        //    {
                        //        ((ComboBox)each).SelectedIndex = 0;
                        //    }
                        //}
                    }
                    else { 
                        MessageBox.Show("資料新增失敗!!");
                    }
                }
                else
                {
                    this.txb_UserAccount.Focus();
                    this.txb_UserAccount.SelectAll();
                }
            }
        }

        void comboBox1_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cbb_UserJobID, "");
        }

        #region click
        void textBox8_Click(object sender, EventArgs e)
        {
            txb_UserPhoneNumber.Clear();
            txb_UserPhoneNumber.ForeColor = Color.Black;
        }

        void textBox5_Click(object sender, EventArgs e)
        {
            txb_UserEmail.Clear();
            txb_UserEmail.ForeColor = Color.Black;
        }

        void textBox3_Click(object sender, EventArgs e)
        {
            txb_UserPwdCheck.Clear();
            txb_UserPwdCheck.ForeColor = Color.Black;
        }

        void textBox2_Click(object sender, EventArgs e)
        {
            txb_UserPwd.Clear();
            txb_UserPwd.ForeColor = Color.Black;
        }

        void textBox7_Click(object sender, EventArgs e)
        {
            txb_UserAccount.Clear();
            txb_UserAccount.ForeColor = Color.Black;
        }

        void textBox6_Click(object sender, EventArgs e)
        {
            txb_UserName.Clear();
            txb_UserName.ForeColor = Color.Black;
        }
        #endregion

        private void FrmNewStaffs_Load(object sender, EventArgs e)
        {
            global::MyDB.MedicareDataClassesDataContext ds = new MyDB.MedicareDataClassesDataContext();

            this.cbb_UserJobID.DataSource = ds.JobTitles.Select(n => n.Job_Title);
            this.ccb_UserDivisionID.DataSource = ds.Divisions.Select(n => n.Div_Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (Control each in this.Controls)
            //{
            //    if (each is TextBox)
            //    {
            //        ((TextBox)each).Clear();
            //    }
            //    else if (each is ComboBox)
            //    {
            //        ((ComboBox)each).SelectedIndex = 0;
            //    }
            //}
            //pictureBox1.Image = null;

            if (MessageBox.Show("確認是否取消？", "取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            button3.Visible = true;
        }

        byte[] buf = null;

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;

                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                buf = new byte[fs.Length];
                fs.Read(buf, 0, (int)fs.Length);
                fs.Close();
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void txb_UserAccount_Leave(object sender, EventArgs e)
        {
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

            if (DB.Staffs.Where(n => n.Staff_Acc == txb_UserAccount.Text).Count() >= 1)
            {
                errorProvider1.SetError(txb_UserAccount, "已經有人在用這個使用者名稱了!");
                txb_UserAccount.Text = "";
            }
            else
            {
                errorProvider1.SetError(txb_UserAccount, "");
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            this.txb_UserName.Text = "陳醫德"; //吳醫德
            this.txb_UserAccount.Text = "doctor";
            this.txb_UserEmail.Text = "shinningstar1001@gmail.com";
            this.cbb_UserJobID.SelectedIndex = 0;
            this.ccb_UserDivisionID.SelectedIndex = 0;
            this.txb_UserPwd.Text = "000000";
            this.txb_UserPwdCheck.Text = "000000";
            this.txb_UserPhoneNumber.Text = "0911223344";
        }
    }
}
