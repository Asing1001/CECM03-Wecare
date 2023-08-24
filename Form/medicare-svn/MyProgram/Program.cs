using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // FrmExamCalender f = new FrmExamCalender();
           // FrmLogin f = new FrmLogin();
            FrmReminder f = new FrmReminder();
           // FrmCombineCalendar f = new FrmCombineCalendar();
            //FrmNewStaff f = new FrmNewStaff();
            f.Show();
            Application.Run();
        }
    }
}
