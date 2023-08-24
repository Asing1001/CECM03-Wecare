using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.UI.WebControls;
using MyClassLibrary;
using MyDB;


namespace MyProgram
{
    public partial class FrmCalender : Form
    {
        clsUser user = null;

        public FrmCalender(clsUser user)
        {
            InitializeComponent();

            this.user = user;
        }

        MedicareDataClassesDataContext DB = new MedicareDataClassesDataContext();
        ClsCalender clscalender = new ClsCalender();

        private void FrmCalender_Load(object sender, EventArgs e)
        {
            foreach (var item in DB.ExamCalender.Select(n => n.日期))
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
