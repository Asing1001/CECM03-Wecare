using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyClassLibrary;
using MyDB;

namespace MyProgram
{
    public partial class frmDoctorHomePage : MyClassLibrary.frmLogo
    {
        clsUser user = null;
        string[] strFunctions = { "基本資料","報表", "離開系統" };

        public frmDoctorHomePage(MyClassLibrary.clsUser user)
        {
            InitializeComponent();

            AddButton(strFunctions);

            this.user = user;
            this.lbl_LoginName.Text = user.userName;

            foreach (Control each in this.flowLayoutPanel1.Controls)
            {
                if (each is Button)
                {
                    btn_ClickRegister((Button)each);
                }
            }
        }

        void btn_ClickRegister(Button btn)
        {
            switch (btn.Text)
            {
                case "離開系統":
                    btn.Click += btn_Exit;
                    break;
                case "報表":
                    btn.Click += btn_Report;
                    break;
                case "基本資料":
                    btn.Click += btn_MyProfile;
                    break;
                default:
                    break;
            }
        }

        private void btn_MyProfile(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmPersonProfile)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmPersonProfile f = new FrmPersonProfile(this.user);
            this.showForm(f);
        }

        private void btn_Report(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmReport)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmReport f = new FrmReport();
            this.showForm(f);
        }

        void btn_Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定離開系統", "確定與否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        void DangerInform(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showForm(Form f)
        {
            f.TopLevel = false; f.ShowIcon = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.splitContainer2.Panel2.Controls.Add(f);
            f.Show();
            f.Dock = DockStyle.Fill; f.BringToFront();
            f.Move += f_Move;
        }

        void f_Move(object sender, EventArgs e)
        {
            ((Form)sender).Location = new Point(0, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
            FrmLogin f = new FrmLogin();
            f.Show();
        }
    }
}
