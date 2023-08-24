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
    public partial class FrmExamCalendarEdit : Form
    {
        public FrmExamCalendarEdit()
        {
            InitializeComponent();
        }

        public static int ID;

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();

        private void FrmCalenderEdit_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DB.Situations;
            comboBox1.DisplayMember = "Status_Name";
            comboBox1.ValueMember = "Status_ID";


            comboBox2.DataSource = DB.ExamConsequences.Select(n => n);
            comboBox2.DisplayMember = "ExamCon_CoC";
            comboBox2.ValueMember = "ExamCon_ID";
            //行事曆IDTextBox.Text = ID.ToString();

            var q = DB.View_ExamCalendars.Where(n => n.行事曆ID == ID).First();
            
            病患Ptt_NameTextBox.Text = q.病患名稱;
            comboBox1.Text = q.狀態;

            if (q.狀態=="未完成")
            {
               結果值TextBox.Enabled=備註TextBox.Enabled=comboBox2.Enabled = false;
            }

            comboBox2.Text = q.檢驗結果;

            if (q.狀態 == "完成")
            {
                結果值TextBox.Text = q.結果值;
                備註TextBox.Text = q.備註;
            }
            else
            {
                結果值TextBox.Text = "尚未檢驗";
                備註TextBox.Text = "無";
            }

          

            this.comboBox1.SelectedIndexChanged += (a, b) =>
            {
                if (comboBox1.Text == "未完成")
                {
                    結果值TextBox.Enabled = 備註TextBox.Enabled = comboBox2.Enabled = false;
                }
                else
                {
                    結果值TextBox.Enabled = 備註TextBox.Enabled = comboBox2.Enabled = true;
                }
            };
               
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要更新資料嗎?\n更新後舊有資料將無法復原!!", "更新確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().Status_ID = (int)comboBox1.SelectedValue;
                DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamCon_ID = (int)comboBox2.SelectedValue;
                //DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamSch_Rlt = 結果值TextBox.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamSch_Rlt = 結果值TextBox.Text;
                    DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamCal_Rem = 備註TextBox.Text;
                }
                else
                {
                    DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamSch_Rlt = "尚未檢驗";
                    DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamCal_Rem = "無";
                }

                DB.SubmitChanges();

                MyClassLibrary.ClsRecord.Record(sender, "FrmExamCalendarEdit", DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamSchedules.Diagnosis.RegisterInformation.Patients.Ptt_ID);
                
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?\n取消後修改資料將消失!!", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
