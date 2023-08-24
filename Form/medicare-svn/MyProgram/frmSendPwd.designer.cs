namespace MyProgram
{
    partial class FrmSendPwd
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
            this.txbpass = new System.Windows.Forms.TextBox();
            this.txbac = new System.Windows.Forms.TextBox();
            this.labpass = new System.Windows.Forms.Label();
            this.labac = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbpass
            // 
            this.txbpass.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbpass.Location = new System.Drawing.Point(99, 101);
            this.txbpass.Margin = new System.Windows.Forms.Padding(5);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(200, 30);
            this.txbpass.TabIndex = 1;
            // 
            // txbac
            // 
            this.txbac.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbac.Location = new System.Drawing.Point(99, 55);
            this.txbac.Margin = new System.Windows.Forms.Padding(5);
            this.txbac.Name = "txbac";
            this.txbac.Size = new System.Drawing.Size(200, 30);
            this.txbac.TabIndex = 0;
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labpass.Location = new System.Drawing.Point(23, 107);
            this.labpass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(66, 19);
            this.labpass.TabIndex = 5;
            this.labpass.Text = "信箱：";
            // 
            // labac
            // 
            this.labac.AutoSize = true;
            this.labac.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labac.Location = new System.Drawing.Point(23, 61);
            this.labac.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labac.Name = "labac";
            this.labac.Size = new System.Drawing.Size(66, 19);
            this.labac.TabIndex = 4;
            this.labac.Text = "帳號：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.Location = new System.Drawing.Point(149, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "忘記密碼";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 14F);
            this.button2.Location = new System.Drawing.Point(229, 152);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 34;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSendPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 213);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txbac);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labac);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSendPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSendPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.TextBox txbac;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.Label labac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}