using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace MyProgram
{
   public class ClsChart
    {
        public System.Windows.Forms.DataVisualization.Charting.Title Chart2Title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
        public Series Chart2series1 = new Series();
        public Series Chart2series2 = new Series();
        public ChartArea Chart2chartArea2 = new ChartArea();
        public Legend Chart2Legend = new Legend();
        public Chart chart2 = new Chart();
        public void CreatChart()
        {
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();
            chart2.Legends.Clear();
            chart2.Series.Add(Chart2series1);
            chart2.Series.Add(Chart2series2);
            chart2.ChartAreas.Add(Chart2chartArea2);
            Chart2Title2.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Chart2series1.Font =Chart2series2.Font= new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Chart2Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Chart2chartArea2.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            Chart2chartArea2.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            Chart2chartArea2.AxisY.LabelAutoFitMaxFontSize = 20;
            Chart2chartArea2.AxisY.LabelAutoFitMinFontSize = 16;
            Chart2chartArea2.AxisX.LabelAutoFitMaxFontSize = 20;
            Chart2chartArea2.AxisX.LabelAutoFitMinFontSize = 16;
            Chart2Title2.ForeColor = System.Drawing.Color.Black;
            //chart2.Titles.Add(Chart2Title2);
            chart2.Legends.Add(Chart2Legend);
            Chart2series1.Name = "ctseries1";
            Chart2series2.Name = "ctseries2";
            Chart2chartArea2.Name = "ctchartarea2";
            Chart2chartArea2.AxisY.TextOrientation = TextOrientation.Stacked;
            //chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            chart2.Visible = true;
            chart2.Location = new Point(170, 4);
            //chart2.Series.Add(series2);
            //chart2.ChartAreas.Add(chartArea2);
            //chart2.Margin = new System.Windows.Forms.Padding(2);
            chart2.Size = new System.Drawing.Size(358, 282);
            chart2.Dock = DockStyle.Fill;
        }
        public string truekey { get; set; }

        public int Count { get; set; }
    }
}
