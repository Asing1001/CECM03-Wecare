﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WeCarePhone.Resources;
using System.IO.IsolatedStorage;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Scheduler;

namespace WeCarePhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //非svn版
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        string AlarmKey = "Myalarm";
        int pID = 1;
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings AppSettings = IsolatedStorageSettings.ApplicationSettings;
            if (AppSettings.Contains("pID"))
            {
                pID = Convert.ToInt32(AppSettings["pID"]);
            }

            WeCarePhoneService.Service1Client pxy = new WeCarePhoneService.Service1Client();
            pxy.GetRemindsAsync(DateTime.Now, pID);
            pxy.GetRemindsCompleted += pxy_GetRemindsCompleted;

        }

        WeCarePhone.WeCarePhoneService.DrugRemind x = null;
        void pxy_GetRemindsCompleted(object sender, WeCarePhoneService.GetRemindsCompletedEventArgs e)
        {

            try
            {
                MyListBox.ItemsSource = e.Result;
                if (e.Result[0] != null)
                {
                    x = e.Result[0];
                    if (x.EventTime <= DateTime.Now)
                    {
                        x = e.Result[1];
                        ScheduledActionService.Remove(AlarmKey);    //把舊時間刪除              
                    }
                    if (havealarm == false)
                    {
                        ScheduledActionService.Add(openalert(AlarmKey));
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("沒有用藥提醒！");
                MyListBox.ItemsSource = null;//ex.ToString());
                // throw;
            }
        }

        bool flag = true;
        private void btnset_Click(object sender, RoutedEventArgs e)
        {
            flag = !flag;
            if (x != null)
            {
                if (flag == false)
                {
                    //換圖
                    ImageBrush altoff = new ImageBrush();
                    altoff.ImageSource = new BitmapImage(new Uri("/Assets/Tiles/at2.png", UriKind.Relative));
                    btnset.Background = altoff;
                    if (havealarm == true)
                    {
                        ScheduledActionService.Remove(AlarmKey);
                    }
                }
                else
                {
                    //ImageBrush alertbakground = (ImageBrush)Application.Current.Resources["at1"];
                    ImageBrush alton = new ImageBrush();
                    alton.ImageSource = new BitmapImage(new Uri("/Assets/Tiles/at1.png", UriKind.Relative));
                    btnset.Background = alton;
                    ScheduledActionService.Add(openalert(AlarmKey));  //呼叫鬧鐘
                }
            }
        }
        bool havealarm = false;
        private Alarm openalert(string alermkey)
        {
            havealarm = true;
            Alarm Newalarm = new Alarm(alermkey);
            Newalarm.Content = "服用" + x.EventName;
            Newalarm.BeginTime = x.EventTime;  //DateTime.Now.AddSeconds(5);
            Newalarm.Sound = new Uri("/Assets/Source1.WAV", UriKind.Relative);
            return Newalarm;
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}