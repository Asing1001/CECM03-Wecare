namespace MyProgram
{
    partial class FrmDrugEdit
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
            System.Windows.Forms.Label 備註Label;
            System.Windows.Forms.Label 起始日期Label;
            System.Windows.Forms.Label 結束日期Label;
            System.Windows.Forms.Label 結案Label;
            System.Windows.Forms.Label 結案原因Label;
            System.Windows.Forms.Label 檢驗名稱Label;
            System.Windows.Forms.Label 檢驗頻率Label;
            System.Windows.Forms.Label label2;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.備註TextBox = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.起始日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.結束日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.結案CheckBox = new System.Windows.Forms.CheckBox();
            this.結案原因TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            備註Label = new System.Windows.Forms.Label();
            起始日期Label = new System.Windows.Forms.Label();
            結束日期Label = new System.Windows.Forms.Label();
            結案Label = new System.Windows.Forms.Label();
            結案原因Label = new System.Windows.Forms.Label();
            檢驗名稱Label = new System.Windows.Forms.Label();
            檢驗頻率Label = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 備註Label
            // 
            備註Label.AutoSize = true;
            備註Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            備註Label.Location = new System.Drawing.Point(58, 301);
            備註Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            備註Label.Name = "備註Label";
            備註Label.Size = new System.Drawing.Size(67, 24);
            備註Label.TabIndex = 61;
            備註Label.Text = "備註：";
            // 
            // 起始日期Label
            // 
            起始日期Label.AutoSize = true;
            起始日期Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            起始日期Label.Location = new System.Drawing.Point(20, 160);
            起始日期Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            起始日期Label.Name = "起始日期Label";
            起始日期Label.Size = new System.Drawing.Size(105, 24);
            起始日期Label.TabIndex = 49;
            起始日期Label.Text = "起始日期：";
            // 
            // 結束日期Label
            // 
            結束日期Label.AutoSize = true;
            結束日期Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            結束日期Label.Location = new System.Drawing.Point(20, 208);
            結束日期Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            結束日期Label.Name = "結束日期Label";
            結束日期Label.Size = new System.Drawing.Size(105, 24);
            結束日期Label.TabIndex = 51;
            結束日期Label.Text = "結束日期：";
            // 
            // 結案Label
            // 
            結案Label.AutoSize = true;
            結案Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            結案Label.Location = new System.Drawing.Point(58, 347);
            結案Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            結案Label.Name = "結案Label";
            結案Label.Size = new System.Drawing.Size(67, 24);
            結案Label.TabIndex = 53;
            結案Label.Text = "結案：";
            // 
            // 結案原因Label
            // 
            結案原因Label.AutoSize = true;
            結案原因Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            結案原因Label.Location = new System.Drawing.Point(20, 391);
            結案原因Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            結案原因Label.Name = "結案原因Label";
            結案原因Label.Size = new System.Drawing.Size(105, 24);
            結案原因Label.TabIndex = 55;
            結案原因Label.Text = "結案原因：";
            // 
            // 檢驗名稱Label
            // 
            檢驗名稱Label.AutoSize = true;
            檢驗名稱Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            檢驗名稱Label.Location = new System.Drawing.Point(20, 61);
            檢驗名稱Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            檢驗名稱Label.Name = "檢驗名稱Label";
            檢驗名稱Label.Size = new System.Drawing.Size(105, 24);
            檢驗名稱Label.TabIndex = 57;
            檢驗名稱Label.Text = "藥物名稱：";
            // 
            // 檢驗頻率Label
            // 
            檢驗頻率Label.AutoSize = true;
            檢驗頻率Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            檢驗頻率Label.Location = new System.Drawing.Point(20, 111);
            檢驗頻率Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            檢驗頻率Label.Name = "檢驗頻率Label";
            檢驗頻率Label.Size = new System.Drawing.Size(105, 24);
            檢驗頻率Label.TabIndex = 58;
            檢驗頻率Label.Text = "使用頻率：";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnCancel.Location = new System.Drawing.Point(352, 102);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 40);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnEdit.Location = new System.Drawing.Point(352, 58);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 40);
            this.btnEdit.TabIndex = 63;
            this.btnEdit.Text = "確定";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // 備註TextBox
            // 
            this.備註TextBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.備註TextBox.Location = new System.Drawing.Point(133, 297);
            this.備註TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.備註TextBox.Name = "備註TextBox";
            this.備註TextBox.Size = new System.Drawing.Size(200, 32);
            this.備註TextBox.TabIndex = 62;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.comboBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(133, 108);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 32);
            this.comboBox4.TabIndex = 60;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.comboBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(133, 58);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 32);
            this.comboBox3.TabIndex = 59;
            // 
            // 起始日期DateTimePicker
            // 
            this.起始日期DateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm";
            this.起始日期DateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.起始日期DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.起始日期DateTimePicker.Location = new System.Drawing.Point(133, 156);
            this.起始日期DateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.起始日期DateTimePicker.Name = "起始日期DateTimePicker";
            this.起始日期DateTimePicker.ShowUpDown = true;
            this.起始日期DateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.起始日期DateTimePicker.TabIndex = 50;
            // 
            // 結束日期DateTimePicker
            // 
            this.結束日期DateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm";
            this.結束日期DateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.結束日期DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.結束日期DateTimePicker.Location = new System.Drawing.Point(133, 204);
            this.結束日期DateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.結束日期DateTimePicker.Name = "結束日期DateTimePicker";
            this.結束日期DateTimePicker.ShowUpDown = true;
            this.結束日期DateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.結束日期DateTimePicker.TabIndex = 52;
            // 
            // 結案CheckBox
            // 
            this.結案CheckBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.結案CheckBox.Location = new System.Drawing.Point(133, 348);
            this.結案CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.結案CheckBox.Name = "結案CheckBox";
            this.結案CheckBox.Size = new System.Drawing.Size(126, 23);
            this.結案CheckBox.TabIndex = 54;
            this.結案CheckBox.UseVisualStyleBackColor = true;
            // 
            // 結案原因TextBox
            // 
            this.結案原因TextBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.結案原因TextBox.Location = new System.Drawing.Point(133, 387);
            this.結案原因TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.結案原因TextBox.Name = "結案原因TextBox";
            this.結案原因TextBox.Size = new System.Drawing.Size(200, 32);
            this.結案原因TextBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(155, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "修改 用藥排程";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(133, 255);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 27);
            this.comboBox6.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.Location = new System.Drawing.Point(4, 259);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 19);
            label2.TabIndex = 66;
            label2.Text = "幾天前提醒：";
            // 
            // FrmDrugEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(254)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(445, 453);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
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
            this.Font = new System.Drawing.Font("新細明體", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDrugEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDrugScheduleEdit";
            this.Load += new System.EventHandler(this.FrmDrugScheduleEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox 備註TextBox;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker 起始日期DateTimePicker;
        private System.Windows.Forms.DateTimePicker 結束日期DateTimePicker;
        private System.Windows.Forms.CheckBox 結案CheckBox;
        private System.Windows.Forms.TextBox 結案原因TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}