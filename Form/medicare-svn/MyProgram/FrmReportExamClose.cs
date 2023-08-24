using MyClassLibrary;
using MyProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChartReport
{
    public partial class FrmReportExamClose : FrmReportmaster2
    {
        public FrmReportExamClose()
        {
            InitializeComponent();
        }
        private void FrmReportExamClose_Load(object sender, EventArgs e)
        {
           
            ClsChartReport.whichitem = "檢驗結案";//判斷是哪一個報表 
            ClsReport.CreatPie(chtpie);
            ClsReport.ExamCloserate(chtpie);
            ClsReport.CreatBar(chtbar);
            ClsReport.ExamCloserate(chtbar);
            ClsReport.CreatSexchart(chtsex);
            ClsReport.CreatAgechart(chtage);
        }

        ClsChartReport2 ClsReport = new ClsChartReport2();

        //private void BtnPie_Click(object sender, EventArgs e)
        //{
        //    ClsReport.CreatPie(chart1, chart2);
        //    ClsReport.ExamCloserate(chart1,chart2);
        //}

        //private void BtnBar_Click(object sender, EventArgs e)
        //{
        //    ClsReport.CreatBar(chart1, chart2);
        //}

        //private void BtnSex_Click(object sender, EventArgs e)
        //{
        //    ClsReport.CreatSexchart(chart1, chart2);
        //}

        //private void BtnAge_Click(object sender, EventArgs e)
        //{
        //    ClsReport.CreatAgechart(chart1, chart2);
        //}


    }
}
