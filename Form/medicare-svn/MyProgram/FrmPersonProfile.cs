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
using System.IO;

namespace MyProgram
{
    public partial class FrmPersonProfile : Form
    {
        clsUser user = null;

        public FrmPersonProfile(clsUser user)
        {
            InitializeComponent();

            this.user = user;
        }

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
            

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.splitContainer2.Panel1Collapsed =! this.splitContainer2.Panel1Collapsed;
        //}

        private void FrmPersonProfile_Load(object sender, EventArgs e)
        {
            //this.splitContainer2.Panel1Collapsed = true;

            this.txb_UserName.Text = this.user.userName;
            this.txb_UserAccount.Text = this.user.userAccount;
            this.txb_UserEmail.Text = this.user.userEmail;

            this.cbb_UserJobID.DataSource = DB.JobTitles;
            this.cbb_UserJobID.DisplayMember = "Job_Title";
            this.cbb_UserJobID.ValueMember = "Job_ID";
            this.cbb_UserJobID.SelectedIndex = this.user.userJobID - 1;


            this.cbb_UserDivisionID.DataSource = DB.Divisions;
            this.cbb_UserDivisionID.DisplayMember = "Div_Name";
            this.cbb_UserDivisionID.ValueMember = "Div_ID";
            this.cbb_UserDivisionID.SelectedIndex = this.user.userDivisionID - 1;

            this.txb_UserPhoneNumber.Text = string.Format("{0:d10}", this.user.userPhoneNumber);

            var q = DB.Staffs.Where(n => n.Staff_ID == this.user.userID).First().Staff_Pix;

          
            if (q == null || q.Length==0) //(DB.Staffs.Where(n => n.醫療人員ID == user.userID).First().照片 == null)
            {
                //pictureBox4.Image = null;
            }
            else
            {
                byte[] buf = q.ToArray();
                MemoryStream ms = new MemoryStream(buf);
                Bitmap bmp = new Bitmap(ms);
                pictureBox4.Image = bmp;
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string NewSalt = user.CreateSalt();
                string OldPassword = 
                    user.CreatePwd(this.txb_UserOldPwd.Text, DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_Salt);

                if (buf!=null) //判斷是否有更改圖片
                {
                    DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_Pix = buf;
                }

                DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_Email = this.txb_UserEmail.Text;
                DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Job_ID = (int)this.cbb_UserJobID.SelectedValue;
                DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Div_ID = (int)this.cbb_UserDivisionID.SelectedValue;
                DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_TN = this.txb_UserPhoneNumber.Text;

                //判斷舊密碼是否正確 & 新密碼是否兩次輸入正確
                if (this.txb_UserNewPwd.Text != "")
                {
                    if (this.txb_UserNewPwd.Text == 
                        this.txb_UserNewPwdCheck.Text && OldPassword == DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_Pwd)
                    {
                        DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_Pwd = user.CreatePwd(this.txb_UserNewPwd.Text, NewSalt);
                        DB.Staffs.Where(n => n.Staff_ID == user.userID).First().Staff_Salt = NewSalt;
                    }
                    else
                    {
                        MessageBox.Show("密碼有誤");
                    }
                }

                try
                {
                    DB.SubmitChanges();
                    MessageBox.Show("修改成功!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //if (filename != null)
            //{
            //    ((PictureBox)this.ParentForm.Controls["TopPanel"].Controls["pictureBox1"]).ImageLocation = filename;

            //}            
            
            ClsRecord.Record(sender, this.Name);
            this.Close();
        }

        byte[] buf = null;
        string filename;

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                filename = openFileDialog1.FileName;
                pictureBox4.ImageLocation = openFileDialog1.FileName;
                

                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                buf = new byte[fs.Length];
                fs.Read(buf, 0, (int)fs.Length);
                fs.Close();            
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後修改資料將消失!!", "取消確認",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}