using MyClassLibrary;
using MyDB;
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
    public partial class FrmDrugSchedule : Form
    {
        public FrmDrugSchedule()
        {
            InitializeComponent();
        }

        ClsDrug clsdrug = new ClsDrug();
        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        private void FrmDrugSchedule_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmDrugSchedule_KeyDown;
            toolStripComboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = clsdrug.GetData();

            this.dataGridView1.RowHeadersWidth = 4;
        }

        void FrmDrugSchedule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                btn_Search_Click( sender,e);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsdrug.Search(toolStripComboBox1.Text, toolStripTextBox2.Text);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ClsRecord.Record(sender, this.Name);

            int id = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
            clsdrug.DeleteSchedule(id);
            dataGridView1.DataSource = clsdrug.GetData();
        }

        Random randomNum = new Random();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int pID = DB.Patients.Select(n => n.Ptt_ID).Max();
            pID = randomNum.Next(1, pID + 1);
            int rID = DB.RegisterInformations.Select(n => n.RegInfo_ID).Max() + 1;
            int dID = DB.Diagnosis.Select(n => n.Diag_ID).Max() + 1;

            //亂數起始結束日期
            int random = randomNum.Next(1, 4);
            DateTime 起始日期 = DateTime.Now.AddDays(randomNum.Next(0, 50));
            DateTime 結束日期 = DateTime.Now.AddDays(randomNum.Next(50, 150));

            //亂數產生掛號 醫囑 檢驗資料
            DB.RegisterInformations.InsertOnSubmit(new MyDB.RegisterInformation { RegInfo_ID = rID, Ptt_ID = pID, OPI_ID = randomNum.Next(1, 4), Staff_ID = 4, });

            DB.Diagnosis.InsertOnSubmit(new MyDB.Diagnosis { Diag_ID = dID, RegInfo_ID = rID, RmdDay_ID = random, Diag_CoD = "骨質疏鬆", Nurse_ID = 2, Counselor_ID = 3, Docter_ID = 4 });
            DB.DrugSchedules.InsertOnSubmit(new MyDB.DrugSchedules { Diag_ID = rID + 5, Drug_ID = random, DrugFreq_ID = randomNum.Next(5, 40), DrugSch_SD = DateTime.Now.AddDays(randomNum.Next(-99, 0)), DrugSch_ED = DateTime.Now.AddDays(randomNum.Next(0, 99)), DrugSch_Rem = "test", DrugSch_ClsRsn = "尚未結案", DrugSch_Cls = false });
            
            DB.SubmitChanges();

            var q = from p in DB.Patients
                    where p.Ptt_ID == pID
                    select p.Ptt_Name;

            string[] x = { "" };

            foreach (var a in q)
            {
                x[0] = a;
            }

            MessageBox.Show(string.Format("新增了一筆就診資料 \n掛號ID : {0} \n病患姓名 : {1}",Properties.Settings.Default.掛號ID,x[0]));

            Properties.Settings.Default.掛號ID += 1;
            Properties.Settings.Default.Save();

            dataGridView1.DataSource = clsdrug.GetData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int index=dataGridView1.Rows.Count-1;

            FrmDrugScheduleNew f = new FrmDrugScheduleNew();

            if (f.ShowDialog()==DialogResult.Yes)
            {
                dataGridView1.DataSource = clsdrug.GetData();

                dataGridView1.Rows[index].Selected = true;
            }
            btn_Search_Click(new object(),new EventArgs());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ClsDrug.editID = (int)(dataGridView1.SelectedRows[0].Cells[0].Value);
            int index=dataGridView1.SelectedRows[0].Index;
            FrmDrugEdit f = new FrmDrugEdit();

            f.ShowDialog();
            
            btn_Search_Click(sender, e);
            dataGridView1.Rows[index].Selected=true;
        }
    }
}
