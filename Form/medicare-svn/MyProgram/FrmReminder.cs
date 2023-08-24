using MyClassLibrary;
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
    public partial class FrmReminder : Form
    {
        public FrmReminder()
        {
            InitializeComponent();
            
        }

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();        
        global::MyClassLibrary.ClsRemindHelper RemindHelper= new ExamRemindHelper();

        private void FrmReminder_Load(object sender, EventArgs e)
        {
            int twidth = (this.ClientSize.Width) / 32;
            int theight = (this.ClientSize.Height) / 32;
            int bwidth = BtnSendSMS.Width;
            this.dataGridView1.Width = twidth*10;
            this.dataGridView1.Height = this.splitContainer3.Panel2.Height-50;
            int GVxpoint = (splitContainer3.Panel2.Width-this.dataGridView1.Width)/2;
            int lb4xpoint = ((splitContainer3.Panel1.Width - label4.Width) / 2);  // + (label4.Width / 5)
            int lb5xpoint = ((splitContainer4.Panel1.Width - label5.Width) / 2); //+(label5.Width/5)
            int lb3ypoint =splitContainer3.Height+twidth*2;
            this.splitContainer2.SplitterDistance=this.ClientSize.Width/2;
            this.splitContainer3.Width = this.splitContainer4.Width = twidth * 13;
            this.splitContainer3.Location = new Point(twidth, twidth);
            this.splitContainer4.Location = new Point(twidth, twidth);

            this.BtnSendEmail.Location = new Point(twidth, theight);
            this.BtnSendSMS.Location = new Point(twidth, theight *4);
            this.progressBar1.Location = new Point(twidth * 2 + bwidth, theight);
            this.progressBarSMS.Location = new Point(twidth * 2 + bwidth, theight *4);
            
            this.dataGridView1.Location = new Point(GVxpoint,30);
            

            this.label4.Location = new Point(lb4xpoint, 4);
            this.label5.Location = new Point(lb5xpoint, 4);
            this.label3.Location = new Point(twidth, lb3ypoint);

            dataGridView1.DataSource = RemindHelper.SearchTodayRemind();
            IsRemindFinished();
           
        }
        
         private void FrmReminder_Paint(object sender, PaintEventArgs e)
        {
            //只要改下面的dataGridView1就好!
            //dataGridView1.DataSource = RemindHelper.SearchTodayRemind();
        }

        #region 使用backgroundworker寄送簡訊

        private void BtnSendSMS_Click(object sender, EventArgs e)
        {
            BtnSendSMS.Enabled = false;
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;            
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.RunWorkerAsync();
            //string x = ClsRemindHelper.SendMessage(new ClsRemindHelper { PhoneNumber = "0989063072", EventTime = DateTime.Now, EventName = "檢查囉", Division = "小兒科", PatientName = "周郁珊" });
        }
        
        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //讓非同步更明顯              
            progressBarSMS.Maximum = TotalSMS;
            label2.Text = "正在寄送第 (" + e.ProgressPercentage + "/" + TotalSMS + ") 封簡訊";
            progressBarSMS.Value = e.ProgressPercentage;
            dataGridView1.DataSource = RemindHelper.SearchTodayRemind();
            listBox1.Items.Add(Result);
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label2.Text =e.Result+"筆提醒簡訊已寄出!";
            progressBarSMS.Value = progressBarSMS.Maximum;
            IsRemindFinished();
        }
        string Result = "";
        private string lontask()
        {
            System.Threading.Thread.Sleep(1000);
            return "編號XXX簡訊已發送成功!!";
        }

        int TotalSMS;
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {          
            IEnumerable<ClsRemindHelper> remindList = RemindHelper.SearchUnRemind(DateTime.Now);
            e.Result = TotalSMS = remindList.Count();           
            int i=1;
            foreach (var item in remindList)
            {               
                //簡訊編號XXX傳送成功 病患姓名:ABC
                Result = "病患 : " + item.PatientName +"  "+ RemindHelper.SendMessage(item); 
                //Demo
                //Result = "病患 : " + item.PatientName + lontask() ;
                //progressbar改變值
                ((BackgroundWorker)sender).ReportProgress(i);
                i ++;
                //修改DB為已提醒
                DB.ExamCalendar.Where(n => n.ExamCal_ID == item.CalendarID).Single().ExamCal_Rmd = true;
                DB.SubmitChanges();
                
            }
        }
        #endregion

        //使用4.0非同步寄EMAIL
        async private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            string result = "";
            int TotalMail = 0;
            BtnSendEmail.Enabled = false;
            IEnumerable<ClsRemindHelper> remindList = RemindHelper.SearchUnRemind(DateTime.Now);
         
            TotalMail = progressBar1.Maximum = remindList.Count();
            progressBar1.Value = 0;
            int i = 1;
         
           foreach (var item in remindList)
            {
               //讓非同步更明顯
                label1.Text = "正在寄送第 (" + i +"/"+ TotalMail + ") 封郵件";              
                result = await RemindHelper.SendEmailAsync(item);  
            

               listBox1.Items.Add(result); //顯示傳送結果

               DB.ExamCalendar.Where(n => n.ExamCal_ID == item.CalendarID).Single().ExamCal_Rmd = true;
               DB.SubmitChanges();
               dataGridView1.DataSource = RemindHelper.SearchTodayRemind();
               progressBar1.Value++;
               i++;
            }
           
           label1.Text = TotalMail + "封郵件全數寄送完成!";
           IsRemindFinished();
        }

        //private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        if (((bool)dataGridView1.Rows[i].Cells[0].Value) == true)
        //        {
        //            //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
        //            //若已提醒
        //            //dataGridView1.Rows[i].Cells[0]                   
        //        }
        //    }

        //    IsRemindFinished();
            
        //}

        public void IsRemindFinished()
        {
            int unRemind = RemindHelper.SearchUnRemind(DateTime.Now).Count();
            if (unRemind== 0)
            {
                BtnSendEmail.Enabled = BtnSendSMS.Enabled = false;
                label3.Text = "今日所有病患已提醒完畢!!";
            }
            else
            {
                BtnSendEmail.Enabled = BtnSendSMS.Enabled = true;
                label3.Text = "有 " + unRemind + " 位需要提醒的病患!!";
            }
            label3.BringToFront();
            dataGridView1.DataSource = RemindHelper.SearchTodayRemind();
        }

        


       

     

        //private void button1_Click(object sender, EventArgs e)
        //{
        // //  ((WpfControlLibrary1.MyWPFListBox) elementHost1.Child).AddItem("1234");
        //   ((WpfControlLibrary1.MyWPFListBox)elementHost1.Child).DataSource = DB.ExamOverview;
        //}       
    }

   
}
