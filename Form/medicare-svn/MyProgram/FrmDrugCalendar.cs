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
    public partial class FrmDrugCalendar : Form
    {
        public FrmDrugCalendar()
        {
            InitializeComponent();
        }

        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        ClsDrugCalendar c = new ClsDrugCalendar();

        private void FrmDrugCalendar_Load(object sender, EventArgs e)
        {
            foreach (var item in DB.DrugCalendar.Select(n => n.DrugCal_SD))
            {
                monthCalendar1.AddBoldedDate(item);
            }

            monthCalendar1.UpdateBoldedDates();
            toolStripComboBox1.SelectedIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            dataGridView1.DataSource = c.GetData(DateTime.Today);

            this.KeyDown += FrmCalender_KeyDown;
        }

        void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataGridView1.DataSource = c.GetData(e.End);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Search(toolStripComboBox1.Text, toolStripTextBox2.Text);
        }

        private void FrmCalender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ID = (int)dataGridView1.SelectedRows[0].Cells[1].Value;

            DB.DrugCalendar.Where(n => n.DrugCal_ID == ID).First().DrugCal_Rmd = true;

            DB.SubmitChanges();

            dataGridView1.DataSource = c.GetData(monthCalendar1.SelectionEnd);

            MessageBox.Show("簡訊提醒已發送!!");

            ClsRecord.Record(sender, this.Name);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[1].Value;

            if (MessageBox.Show("確定要刪除嗎?\n刪除後將無法復原!!", "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var q = DB.DrugCalendar.Where(n => n.DrugCal_ID == id).First();

                DB.DrugCalendar.DeleteOnSubmit(q);
                DB.SubmitChanges();
            }

            btn_Search_Click(sender, e);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
            ClsDrugCalendar cal = new ClsDrugCalendar(id);

            using (FrmDrugCalendarEdit f = new FrmDrugCalendarEdit())
            {
                f.dCal = cal;
                f.ShowDialog();
            }

            btn_Search_Click(sender, e);
        }
    }
}
