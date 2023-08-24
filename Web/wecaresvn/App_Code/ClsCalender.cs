using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCareWeb.App_Code
{
    public class ClsExamCalender:IMedicare
    {
        MediCareDataClassesDataContext DB = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        private DateTime _today;

        public int ExamCal_ID { get; set; }
        public int ExamSch_ID { get; set; }
        public int RmdDay_ID { get; set; }
        public int RmdDay_Days { get; set; }
        public int Status_ID { get; set; }
        public string Status_Name { get; set; }
        public DateTime ExamCal_date { get; set; }
        public string ExamCal_Rem { get; set; }
        public bool ExamCal_Rmd { get; set; }
        public int Doctor_ID { get; set; }
        public string Doctor_Name { get; set; }
        public int Ptt_Num { get; set; }
        public string Ptt_Name { get; set; }
        public int Exam_ID { get; set; }
        public string Exam_NameCH { get; set; }
        public string ExamCon_CoC { get; set; }
        public string ExamSch_Rlt { get; set; }

        public ClsExamCalender() { }

        public ClsExamCalender(int id)
        {
            var q = DB.View_ExamCalendars.Where(n => n.行事曆ID == id).First();

            this.ExamCal_ID = q.行事曆ID;
            this.Exam_NameCH = q.檢驗項目;
            this.ExamCal_date = q.檢驗日期;
            this.Exam_ID = DB.ExamOverview.Where(n => n.Exam_NameCH == this.Exam_NameCH).First().Exam_ID;
            this.ExamCal_Rem = q.備註;
            this.ExamCal_Rmd = q.已提醒;
            this.ExamCon_CoC = q.檢驗結果;
            this.ExamSch_ID = DB.ExamCalendar.Where(n => n.ExamCal_ID == q.行事曆ID).Single().ExamSch_ID;
            this.Ptt_Name = q.病患名稱;
            this.Ptt_Num = q.病歷號碼;
            this.RmdDay_Days = q.提早天數;
            this.RmdDay_ID = DB.RemindDays.Where(n => n.RmdDays_Days == this.RmdDay_Days).Single().RmdDays_ID;
            this.Doctor_ID = DB.Staffs.Where(n => n.Staff_Name == q.主治醫師).Single().Staff_ID;
            this.Doctor_Name = q.主治醫師;
            this.Status_Name = q.狀態;
            this.Status_ID = DB.Situations.Where(n => n.Status_Name == this.Status_Name).Single().Status_ID;
            this.ExamSch_Rlt = q.結果值;
        }
        
        public BindingSource GetData(DateTime d)
        {
            BindingSource bs = new BindingSource();
            //搜尋 1.當日  2.檢驗快到該提醒但未提醒  3.昨天應到卻未到   的病患
            bs.DataSource = DB.View_ExamCalendars.Where
                (n => n.檢驗日期 == d.Date ||   //當日
                (n.檢驗日期.Date <= d.Date.AddDays(n.提早天數) && n.檢驗日期 >= d && n.已提醒 == false) || //未提醒
                (n.檢驗日期 == d.AddDays(-1) && n.狀態 == "未完成")).OrderBy(n => n.檢驗日期).ToList();  //昨日應到
            return bs;
        }

        public BindingSource GetData(DateTime d, string pttName, int type)
        {
            BindingSource bs = new BindingSource();
            if (type == 0)
            {
                bs.DataSource = DB.View_ExamCalendars.Where
                    (n => (n.檢驗日期 == d.Date && n.病患名稱 == pttName)).ToList();
                return bs;
            }
            else
            {
                string name = DB.Staffs.Where(n => n.Staff_Acc == pttName).Single().Staff_Name;
                int id = DB.Staffs.Where(n => n.Staff_Acc == pttName).Single().Staff_ID;
                bs.DataSource = DB.View_ExamCalendars.Where
                    (n => n.檢驗日期 == d.Date && 
                        (n.主治醫師 == name || n.諮詢師ID == id || n.護士ID == id)).ToList();
                return bs;
            }
        }


        public BindingSource GetData()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DB.View_ExamCalendars.Where
                (n => n.檢驗日期 == DateTime.Today ||
                (n.檢驗日期.Date <= DateTime.Today.Date.AddDays(n.提早天數) && n.檢驗日期.Date >= DateTime.Today && n.已提醒 == false) ||
                (n.檢驗日期 == DateTime.Today.AddDays(-1) && n.狀態 == "未完成")).ToList();
            return bs;
        }

        public Dictionary<string, string> GetObject()
        {
            Dictionary<string, string> eCalList = new Dictionary<string, string>();
            eCalList.Add("Ptt_Num", this.Ptt_Num.ToString());
            eCalList.Add("Ptt_Name", this.Ptt_Name);
            eCalList.Add("Exam_NameCH", this.Exam_NameCH);
            eCalList.Add("ExamCal_Date", this.ExamCal_date.ToShortDateString());
            eCalList.Add("Doctor_Name", this.Doctor_Name);
            eCalList.Add("ExamCal_Rem", this.ExamCal_Rem);
            eCalList.Add("RmdDay_Days", this.RmdDay_Days.ToString());
            return eCalList;
        }

        public BindingSource Search(string SearchBy, string InputString)
        {
            BindingSource bs = new BindingSource();
            if (SearchBy == "病患姓名")
            {
                var q = from p in DB.View_ExamCalendars
                        where p.病患名稱.Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
            else
            {
                var q = from p in DB.View_ExamCalendars
                        where p.病歷號碼.ToString().Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
        }
    }

    public class ClsDrugCalendar
    {
        MediCareDataClassesDataContext DB = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString);
        private DateTime _today;

        public int DrugCal_ID { get; set; }
        public int DrugSch_ID { get; set; }
        public int RmdDay_ID { get; set; }
        public int RmdDay_Days { get; set; }
        public string Status_Name { get; set; }
        public int Status_ID { get; set; }
        public DateTime DrugCal_SD { get; set; }
        public string DrugCal_Rem { get; set; }
        public bool DrugCal_Rmd { get; set; }
        public int Doctor_ID { get; set; }
        public string Doctor_Name { get; set; }
        public string Ptt_Name { get; set; }
        public int Ptt_Num { get; set; }
        public int Drug_ID { get; set; }
        public string Drug_NameEN { get; set; }
        public string Drug_NameCH { get; set; }

        public ClsDrugCalendar()
        { 

        }

        public ClsDrugCalendar(int id)
        {
            var q = DB.View_DrugCalendars.Where(n => n.ID == id).First();

            DrugCal_ID = q.ID;
            DrugSch_ID = DB.DrugCalendar.Where(n => n.DrugCal_ID == this.DrugCal_ID).Single().DrugSch_ID;
            RmdDay_Days = q.幾天前提醒;
            RmdDay_ID = DB.RemindDays.Where(n => n.RmdDays_Days == this.RmdDay_Days).Single().RmdDays_ID;
            Status_Name = q.狀態;
            Status_ID = DB.Situations.Where(n => n.Status_Name == Status_Name).Single().Status_ID;
            DrugCal_SD = q.用藥日期;
            DrugCal_Rem = q.備註;
            DrugCal_Rmd = q.已提醒;
            Doctor_ID = DB.View_DrugCalendars.Where(n => n.ID == id).First().Staff_ID;
            Doctor_Name = DB.Staffs.Where(n => n.Staff_ID == this.Doctor_ID).Single().Staff_Name;
            Ptt_Name = q.病患姓名;
            Ptt_Num = q.病歷號碼;
            Drug_ID = q.Drug_ID;
            Drug_NameCH = q.特殊藥物;
            Drug_NameEN = DB.DrugOverview.Where(n => n.Drug_ID == Drug_ID).First().Drug_NameEN.ToString();
        }

        public BindingSource GetData(DateTime d)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DB.View_DrugCalendars.Where
                (n => n.用藥日期 == d ||
                (n.用藥日期.Date <= d.Date.AddDays(n.幾天前提醒) && n.用藥日期 >= d && n.已提醒 == false) ||
                (n.用藥日期 == d.AddDays(-1) && n.狀態 != "完成")).OrderBy(n => n.用藥日期).ToList();
            return bs;
        }

        public BindingSource GetData(DateTime d, string Pttname, int type)
        {
            BindingSource bs = new BindingSource();
            if (type == 0)
            {
                bs.DataSource = DB.View_DrugCalendars.Where
                (n => (n.用藥日期 == d && n.病患姓名 == Pttname)).ToList();
            }
            else
            {
                string name = DB.Staffs.Where(n => n.Staff_Acc == Pttname).Single().Staff_Name;
                int id=DB.Staffs.Where(n=>n.Staff_Acc==Pttname).Single().Staff_ID;
                bs.DataSource = DB.View_DrugCalendars.Where
                (n => n.用藥日期 == d && (n.主治醫師 == name || n.護士ID == id || n.諮詢師ID == id)).ToList();
            }
            
            return bs;
        }





        public BindingSource Search(string SearchBy, string InputString)
        {
            BindingSource bs = new BindingSource();
            if (SearchBy == "病患姓名")
            {
                var q = from p in DB.View_DrugCalendars
                        where p.病患姓名.Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
            else
            {
                var q = from p in DB.View_DrugCalendars
                        where p.病歷號碼.ToString().Contains(InputString)
                        select p;
                bs.DataSource = q.ToList();
                return bs;
            }
        }

        public void Updata()
        {
            var q = DB.DrugCalendar.Where(n => n.DrugCal_ID == this.DrugCal_ID).First();

            q.DrugCal_Rem = DrugCal_Rem;
            q.DrugCal_Rmd = DrugCal_Rmd;

            DB.SubmitChanges();
        }

        public BindingSource GetData()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = (from p in DB.View_DrugCalendars
                             select p).ToList();
            return bs;
        }

        public Dictionary<string, string> GetObject()
        {
            Dictionary<string, string> dCalList = new Dictionary<string, string>();
            dCalList.Add("Ptt_Num", this.Ptt_Num.ToString());
            dCalList.Add("Ptt_Name", this.Ptt_Name);
            dCalList.Add("Drug_NameCH", this.Drug_NameCH);
            dCalList.Add("DrugCal_Date", this.DrugCal_SD.ToShortDateString());
            dCalList.Add("Doctor_Name", this.Doctor_Name);
            dCalList.Add("DrugCal_Rem", this.DrugCal_Rem);
            dCalList.Add("RmdDay_Days", this.RmdDay_Days.ToString());

            return dCalList;
        }
    }
}
