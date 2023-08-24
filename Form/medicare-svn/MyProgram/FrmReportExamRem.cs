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
using MyClassLibrary;

namespace ChartReport
{
    public partial class FrmReportExamRem : FrmReportmaster2
    {
        public FrmReportExamRem()
        {
            InitializeComponent();
        }

        private void FrmReportExamRem_Load(object sender, EventArgs e)
        {
           // BtnPie_Click(sender, e);     //預設為圓餅圖    
            ClsChartReport.whichitem = "檢驗";  //判斷是哪一個報表
            ClsReport.CreatPie(chtpie);
            ClsReport.ExamUserate(chtpie);
            ClsReport.CreatBar(chtbar);
            ClsReport.ExamUserate(chtbar);
            ClsReport.CreatSexchart(chtsex);
            ClsReport.CreatAgechart(chtage);
        }

        ClsChartReport2 ClsReport = new ClsChartReport2();

        //private void BtnPie_Click(object sender, EventArgs e)
        //{
        //    ClsReport.CreatPie(chart1, chart2);
        //    ClsReport.ExamUserate(chart1);
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
