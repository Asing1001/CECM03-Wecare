namespace ChartReport
{
    partial class FrmReportmaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportmaster));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnAge = new System.Windows.Forms.Button();
            this.BtnSex = new System.Windows.Forms.Button();
            this.BtnBar = new System.Windows.Forms.Button();
            this.BtnPie = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnAge);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSex);
            this.splitContainer1.Panel1.Controls.Add(this.BtnBar);
            this.splitContainer1.Panel1.Controls.Add(this.BtnPie);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.chart2);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1310, 700);
            this.splitContainer1.SplitterDistance = 521;
            this.splitContainer1.TabIndex = 1;
            // 
            // BtnAge
            // 
            this.BtnAge.BackColor = System.Drawing.Color.IndianRed;
            this.BtnAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAge.BackgroundImage")));
            this.BtnAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAge.FlatAppearance.BorderSize = 0;
            this.BtnAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAge.Location = new System.Drawing.Point(261, 425);
            this.BtnAge.Name = "BtnAge";
            this.BtnAge.Size = new System.Drawing.Size(250, 250);
            this.BtnAge.TabIndex = 10;
            this.BtnAge.UseVisualStyleBackColor = false;
            // 
            // BtnSex
            // 
            this.BtnSex.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSex.BackgroundImage")));
            this.BtnSex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSex.FlatAppearance.BorderSize = 0;
            this.BtnSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSex.Location = new System.Drawing.Point(5, 425);
            this.BtnSex.Name = "BtnSex";
            this.BtnSex.Size = new System.Drawing.Size(250, 250);
            this.BtnSex.TabIndex = 9;
            this.BtnSex.UseVisualStyleBackColor = false;
            // 
            // BtnBar
            // 
            this.BtnBar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBar.BackgroundImage")));
            this.BtnBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBar.FlatAppearance.BorderSize = 0;
            this.BtnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBar.Location = new System.Drawing.Point(261, 169);
            this.BtnBar.Name = "BtnBar";
            this.BtnBar.Size = new System.Drawing.Size(250, 250);
            this.BtnBar.TabIndex = 7;
            this.BtnBar.UseVisualStyleBackColor = false;
            // 
            // BtnPie
            // 
            this.BtnPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPie.BackgroundImage")));
            this.BtnPie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPie.FlatAppearance.BorderSize = 0;
            this.BtnPie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPie.Location = new System.Drawing.Point(5, 169);
            this.BtnPie.Name = "BtnPie";
            this.BtnPie.Size = new System.Drawing.Size(250, 250);
            this.BtnPie.TabIndex = 6;
            this.BtnPie.UseVisualStyleBackColor = false;
            // 
            // chart2
            // 
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelAutoFitMaxFontSize = 20;
            chartArea5.AxisX.LabelAutoFitMinFontSize = 16;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea5.AxisX2.TitleFont = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea5.AxisY.LabelAutoFitMaxFontSize = 20;
            chartArea5.AxisY.LabelAutoFitMinFontSize = 16;
            chartArea5.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            legend5.TitleFont = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(12, 169);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(744, 506);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            title5.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            this.chart2.Titles.Add(title5);
            // 
            // chart1
            // 
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelAutoFitMaxFontSize = 20;
            chartArea6.AxisX.LabelAutoFitMinFontSize = 16;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea6.AxisX2.TitleFont = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea6.AxisY.LabelAutoFitMaxFontSize = 20;
            chartArea6.AxisY.LabelAutoFitMinFontSize = 16;
            chartArea6.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            legend6.TitleFont = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 169);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(744, 506);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title6.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            this.chart1.Titles.Add(title6);
            // 
            // FrmReportmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 700);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportmaster";
            this.Text = "FrmReportmaster";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button BtnAge;
        protected System.Windows.Forms.Button BtnSex;
        protected System.Windows.Forms.Button BtnBar;
        protected System.Windows.Forms.Button BtnPie;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        internal System.Windows.Forms.SplitContainer splitContainer1;
    }
}