using MyDB.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyDB;
namespace MyProgram
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            
        }
            System.Windows.Forms.DataVisualization.Charting.Title chartitle1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            Series series2 = new Series();
            ChartArea chartArea2 = new ChartArea();
       
            global::MyDB.MedDataSet meddataset = new MedDataSet();
            MyDB.MedDataSetTableAdapters.PatientsTableAdapter patientTadpter = new MyDB.MedDataSetTableAdapters.PatientsTableAdapter();//new MedDataSetTableAdapters.PatientsTableAdapter();
            MyDB.MedDataSetTableAdapters.DrugSchedulesTableAdapter DrugScheduleTadpter =new MyDB.MedDataSetTableAdapters.DrugSchedulesTableAdapter(); //new MedDataSetTableAdapters.DrugSchedulesTableAdapter();
            MyDB.MedDataSetTableAdapters.ExemSchedulesTableAdapter ExemScheduleTadpter = new MyDB.MedDataSetTableAdapters.ExemSchedulesTableAdapter(); //new MedDataSetTableAdapters.ExemSchedulesTableAdapter();

            string whichitem = "";
        private void button4_Click(object sender, EventArgs e)
        {
            whichitem = "檢驗";
            toolStrip1.Visible = true;
            chart1.Visible = true;
            c.chart2.Visible = false;
            patientTadpter.Fill(meddataset.Patients);
            var q = from n in meddataset.Patients
                    group n by n.Ptt_ExamRmd into g
                    select new { truekey = (g.Key) ? "是" : "否", falsekey = g.Count() };                   
            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "truekey";               
            chart1.Series[0].YValueMembers = "falsekey";         
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Titles.Clear();
            chartitle1.Text = "檢驗體醒使用率";
            chartitle1.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartitle1.ForeColor = System.Drawing.Color.Black;
            this.chart1.Titles.Add(chartitle1);
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LegendText = "#AXISLABEL: [ #PERCENT{P0} ]"; //X軸 + 百分比
            chart1.Series[0].Label = "#AXISLABEL\n#PERCENT{P0}";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            whichitem = "用藥";
            toolStrip1.Visible = true;
            chart1.Visible = true;
            c.chart2.Visible = false;
            patientTadpter.Fill(meddataset.Patients);
            var q =from n in meddataset.Patients
                   group n by n.Ptt_DrugRmd into g
                   select new {truekey=(g.Key)?"是":"否",falsekey=g.Count()};
            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "truekey";
            chart1.Series[0].YValueMembers = "falsekey";
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Titles.Clear();      
            chartitle1.Text = "用藥體醒使用率";
            this.chart1.Titles.Add(chartitle1);
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LegendText = "#AXISLABEL: [ #PERCENT{P0} ]"; //X軸 + 百分比
            chart1.Series[0].Label = "#AXISLABEL\n#PERCENT{P0}";

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
           chartitle1.Name = "Title1";
           chart1.Visible = false;
           button4_Click(sender, e);
        }

        private void btn_pie_Click(object sender, EventArgs e)
        {
           // if (whichitem == "用藥" || whichitem == "檢驗")
            
                chart1.Visible = true;
                c.chart2.Visible = false;
                chart1.Series[0].ChartType = SeriesChartType.Pie;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.Series[0].LegendText = "#AXISLABEL: [ #PERCENT{P0} ]"; //X軸 + 百分比
                chart1.Series[0].Label = "#AXISLABEL\n#PERCENT{P0}";
            

        }
        private void btn_Column_Click(object sender, EventArgs e)    //bar
        {
         
                chart1.Visible = true;
                c.chart2.Visible = false;
                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.Series[0].LegendText = "使用率"; //X軸 + 百分比
                chart1.Series[0].Label = "#VAL";
                chart1.ChartAreas[0].AxisY.Title = "個數";
            
        }
        ClsChart c = new ClsChart();
        private void button3_Click(object sender, EventArgs e)
        {
            whichitem = "用藥結案";
            toolStrip1.Visible = true;
            chart1.Visible = true;
            c.chart2.Visible = false;
            DrugScheduleTadpter.Fill(meddataset.DrugSchedules);
            var q = from n in meddataset.DrugSchedules
                    group n by n.DrugSch_Cls into g
                    select new { truekey = g.Key ? "是" : "否", falsekey = g.Count() };
            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "truekey";
            chart1.Series[0].YValueMembers = "falsekey";
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Titles.Clear();
            chartitle1.Text = "用藥結案比例";
            this.chart1.Titles.Add(chartitle1);
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LegendText = "#AXISLABEL: [ #PERCENT{P0} ]"; //X軸 + 百分比
            chart1.Series[0].Label = "#AXISLABEL\n#PERCENT{P0}";

            
        }
        string Men = "男";
        string Women = "女";
        int yesmen = 0;
        int nomen = 0;
        int yesW = 0;
        int noW = 0;
