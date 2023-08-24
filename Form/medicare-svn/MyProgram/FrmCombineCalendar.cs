using Calendar.NET;
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
    public partial class FrmCombineCalendar : Form
    {
        private static string userName = null;

        public FrmCombineCalendar(string name) //醫師or護理人員
        {
            InitializeComponent();

            userName = name;
            this.label1.Text = name + "姓名:";
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
        FrmExamCalendar f = new FrmExamCalendar();

        private void FrmCombineCalendar_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += (object a, EventArgs b) =>  showCalendar(); //Lamda註冊方法  

            f.Dock = DockStyle.Fill;
            f.Show();
            f.TopLevel = false;

            this.splitContainer1.Panel2.Controls.Add(f); //add FrmExamCalendar        

            if (userName == "醫師")
            {
                var q = from p in DB.Staffs
                        where p.Job_ID == 1
                        select p.Staff_Name;

                foreach (var item in q)
                {
                    comboBox1.Items.Add(item);
                }
            }
            else
            {
                var q = from p in DB.Staffs
                        where p.Job_ID ==2 || p.Job_ID==3
                        select new NameID{ DisplayName= p.Staff_Name, ValueMember=p.Staff_ID };

                //foreach (var item in q)
                //{
                //    comboBox1.Items.Add(item);
                //}
                comboBox1.DataSource = q.ToList();
                comboBox1.DisplayMember = "DisplayName";
                comboBox1.ValueMember = "ValueMember";
               
            }

            comboBox1.SelectedIndex = 0;
            showCalendar();
          //  Application.DoEvents();
            // f.BringToFront();
        }

        private void coolButton3_MouseClick(object sender, MouseEventArgs e)
        {
            showCalendar();
        }

        bool isday = true; //判斷目前的檢視方式

        private void coolButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isday)
            {
                foreach (Control item in this.splitContainer1.Panel2.Controls)
                {
                    if (item is Calendar.NET.Calendar)
                    {
                        item.BringToFront();
                    }
                }
            }
            else
            {
                f.BringToFront();
            }

            isday = !isday;

        }

        private void showCalendar()  //rebuild and show a new calendar
        {

            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if (item is Calendar.NET.Calendar)
                {
                    item.Dispose();
                }
            }

            global::Calendar.NET.Calendar calendar2 = new Calendar.NET.Calendar();          
            calendar2.CalendarDate = DateTime.Today;
            calendar2.CalendarView = CalendarViews.Month;

            
            //依照醫師名秀出該醫師的工作
           
            var q1 = DB.View_ExamCalendars.Where(n => n.主治醫師 == comboBox1.Text);
            var q3 = DB.View_DrugCalendars.Where(n => n.主治醫師 == comboBox1.Text);
 
            
            
            if (userName == "護理人員")  //若是護士表單..
            {
                int SelectedID = ((NameID)comboBox1.SelectedItem).ValueMember;
                q1 = DB.View_ExamCalendars.Where(n => n.諮詢師ID == SelectedID || n.護士ID == SelectedID);
                q3 = DB.View_DrugCalendars.Where(n => n.諮詢師ID == SelectedID || n.護士ID == SelectedID);
            }
            

            if (comboBox1.Text == "請選擇...")   //沒選時...秀所有資料
            {
                q1 = DB.View_ExamCalendars;
                q3 = DB.View_DrugCalendars;
            }

            
            foreach (var item in q1)
            {
                var q2 = new CustomEvent();
                q2.EventText = item.病患名稱; //+item.檢驗項目 + "檢驗";
                q2.Date = item.檢驗日期;
                q2.EventLengthInHours = 6.0f;
                q2.RecurringFrequency = RecurringFrequencies.None;
                q2.EventFont = new Font("Verdana", 11, FontStyle.Regular);
                q2.Enabled = true;
                q2.EventColor = Color.FromArgb(120, 255, 120);
                q2.EventTextColor = Color.Black;
                q2.ID = item.行事曆ID;
                q2.Rank = 1;
                q2.eventDetail = item.病患名稱+item.檢驗項目 + "檢驗";
                calendar2.AddEvent(q2);
            }

           
            foreach (var item in q3)
            {
                var q2 = new CustomEvent();
                q2.EventText = item.病患姓名;// +item.特殊藥物;
                q2.Date = item.用藥日期;
                q2.EventLengthInHours = 7.0f;
                q2.RecurringFrequency = RecurringFrequencies.None;
                q2.EventFont = new Font("Verdana", 11, FontStyle.Regular);
                q2.Enabled = true;
                q2.Rank = 2;
                q2.ID = item.ID;
                q2.eventDetail = item.病患姓名 +item.特殊藥物;
                calendar2.AddEvent(q2);
            }

            this.splitContainer1.Panel2.Controls.Add(calendar2);
            calendar2.Dock = DockStyle.Fill;
            calendar2.BringToFront();
        }

    }
}

class NameID
{
    public int ValueMember { get; set; }

    public string DisplayName { get; set; }
}
