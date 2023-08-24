using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDB.Properties;
using System.Data.SqlClient;

namespace MyProgram
{
    public partial class FrmUseRecord : Form
    {
        public FrmUseRecord()
        {
            InitializeComponent();
        }

        MyDB.MedicareDataClassesDataContext ds = new MyDB.MedicareDataClassesDataContext();
       
        private void FrmUseRecord_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = ds.View_UseRecords.Where(n => n.使用時間.Date == DateTime.Today).ToList();
            this.KeyPreview = true;
            this.KeyDown += FrmUseRecord_KeyDown;
        }

        void FrmUseRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                btn_Seach_Click(sender, e);
            }
        }             

        private void btn_Seach_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "使用者":
                    dataGridView1.DataSource = ds.View_UseRecords.Where(n => n.使用者.Contains(toolStripTextBox2.Text)).ToList();
                    break;
                case "病患姓名":
                    dataGridView1.DataSource = ds.View_UseRecords.Where(n => n.被修改的病患.Contains(toolStripTextBox2.Text)).ToList();
                    break;
            }
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            dataGridView1.DataSource = ds.View_UseRecords.Where(n => n.使用時間.Date == e.Start.Date).ToList();
        }
    }
}
