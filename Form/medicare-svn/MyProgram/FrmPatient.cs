using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }

        ToolStripMenuItem menuItemPhone = new ToolStripMenuItem("電話");
        ToolStripMenuItem menuItemAddr = new ToolStripMenuItem("地址");
        ToolStripMenuItem menuItemEmail = new ToolStripMenuItem("Email");
        ToolStripMenuItem menuItemVIP = new ToolStripMenuItem("VIP");

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            ContextMenuStrip contextmenustrip = new System.Windows.Forms.ContextMenuStrip();
            
            contextmenustrip.Items.Add(menuItemPhone);
            contextmenustrip.Items.Add(menuItemAddr);
            contextmenustrip.Items.Add(menuItemEmail);
            contextmenustrip.Items.Add(menuItemVIP);
            menuItemEmail.Checked = true;
            menuItemPhone.Checked = menuItemAddr.Checked = menuItemVIP.Checked = false;

            dataGridView1.ContextMenuStrip = contextmenustrip;

            menuItemPhone.Click += menuItemPhone_Click;
            menuItemAddr.Click += menuItemAddr_Click;
            menuItemEmail.Click += menuItemEmail_Click;
            menuItemVIP.Click += menuItemVIP_Click;
       

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.dataGridView1.ScrollBars = ScrollBars.Both;
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox1.TextChanged += toolStripComboBox1_TextChanged;
        }

        void menuItemPhone_Click(object sender, EventArgs e)
        {
            hideColumn(sender, 5);
        }

        void menuItemAddr_Click(object sender, EventArgs e)
        {
            hideColumn(sender, 6);
        }

        void menuItemEmail_Click(object sender, EventArgs e)
        {
            hideColumn(sender, 7);
        }
        void menuItemVIP_Click(object sender, EventArgs e)
        {
            hideColumn(sender, 8);
        }

        void hideColumn(object mysender,int myindex)   //勾選狀態後 切換
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)mysender;

            if (menuItem.CheckState == CheckState.Checked)
            {
                menuItem.CheckState = CheckState.Unchecked;
                dataGridView1.Columns[myindex].Visible = false;
            }
            else
            {
                menuItem.CheckState = CheckState.Checked;
                dataGridView1.Columns[myindex].Visible = true;
            }
        }
        void hideStatus(object mysender, int myindex)  //顯示狀態
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)mysender;
            
             if (menuItem.CheckState == CheckState.Checked)
             {
                 dataGridView1.Columns[myindex].Visible = true;
             }
             else
             {
                 dataGridView1.Columns[myindex].Visible = false;
             }
        }
     

        void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripTextBox2.Focus();
            this.toolStripTextBox2.SelectAll();
        }



        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmAdd g = new FrmAdd();
            g.ShowDialog();

            var y = from p in db.Patients
                    select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
            this.dataGridView1.DataSource = y.ToList();

            //顯示狀態
            hideStatus(menuItemPhone, 5);
            hideStatus(menuItemAddr, 6);
            hideStatus(menuItemEmail, 7);
            hideStatus(menuItemVIP, 8);

            toolStripStatusLabel1.Text = "總筆數 :" + dataGridView1.Rows.Count;
            toolStripStatusLabel2.Text = dataGridView1.SelectedRows[0].Index + 1 + " / " + dataGridView1.Rows.Count;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            if (toolStripTextBox2.Text == "")
            {
                var q = from p in db.Patients
                        select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                dataGridView1.DataSource = q.ToList();
            }
            else
            {
                switch (toolStripComboBox1.SelectedIndex)
                {
                    case 0:
                        var q = from p in db.Patients
                                where p.Ptt_Name.Contains(toolStripTextBox2.Text)
                                select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                        dataGridView1.DataSource = q.ToList();
                        break;
                    case 1:
                        var w = from p in db.Patients
                                where p.Ptt_PID.Contains(toolStripTextBox2.Text)
                                select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                        dataGridView1.DataSource = w.ToList();
                        break;
                    case 2:
                        DateTime x;
                        if (DateTime.TryParse(toolStripTextBox2.Text, out x))
                        {
                            var a = from p in db.Patients //要輸入齊全年月日
                                    where p.Ptt_BD == DateTime.Parse(string.Format("{0:yyyy/M/d}", toolStripTextBox2.Text))
                                    select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                            dataGridView1.DataSource = a.ToList();
                        }
                        break;
                    case 3:
                        var b = from p in db.Patients
                                where p.Ptt_TN.Contains(toolStripTextBox2.Text)
                                select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                        dataGridView1.DataSource = b.ToList();
                        break;
                }
            }
            //顯示狀態
            hideStatus(menuItemPhone, 5);
            hideStatus(menuItemAddr, 6);
            hideStatus(menuItemEmail, 7);
            hideStatus(menuItemVIP, 8);
            
            this.toolStripTextBox2.Focus();
            this.toolStripTextBox2.SelectAll();
            //筆數
            toolStripStatusLabel1.Text = "總筆數 :" + db.Patients.Count();
            if (dataGridView1.Rows.Count < 1)
            {
                toolStripStatusLabel2.Text = "0 / 0";
            }
            else
            {
                toolStripStatusLabel2.Text = dataGridView1.SelectedRows[0].Index + 1 + " / " + dataGridView1.Rows.Count;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.DataSource == null)
            {
                MessageBox.Show("請選擇欲查詢病患");
            }
            else
            {
                FrmEdit g = new FrmEdit();
                g.identity = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//告知何筆資料 帶入FrmEdit
                g.ShowDialog();

                if (g.pId != null)
                {
                    var q = from p in db.Patients
                            where p.Ptt_PID == g.pId
                            select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                    dataGridView1.DataSource = q.ToList();
                }
                else
                {
                    var q = from p in db.Patients
                            where p.Ptt_PID == g.identity
                            select new { 病號 = p.Ptt_Num, 姓名 = p.Ptt_Name, 身分證字號 = p.Ptt_PID, 性別 = p.Ptt_Sex, 生日 = p.Ptt_BD, 電話 = p.Ptt_TN, 地址 = p.Ptt_Addr, Email = p.Ptt_Email, VIP = p.Ptt_VIP, 檢驗提醒 = p.Ptt_ExamRmd, 用藥提醒 = p.Ptt_DrugRmd };
                    dataGridView1.DataSource = q.ToList();
                }
                //顯示狀態
                hideStatus(menuItemPhone, 5);
                hideStatus(menuItemAddr, 6);
                hideStatus(menuItemEmail, 7);
                hideStatus(menuItemVIP, 8);

                this.toolStripTextBox2.Focus();
                this.toolStripTextBox2.SelectAll();
                //筆數
                if (dataGridView1.Rows.Count < 1)
                {
                    toolStripStatusLabel2.Text = "0 / 0";
                }
                else
                {
                    toolStripStatusLabel2.Text = dataGridView1.SelectedRows[0].Index + 1 + " / " + dataGridView1.Rows.Count;
                }
            }
        }

        public static int MaxID;
        int ImportNum = 0;

        private void btn_Load_Click(object sender, EventArgs e)
        {
            //btn_Search_Click(sender, e);
            //得到目前最後一個病號
            MaxID = (from p in db.Patients
                     select p.Ptt_ID).Max()+1000;

            int FailCounts = 0;

            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {

                string fileName = file.FileName;
               // string excelConn = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + fileName + "; Extended Properties = 'Excel 8.0;HDR=YES;IMEX=1;ReadOnly=0'"; //連線
              string excelConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + fileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES'";
                
                List<String> sheets = global::MyClassLibrary.clsPatient.getSheets(fileName);  //取得匯入資料的sheets名稱
                string targetSheet = sheets[0];  //固定只匯入第一個sheet

                //由.xls的[Sheet1$] 倒入DataTable 並繫結到dataGridView1
                //string strExcelSelect = "SELECT * FROM [Sheet1$]"; 
                string strExcelSelect = String.Format("SELECT * FROM [{0}]", targetSheet);
                OleDbDataAdapter adapter = new OleDbDataAdapter(strExcelSelect, excelConn);
                DataTable fileData = new DataTable();
                adapter.Fill(fileData);
                dataGridView1.DataSource = fileData;

                //連線寫入DB
                using (SqlConnection Conn = new SqlConnection(Properties.Settings.Default.MedicareConnectionString))
                {
                    string strDBInsert = "INSERT INTO Patients(Ptt_Name,Ptt_PID,Ptt_Sex,Ptt_BD,Ptt_TN,Ptt_Addr,Ptt_Email,Ptt_VIP,Ptt_ExamRmd,Ptt_DrugRmd,Ptt_Num) VALUES (@name,@id,@sex,@birth,@Phone,@addr,@email,@vip,@rexam,@rmed,@num)";
                    using (SqlCommand cmd = new SqlCommand(strDBInsert, Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        Conn.Open();

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {

                            if (MyClassLibrary.clsPatient.checkimport(dataGridView1[1, i]))//判斷身分證重複性
                            {
                                try
                                {
                                    cmd.Parameters.Clear();
                                    ImportNum++;

                                    cmd.Parameters.AddWithValue("@num", MaxID + ImportNum);
                                    cmd.Parameters.AddWithValue("@name", Convert.ToString(dataGridView1[0, i].Value));
                                    cmd.Parameters.AddWithValue("@id", Convert.ToString(dataGridView1[1, i].Value));
                                    cmd.Parameters.AddWithValue("@sex", Convert.ToString(dataGridView1[2, i].Value));
                                    cmd.Parameters.AddWithValue("@birth", Convert.ToDateTime(dataGridView1[3, i].Value));
                                    cmd.Parameters.AddWithValue("@Phone", Convert.ToString(dataGridView1[4, i].Value));
                                    cmd.Parameters.AddWithValue("@addr", Convert.ToString(dataGridView1[5, i].Value));
                                    cmd.Parameters.AddWithValue("@email", Convert.ToString(dataGridView1[6, i].Value));
                                    cmd.Parameters.AddWithValue("@vip", Convert.ToBoolean(dataGridView1[7, i].Value));
                                    cmd.Parameters.AddWithValue("@rexam", Convert.ToBoolean(dataGridView1[8, i].Value));
                                    cmd.Parameters.AddWithValue("@rmed", Convert.ToBoolean(dataGridView1[9, i].Value));
                                    cmd.ExecuteNonQuery();
                                    MedicareDataClassesDataContext db1 = new MedicareDataClassesDataContext();
                                    ClsRecord.Record(sender, this.Name, db1.Patients.Max(n => n.Ptt_ID));
                                }
                                catch (Exception) //空白行 或者 有沒全填欄位者 都會出錯
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                MessageBox.Show(string.Format("{0} 身分證是否有空值,重複或長度異常", dataGridView1[0, i].Value));
                                //MyClassLibrary.clsPatient.m = true;
                                FailCounts++;
                            }
                        }
                    }
                }
            }

            //顯示狀態
            //hideStatus(menuItemPhone, 5);
            //hideStatus(menuItemAddr, 6);
            //hideStatus(menuItemEmail, 7);
            //hideStatus(menuItemVIP, 8);



            this.toolStripTextBox2.Focus();
            this.toolStripTextBox2.SelectAll();

            int RecordCounts = (from g in db.Patients
                                select g).Count();

            if (dataGridView1.Rows.Count > 1) 
            {
                toolStripStatusLabel1.Text = "總筆數 :" + RecordCounts;
                toolStripStatusLabel2.Text = "失敗:" + FailCounts;
            }

        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if (dataGridView1.GetCellCount(DataGridViewElementStates.Displayed) == 0)
            {
                MessageBox.Show("請將要匯出成 Excel 的內容 篩選至畫面");
            }
            else
            {
                MyClassLibrary.clsPatient.ExportDataGridview(dataGridView1, true);
                //顯示狀態
                hideStatus(menuItemPhone, 5);
                hideStatus(menuItemAddr, 6);
                hideStatus(menuItemEmail, 7);
                hideStatus(menuItemVIP, 8);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripStatusLabel2.Text = dataGridView1.SelectedRows[0].Index + 1 + " / " + dataGridView1.Rows.Count;
        }
    }
}

