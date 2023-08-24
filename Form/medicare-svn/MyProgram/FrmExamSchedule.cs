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
    public partial class FrmExamSchedule : Form
    {
        public FrmExamSchedule()
        {
            InitializeComponent();
        }

        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = ClsExamSchedule.getSchedule();
            this.KeyPreview = true;                    
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmExamScheduleNew f = new FrmExamScheduleNew();

            if (f.ShowDialog() == DialogResult.Yes)
            {
                dataGridView1.DataSource = ClsExamSchedule.getSchedule();
                int index = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[index].Selected = true;
            }

            ClsRecord.Record(sender, this.Name);
            btn_Seach_Click(new object(), new EventArgs());
        }

        private void btn_Seach_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text=="姓名")
            {
                var q = from p in DB.View_ExamSchedules
                        where p.病患名稱.Contains(toolStripTextBox2.Text)
                        select p;

                dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from p in DB.View_ExamSchedules
                        where p.病歷號碼.ToString() == toolStripTextBox2.Text
                        select p;

                dataGridView1.DataSource = q.ToList();
            } 
        }

        Random randomNum = new Random();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //亂數選擇一病患ID
            //幫最新的一個病患掛號、看病產生醫囑
            int pID = DB.Patients.Select(n=>n.Ptt_ID).Max();
            //亂數選擇病患
            pID = randomNum.Next(1, pID+1);  
            int rID=DB.RegisterInformations.Select(n=> n.RegInfo_ID).Max()+1;
            int dID = DB.Diagnosis.Select(n => n.Diag_ID).Max()+1;
            //亂數一個醫生
            List<int> DoctorStaffID= DB.Staffs.Where(n => n.Job_ID == 1).Select(n=>n.Staff_ID).ToList();
            int DoctorID =DoctorStaffID[randomNum.Next(0,DoctorStaffID.Count)];
            //亂數起始結束日期
            int random=randomNum.Next(1, 4);
            
            //DateTime 起始日期=DateTime.Now.AddDays(randomNum.Next(0, 50));
            
            //假設今天看病
            DateTime 起始日期=DateTime.Now;
            
            //隨機排程結束日期
            DateTime 結束日期 = DateTime.Now.AddDays(randomNum.Next(50, 150));
            
            //亂數產生掛號 醫囑 檢驗資料
            DB.RegisterInformations.InsertOnSubmit(new MyDB.RegisterInformation { RegInfo_ID = rID, Ptt_ID = pID, OPI_ID = randomNum.Next(1, 4), Staff_ID = DoctorID, });
                      
            DB.Diagnosis.InsertOnSubmit(new MyDB.Diagnosis {  Diag_ID = dID, RegInfo_ID = rID, RmdDay_ID = random,  Diag_CoD = "骨質疏鬆", Nurse_ID = 2, Counselor_ID = 3, Docter_ID =DoctorID  });
          
            //DEMO時手動新增
            DB.ExamSchedules.InsertOnSubmit(new MyDB.ExamSchedules { Diag_ID = dID, ExamFreq_EFC=random, Exam_ID = randomNum.Next(1, 4), ExamSch_ID = random, ExamSch_SD = 起始日期, ExamSch_ED = 結束日期, ExamSch_Rem = "DEMO",  ExamSch_ClsRsn = "尚未結案",  ExamSch_Cls = false });
            
            DB.SubmitChanges();

            var q = from p in DB.Patients
                    where p.Ptt_ID == pID
                    select p.Ptt_Name;
            string[] x = { "" };
            foreach (var a in q)
            {
                x[0] = a;
            }

            MessageBox.Show(string.Format("新增了一筆就診資料 \n掛號ID : {0} \n病患姓名 : {1}",rID,x[0]));

            for (DateTime d = 起始日期; d < 結束日期; d = d.AddDays(DB.ExamFrequencies.Where(n=>n.ExamFreq_ID==random).First().ExamFreq_Days))
            {
                MyDB.ExamCalendar ec = new MyDB.ExamCalendar
                {
                    ExamSch_ID =DB.ExamSchedules.Select(n=>n.ExamSch_ID).Max(),
                     Status_ID = 2,
                    RmdDays_ID = random,
                    ExamCon_ID = 1,
                     TI_ID = 1,
                     ExamSch_DoE = d.Date,
                     ExamCal_Rem = "DEMO",
                     ExamCal_Rmd= false,
                    ExamSch_Rlt = "尚未檢測"
                };
                DB.ExamCalendar.InsertOnSubmit(ec);
            }
            try
            {
                DB.SubmitChanges();

                MessageBox.Show("已同步新增行事曆!");              
            }
            catch (Exception)
            {
                MessageBox.Show("行事曆同步失敗");
            }

            dataGridView1.DataSource = MyClassLibrary.ClsExamSchedule.getSchedule();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除嗎?\n刪除後將無法復原!!", "警告", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
                var q = from p in DB.ExamSchedules
                        where p.ExamSch_ID == id
                        select p;

                ClsRecord.Record(sender, this.Name, q.First().Diagnosis.RegisterInformation.Patients.Ptt_ID);
                DB.ExamSchedules.DeleteOnSubmit(q.FirstOrDefault());
                DB.SubmitChanges();
                dataGridView1.DataSource = MyClassLibrary.ClsExamSchedule.getSchedule();
            }
        }

        private void FrmExamScheduleManage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                btn_Seach_Click(sender, e);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            ClsExamSchedule.id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            
            FrmExamEdit f = new FrmExamEdit();
            f.ShowDialog();

            btn_Seach_Click(sender, e);
            dataGridView1.Rows[index].Selected = true;

            //ClsRecord.Record(sender, this.Name, DB.ExamSchedules.Where(n => n.ExamSch_ID==ClsExamSchedule.id).First().Diagnosis.RegisterInformation.Patients.Ptt_ID);
        }
    }
}
