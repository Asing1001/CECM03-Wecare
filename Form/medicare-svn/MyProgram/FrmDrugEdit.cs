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
    public partial class FrmDrugEdit : Form
    {
        global::MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        public FrmDrugEdit()
        {
            InitializeComponent();
        }

        ClsDrug clsdrug = new ClsDrug();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?取消後新增資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        int ID = ClsDrug.editID;

        private void FrmDrugScheduleEdit_Load(object sender, EventArgs e)
        {
            clsdrug = new DrugFrequency();
            comboBox4.DataSource = clsdrug.GetData();
            comboBox4.DisplayMember = "DrugFreq_DFC";
            comboBox4.ValueMember = "DrugFreq_Days";

            clsdrug = new TotalDrug();
            comboBox3.DataSource = clsdrug.GetData();
            comboBox3.DisplayMember = "Drug_NameCH";

            comboBox6.DataSource = DB.RemindDays;
            comboBox6.ValueMember = "RmdDays_ID";
            comboBox6.DisplayMember = "RmdDays_Days";
                

            var q = DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First();

            comboBox3.SelectedIndex = (int)q.Drug_ID - 1;
            comboBox4.SelectedIndex = (int)q.DrugFreq_ID - 1;
            起始日期DateTimePicker.Value = q.DrugSch_SD;
            結束日期DateTimePicker.Value = (DateTime)q.DrugSch_ED;
            備註TextBox.Text = q.DrugSch_Rem;
            結案原因TextBox.Text = q.DrugSch_ClsRsn;
            結案CheckBox.Checked = (bool)q.DrugSch_Cls;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MyDB.DrugSchedules i = new MyDB.DrugSchedules
                {
                    Drug_ID = ((MyDB.DrugOverview)comboBox3.SelectedItem).Drug_ID,
                    DrugFreq_ID = ((MyDB.DrugFrequencies)comboBox4.SelectedItem).DrugFreq_ID,
                    DrugSch_SD = 起始日期DateTimePicker.Value,
                    DrugSch_ED = 結束日期DateTimePicker.Value,
                    DrugSch_Rem = 備註TextBox.Text,
                    DrugSch_ClsRsn = 結案原因TextBox.Text,
                    DrugSch_Cls = 結案CheckBox.Checked
                };

                try
                {
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().DrugSch_SD = i.DrugSch_SD;
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().DrugSch_Rem = i.DrugSch_Rem;
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().DrugSch_ED = i.DrugSch_ED;
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().DrugSch_Cls = i.DrugSch_Cls;
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().DrugSch_ClsRsn = i.DrugSch_ClsRsn;
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().Drug_ID = i.Drug_ID;
                    DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().DrugFreq_ID = i.DrugFreq_ID;                    
                    DB.SubmitChanges();

                    MessageBox.Show("修改成功!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失敗");
                }

                var q = DB.DrugCalendar.Where(n => n.DrugSch_ID == ID);

                foreach (var item in q)
                {
                    DB.DrugCalendar.DeleteOnSubmit(item);
                }

                DB.SubmitChanges();

                if (i.DrugSch_Cls == false)
                {
                    for (DateTime d = 起始日期DateTimePicker.Value; d < 結束日期DateTimePicker.Value; d = d.AddDays((int)comboBox6.SelectedValue))
                    {
                        MyDB.DrugCalendar ec = new MyDB.DrugCalendar
                        {
                            RmdDay_ID = (int)comboBox6.SelectedValue,
                            DrugSch_ID =  ID,                            
                            Status_ID = 2,       
                            DrugCal_SD = d,
                            DrugCal_Rem = 備註TextBox.Text,
                            DrugCal_Rmd = false, 
                        };

                        DB.DrugCalendar.InsertOnSubmit(ec);
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

                ClsRecord.Record(sender, this.Text, DB.DrugSchedules.Where(n => n.DrugSch_ID == ID).First().Diagnosis.RegisterInformation.Patients.Ptt_ID);
            }
        }
    }
}
