using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlLibrary1
{
    /// <summary>
    /// MyWPFListBox.xaml 的互動邏輯
    /// </summary>
    public partial class MyWPFListBox : UserControl
    {
        public MyWPFListBox()
        {
            InitializeComponent();
            //MyDBModel.ClsProduts x = new MyDBModel.ClsProduts();          
        }

        public IEnumerable DataSource
        {
            set { this.ListBox1.ItemsSource = value; }
        }

        public void AddItem<T>(T item)
        {
            this.ListBox1.Items.Add(item);
        }


    }
}
