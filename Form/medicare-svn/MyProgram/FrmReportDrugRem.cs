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
    public partial class FrmReportDrugRem : FrmReportmaster2
    {
        public FrmReportDrugRem()
        {
            InitializeComponent();
        }

        private void FrmReportDrugRem_Load(object sender, EventArgs e)
        {            
            ClsChartReport.whichitem = "用藥";
            ClsReport.CreatPie(chtpie);
            ClsReport.DrugUserate(chtpie);
            ClsReport.CreatBar(chtbar);
            ClsReport.DrugUserate(chtbar);
            ClsReport.CreatSexchart(chtsex);
            ClsReport.CreatAgechart(chtage);
        }

        ClsChartReport2 ClsReport = new ClsChartReport2();

        //private void BtnPie_Click(object sender, EventArgs e)
        //{
        //    ClsReport.CreatPie(chart1, chart2);
        //    ClsReport.DrugUserate(chart1, chart2);
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
