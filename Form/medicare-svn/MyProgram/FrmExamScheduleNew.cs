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
    public partial class FrmExamScheduleNew : Form
    {
        public FrmExamScheduleNew()
        {
            InitializeComponent();
        }

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        private void FrmNewSchedule_Load(object sender, EventArgs e)
        {
            var q2 = from p in DB.Patients
                     select new { p.Ptt_Name, p.Ptt_Num, p.Ptt_ID };

            BindingSource bs = new BindingSource();
            bs.DataSource = q2.ToList();
            comboBox1.DataSource = comboBox2.DataSource = bs;
            comboBox1.DisplayMember = "Ptt_Name";
            comboBox2.DisplayMember = "Ptt_Num";
            comboBox1.ValueMember = "Ptt_ID";

            BindingSource bsFrequency = new BindingSource();
            bsFrequency.DataSource = MyClassLibrary.frequency.GetFrequency();
            comboBox4.DataSource = bsFrequency;
            comboBox4.DisplayMember = "fName";

            comboBox3.DataSource = MyClassLibrary.Exam.GetExam();
            comboBox3.DisplayMember = "eName";

            RemindDays r = new RemindDays();
            RmdcomboBox.DataSource = r.GetData();
            RmdcomboBox.DisplayMember = "RmdDays_Days";
            RmdcomboBox.ValueMember = "RmdDays_ID";           

            var staffs = DB.Staffs;            

            DoctorComboBox.DataSource = staffs.Where(n=>n.Job_ID==1).Select(n=>new {ID=n.Staff_ID,Name= n.Staff_Name});
            DoctorComboBox.DisplayMember = "Name";
            DoctorComboBox.ValueMember = "ID";

            NurseCombo.DataSource = staffs.Where(n => n.Job_ID == 2).Select(n => new { ID = n.Staff_ID, Name = n.Staff_Name });
            NurseCombo.DisplayMember = "Name";
            NurseCombo.ValueMember = "ID";

            ConsultCombo.DataSource = staffs.Where(n => n.Job_ID == 3).Select(n => new { ID = n.Staff_ID, Name = n.Staff_Name });
            ConsultCombo.DisplayMember = "Name";
            ConsultCombo.ValueMember = "ID";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int docID=Convert.ToInt32( DoctorComboBox.SelectedValue);
            int nurID=Convert.ToInt32( NurseCombo.SelectedValue);
            int consultID=Convert.ToInt32( ConsultCombo.SelectedValue);
            string diagCons = "糖尿病";
            int RmdID=Convert.ToInt32( RmdcomboBox.SelectedValue);
            int pttID =Convert.ToInt32( comboBox1.SelectedValue);

            if (MessageBox.Show("確定要新增嗎?", "新增確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int regID= Register.RegisterPatient(pttID, docID);



                DB.Diagnosis.InsertOnSubmit(new MyDB.Diagnosis
                {
                    RegInfo_ID = regID,
                    Docter_ID = docID,
                    Nurse_ID = nurID,
                    Counselor_ID = consultID,
                    Diag_CoD = diagCons,
                    RmdDay_ID = RmdID,
                });
                DB.SubmitChanges();


                int diagID= DB.Diagnosis.Max(n=>n.Diag_ID);
                DB.Evaluations.InsertOnSubmit(new MyDB.Evaluation
                {
                    Diag_ID = diagID,
                    Staff_ID = docID,
                    Ptt_ID = pttID 
                });
                
                MyDB.ExamSchedules i = new MyDB.ExamSchedules
                {                
                    Diag_ID=diagID,
                    Exam_ID = ((Exam)comboBox3.SelectedItem).eID,
                    ExamFreq_EFC = ((frequency)comboBox4.SelectedItem).fID,
                    ExamSch_SD = 起始日期DateTimePicker.Value,
                    ExamSch_ED = 結束日期DateTimePicker.Value,
                    ExamSch_Rem = 備註TextBox.Text,
                    ExamSch_ClsRsn = 結案原因TextBox.Text,
                    ExamSch_Cls = 結案CheckBox.Checked
                };
                try
                {
                    DB.ExamSchedules.InsertOnSubmit(i);
                    DB.SubmitChanges();

                    MessageBox.Show("新增成功!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("新增失敗");
                }


                int sID = DB.ExamSchedules.Select(n => n.ExamSch_ID).Max();

                for (DateTime d = 起始日期DateTimePicker.Value.Date; d < 結束日期DateTimePicker.Value.Date; d = d.AddDays(((frequency)comboBox4.SelectedItem).fDay))
                {
                    MyDB.ExamCalendar ec = new MyDB.ExamCalendar
                    {
                        ExamSch_ID = sID,
                        Status_ID = 2,
                        RmdDays_ID = (int)RmdcomboBox.SelectedValue,
                        ExamCon_ID = 1,
                        TI_ID = 1,
                        ExamSch_DoE = d.Date,
                        ExamCal_Rem = 備註TextBox.Text,
                        ExamCal_Rmd = false,
                        ExamSch_Rlt = "尚未檢測"

                    };

                    DB.ExamCalendar.InsertOnSubmit(ec);
                }
                try
                {
                    DB.SubmitChanges();

                    MessageBox.Show("已同步新增行事曆!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("行事曆同步失敗");
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
