namespace MyProgram
{
    partial class FrmExamCalendarEdit
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
            System.Windows.Forms.Label 狀態Label;
            System.Windows.Forms.Label 結果值Label;
            System.Windows.Forms.Label 檢驗結果Label;
            System.Windows.Forms.Label 病患Ptt_NameLabel;
            System.Windows.Forms.Label 備註Label;
            this.結果值TextBox = new System.Windows.Forms.TextBox();
            this.病患Ptt_NameTextBox = new System.Windows.Forms.TextBox();
            this.備註TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view_ExamCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            狀態Label = new System.Windows.Forms.Label();
            結果值Label = new System.Windows.Forms.Label();
            檢驗結果Label = new System.Windows.Forms.Label();
            病患Ptt_NameLabel = new System.Windows.Forms.Label();
            備註Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_ExamCalendarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 狀態Label
            // 
            狀態Label.AutoSize = true;
            狀態Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            狀態Label.Location = new System.Drawing.Point(59, 111);
            狀態Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            狀態Label.Name = "狀態Label";
            狀態Label.Size = new System.Drawing.Size(67, 24);
            狀態Label.TabIndex = 99;
            狀態Label.Text = "狀態：";
            狀態Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 結果值Label
            // 
            結果值Label.AutoSize = true;
            結果值Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            結果值Label.Location = new System.Drawing.Point(40, 213);
            結果值Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            結果值Label.Name = "結果值Label";
            結果值Label.Size = new System.Drawing.Size(86, 24);
            結果值Label.TabIndex = 99;
            結果值Label.Text = "結果值：";
            結果值Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 檢驗結果Label
            // 
            檢驗結果Label.AutoSize = true;
            檢驗結果Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            檢驗結果Label.Location = new System.Drawing.Point(21, 162);
            檢驗結果Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            檢驗結果Label.Name = "檢驗結果Label";
            檢驗結果Label.Size = new System.Drawing.Size(105, 24);
            檢驗結果Label.TabIndex = 99;
            檢驗結果Label.Text = "檢驗結果：";
            檢驗結果Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 病患Ptt_NameLabel
            // 
            病患Ptt_NameLabel.AutoSize = true;
            病患Ptt_NameLabel.Font = new System.Drawing.Font("微軟正黑體", 14F);
            病患Ptt_NameLabel.Location = new System.Drawing.Point(21, 60);
            病患Ptt_NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            病患Ptt_NameLabel.Name = "病患Ptt_NameLabel";
            病患Ptt_NameLabel.Size = new System.Drawing.Size(105, 24);
            病患Ptt_NameLabel.TabIndex = 99;
            病患Ptt_NameLabel.Text = "病患姓名：";
            病患Ptt_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 備註Label
            // 
            備註Label.AutoSize = true;
            備註Label.Font = new System.Drawing.Font("微軟正黑體", 14F);
            備註Label.Location = new System.Drawing.Point(59, 264);
            備註Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            備註Label.Name = "備註Label";
            備註Label.Size = new System.Drawing.Size(67, 24);
            備註Label.TabIndex = 99;
            備註Label.Text = "備註：";
            備註Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 結果值TextBox
            // 
            this.結果值TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_ExamCalendarBindingSource, "結果值", true));
            this.結果值TextBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.結果值TextBox.Location = new System.Drawing.Point(134, 209);
            this.結果值TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.結果值TextBox.Name = "結果值TextBox";
            this.結果值TextBox.Size = new System.Drawing.Size(200, 32);
            this.結果值TextBox.TabIndex = 4;
            // 
            // 病患Ptt_NameTextBox
            // 
            this.病患Ptt_NameTextBox.BackColor = System.Drawing.Color.White;
            this.病患Ptt_NameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.病患Ptt_NameTextBox.Location = new System.Drawing.Point(134, 56);
            this.病患Ptt_NameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.病患Ptt_NameTextBox.Name = "病患Ptt_NameTextBox";
            this.病患Ptt_NameTextBox.ReadOnly = true;
            this.病患Ptt_NameTextBox.Size = new System.Drawing.Size(200, 32);
            this.病患Ptt_NameTextBox.TabIndex = 1;
            // 
            // 備註TextBox
            // 
            this.備註TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_ExamCalendarBindingSource, "備註", true));
            this.備註TextBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.備註TextBox.Location = new System.Drawing.Point(134, 260);
            this.備註TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.備註TextBox.Name = "備註TextBox";
            this.備註TextBox.Size = new System.Drawing.Size(200, 32);
            this.備註TextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(351, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(351, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 32);
            this.comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(141, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "編輯 檢驗行事曆";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // view_ExamCalendarBindingSource
            // 
            this.view_ExamCalendarBindingSource.DataSource = typeof(MyDB.View_ExamCalendar);
            // 
            // FrmExamCalendarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(443, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(備註Label);
            this.Controls.Add(this.備註TextBox);
            this.Controls.Add(病患Ptt_NameLabel);
            this.Controls.Add(this.病患Ptt_NameTextBox);
            this.Controls.Add(檢驗結果Label);
            this.Controls.Add(結果值Label);
            this.Controls.Add(this.結果值TextBox);
            this.Controls.Add(狀態Label);
            this.Font = new System.Drawing.Font("新細明體", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmExamCalendarEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "行事曆修改";
            this.Load += new System.EventHandler(this.FrmCalenderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_ExamCalendarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource view_ExamCalendarBindingSource;
        private System.Windows.Forms.TextBox 結果值TextBox;
        private System.Windows.Forms.TextBox 病患Ptt_NameTextBox;
        private System.Windows.Forms.TextBox 備註TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}