namespace MyProgram
{
    partial class FrmDrugCalendarEdit
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
            System.Windows.Forms.Label 病患Ptt_NameLabel;
            System.Windows.Forms.Label 檢驗結果Label;
            System.Windows.Forms.Label 狀態Label;
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.病患Ptt_NameTextBox = new System.Windows.Forms.TextBox();
            this.txtNameEN = new System.Windows.Forms.TextBox();
            this.txtNameCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRmd = new System.Windows.Forms.CheckBox();
            備註Label = new System.Windows.Forms.Label();
            病患Ptt_NameLabel = new System.Windows.Forms.Label();
            檢驗結果Label = new System.Windows.Forms.Label();
            狀態Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 備註Label
            // 
            備註Label.AutoSize = true;
            備註Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            備註Label.Location = new System.Drawing.Point(90, 258);
            備註Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            備註Label.Name = "備註Label";
            備註Label.Size = new System.Drawing.Size(67, 24);
            備註Label.TabIndex = 108;
            備註Label.Text = "備註：";
            備註Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 病患Ptt_NameLabel
            // 
            病患Ptt_NameLabel.AutoSize = true;
            病患Ptt_NameLabel.Font = new System.Drawing.Font("微軟正黑體", 14F);
            病患Ptt_NameLabel.Location = new System.Drawing.Point(52, 67);
            病患Ptt_NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            病患Ptt_NameLabel.Name = "病患Ptt_NameLabel";
            病患Ptt_NameLabel.Size = new System.Drawing.Size(105, 24);
            病患Ptt_NameLabel.TabIndex = 109;
            病患Ptt_NameLabel.Text = "病患姓名：";
            病患Ptt_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 檢驗結果Label
            // 
            檢驗結果Label.AutoSize = true;
            檢驗結果Label.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            檢驗結果Label.Location = new System.Drawing.Point(15, 169);
            檢驗結果Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            檢驗結果Label.Name = "檢驗結果Label";
            檢驗結果Label.Size = new System.Drawing.Size(142, 19);
            檢驗結果Label.TabIndex = 110;
            檢驗結果Label.Text = "藥物中文名稱：";
            檢驗結果Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 狀態Label
            // 
            狀態Label.AutoSize = true;
            狀態Label.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            狀態Label.Location = new System.Drawing.Point(15, 118);
            狀態Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            狀態Label.Name = "狀態Label";
            狀態Label.Size = new System.Drawing.Size(142, 19);
            狀態Label.TabIndex = 112;
            狀態Label.Text = "藥物英文名稱：";
            狀態Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(158, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 107;
            this.label1.Text = "編輯 用藥行事曆";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(381, 107);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 40);
            this.btnCancel.TabIndex = 106;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.Location = new System.Drawing.Point(381, 63);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 40);
            this.btnEdit.TabIndex = 105;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtRem
            // 
            this.txtRem.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRem.Location = new System.Drawing.Point(165, 254);
            this.txtRem.Margin = new System.Windows.Forms.Padding(5);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(200, 32);
            this.txtRem.TabIndex = 104;
            // 
            // 病患Ptt_NameTextBox
            // 
            this.病患Ptt_NameTextBox.BackColor = System.Drawing.Color.White;
            this.病患Ptt_NameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.病患Ptt_NameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.病患Ptt_NameTextBox.Location = new System.Drawing.Point(165, 63);
            this.病患Ptt_NameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.病患Ptt_NameTextBox.Name = "病患Ptt_NameTextBox";
            this.病患Ptt_NameTextBox.ReadOnly = true;
            this.病患Ptt_NameTextBox.Size = new System.Drawing.Size(200, 32);
            this.病患Ptt_NameTextBox.TabIndex = 100;
            // 
            // txtNameEN
            // 
            this.txtNameEN.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNameEN.ForeColor = System.Drawing.Color.Gray;
            this.txtNameEN.Location = new System.Drawing.Point(165, 112);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.ReadOnly = true;
            this.txtNameEN.Size = new System.Drawing.Size(200, 30);
            this.txtNameEN.TabIndex = 113;
            // 
            // txtNameCH
            // 
            this.txtNameCH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNameCH.ForeColor = System.Drawing.Color.Gray;
            this.txtNameCH.Location = new System.Drawing.Point(165, 163);
            this.txtNameCH.Name = "txtNameCH";
            this.txtNameCH.ReadOnly = true;
            this.txtNameCH.Size = new System.Drawing.Size(200, 30);
            this.txtNameCH.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 115;
            this.label2.Text = "提醒與否：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbRmd
            // 
            this.cbRmd.AutoSize = true;
            this.cbRmd.Location = new System.Drawing.Point(165, 216);
            this.cbRmd.Name = "cbRmd";
            this.cbRmd.Size = new System.Drawing.Size(15, 14);
            this.cbRmd.TabIndex = 116;
            this.cbRmd.UseVisualStyleBackColor = true;
            // 
            // FrmDrugCalendarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 304);
            this.Controls.Add(this.cbRmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameCH);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(備註Label);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(病患Ptt_NameLabel);
            this.Controls.Add(this.病患Ptt_NameTextBox);
            this.Controls.Add(檢驗結果Label);
            this.Controls.Add(狀態Label);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDrugCalendarEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDrugCalendarEdit";
            this.Load += new System.EventHandler(this.FrmDrugCalendarEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.TextBox 病患Ptt_NameTextBox;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameEN;
        private System.Windows.Forms.TextBox txtNameCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRmd;
    }
}