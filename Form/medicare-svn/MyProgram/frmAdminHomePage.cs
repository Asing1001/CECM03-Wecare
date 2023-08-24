using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class frmAdminHomePage : MyClassLibrary.frmLogo
    {
        string[] strFunctions = {    "使用者帳號\n管理",
                                                  "職稱設定",
                                                  "科別設定",
                                                  "檢驗類別\n設定", 
                                                  "檢驗項目\n設定", 
                                                  "檢驗頻率\n設定", 
                                                  "藥物項目\n設定", 
                                                  "用藥頻率\n設定",
                                                  "狀態表項目\n設定",
                                                  "使用記錄\n查詢",
                                                  "離開系統" };

        public frmAdminHomePage(MyClassLibrary.clsUser user)
        {
            InitializeComponent();

            this.lbl_LoginName.Text = user.userName;

            AddButton(strFunctions);

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
                case "職稱設定":
                    btn.Click += btn_SetJobTitle;
                    break;
                case "使用者帳號\n管理":
                    btn.Click += btn_UserManager;
                    break;
                case "科別設定":
                    btn.Click += btn_SetDivision;
                    break;
                case "檢驗類別\n設定":
                    btn.Click += btn_SetExamCatalog;
                    break;
                case "檢驗項目\n設定":
                    btn.Click += btn_SetExamOverview;
                    break;
                case "檢驗頻率\n設定":
                    btn.Click += btn_SetExamFrequency;
                    break;
                case "藥物項目\n設定":
                    btn.Click += btn_SetDrugOverview;
                    break;
                case "用藥頻率\n設定":
                    btn.Click += btn_SetDrugFreqency;
                    break;
                case "狀態表項目\n設定":
                    btn.Click += btn_SetSituation;
                    break;
                case "使用記錄\n查詢":
                    btn.Click += btn_GetRecord;
                    break;
                default:
                    break;
            }

        }

        private void btn_SetExamFrequency(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmExamFrequenciesCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmExamFrequenciesCT f = new FrmExamFrequenciesCT();
            this.showForm(f);
        }

        private void btn_GetRecord(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmUseRecord)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmUseRecord f = new FrmUseRecord();
            this.showForm(f);
        }

        private void btn_SetSituation(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmSituationsCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmSituationsCT f = new FrmSituationsCT();
            this.showForm(f);
        }

        private void btn_SetJobTitle(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmJBT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmJBT f = new FrmJBT();
            this.showForm(f);
        }

        private void btn_SetDrugFreqency(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmDrugFrequenciesCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmDrugFrequenciesCT f = new FrmDrugFrequenciesCT();
            this.showForm(f);
        }

        private void btn_SetDrugOverview(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmDrugOverviewCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmDrugOverviewCT f = new FrmDrugOverviewCT();
            this.showForm(f);
        }

        private void btn_SetExamOverview(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmExamOverviewCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmExamOverviewCT f = new FrmExamOverviewCT();
            this.showForm(f);
        }

        private void btn_SetExamCatalog(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmExamCategoriesCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmExamCategoriesCT f = new FrmExamCategoriesCT();
            this.showForm(f);
        }

        private void btn_SetDivision(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Form each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmDivisionsCT)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmDivisionsCT f = new FrmDivisionsCT();
            this.showForm(f);
        }

        private void btn_UserManager(object sender, EventArgs e)
        {
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                foreach (Control each in this.splitContainer2.Panel2.Controls)
                {
                    if (each is FrmStaffs)
                    {
                        each.BringToFront();
                        return;
                    }
                }
            }

            FrmStaffs f = new FrmStaffs();
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
