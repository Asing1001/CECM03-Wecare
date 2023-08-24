using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProgram;
using MyClassLibrary;
using System.IO;
using ChartReport;

namespace HomePageUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.label2.Text = " Welcome ,  " + ClsRecord.CurrentUser.userName;
        }

        //不同的主按鈕按下時的顏色設定存入List中
        List<ColorImage> x = new List<ColorImage>();
        string FolderPath = System.IO.Path.GetFullPath(".");

        private void ShowUserImage()
        {
            MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

            var q = DB.Staffs.Where(n => n.Staff_ID == ClsRecord.CurrentUser.userID).First().Staff_Pix;

            if (q == null || q.Length == 0) //(DB.Staffs.Where(n => n.醫療人員ID == user.userID).First().照片 == null)
            {
                //pictureBox4.Image = null;
            }
            else
            {
                byte[] buf = q.ToArray();
                MemoryStream ms = new MemoryStream(buf);
                Bitmap bmp = new Bitmap(ms);
                this.pictureBox1.Image = bmp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsRemindHelper helper = new ClsRemindHelper();
            int unRemind = helper.SearchUnRemind(DateTime.Now).Count();
            MessageBox.Show(string.Format("今日還有{0}位病患尚未提醒！", unRemind), "今日提醒！");
          

            //權限設定 非管理者隱藏管理
            if (ClsRecord.CurrentUser.userJobID!=4)
            {
                button5.Visible = false;
            }

            ShowUserImage();

            x.Add(new ColorImage { BtnColor = Color.FromArgb(206, 26, 55), BtnImage = Properties.Resources.Calendar2 });
            x.Add(new ColorImage { BtnColor = Color.FromArgb(248, 90, 50), BtnImage = Properties.Resources.Schedule2 });
            x.Add(new ColorImage { BtnColor = Color.FromArgb(2, 107, 193), BtnImage = Properties.Resources.Report2 });
            x.Add(new ColorImage { BtnColor = Color.FromArgb(148, 168, 12), BtnImage = Properties.Resources.Management2 });
            x.Add(new ColorImage { BtnColor = Color.FromArgb(103, 24, 138), BtnImage = Properties.Resources.Time2 });
            x.Add(new ColorImage { BtnColor = Color.FromArgb(240, 173, 0), BtnImage = Properties.Resources.Logout2 });

            int buttonIndex = 0;

            foreach (Button b in flowLayoutPanel1.Controls)
            {
                //藏主button的index在TAG中
                b.Tag = buttonIndex;
                b.Click += b_Click;
                buttonIndex++;
            }

            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
        }

        //記錄前一個按鈕資訊
        Button PreviousButton;
        Image PreviousImage;

        void b_Click(object sender, EventArgs e)
        {
            if (PreviousButton != null)
            {
                PreviousButton.BackColor = Color.Black;
                PreviousButton.BackgroundImage = PreviousImage;
            }

            Button b = (Button)sender;
            int i = (int)b.Tag;

            PreviousImage = b.BackgroundImage;
            b.BackColor = x[i].BtnColor;
            b.BackgroundImage = x[i].BtnImage;

            //不同Button做不一樣的事
            MainButtonHandler(i);

            //記住前一個按的按鈕
            PreviousButton = b;

            if (i < 4)
            {
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel1.BackColor = b.BackColor;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }

        string[] adminBtn = {    "醫療帳號管理",
                                 "病患資料管理",
                                 "職稱設定",
                                 "科別設定",
                                 "檢驗類別設定", 
                                 "檢驗項目設定", 
                                 //"檢驗頻率設定", 
                                 "藥物項目設定", 
                                 "用藥頻率設定",
                                 "狀態項目設定",
                                 "使用記錄查詢",
                            };

        FrmReminder frmReminder = new FrmReminder();

        private void MainButtonHandler(int buttonTag)
        {
            flowLayoutPanel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Clear();

            switch (buttonTag)
            {
                case 0:
                    GenerateButton("醫師");
                    GenerateButton("護理人員");
                    GenerateButton("病人");
                    break;
                case 1:
                    GenerateButton("檢驗排程");
                    GenerateButton("藥物排程");
                    break;
                case 2:
                    GenerateButton("檢驗提醒比率");
                    GenerateButton("用藥提醒比率");
                    GenerateButton("檢驗結案比率");
                    GenerateButton("用藥結案比率");
                    break;
                case 3:
                    foreach (var item in adminBtn)
                    {
                        GenerateButton(item);
                    }
                    break;
                case 4: //若按的是關懷提醒按紐
                    ShowForm(frmReminder);
                    frmReminder.IsRemindFinished();
                    break;
                case 5: //離開系統  最後確認
                    ClsRemindHelper helper = new ClsRemindHelper();
                    int unRemind= helper.SearchUnRemind(DateTime.Now).Count();
                    if (unRemind == 0)
                    {
                        Application.Exit();
                    }else  if (MessageBox.Show(string.Format("今日還有{0}位病患尚未提醒！",unRemind),
                        "確定離開?", MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
                    {
                        Application.Exit(); 
                    }
                    break;
            }
        }

        //產生panel內的Button
        private void GenerateButton(string btnName)
        {
            Button PanelBtn = new Button();

            PanelBtn.Width = flowLayoutPanel2.Width;
            PanelBtn.Text = btnName;
            PanelBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            PanelBtn.ForeColor = System.Drawing.Color.White;
            PanelBtn.Height = 50;
            PanelBtn.FlatStyle = FlatStyle.Flat;
            PanelBtn.FlatAppearance.BorderSize = 0;
            PanelBtn.TextAlign = ContentAlignment.MiddleCenter;
            PanelBtn.Margin = new Padding(0);
            PanelBtn.FlatAppearance.BorderColor = Color.White;
            flowLayoutPanel2.Controls.Add(PanelBtn);
            PanelBtn.Click += PanelBtn_Click;
        }

        Button PreviousPanelBtn;
        Button ActivatePanelBtn;
        Color PreviousMouseOverColor;

        void PanelBtn_Click(object sender, EventArgs e)
        {
            //更改按下去Button的設定
            ActivatePanelBtn = (Button)sender;

            if (ActivatePanelBtn == PreviousPanelBtn)
            {
                return;  //防止重複按同一按鈕
            }

            ActivatePanelBtn.BackColor = Color.White;
            ActivatePanelBtn.ForeColor = Color.Black;
            PreviousMouseOverColor = ActivatePanelBtn.FlatAppearance.MouseOverBackColor;
            ActivatePanelBtn.FlatAppearance.MouseOverBackColor = Color.White;

            //還原上一個button的設定
            if (PreviousPanelBtn != null)
            {
                PreviousPanelBtn.BackColor = flowLayoutPanel2.BackColor;
                PreviousPanelBtn.ForeColor = Color.White;
                PreviousPanelBtn.FlatAppearance.MouseOverBackColor = PreviousMouseOverColor;
            }

            PreviousPanelBtn = ActivatePanelBtn;
            string BtnText = ((Button)sender).Text;

            switch (BtnText)
            {
                case "醫師":
                    ShowForm(new FrmCombineCalendar("醫師"));
                    break;
                case "護理人員":
                    ShowForm(new FrmCombineCalendar("護理人員"));
                    break;
                case "病人":
                    //ShowForm(new FrmExamCalendar());      
                    ShowForm(new frmCalendar(ClsRecord.CurrentUser));
                    break;
                case "檢驗排程":
                    ShowForm(new FrmExamSchedule());
                    break;
                case "藥物排程":
                    ShowForm(new FrmDrugSchedule());
                    break;
                case "檢驗提醒比率":
                    ShowForm(new FrmReportExamRem());
                    break;
                case "用藥提醒比率":
                    ShowForm(new FrmReportDrugRem());
                    break;
                case "檢驗結案比率":
                    ShowForm(new FrmReportExamClose());
                    break;
                case "用藥結案比率":
                    ShowForm(new FrmReportDrugClose());
                    break;
                case "職稱設定":
                    ShowForm(new FrmJBT());
                    break;
                case "醫療帳號管理":
                    ShowForm(new FrmStaffs());
                    break;
                case "病患資料管理":
                    ShowForm(new FrmPatient());
                    break;
                case "科別設定":
                    ShowForm(new FrmDivisionsCT());
                    break;
                case "檢驗類別設定":
                    ShowForm(new FrmExamCategoriesCT());
                    break;
                case "檢驗項目設定":
                    ShowForm(new FrmExamOverviewCT());
                    break;
                //case "檢驗頻率設定":
                //    ShowForm(new FrmExamFrequenciesCT());
                //    break;
                case "藥物項目設定":
                    ShowForm(new FrmDrugOverviewCT());
                    break;
                case "用藥頻率設定":
                    ShowForm(new FrmDrugFrequenciesCT());
                    break;
                case "狀態項目設定":
                    ShowForm(new FrmSituationsCT());
                    break;
                case "使用記錄查詢":
                    ShowForm(new FrmUseRecord());
                    break;
            }           
        }

        Form PreviousForm; //記錄前一張表單

        void ShowForm(Form f)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.Show();
            f.TopLevel = false;
            //f.LostFocus += (a, b) => f.Focus();

            this.splitContainer1.Panel2.Controls.Add(f);

            if (PreviousForm != null && PreviousForm.Name != "FrmReminder")
            {
                PreviousForm.Close();
                PreviousForm.Dispose();
            }

            PreviousForm = f;
            f.Focus();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmPersonProfile(ClsRecord.CurrentUser));
            splitContainer1.Panel1Collapsed = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認登出", "登出", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                FrmLogin f = new FrmLogin();
                f.ShowDialog();
            }
        }
    }

    public class ColorImage
    {
        public Image BtnImage { get; set; }
        public Color BtnColor { get; set; }
    }
}
