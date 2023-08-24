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
    public partial class FrmExamEdit : Form
    {
        public FrmExamEdit()
        {
            InitializeComponent();
        }

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        private void FrmExamEdit_Load(object sender, EventArgs e)
        {
            BindingSource bsFrequency = new BindingSource();
            bsFrequency.DataSource = MyClassLibrary.frequency.GetFrequency();
            comboBox4.DataSource = bsFrequency;
            comboBox4.DisplayMember = "fName";

            comboBox3.DataSource = MyClassLibrary.Exam.GetExam();
            comboBox3.DisplayMember = "eName";

            var q = DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First();
            comboBox3.SelectedIndex = (int)DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().Exam_ID - 1;
            comboBox4.SelectedIndex = (int)DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamFreq_EFC - 1;
            起始日期DateTimePicker.Value = q.ExamSch_SD;
            結束日期DateTimePicker.Value = (DateTime)q.ExamSch_ED;
            備註TextBox.Text = q.ExamSch_Rem;
            結案原因TextBox.Text = q.ExamSch_ClsRsn;
            結案CheckBox.Checked = (bool)q.ExamSch_Cls;

            RemindDays r = new RemindDays();
            comboBox6.DataSource = r.GetData();
            comboBox6.DisplayMember = "RmdDays_Days";
            comboBox6.ValueMember = "RmdDays_ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後將無法復原!!", "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MyDB.ExamSchedules i = new MyDB.ExamSchedules
                {
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
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamSch_SD = i.ExamSch_SD;
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamSch_Rem = i.ExamSch_Rem;
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamSch_ED = i.ExamSch_ED;
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamSch_Cls = i.ExamSch_Cls;
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamSch_ClsRsn = i.ExamSch_ClsRsn;
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().Exam_ID = i.Exam_ID;
                    DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().ExamFreq_EFC = i.ExamFreq_EFC;
                    DB.SubmitChanges();

                    MessageBox.Show("修改成功!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失敗");
                }

                var q = DB.ExamCalendar.Where(n => n.ExamSch_ID == ClsExamSchedule.id);

                foreach (var item in q)
                {
                    DB.ExamCalendar.DeleteOnSubmit(item);
                }

                DB.SubmitChanges();

                if (i.ExamSch_Cls == false)
                {
                    for (DateTime d = 起始日期DateTimePicker.Value.Date; d < 結束日期DateTimePicker.Value.Date; d = d.AddDays(((frequency)comboBox4.SelectedItem).fDay))
                    {
                        MyDB.ExamCalendar ec = new MyDB.ExamCalendar
                        {
                            ExamSch_ID = ClsExamSchedule.id,
                            Status_ID = 2,
                            RmdDays_ID = (int)comboBox6.SelectedValue,
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

                        MessageBox.Show("已同步修改行事曆!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("行事曆同步失敗");
                    }
                }

                ClsRecord.Record(sender, this.Name, DB.ExamSchedules.Where(n => n.ExamSch_ID == ClsExamSchedule.id).First().Diagnosis.RegisterInformation.Patients.Ptt_ID);
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
