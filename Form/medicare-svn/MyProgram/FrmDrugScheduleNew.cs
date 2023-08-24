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
    public partial class FrmDrugScheduleNew : Form
    {
        public FrmDrugScheduleNew()
        {
            InitializeComponent();
        }
        
        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
        ClsDrug clsdrug;

        private void FrmNewDrugSchedule_Load(object sender, EventArgs e)
        {
            var q2 = from p in DB.Patients
                     select new { p.Ptt_Name, p.Ptt_Num, p.Ptt_ID };

            BindingSource bs = new BindingSource();
            bs.DataSource = q2.ToList();
            comboBox1.DataSource = comboBox2.DataSource = bs;
            comboBox1.DisplayMember = "Ptt_Name";
            comboBox2.DisplayMember = "Ptt_Num";
            comboBox1.ValueMember = "Ptt_ID";

            clsdrug= new DrugFrequency();
            comboBox4.DataSource= clsdrug.GetData();
            comboBox4.DisplayMember = "DrugFreq_DFC";
            comboBox4.ValueMember = "DrugFreq_Days";

            clsdrug = new TotalDrug();
            comboBox3.DataSource = clsdrug.GetData();
            comboBox3.DisplayMember = "Drug_NameCH";

            clsdrug = new RemindDays();
            comboBox6.DataSource = clsdrug.GetData();
            comboBox6.DisplayMember = "RmdDays_Days";
            comboBox6.ValueMember = "RmdDays_ID";

            this.comboBox1.SelectedValueChanged += comboBox1_TextChanged;
            comboBox1_TextChanged(sender, e);
        }

        void comboBox1_TextChanged(object sender, EventArgs e)
        {            
            var q = from p in DB.Diagnosis
                    where p.RegisterInformation.Patients.Ptt_ID == (int)comboBox1.SelectedValue
                    orderby p.Diag_ID descending
                    select new { ID=p.Diag_ID };

            comboBox5.DataSource = q.ToList();
            comboBox5.DisplayMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後新增資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DB.DrugSchedules.InsertOnSubmit(new MyDB.DrugSchedules
                    {
                        Diag_ID = int.Parse(comboBox5.Text),
                        Drug_ID = ((MyDB.DrugOverview)comboBox3.SelectedItem).Drug_ID,
                        DrugFreq_ID = ((MyDB.DrugFrequencies)comboBox4.SelectedItem).DrugFreq_ID,
                        DrugSch_SD = 起始日期DateTimePicker.Value,
                        DrugSch_ED = 結束日期DateTimePicker.Value,
                        DrugSch_Rem = 備註TextBox.Text,
                        DrugSch_ClsRsn = 結案原因TextBox.Text,
                        DrugSch_Cls = 結案CheckBox.Checked
                    });
                   
                    DB.SubmitChanges();

                    MessageBox.Show("新增成功!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("新增失敗");
                }

                int sID = DB.DrugSchedules.Select(n => n.DrugSch_ID).Max();

                for (DateTime d = 起始日期DateTimePicker.Value; d < 結束日期DateTimePicker.Value; d = d.AddDays((int)comboBox4.SelectedValue))
                {
                    MyDB.DrugCalendar ec = new MyDB.DrugCalendar
                    {
                        DrugSch_ID = sID,
                        Status_ID = 2,
                        RmdDay_ID = (int)comboBox6.SelectedValue,
                        DrugCal_SD = d,
                        DrugCal_Rem = 備註TextBox.Text,
                        DrugCal_Rmd = false,
                    };

                    DB.DrugCalendar.InsertOnSubmit(ec);
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

                ClsRecord.Record(sender, this.Name, (int)comboBox1.SelectedValue);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
