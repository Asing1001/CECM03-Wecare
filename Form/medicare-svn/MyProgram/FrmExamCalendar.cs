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

namespace MyProgram
{
    public partial class FrmExamCalendar : Form
    {
        public FrmExamCalendar()
        {
            InitializeComponent();
        }

        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
        ClsExamCalender clscalender = new ClsExamCalender();

        private void FrmCalender_Load(object sender, EventArgs e)
        {
             //將日期粗體化
            //foreach (var item in DB.ExamCalendar.Select(n => n.ExamSch_DoE))
            //{
            //    monthCalendar1.AddBoldedDate(item);
            //}
            //monthCalendar1.UpdateBoldedDates();
            dataGridView1.DataSource = clscalender.GetData(DateTime.Today);
            toolStripComboBox1.SelectedIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
           // dataGridView1.DataSource = clscalender.GetData();
        }
        void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataGridView1.DataSource= clscalender.GetData(e.End);
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {         
           dataGridView1.DataSource= clscalender.Search(toolStripComboBox1.Text, toolStripTextBox2.Text);
        }

        private void FrmCalender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                btn_Search_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ID= (int)dataGridView1.SelectedRows[0].Cells[1].Value;
            DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamCal_Rmd = true;
            DB.SubmitChanges();
            dataGridView1.DataSource = dataGridView1.DataSource = clscalender.GetData(monthCalendar1.SelectionEnd);

            MessageBox.Show("簡訊提醒已發送!!");
            ClsRecord.Record(sender, "FrmExamCalendar");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            int index = (int)dataGridView1.SelectedRows[0].Index;

            FrmExamCalendarEdit.ID = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
            FrmExamCalendarEdit f = new FrmExamCalendarEdit();
            f.ShowDialog();

            dataGridView1.DataSource = clscalender.Search(toolStripComboBox1.Text, toolStripTextBox2.Text);
            dataGridView1.Rows[index].Selected = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除嗎?\n刪除後將無法復原!!", "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //int id = (int)dataGridView1.SelectedRows[1].Index;
                int id = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                int n = DB.Patients.Where(m => m.Ptt_Num == (int)dataGridView1.SelectedRows[0].Cells[2].Value).First().Ptt_ID;

                var q = from p in DB.ExamCalendar
                        where p.ExamCal_ID == id
                        select p;

                ClsRecord.Record(sender, this.Name, n);
                DB.ExamCalendar.DeleteOnSubmit(q.FirstOrDefault());
                DB.SubmitChanges();
                dataGridView1.DataSource = MyClassLibrary.ClsExamSchedule.getSchedule();
            }
        }
    }
}