//==================================================================================
        int Ytwenty = 0;
        int Yfourty = 0;
        int Ysixty = 0;
        int Yeighty = 0;
        int Yeightyone = 0;
        int Ntwenty = 0;
        int Nfourty = 0;
        int Nsixty = 0;
        int Neighty = 0;
        int Neightyone = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            yesmen = 0;nomen = 0;yesW = 0;noW = 0;
            chart1.Visible = false;
            //splitContainer1.Panel2.Controls.Add(c.chart2);
            panel1.Controls.Add(c.chart2);
            c.CreatChart();
            patientTadpter.Fill(meddataset.Patients);
            foreach (MedDataSet.PatientsRow r in meddataset.Patients.Rows)
            {
                if (Men == r.Ptt_Sex)
                {
                    if (whichitem == "檢驗")
                    {
                        c.Chart2Title2.Text = "檢驗體醒 VS. 性別";
                        if (r.Ptt_ExamRmd)
                        {
                            yesmen++;
                        }
                        else
                            nomen++;
                    }
                    if (whichitem == "用藥")
                    {
                        c.Chart2Title2.Text = "用藥體醒 VS. 性別";
                        if (r.Ptt_DrugRmd)
                        {
                            yesmen++;
                        }
                        else
                            nomen++;
                    }
                }
                if (Women == r.Ptt_Sex)
                {
                    if (whichitem == "檢驗")
                    {
                        if (r.Ptt_ExamRmd)
                        {
                            yesW++;
                        }
                        else
                            noW++;
                    }
                    if (whichitem == "用藥")
                    {
                        if (r.Ptt_DrugRmd)
                        {
                            yesW++;
                        }
                        else
                            noW++;
                    }
                }
            }
            if (whichitem == "用藥結案")
            {
                c.Chart2Title2.Text = "用藥結案 VS. 性別";
                foreach (MedDataSet.DrugSchedulesRow r in meddataset.DrugSchedules.Rows)
                {
                    if (Men == r.Ptt_Sex)
                    {
                        if (r.DrugSch_Cls)
                        {
                            yesmen++;
                        }
                        else
                            nomen++;
                    }
                    if (Women == r.Ptt_Sex)
                    {
                        if (r.DrugSch_Cls)
                        {
                            yesW++;
                        }
                        else
                            noW++;
                    }
                }
            }
            if (whichitem == "檢驗結案")
            {
                c.Chart2Title2.Text = "檢驗結案 VS. 性別";
                foreach (MedDataSet.ExemSchedulesRow r in meddataset.ExemSchedules.Rows)
                {
                    if (Men == r.Ptt_Sex)
                    {
                        if (r.ExamSch_Cls)
                        {
                            yesmen++;
                        }
                        else
                            nomen++;
                    }
                    if (Women == r.Ptt_Sex)
                    {
                        if (r.ExamSch_Cls)
                        {
                            yesW++;
                        }
                        else
                            noW++;
                    }
                }
            }

            double Addmen = yesmen + nomen;
            double AddW = yesW + noW;
            string[] xValues = { "是", "否" };
            string[] titlemenW = { "男", "女" };
            double[] yValues = { (yesmen / Addmen), (nomen / Addmen) };
            double[] yValues2 = { (yesW / AddW), (noW / AddW) };
            c.chart2.Series[0].Points.DataBindXY(xValues, yValues);
            c.chart2.Series[1].Points.DataBindXY(xValues, yValues2);
            c.chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            c.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            c.chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            //c.chart2.Titles.Clear();
            //c.Chart2Title2.Text = "男女比例";
            c.chart2.Titles.Add(c.Chart2Title2);
            c.chart2.Text = "男女比例";
            c.chart2.Series[0].IsValueShownAsLabel = true;
            c.chart2.Series[0].LegendText = "男 ";
            c.chart2.Series[1].LegendText = "女";
            c.chart2.ChartAreas[0].AxisY.LabelStyle.Format = "p0";
            c.chart2.Series[0].Label = "男\n#PERCENT{P0}";
            c.chart2.Series[1].Label = "女\n#PERCENT{P0}";
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            Ytwenty = 0; Yfourty = 0; Ysixty = 0; Yeighty = 0; Yeightyone = 0;
            Ntwenty = 0; Nfourty = 0; Nsixty = 0; Neighty = 0; Neightyone = 0;
            chart1.Visible = false;
            //splitContainer1.Panel2.Controls.Add(c.chart2);
            panel1.Controls.Add(c.chart2);
            c.CreatChart();
            List<DateTime> t2Yes = new List<DateTime>();
            List<DateTime> t2No = new List<DateTime>();
            DateTime t1 = DateTime.Now;
            if (whichitem == "檢驗")
            {
                c.Chart2Title2.Text = "檢驗體醒 VS. 年齡";
                t2Yes = (from m in meddataset.Patients
                         where m.Ptt_ExamRmd == true
                         select m.Ptt_BD).ToList();
              
                t2No = (from m in meddataset.Patients
                        where m.Ptt_ExamRmd == false
                        select m.Ptt_BD).ToList();

            }
            if(whichitem=="用藥")
            {
                c.Chart2Title2.Text = "用藥體醒 VS. 年齡";
                t2Yes = (from m in meddataset.Patients
                         where m.Ptt_DrugRmd == true
                         select m.Ptt_BD).ToList();

                t2No = (from m in meddataset.Patients
                        where m.Ptt_DrugRmd == false
                        select m.Ptt_BD).ToList();
            }
            if (whichitem == "檢驗結案")
            {
                c.Chart2Title2.Text = "檢驗結案 VS. 年齡";
                t2Yes = (from m in meddataset.ExemSchedules
                         where m.ExamSch_Cls == true
                         select m.Ptt_BD).ToList();

                t2No = (from m in meddataset.ExemSchedules
                        where m.ExamSch_Cls == false
                        select m.Ptt_BD).ToList();
            }
            if (whichitem == "用藥結案")
            {
                c.Chart2Title2.Text = "用藥結案 VS. 年齡";
                t2Yes = (from m in meddataset.DrugSchedules
                         where m.DrugSch_Cls == true
                         select m.Ptt_BD).ToList();

                t2No = (from m in meddataset.DrugSchedules
                        where m.DrugSch_Cls == false
                        select m.Ptt_BD).ToList();
            }
            List<int> ageYes = new List<int>();
            List<int> ageNo = new List<int>();
            foreach (var item in t2Yes)
            {
                ageYes.Add(t1.Year - item.Year);
            }
            foreach (var item in t2No)
            {
                ageNo.Add(t1.Year - item.Year);
            }

            foreach (int num in ageYes)
            {
                if (num <= 20)
                {
                    Ytwenty++;
                }
                if (num > 20 && num <= 40)
                {
                    Yfourty++;
                }
                if (num > 40 && num <= 60)
                {
                    Ysixty++;
                }
                if (num > 60 && num <= 80)
                {
                    Yeighty++;
                }
                if (num > 80)
                {
                    Yeightyone++;
                }
            }
            foreach (int num in ageNo)
            {
                if (num <= 20)
                {
                    Ntwenty++;
                }
                if (num > 20 && num <= 40)
                {
                    Nfourty++;
                }
                if (num > 40 && num <= 60)
                {
                    Nsixty++;
                }
                if (num > 60 && num <= 80)
                {
                    Neighty++;
                }
                if (num > 80)
                {
                    Neightyone++;
                }
            }

            string[] xValues = { "20以下", "21~40", "41~60", "61~80", "81以上" };
            double[] yValues = { Ytwenty, Yfourty, Ysixty, Yeighty, Yeightyone };
            double[] yValues2 = { Ntwenty, Nfourty, Nsixty, Neighty, Neightyone };
            c.chart2.Series[0].Points.DataBindXY(xValues, yValues);
            c.chart2.Series[1].Points.DataBindXY(xValues, yValues2);
            c.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            c.chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //c.Chart2Title2.Text = "年齡比例";
            c.chart2.Titles.Add(c.Chart2Title2);
            c.chart2.Series[0].MarkerColor = System.Drawing.Color.Blue;
            c.chart2.Series[1].MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            for (int i = 0; i < c.chart2.Series.Count; i++)
            {

                c.chart2.Series[i].MarkerSize = 10;
                c.chart2.Series[i].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                c.chart2.Series[i].BorderWidth = 5;
            }
            c.chart2.Series[0].IsValueShownAsLabel = true;
            c.chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            c.chart2.Series[0].LegendText = "是";
            c.chart2.Series[1].LegendText = "否";
            c.chart2.ChartAreas[0].AxisY.LabelStyle.Format = "";
            c.chart2.Series[0].Label = "#VAL";
            c.chart2.Series[1].Label = "#VAL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            whichitem = "檢驗結案";
            toolStrip1.Visible = true;
            chart1.Visible = true;
            c.chart2.Visible = false;
            ExemScheduleTadpter.Fill(meddataset.ExemSchedules);
            var q = from n in meddataset.ExemSchedules
                    group n by n.ExamSch_Cls into g
                    select new { truekey = g.Key ? "是" : "否", falsekey = g.Count() };

            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "truekey";
            chart1.Series[0].YValueMembers = "falsekey";
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Titles.Clear();
            chartitle1.Text = "檢驗結案比例";
            this.chart1.Titles.Add(chartitle1);
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LegendText = "#AXISLABEL: [ #PERCENT{P0} ]"; //X軸 + 百分比
            chart1.Series[0].Label = "#AXISLABEL\n#PERCENT{P0}";
        }

        
        }
    }

