namespace MyProgram
{
    partial class FrmExamCalendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamCalendar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Seach = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.已提醒DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.行事曆IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.病歷號碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.檢驗項目DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.檢驗日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.檢驗結果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.結果值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewExamCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExamCalendarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripTextBox2,
            this.btn_Seach,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btn_Delete,
            this.btn_Edit});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.MinimumSize = new System.Drawing.Size(0, 60);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1344, 60);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 57);
            this.toolStripLabel1.Text = "檢驗行事曆";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoSize = false;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "病患姓名",
            "病歷號碼"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(204, 38);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(106, 60);
            // 
            // btn_Seach
            // 
            this.btn_Seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Seach.Image = ((System.Drawing.Image)(resources.GetObject("btn_Seach.Image")));
            this.btn_Seach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Seach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Seach.Name = "btn_Seach";
            this.btn_Seach.Size = new System.Drawing.Size(97, 57);
            this.btn_Seach.Text = "搜索";
            this.btn_Seach.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(162, 57);
            this.toolStripButton1.Text = "發送簡訊提醒";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(97, 57);
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(97, 57);
            this.btn_Edit.Text = "修改";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1MinSize = 220;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 717);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Maroon;
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.已提醒DataGridViewTextBoxColumn,
            this.行事曆IDDataGridViewTextBoxColumn,
            this.病歷號碼DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.檢驗項目DataGridViewTextBoxColumn,
            this.檢驗日期DataGridViewTextBoxColumn,
            this.狀態DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.檢驗結果DataGridViewTextBoxColumn,
            this.結果值DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.viewExamCalendarBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 717);
            this.dataGridView1.TabIndex = 4;
            // 
            // 已提醒DataGridViewTextBoxColumn
            // 
            this.已提醒DataGridViewTextBoxColumn.DataPropertyName = "已提醒";
            this.已提醒DataGridViewTextBoxColumn.HeaderText = "已提醒";
            this.已提醒DataGridViewTextBoxColumn.Name = "已提醒DataGridViewTextBoxColumn";
            this.已提醒DataGridViewTextBoxColumn.ReadOnly = true;
            this.已提醒DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.已提醒DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.已提醒DataGridViewTextBoxColumn.Width = 101;
            // 
            // 行事曆IDDataGridViewTextBoxColumn
            // 
            this.行事曆IDDataGridViewTextBoxColumn.DataPropertyName = "行事曆ID";
            this.行事曆IDDataGridViewTextBoxColumn.HeaderText = "行事曆ID";
            this.行事曆IDDataGridViewTextBoxColumn.Name = "行事曆IDDataGridViewTextBoxColumn";
            this.行事曆IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.行事曆IDDataGridViewTextBoxColumn.Visible = false;
            this.行事曆IDDataGridViewTextBoxColumn.Width = 144;
            // 
            // 病歷號碼DataGridViewTextBoxColumn
            // 
            this.病歷號碼DataGridViewTextBoxColumn.DataPropertyName = "病歷號碼";
            this.病歷號碼DataGridViewTextBoxColumn.HeaderText = "病歷號碼";
            this.病歷號碼DataGridViewTextBoxColumn.Name = "病歷號碼DataGridViewTextBoxColumn";
            this.病歷號碼DataGridViewTextBoxColumn.ReadOnly = true;
            this.病歷號碼DataGridViewTextBoxColumn.Width = 123;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "病患名稱";
            this.dataGridViewTextBoxColumn4.HeaderText = "病患名稱";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 123;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "主治醫師";
            this.dataGridViewTextBoxColumn5.HeaderText = "主治醫師";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 123;
            // 
            // 檢驗項目DataGridViewTextBoxColumn
            // 
            this.檢驗項目DataGridViewTextBoxColumn.DataPropertyName = "檢驗項目";
            this.檢驗項目DataGridViewTextBoxColumn.HeaderText = "檢驗項目";
            this.檢驗項目DataGridViewTextBoxColumn.Name = "檢驗項目DataGridViewTextBoxColumn";
            this.檢驗項目DataGridViewTextBoxColumn.ReadOnly = true;
            this.檢驗項目DataGridViewTextBoxColumn.Width = 123;
            // 
            // 檢驗日期DataGridViewTextBoxColumn
            // 
            this.檢驗日期DataGridViewTextBoxColumn.DataPropertyName = "檢驗日期";
            this.檢驗日期DataGridViewTextBoxColumn.HeaderText = "檢驗日期";
            this.檢驗日期DataGridViewTextBoxColumn.Name = "檢驗日期DataGridViewTextBoxColumn";
            this.檢驗日期DataGridViewTextBoxColumn.ReadOnly = true;
            this.檢驗日期DataGridViewTextBoxColumn.Width = 123;
            // 
            // 狀態DataGridViewTextBoxColumn
            // 
            this.狀態DataGridViewTextBoxColumn.DataPropertyName = "狀態";
            this.狀態DataGridViewTextBoxColumn.HeaderText = "狀態";
            this.狀態DataGridViewTextBoxColumn.Name = "狀態DataGridViewTextBoxColumn";
            this.狀態DataGridViewTextBoxColumn.ReadOnly = true;
            this.狀態DataGridViewTextBoxColumn.Width = 79;
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            this.備註DataGridViewTextBoxColumn.ReadOnly = true;
            this.備註DataGridViewTextBoxColumn.Width = 79;
            // 
            // 檢驗結果DataGridViewTextBoxColumn
            // 
            this.檢驗結果DataGridViewTextBoxColumn.DataPropertyName = "檢驗結果";
            this.檢驗結果DataGridViewTextBoxColumn.HeaderText = "檢驗結果";
            this.檢驗結果DataGridViewTextBoxColumn.Name = "檢驗結果DataGridViewTextBoxColumn";
            this.檢驗結果DataGridViewTextBoxColumn.ReadOnly = true;
            this.檢驗結果DataGridViewTextBoxColumn.Width = 123;
            // 
            // 結果值DataGridViewTextBoxColumn
            // 
            this.結果值DataGridViewTextBoxColumn.DataPropertyName = "結果值";
            this.結果值DataGridViewTextBoxColumn.HeaderText = "結果值";
            this.結果值DataGridViewTextBoxColumn.Name = "結果值DataGridViewTextBoxColumn";
            this.結果值DataGridViewTextBoxColumn.ReadOnly = true;
            this.結果值DataGridViewTextBoxColumn.Width = 101;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "提早天數";
            this.dataGridViewTextBoxColumn6.HeaderText = "提早天數";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 123;
            // 
            // viewExamCalendarBindingSource
            // 
            this.viewExamCalendarBindingSource.DataSource = typeof(MyDB.View_ExamCalendar);
            // 
            // FrmExamCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 777);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("新細明體", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExamCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCalender_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCalender_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExamCalendarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton btn_Seach;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 已提醒DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行事曆IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 病歷號碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 檢驗項目DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 檢驗日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 檢驗結果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 結果值DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource viewExamCalendarBindingSource;
    }
}