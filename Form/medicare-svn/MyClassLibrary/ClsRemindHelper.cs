using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KOTSMSAPI;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class ClsRemindHelper
    {
        public int CalendarID { get; set; }
        public string PatientName { get; set; }
        public string EventName { get; set; }      
        public DateTime EventTime { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool WantBeRemind { get; set; }        
        public string Division { get; set; }
        public bool IsRemind { get; set; }
        //查詢今日應提醒之病患
        public virtual IEnumerable<ClsRemindHelper> SearchUnRemind(DateTime date)
        {
            MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext();
            var q = from p in db.View_ExamReminders
                    where (p.ExamTakenDate.Date <= date.Date.AddDays(p.BeforeDays) && p.ExamTakenDate >= date &&p.isRemind==false  )
                    select new ClsRemindHelper
                    {
                        PatientName = p.PatientName,
                        EventTime = p.ExamTakenDate,
                        EventName = p.ExamName,
                        Division = p.DivisionName,
                        PhoneNumber = p.PhoneNum,
                        Email = p.Email,
                        WantBeRemind = p.WantRemind,
                        CalendarID = p.ExamCalendarID,
                        IsRemind=p.isRemind.Value
                    };
            return q.AsEnumerable();
        }

        

        
        //簡訊寄送方法
        public virtual string SendMessage(ClsRemindHelper RemindObject)
        {
            string GetResult = "";
            KOT_SMSAPI mySMS = new KOT_SMSAPI();
            mySMS.username = "noidea0216";  //簡訊王帳密
            mySMS.password = "roge5187";
            mySMS.dstaddr = RemindObject.PhoneNumber; //病患電話號碼
            mySMS.smbody = "親愛的 " + RemindObject.PatientName + //簡訊內容
                        " 您好，提醒您於" + RemindObject.EventTime.ToShortDateString() +
                        " 至WeCare " + RemindObject.Division + "進行 " + RemindObject.EventName + "檢查";
            mySMS.SMSEncode = EncodingbyApp.Big5; //BIG5編碼
            GetResult = mySMS.SendSMSNow(); //取回結果
            
            //因寄送的簡訊很少，為了DEMO讓方法做久一點
            Thread.Sleep(500);
            
            //以下若為TRUE則資料有誤
            if (GetResult.StartsWith(">") == true)
            {
                return GetResult;
            }
            else
            {
                //使用API的方法解析GetResult結果           
                return mySMS.getSMSResult(GetResult);
            }
        }
        //Email寄送
        async public Task<string> SendEmailAsync(ClsRemindHelper RemindObject)
        {
            string patientName = RemindObject.PatientName.Replace(" ", ""); //去除空白
            string emailFrom = "cecmwecare@gmail.com";//"email@yahoo.com";
            string password = "hxgjijoubuaozjny";
            string emailTo = RemindObject.Email;//"someone@domain.com";
            string subject = "Wecare診所檢驗提醒";//"Hello";
            string body = "親愛的 " + patientName + //簡訊內容
                        " 您好，提醒您於" + RemindObject.EventTime.ToShortDateString() +
                        " 至WeCare " + RemindObject.Division + "進行 " + RemindObject.EventName + "檢查";
                        //"Hello, I'm just writing this to say Hi!";

            using (MailMessage mail = new MailMessage())
            {
                try
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;
                    // Can set to false, if you are sending pure text.
                    //mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                    //mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                    }
                }
                catch { return "病患：" + patientName + " 的EMail格式不正確"; }
                //catch(Exception e) { MessageBox.Show(e.ToString()); }

                return "病患：" + patientName + " 的檢驗提醒EMail已發送!";
            }           
        }   
         
        //public IEnumerable SearchTodayRemind()
        //{
        //    MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext();
        //    var q = db.View_ExamReminders.Where(p => p.ExamTakenDate.Date <= DateTime.Now.AddDays(p.BeforeDays)
        //        && p.ExamTakenDate >= DateTime.Now ).Select(n => new { 已提醒 = n.isRemind.Value, 病患姓名 = n.PatientName, 檢驗項目 = n.ExamName, 檢驗日期 = n.ExamTakenDate });
        //    return q.ToList();
        //}

        public IEnumerable SearchTodayRemind()
        {
            MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext();
            var q = db.View_ExamReminders.Where(p => p.ExamTakenDate.Date <= DateTime.Now.AddDays(p.BeforeDays)
                && p.ExamTakenDate >= DateTime.Now).Select(n => new { 已提醒 = ImageForYesNo(n.isRemind.Value) , 病患姓名 = n.PatientName, 檢驗項目 = n.ExamName, 檢驗日期 = n.ExamTakenDate });
            return q.ToList();
        }

        private Image ImageForYesNo(bool already)
        {
            Image image = Properties.Resources._1402475817_Delete;
            if (already)
            {
                image = Properties.Resources.YesIcon;
            }            
            return image;
        }
    }

    public class ExamRemindHelper : ClsRemindHelper
    {
    }

    //寄藥物提醒簡訊用.....(暫時不用，因為寄簡訊提醒吃藥不切實際，因此做在手機)
    public class DrugRemindHelper : ClsRemindHelper
    {        
    }

    //public class ExamRemind
    //{
    //    public bool 已提醒 { get; set; }
    //    public string 病患姓名 { get; set; }
    //    public string 檢驗項目 { get; set; }
    //    public DateTime 檢驗日期 { get; set; }
    //    //show in datagridview
    //    public static List<ExamRemind> SearchTodayRemind()
    //    {
    //        MyDB.MedicareDataClassesDataContext db = new MyDB.MedicareDataClassesDataContext();
    //        var q = db.View_ExamReminders.Where(p => p.ExamTakenDate.Date <= DateTime.Now.AddDays(p.BeforeDays) && p.ExamTakenDate >= DateTime.Now ).Select(n => new ExamRemind { 已提醒 = n.isRemind.Value, 病患姓名 = n.PatientName, 檢驗項目 = n.ExamName, 檢驗日期 = n.ExamTakenDate });
    //        return q.ToList();
    //    }
    //}
}
