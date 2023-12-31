﻿using Calendar.NET;
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
    public partial class FrmCalendarFinal : Form
    {

        [CustomRecurringFunction("RehabDates", "Calculates which days I should be getting Rehab")]

        MyDB.MedicareDataClassesDataContext DB = new MyDB.MedicareDataClassesDataContext();
        private bool RehabDays(IEvent evnt, DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Monday || day.DayOfWeek == DayOfWeek.Friday)
            {
                if (day.Ticks >= (new DateTime(2012, 7, 1)).Ticks)
                    return false;
                return true;
            }

            return false;
        }

           public FrmCalendarFinal()
           {
            InitializeComponent();

            //calendar1.CalendarDate = new DateTime(2012, 5, 2, 0, 0, 0);
            calendar1.CalendarDate = DateTime.Today;
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;

            var groundhogEvent = new HolidayEvent
                                     {
                                         Date = new DateTime(2012, 2, 2),
                                         EventText = "Groundhog Day",
                                         RecurringFrequency = RecurringFrequencies.Yearly
                                     };

            calendar1.AddEvent(groundhogEvent);

            //var exerciseEvent = new CustomEvent
            //                        {
            //                            Date = DateTime.Now,
            //                            RecurringFrequency = RecurringFrequencies.EveryMonWedFri,
            //                            EventLengthInHours = 1,
            //                            EventText = "Time for Exercise!"
            //                        };


            //calendar1.AddEvent(exerciseEvent);


            var rehabEvent = new CustomEvent
                {
                    Date = DateTime.Now,
                    RecurringFrequency = RecurringFrequencies.Custom,
                    EventText = "Rehab Therapy",
                    Rank = 3,
                    CustomRecurringFunction = RehabDays
                };

          //  calendar1.AddEvent(rehabEvent);

            //var ce = new CustomEvent();

            //ce.EventText = "My Event";
            //ce.Date = new DateTime(2012, 4, 1);
            //ce.RecurringFrequency = RecurringFrequencies.Monthly;
            //ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            //ce.ThisDayForwardOnly = true;
            //ce.Enabled = true;
            //calendar1.AddEvent(ce);
            
            //var ce2 = new HolidayEvent();

            //ce2.EventText = "test";
            //ce2.Date = new DateTime(2012, 4, 2);
            //ce2.RecurringFrequency = RecurringFrequencies.EveryMonWedFri;
            //ce2.Rank = 3;
            //calendar1.AddEvent(ce2);

            var q = DB.View_ExamCalendars.Select(n => n);
            foreach (var item in q)
            {
                var q2 = new CustomEvent();
                q2.EventText = item.病患名稱 + item.檢驗項目;
                q2.Date = item.檢驗日期;
                q2.EventLengthInHours = 6.0f;
                q2.RecurringFrequency = RecurringFrequencies.None;
                q2.EventFont = new Font("Verdana", 11, FontStyle.Regular);
                q2.Enabled = true;
                q2.EventColor = Color.FromArgb(120, 255, 120);
                q2.EventTextColor = Color.Black;
                q2.ID = item.行事曆ID;
                q2.Rank = 1;
                calendar1.AddEvent(q2);
            }

            var q3 = DB.View_DrugCalendars.Select(n => n);
            foreach (var item in q3)
            {
                var q2 = new CustomEvent();
                q2.EventText = item.病患姓名 +item.特殊藥物;
                q2.Date = item.用藥日期;
                q2.EventLengthInHours = 7.0f;
                q2.RecurringFrequency = RecurringFrequencies.None;
                q2.EventFont = new Font("Verdana", 11, FontStyle.Regular);
                q2.Enabled = true;
                q2.Rank = 2;
                q2.ID = item.ID;
                calendar1.AddEvent(q2);
            }


            var ce = new CustomEvent();
            ce.IgnoreTimeComponent = false;
            ce.EventText = "Interview";
            ce.Date = new DateTime(2012, 5, 2, 15, 30, 0);
            ce.EventLengthInHours = 2f;
            ce.RecurringFrequency = RecurringFrequencies.None;
            ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            ce.Enabled = true;
            calendar1.AddEvent(ce);

            var ce2 = new CustomEvent
                {
                    IgnoreTimeComponent = false,
                    EventText = "Dinner",
                    Date = new DateTime(2012, 5, 15, 18, 0, 0),
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("Verdana", 12, FontStyle.Regular),
                    Enabled = true,
                    EventColor = Color.FromArgb(120, 255, 120),
                    EventTextColor = Color.Black,
                    ThisDayForwardOnly=true
                };
            calendar1.AddEvent(ce2);
        }

        [CustomRecurringFunction("Get Monday and Wednesday", "Selects the Monday and Wednesday of each month")]
        public bool GetMondayAndWednesday(IEvent evnt, DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Monday || dt.DayOfWeek == DayOfWeek.Wednesday)
                return true;
            return false;
        }


        private void coolButton1_Click(object sender, EventArgs e)
        {
            int ID = 1;// calendar1.Container.Components.
            DB.ExamCalendar.Where(n => n.ExamCal_ID == ID).First().ExamCal_Rmd = true;
            DB.SubmitChanges();

            MessageBox.Show("簡訊提醒已發送!!");
           // ClsRecord.Record(sender, "FrmExamCalendar");
        }

        private void FrmCalendarFinal_Load(object sender, EventArgs e)
        {
            
        }

        private void coolButton1_Load(object sender, EventArgs e)
        {

        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

    }
}
