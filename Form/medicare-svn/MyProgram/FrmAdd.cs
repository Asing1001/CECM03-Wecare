using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDB;
using MyClassLibrary;

namespace MyProgram
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();

            this.Load += FrmAdd_Load;
        }

        void FrmAdd_Load(object sender, EventArgs e)
        {
            foreach (var each in this.Controls)
            {
                if (each is TextBox)
                {
                    ((TextBox)each).KeyUp += FrmAdd_KeyUp;
                    ((TextBox)each).TextChanged += FrmAdd_TextChanged;
                }
            }

            //this.KeyUp += FrmAdd_KeyUp;
            //this.TextChanged += FrmAdd_TextChanged;

            //this.KeyPreview = true;
            this.btn_AddPatientsOK.Enabled = false;
        }

        void VisualCue()
        {
            if (textBox3.Text.Trim() == "")  //必填欄位 姓名
            {
                btn_AddPatientsOK.Enabled = false;
            }
            else
            {
                btn_AddPatientsOK.Enabled = true;
            }
        }

        // bool m = true;
        FrmPatient p = new FrmPatient();

        private void btn_AddPatientsOK_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "") { MessageBox.Show("請輸入身分證字號"); }

            if (textBox4.Text.Trim().Length < 10) { MessageBox.Show("身分證字號 過短"); }
            else if (textBox4.Text.Trim().Length > 10) { MessageBox.Show("身分證字號 過長"); }
            else
            {
                //身分證字號
                bool m = true;
                String pId = textBox4.Text;

                using (SqlConnection Conn = new SqlConnection(Properties.Settings.Default.MedicareConnectionString))
                {
                    //string strCompare = "Select 身分證字號 from Patients";
                    string strCompare = "Select COUNT(Ptt_PID) from Patients where Ptt_PID=@identity";

                    using (SqlCommand cmd = new SqlCommand(strCompare, Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@identity", textBox4.Text);
                        Conn.Open();

                        #region MyRegion old_1
                        //SqlDataReader acdr = cmd.ExecuteReader();
                        //while (acdr.Read())
                        //{

                        //    String s = acdr["身分證字號"].ToString();
                        //    if (s == pId)
                        //    {
                        //        MessageBox.Show("身分證字號 重複");
                        //        m = false;
                        //        return;
                        //    }
                        //} 
                        #endregion

                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("身分證字號 重複");
                            m = false;
                        }
                    }

                    if (m)    //write to DB ==============LinQ ===============
                    {
                        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

                        var q = (from p in db.Patients
                                 select p.Ptt_ID).Max();

                        db.Patients.InsertOnSubmit(new MyDB.Patients
                        {
                            Ptt_Name = textBox3.Text,
                            Ptt_PID = textBox4.Text,
                            Ptt_BD = dateTimePicker1.Value,
                            Ptt_Sex = comboBox1.Text,
                            Ptt_TN = textBox5.Text,
                            Ptt_Addr = textBox6.Text,
                            Ptt_Email = textBox7.Text,
                            Ptt_VIP = checkBox1.Checked,
                            Ptt_ExamRmd = checkBox2.Checked,
                            Ptt_DrugRmd = checkBox3.Checked,
                            //病歷號碼 = int.Parse(textBox2.Text)
                            Ptt_Num = 1000 + q + 1
                        });

                        if (MessageBox.Show("確定要新增嗎?", "新增確認",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                db.SubmitChanges();
                                MessageBox.Show("新增成功!");
                                this.Close();
                            }
                            catch (System.Data.SqlClient.SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

            MedicareDataClassesDataContext db1 = new MedicareDataClassesDataContext();
            ClsRecord.Record(sender, this.Name, db1.Patients.Max(n => n.Ptt_ID));
        }

        private void FrmAdd_KeyUp(object sender, KeyEventArgs e)
        {
            VisualCue();
        }

        private void FrmAdd_TextChanged(object sender, EventArgs e)
        {
            VisualCue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消嗎?", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
             textBox3.Text = "王維可";                            
                             dateTimePicker1.Value = DateTime.Now.AddYears(-20);
                            comboBox1.SelectedIndex=1;
                            textBox5.Text="0921910510";
                           textBox6.Text="台北市大安區復興南路一段229號204室";
                            textBox7.Text="joychiou2012@gmail.com";
                            checkBox1.Checked=false;
                            checkBox2.Checked=   checkBox3.Checked=true;
                           
        }
    }
}
