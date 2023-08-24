namespace MyProgram
{
    partial class FrmReportmaster2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chtpie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtsex = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtbar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtpie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtsex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtage)).BeginInit();
            this.SuspendLayout();
            // 
            // chtpie
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 16;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 12;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 16;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 12;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea1.Name = "ChartArea1";
            this.chtpie.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtpie.Legends.Add(legend1);
            this.chtpie.Location = new System.Drawing.Point(75, 77);
            this.chtpie.Name = "chtpie";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtpie.Series.Add(series1);
            this.chtpie.Size = new System.Drawing.Size(400, 350);
            this.chtpie.TabIndex = 6;
            this.chtpie.Text = "chart1";
            title1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chtpie.Titles.Add(title1);
            // 
            // chtsex
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 20;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 16;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea2.AxisY.LabelAutoFitMaxFontSize = 13;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 12;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea2.Name = "ChartArea1";
            this.chtsex.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtsex.Legends.Add(legend2);
            this.chtsex.Location = new System.Drawing.Point(22, 433);
            this.chtsex.Name = "chtsex";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.chtsex.Series.Add(series2);
            this.chtsex.Series.Add(series3);
            this.chtsex.Size = new System.Drawing.Size(640, 350);
            this.chtsex.TabIndex = 7;
            this.chtsex.Text = "chart2";
            title2.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            this.chtsex.Titles.Add(title2);
            // 
            // chtbar
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 14;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 12;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea3.AxisX2.TitleFont = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 13;
            chartArea3.AxisY.LabelAutoFitMinFontSize = 12;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea3.Name = "ChartArea1";
            this.chtbar.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtbar.Legends.Add(legend3);
            this.chtbar.Location = new System.Drawing.Point(607, 12);
            this.chtbar.Name = "chtbar";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtbar.Series.Add(series4);
            this.chtbar.Size = new System.Drawing.Size(645, 350);
            this.chtbar.TabIndex = 7;
            this.chtbar.Text = "chart1";
            title3.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            this.chtbar.Titles.Add(title3);
            // 
            // chtage
            // 
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisX.LabelStyle.Angle = 30;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea4.AxisX2.TitleFont = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea4.AxisY.LabelAutoFitMaxFontSize = 13;
            chartArea4.AxisY.LabelAutoFitMinFontSize = 12;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea4.Name = "ChartArea1";
            this.chtage.ChartAreas.Add(chartArea4);
            legend4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtage.Legends.Add(legend4);
            this.chtage.Location = new System.Drawing.Point(668, 368);
            this.chtage.Name = "chtage";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chtage.Series.Add(series5);
            this.chtage.Series.Add(series6);
            this.chtage.Size = new System.Drawing.Size(527, 350);
            this.chtage.TabIndex = 8;
            this.chtage.Text = "chart2";
            title4.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            this.chtage.Titles.Add(title4);
            // 
            // FrmReportmaster2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 861);
            this.Controls.Add(this.chtbar);
            this.Controls.Add(this.chtpie);
            this.Controls.Add(this.chtage);
            this.Controls.Add(this.chtsex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportmaster2";
            this.Text = "FrmReportmaster2";
            this.Load += new System.EventHandler(this.FrmReportmaster2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtpie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtsex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataVisualization.Charting.Chart chtsex;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chtpie;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chtbar;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chtage;
    }
}