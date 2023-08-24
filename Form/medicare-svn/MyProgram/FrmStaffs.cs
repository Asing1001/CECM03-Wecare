using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDB;
using MyClassLibrary;

namespace MyProgram
{
    public partial class FrmStaffs : FrmBase
    {
        public FrmStaffs()
        {
            InitializeComponent();
            //button1_Click(new object(), new EventArgs());
        }

        MedicareDataClassesDataContext db = new MedicareDataClassesDataContext();

        //Search all user
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                var q = from f in db.Staffs
                        join j in db.JobTitles on f.Job_ID equals j.Job_ID
                        join d in db.Divisions on f.Div_ID equals d.Div_ID
                        select new
                        {
                            醫療人員ID = f.Staff_ID,
                            醫療人員姓名 = f.Staff_Name,
                            科別 = d.Div_Name,
                            職稱 = j.Job_Title,
                            帳號 = f.Staff_Acc,
                            //密碼 = f.Staff_Pwd,
                            //salt = f.Staff_Salt,
                            電話 = f.Staff_TN,
                            電子信箱 = f.Staff_Email
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from f in db.Staffs
                        join j in db.JobTitles on f.Job_ID equals j.Job_ID
                        join d in db.Divisions on f.Div_ID equals d.Div_ID
                        where f.Staff_Name.Contains(this.textBox1.Text)
                        select new
                        {
                            醫療人員ID = f.Staff_ID,
                            醫療人員姓名 = f.Staff_Name,
                            科別 = d.Div_Name,
                            職稱 = j.Job_Title,
                            帳號 = f.Staff_Acc,
                            //密碼 = f.Staff_Pwd,
                            //salt = f.Staff_Salt,
                            電話 = f.Staff_TN,
                            電子信箱 = f.Staff_Email
                        };

                this.dataGridView1.DataSource = q.ToList();
            }
        }

        //Insert user
        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmNewStaff f = new FrmNewStaff())
            {
                f.ShowDialog();
            }

            dataGridView1.DataSource = (from f in db.Staffs
                                        join j in db.JobTitles on f.Job_ID equals j.Job_ID
                                        join d in db.Divisions on f.Div_ID equals d.Div_ID
                                        select new
                                        {
                                            醫療人員ID = f.Staff_ID,
                                            醫療人員姓名 = f.Staff_Name,
                                            科別 = d.Div_Name,
                                            職稱 = j.Job_Title,
                                            帳號 = f.Staff_Acc,
                                            電話 = f.Staff_TN,
                                            電子信箱 = f.Staff_Email
                                        }).ToList();
        }

        //Edit
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.DataSource == null)
            {
                MessageBox.Show("請先選擇編輯項目");
            }
            else
            {

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                using (FrmPersonProfile f = new FrmPersonProfile(clsUser.GetUserData(id)))
                {
                    //f.user = clsUser.GetUserData(id);
                    //f.label1.Text = "編輯 使用者帳號";
                    f.ShowDialog();
                }

                dataGridView1.DataSource = (from f in db.Staffs
                                            join j in db.JobTitles on f.Job_ID equals j.Job_ID
                                            join d in db.Divisions on f.Div_ID equals d.Div_ID
                                            select new
                                            {
                                                醫療人員ID = f.Staff_ID,
                                                醫療人員姓名 = f.Staff_Name,
                                                科別 = d.Div_Name,
                                                職稱 = j.Job_Title,
                                                帳號 = f.Staff_Acc,
                                                電話 = f.Staff_TN,
                                                電子信箱 = f.Staff_Email
                                            }).ToList();

            }
        }
        //Delete user
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認永久刪除使用者帳號資料？", 
                "確認送出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                var q = from p in db.Staffs
                        where p.Staff_ID == id
                        select p;

                //ClsRecord.Record(sender, this.Name, id);
                db.Staffs.DeleteOnSubmit(q.FirstOrDefault());
                db.SubmitChanges();
                dataGridView1.DataSource = db.Staffs.ToArray();
            }
        }

        private void FrmStaffs_Load(object sender, EventArgs e)
        {
            this.textBox1.Width = 150;

            this.dataGridView1.ScrollBars = ScrollBars.Both;
            this.dataGridView1.Dock = DockStyle.None;
            this.dataGridView1.Width = this.Width;
            this.dataGridView1.Height = this.Height - 60;
            this.dataGridView1.Location = new Point(0, 60);
            this.dataGridView1.RowHeadersVisible = false;

            this.button1.Location = new Point(this.textBox1.Width + 10, -3);
            this.button2.Location = new Point(this.Width - (140 * 2), -3);
            this.button3.Location = new Point(this.Width - 140, -3);
            this.button4.Location = new Point(this.Width - (140 * 3), -3);
        }
    }
}
