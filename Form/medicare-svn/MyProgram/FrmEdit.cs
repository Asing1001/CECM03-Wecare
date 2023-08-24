using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;
using MyDB;

namespace MyProgram
{
    public partial class FrmEdit : Form
    {
        public FrmEdit()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicareDataSet);
        }

        public string identity;
        string Origine;

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'medicareDataSet.Patients' 資料表。您可以視需要進行移動或移除。
            this.patientsTableAdapter.FillByid(this.medicareDataSet.Patients, identity);

            Origine = 身分證字號TextBox.Text;
        }

        bool m = true;
        public String pId;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Ptt_NameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else
            {
                pId = 身分證字號TextBox.Text;

                if (pId.Trim().Length == 0)
                {
                    MessageBox.Show("請輸入 身分證字號");
                }
                else if (身分證字號TextBox.Text.Trim().Length < 10) { MessageBox.Show("身分證字號 過短"); }
                else if (身分證字號TextBox.Text.Trim().Length > 10) { MessageBox.Show("身分證字號 過長"); }
                else
                {
                    if (pId != Origine)
                    {
                        using (SqlConnection Conn = new SqlConnection(MyProgram.Properties.Resources.MedicareConnectionString))
                        {
                            string strCompare = "Select Ptt_PID from Patients";

                            using (SqlCommand cmd = new SqlCommand(strCompare, Conn))
                            {
                                cmd.CommandType = CommandType.Text;

                                Conn.Open();

                                SqlDataReader acdr = cmd.ExecuteReader();

                                while (acdr.Read())
                                {
                                    String s = acdr["Ptt_PID"].ToString();

                                    if (s == pId)
                                    {
                                        MessageBox.Show("身分證字號重複");

                                        m = false;
                                        break;
                                    }
                                }

                                if (m)
                                {
                                    if (MessageBox.Show("確定要更新資料嗎?", "更新確認",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        MessageBox.Show("修改成功");

                                        this.Validate();
                                        this.patientsBindingSource.EndEdit();
                                        this.tableAdapterManager.UpdateAll(this.medicareDataSet);

                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.Validate();
                        this.patientsBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.medicareDataSet);

                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) //關閉
        {
            if (MessageBox.Show("確定要取消嗎?", "取消確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
