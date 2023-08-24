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
    public partial class FrmExamCalender : Form
    {
        public FrmExamCalender()
        {
            InitializeComponent();
        }

        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
        ClsExamCalender clscalender = new ClsExamCalender();

        private void FrmCalender_Load(object sender, EventArgs e)
        {
            foreach (var item in DB.ExamCalendars.Select(n => n.日期))
            {
                monthCalendar1.AddBoldedDate(item);
            }
            monthCalendar1.UpdateBoldedDates();
            toolStripComboBox1.SelectedIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            dataGridView1.DataSource = clscalender.GetData();
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

       
    }
}
