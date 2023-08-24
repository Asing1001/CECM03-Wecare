namespace MyProgram
{
    partial class FrmExamScheduleNew
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
            System.Windows.Forms.Label 起始日期Label;
            System.Windows.Forms.Label 結束日期Label;
            System.Windows.Forms.Label 結案Label;
            System.Windows.Forms.Label 結案原因Label;
            System.Windows.Forms.Label 檢驗名稱Label;
            System.Windows.Forms.Label 檢驗頻率Label;
            System.Windows.Forms.Label 備註Label;
            System.Windows.Forms.Label Diag_IDLabel;
            System.Windows.Forms.Label Ptt_NameLabel;
            System.Windows.Forms.Label 病歷號碼Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.起始日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.view_ExamScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.結束日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.結案CheckBox = new System.Windows.Forms.CheckBox();
            this.結案原因TextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.備註TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugOverviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RmdcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NurseCombo = new System.Windows.Forms.ComboBox();
            this.ConsultCombo = new System.Windows.Forms.ComboBox();
            起始日期Label = new System.Windows.Forms.Label();
            結束日期Label = new System.Windows.Forms.Label();
            結案Label = new System.Windows.Forms.Label();
            結案原因Label = new System.Windows.Forms.Label();
            檢驗名稱Label = new System.Windows.Forms.Label();
            檢驗頻率Label = new System.Windows.Forms.Label();
            備註Label = new System.Windows.Forms.Label();
            Diag_IDLabel = new System.Windows.Forms.Label();
            Ptt_NameLabel = new System.Windows.Forms.Label();
            病歷號碼Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_ExamScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugOverviewsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 起始日期Label
            // 
            起始日期Label.AutoSize = true;
            起始日期Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            起始日期Label.Location = new System.Drawing.Point(35, 377);
            起始日期Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            起始日期Label.Name = "起始日期Label";
            起始日期Label.Size = new System.Drawing.Size(130, 24);
            起始日期Label.TabIndex = 5;
            起始日期Label.Text = "起始日期：";
            // 
            // 結束日期Label
            // 
            結束日期Label.AutoSize = true;
            結束日期Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            結束日期Label.Location = new System.Drawing.Point(35, 422);
            結束日期Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            結束日期Label.Name = "結束日期Label";
            結束日期Label.Size = new System.Drawing.Size(130, 24);
            結束日期Label.TabIndex = 9;
            結束日期Label.Text = "結束日期：";
            // 
            // 結案Label
            // 
            結案Label.AutoSize = true;
            結案Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            結案Label.Location = new System.Drawing.Point(73, 557);
            結案Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            結案Label.Name = "結案Label";
            結案Label.Size = new System.Drawing.Size(82, 24);
            結案Label.TabIndex = 11;
            結案Label.Text = "結案：";
            // 
            // 結案原因Label
            // 
            結案原因Label.AutoSize = true;
            結案原因Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            結案原因Label.Location = new System.Drawing.Point(35, 602);
            結案原因Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            結案原因Label.Name = "結案原因Label";
            結案原因Label.Size = new System.Drawing.Size(130, 24);
            結案原因Label.TabIndex = 13;
            結案原因Label.Text = "結案原因：";
            // 
            // 檢驗名稱Label
            // 
            檢驗名稱Label.AutoSize = true;
            檢驗名稱Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            檢驗名稱Label.Location = new System.Drawing.Point(35, 287);
            檢驗名稱Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            檢驗名稱Label.Name = "檢驗名稱Label";
            檢驗名稱Label.Size = new System.Drawing.Size(130, 24);
            檢驗名稱Label.TabIndex = 15;
            檢驗名稱Label.Text = "檢驗名稱：";
            // 
            // 檢驗頻率Label
            // 
            檢驗頻率Label.AutoSize = true;
            檢驗頻率Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            檢驗頻率Label.Location = new System.Drawing.Point(35, 332);
            檢驗頻率Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            檢驗頻率Label.Name = "檢驗頻率Label";
            檢驗頻率Label.Size = new System.Drawing.Size(130, 24);
            檢驗頻率Label.TabIndex = 17;
            檢驗頻率Label.Text = "檢驗頻率：";
            // 
            // 備註Label
            // 
            備註Label.AutoSize = true;
            備註Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            備註Label.Location = new System.Drawing.Point(73, 512);
            備註Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            備註Label.Name = "備註Label";
            備註Label.Size = new System.Drawing.Size(82, 24);
            備註Label.TabIndex = 22;
            備註Label.Text = "備註：";
            // 
            // Diag_IDLabel
            // 
            Diag_IDLabel.AutoSize = true;
            Diag_IDLabel.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            Diag_IDLabel.Location = new System.Drawing.Point(32, 141);
            Diag_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Diag_IDLabel.Name = "Diag_IDLabel";
            Diag_IDLabel.Size = new System.Drawing.Size(130, 24);
            Diag_IDLabel.TabIndex = 54;
            Diag_IDLabel.Text = "主治醫師：";
            // 
            // Ptt_NameLabel
            // 
            Ptt_NameLabel.AllowDrop = true;
            Ptt_NameLabel.AutoSize = true;
            Ptt_NameLabel.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            Ptt_NameLabel.Location = new System.Drawing.Point(35, 97);
            Ptt_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Ptt_NameLabel.Name = "Ptt_NameLabel";
            Ptt_NameLabel.Size = new System.Drawing.Size(130, 24);
            Ptt_NameLabel.TabIndex = 50;
            Ptt_NameLabel.Text = "病患姓名：";
            // 
            // 病歷號碼Label
            // 
            病歷號碼Label.AllowDrop = true;
            病歷號碼Label.AutoSize = true;
            病歷號碼Label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            病歷號碼Label.Location = new System.Drawing.Point(35, 52);
            病歷號碼Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            病歷號碼Label.Name = "病歷號碼Label";
            病歷號碼Label.Size = new System.Drawing.Size(130, 24);
            病歷號碼Label.TabIndex = 51;
            病歷號碼Label.Text = "病歷號碼：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.Location = new System.Drawing.Point(16, 467);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 24);
            label1.TabIndex = 57;
            label1.Text = "幾天前提醒：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label3.Location = new System.Drawing.Point(80, 185);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 24);
            label3.TabIndex = 60;
            label3.Text = "護士：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label4.Location = new System.Drawing.Point(56, 234);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(106, 24);
            label4.TabIndex = 62;
            label4.Text = "諮詢師：";
            // 
            // 起始日期DateTimePicker
            // 
            this.起始日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.view_ExamScheduleBindingSource, "起始日期", true));
            this.起始日期DateTimePicker.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.起始日期DateTimePicker.Location = new System.Drawing.Point(146, 371);
            this.起始日期DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.起始日期DateTimePicker.Name = "起始日期DateTimePicker";
            this.起始日期DateTimePicker.Size = new System.Drawing.Size(200, 36);
            this.起始日期DateTimePicker.TabIndex = 6;
            // 
            // view_ExamScheduleBindingSource
            // 
            this.view_ExamScheduleBindingSource.DataSource = typeof(MyDB.View_ExamSchedule);
            // 
            // 結束日期DateTimePicker
            // 
            this.結束日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.view_ExamScheduleBindingSource, "結束日期", true));
            this.結束日期DateTimePicker.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.結束日期DateTimePicker.Location = new System.Drawing.Point(146, 416);
            this.結束日期DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.結束日期DateTimePicker.Name = "結束日期DateTimePicker";
            this.結束日期DateTimePicker.Size = new System.Drawing.Size(200, 36);
            this.結束日期DateTimePicker.TabIndex = 10;
            // 
            // 結案CheckBox
            // 
            this.結案CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.view_ExamScheduleBindingSource, "結案", true));
            this.結案CheckBox.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.結案CheckBox.Location = new System.Drawing.Point(146, 551);
            this.結案CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.結案CheckBox.Name = "結案CheckBox";
            this.結案CheckBox.Size = new System.Drawing.Size(200, 30);
            this.結案CheckBox.TabIndex = 12;
            this.結案CheckBox.UseVisualStyleBackColor = true;
            // 
            // 結案原因TextBox
            // 
            this.結案原因TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_ExamScheduleBindingSource, "結案原因", true));
            this.結案原因TextBox.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.結案原因TextBox.Location = new System.Drawing.Point(146, 596);
            this.結案原因TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.結案原因TextBox.Name = "結案原因TextBox";
            this.結案原因TextBox.Size = new System.Drawing.Size(200, 36);
            this.結案原因TextBox.TabIndex = 14;
            this.結案原因TextBox.Text = "尚未結案";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 283);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 32);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(146, 328);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 32);
            this.comboBox4.TabIndex = 21;
            // 
            // 備註TextBox
            // 
            this.備註TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_ExamScheduleBindingSource, "備註", true));
            this.備註TextBox.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.備註TextBox.Location = new System.Drawing.Point(146, 506);
            this.備註TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.備註TextBox.Name = "備註TextBox";
            this.備註TextBox.Size = new System.Drawing.Size(200, 36);
            this.備註TextBox.TabIndex = 23;
            this.備註TextBox.Text = "無";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(366, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataSource = typeof(MyDB.Diagnosis);
            // 
            // drugOverviewsBindingSource
            // 
            this.drugOverviewsBindingSource.DataSource = typeof(MyDB.DrugOverview);
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorComboBox.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DoctorComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(146, 138);
            this.DoctorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(200, 32);
            this.DoctorComboBox.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Location = new System.Drawing.Point(146, 48);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 32);
            this.comboBox2.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(146, 93);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(366, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 56;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RmdcomboBox
            // 
            this.RmdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RmdcomboBox.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RmdcomboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RmdcomboBox.FormattingEnabled = true;
            this.RmdcomboBox.Location = new System.Drawing.Point(146, 463);
            this.RmdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.RmdcomboBox.Name = "RmdcomboBox";
            this.RmdcomboBox.Size = new System.Drawing.Size(200, 32);
            this.RmdcomboBox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 59;
            this.label2.Text = "檢驗排程項目新增";
            // 
            // NurseCombo
            // 
            this.NurseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseCombo.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NurseCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NurseCombo.FormattingEnabled = true;
            this.NurseCombo.Location = new System.Drawing.Point(146, 185);
            this.NurseCombo.Margin = new System.Windows.Forms.Padding(4);
            this.NurseCombo.Name = "NurseCombo";
            this.NurseCombo.Size = new System.Drawing.Size(200, 32);
            this.NurseCombo.TabIndex = 61;
            // 
            // ConsultCombo
            // 
            this.ConsultCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultCombo.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConsultCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConsultCombo.FormattingEnabled = true;
            this.ConsultCombo.Location = new System.Drawing.Point(146, 231);
            this.ConsultCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ConsultCombo.Name = "ConsultCombo";
            this.ConsultCombo.Size = new System.Drawing.Size(200, 32);
            this.ConsultCombo.TabIndex = 63;
            // 
            // FrmExamScheduleNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(456, 645);
            this.Controls.Add(this.ConsultCombo);
            this.Controls.Add(label4);
            this.Controls.Add(this.NurseCombo);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RmdcomboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DoctorComboBox);
            this.Controls.Add(Diag_IDLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(Ptt_NameLabel);
            this.Controls.Add(病歷號碼Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(備註Label);
            this.Controls.Add(this.備註TextBox);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(起始日期Label);
            this.Controls.Add(this.起始日期DateTimePicker);
            this.Controls.Add(結束日期Label);
            this.Controls.Add(this.結束日期DateTimePicker);
            this.Controls.Add(結案Label);
            this.Controls.Add(this.結案CheckBox);
            this.Controls.Add(結案原因Label);
            this.Controls.Add(this.結案原因TextBox);
            this.Controls.Add(檢驗名稱Label);
            this.Controls.Add(檢驗頻率Label);
            this.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExamScheduleNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增檢驗排程";
            this.Load += new System.EventHandler(this.FrmNewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_ExamScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugOverviewsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource view_ExamScheduleBindingSource;
        private System.Windows.Forms.DateTimePicker 起始日期DateTimePicker;
        private System.Windows.Forms.DateTimePicker 結束日期DateTimePicker;
        private System.Windows.Forms.CheckBox 結案CheckBox;
        private System.Windows.Forms.TextBox 結案原因TextBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox 備註TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.BindingSource drugOverviewsBindingSource;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox RmdcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NurseCombo;
        private System.Windows.Forms.ComboBox ConsultCombo;
    }
}