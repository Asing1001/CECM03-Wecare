using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using App3__Win_8._1_.Common;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Item Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234232

namespace App3__Win_8._1_
{
    /// <summary>
    /// A page that displays details for a single item within a group while allowing gestures to
    /// flip through other items belonging to the same group.
    /// </summary>
    public sealed partial class BMI : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public BMI()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            
        }

    

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            object navigationParameter;
            if (e.PageState != null && e.PageState.ContainsKey("SelectedItem"))
            {
                navigationParameter = e.PageState["SelectedItem"];
            }

            // TODO: Assign a bindable group to this.DefaultViewModel["Group"]
            // TODO: Assign a collection of bindable items to this.DefaultViewModel["Items"]
            // TODO: Assign the selected item to this.flipView.SelectedItem
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        void DT_Tick(object sender, object e)
        {
            if (myBMIBar.Value <= BMIresult)
            {
                myBMIBar.Value += 5;
            }
        }
        double BMIresult;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            DispatcherTimer DT = new DispatcherTimer();
            DT.Interval = TimeSpan.FromMilliseconds(5); //設置時間間隔
            DT.Tick += DT_Tick;
            DT.Start();

            double meter = Convert.ToDouble(pheight.Text)*0.01;
            double kg = Convert.ToDouble(pweight.Text);
            double meters=meter * meter;

            int Old = Convert.ToInt32(old.Text);
            int Sex = sex.SelectedIndex;
            double[] Range=getCalculate(Old, Sex);
            
            txtResult.Text = Convert.ToString(Math.Round(kg / (meter * meter), 2));
            txtRange.Text = String.Format("{0}~{1}", Math.Round(meters * Range[0], 2), Math.Round(meters * Range[1], 2));
            txtStandard.Text = Convert.ToString(meters * 22);
            

            myBMIBar.Maximum = 40;
            myBMIBar.Value = BMIresult = kg / (meter * meter);
            if (BMIresult < 28 && BMIresult > 24)
            {
                Suggestion.Text = "超重!!少吃點吧";
            }
            else if (BMIresult < 18)
            {
                Suggestion.Text = "太輕啦!!要飄走了";
            }
            else if (BMIresult >= 28)
            {
                Suggestion.Text = "肥胖!!快去運動~";
            }
            else 
            {
                Suggestion.Text = "恭喜您!很健康喔~";
            }
    
            DT.Stop();
        }

        private double[] getCalculate(int old, int sexIndex)
        {
            if (old > 30)
            {
                
                if (sexIndex == 0) //man
                {
                    double[] set = { 18.3, 23.5 };
                    return set;
                }
                else
                {
                    double[] set = { 18.5, 24 };
                    return set;
                }

            }
            else
            {
                if (sexIndex == 0) //man
                {
                    double[] set = { 18, 23 };
                    return set;
                }
                else
                {
                    double[] set = { 18.5, 23.5 };
                    return set;
                }
            }
            
        }
    }
}
