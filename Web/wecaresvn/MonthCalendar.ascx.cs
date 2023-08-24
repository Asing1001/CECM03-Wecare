using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCareWeb.App_Code;

public partial class WeekCalendar : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.monthLabel.Text = ((DateTime)Cache["tDay"]).Month.ToString() + "月";

        if (!IsPostBack)
        {
            string pa = "";
            ClsExamCalender eCal = new ClsExamCalender();
            ClsDrugCalendar dCal = new ClsDrugCalendar();
            DateTime _today = (DateTime)Cache["tDay"];
            DateTime _firstDayOfMonth = _today.AddDays(1 - _today.Day);
            DateTime _firstDayOfWeek = _firstDayOfMonth.AddDays(-(_firstDayOfMonth.DayOfWeek - DayOfWeek.Sunday));

            if (Request.Cookies["Job"] != null)
            {
                pa = Request.Cookies["login"].Value;
            }
            else if (Request.Cookies["PttID"] != null)
            {
                pa = Request.Cookies["PttID"].Value;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }

            using (MediCareDataClassesDataContext db = new MediCareDataClassesDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["MedicareConnectionString"].ConnectionString))
            {
                for (int i = 0; i < 35; i++)
                {
                    string s = "";

                    if (Request.Cookies["Job"] != null)
                    {
                        string name = db.Staffs.Where(n => n.Staff_Acc == pa).Single().Staff_Name;
                        int id = db.Staffs.Where(n => n.Staff_Acc == pa).Single().Staff_ID;

                        var q = db.View_ExamCalendars.Where
                        (n => n.檢驗日期 == _firstDayOfWeek.AddDays(i).Date &&
                        (n.主治醫師 == name || n.護士ID == id || n.諮詢師ID == id));

                        int j = 0;
                        foreach (var item in q)
                        {
                            s += "<div class='divMItem' style='background-color:#ffcc33;'>&nbsp;&nbsp;"
                                 + item.病患名稱 + "&nbsp;&nbsp;" + item.檢驗項目 + "</div>";
                            if (++j >= 2)
                            {
                                break;
                            }
                        }

                        var p = db.View_DrugCalendars.Where
                            (n => n.用藥日期 == _firstDayOfWeek.AddDays(i) &&
                            (n.主治醫師 == name || n.護士ID == id || n.諮詢師ID == id));

                        j = 0;
                        foreach (var item in p)
                        {
                            s += "<div class='divMItem' style='background-color:#CC6633; color:white;'>&nbsp;&nbsp;"
                                 + item.病患姓名 + "&nbsp;&nbsp;" + item.特殊藥物 + "</div>";
                            if (++j >= 2)
                            {
                                s += "<a style='margin-left:5px;'>顯示更多資料<a>";
                                break;
                            }
                        }
                    }
                    else
                    {
                        string loginPtt = db.Patients.Where(n => n.Ptt_ID == Convert.ToInt32(pa)).Single().Ptt_Name;

                        var q = db.View_ExamCalendars.Where
                            (n => n.檢驗日期 == _firstDayOfWeek.AddDays(i).Date && n.病患名稱 == loginPtt);

                        int j = 0;
                        foreach (var item in q)
                        {
                            s += "<div class='divMItem' style='background-color:#ffcc33;'>&nbsp;&nbsp;"
                                 + item.病患名稱 + "&nbsp;&nbsp;" + item.檢驗項目 + "</div>";
                            if (++j >= 2)
                            {
                                break;
                            }
                        }

                        var p = db.View_DrugCalendars.Where
                            (n => n.用藥日期 == _firstDayOfWeek.AddDays(i) && n.病患姓名 == loginPtt);

                        j = 0;
                        foreach (var item in p)
                        {
                            s += "<div class='divMItem' style='background-color:#CC6633; color:white;'>&nbsp;&nbsp;"
                                 + item.病患姓名 + "&nbsp;&nbsp;" + item.特殊藥物 + "</div>";
                            if (++j >= 2)
                            {
                                s += "<a style='margin-left:5px;'>顯示更多資料<a>";
                                break;
                            }
                        }
                    }
                    
                    switch (i)
                    {
                        case 0:
                            this.Literal00.Text = s;
                            this.Label00.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label00);
                            break;
                        case 1:
                            this.Literal01.Text = s;
                            this.Label01.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label01);
                            break;
                        case 2:
                            this.Literal02.Text = s;
                            this.Label02.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label02);
                            break;
                        case 3:
                            this.Literal03.Text = s;
                            this.Label03.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label03);
                            break;
                        case 4:
                            this.Literal04.Text = s;
                            this.Label04.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label04);
                            break;
                        case 5:
                            this.Literal05.Text = s;
                            this.Label05.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label05);
                            break;
                        case 6:
                            this.Literal06.Text = s;
                            this.Label06.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 7:
                            this.Literal10.Text = s;
                            this.Label10.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 8:
                            this.Literal11.Text = s;
                            this.Label11.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 9:
                            this.Literal12.Text = s;
                            this.Label12.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 10:
                            this.Literal13.Text = s;
                            this.Label13.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 11:
                            this.Literal14.Text = s;
                            this.Label14.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 12:
                            this.Literal15.Text = s;
                            this.Label15.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 13:
                            this.Literal16.Text = s;
                            this.Label16.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 14:
                            this.Literal20.Text = s;
                            this.Label20.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 15:
                            this.Literal21.Text = s;
                            this.Label21.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 16:
                            this.Literal22.Text = s;
                            this.Label22.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 17:
                            this.Literal23.Text = s;
                            this.Label23.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 18:
                            this.Literal24.Text = s;
                            this.Label24.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 19:
                            this.Literal25.Text = s;
                            this.Label25.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 20:
                            this.Literal26.Text = s;
                            this.Label26.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 21:
                            this.Literal30.Text = s;
                            this.Label30.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 22:
                            this.Literal31.Text = s;
                            this.Label31.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 23:
                            this.Literal32.Text = s;
                            this.Label32.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 24:
                            this.Literal33.Text = s;
                            this.Label33.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 25:
                            this.Literal34.Text = s;
                            this.Label34.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 26:
                            this.Literal35.Text = s;
                            this.Label35.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 27:
                            this.Literal36.Text = s;
                            this.Label36.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 28:
                            this.Literal40.Text = s;
                            this.Label40.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            break;
                        case 29:
                            this.Literal41.Text = s;
                            this.Label41.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label41);
                            break;
                        case 30:
                            this.Literal42.Text = s;
                            this.Label42.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label42);
                            break;
                        case 31:
                            this.Literal43.Text = s;
                            this.Label43.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label43);
                            break;
                        case 32:
                            this.Literal44.Text = s;
                            this.Label44.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label44);
                            break;
                        case 33:
                            this.Literal45.Text = s;
                            this.Label45.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label45);
                            break;
                        case 34:
                            this.Literal46.Text = s;
                            this.Label46.Text = _firstDayOfWeek.AddDays(i).Day.ToString();
                            checkMonth(_firstDayOfWeek.AddDays(i), _today, this.Label46);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    private void checkMonth(DateTime _firstDayOfWeek, DateTime _today, Label lbl)
    {
        if (_firstDayOfWeek.Month != _today.Month)
        {
            lbl.ForeColor = System.Drawing.Color.Silver;
        }
    }
}