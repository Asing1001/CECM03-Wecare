namespace MyProgram
{
    partial class FrmLogin
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txb_UserPwd = new System.Windows.Forms.TextBox();
            this.txb_UserAccount = new System.Windows.Forms.TextBox();
            this.labpass = new System.Windows.Forms.Label();
            this.labac = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_ForgetPwd = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Login.Location = new System.Drawing.Point(100, 341);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(7);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 63);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txb_UserPwd
            // 
            this.txb_UserPwd.Location = new System.Drawing.Point(279, 242);
            this.txb_UserPwd.Margin = new System.Windows.Forms.Padding(7);
            this.txb_UserPwd.Name = "txb_UserPwd";
            this.txb_UserPwd.Size = new System.Drawing.Size(366, 33);
            this.txb_UserPwd.TabIndex = 1;
            // 
            // txb_UserAccount
            // 
            this.txb_UserAccount.Location = new System.Drawing.Point(279, 170);
            this.txb_UserAccount.Margin = new System.Windows.Forms.Padding(7);
            this.txb_UserAccount.Name = "txb_UserAccount";
            this.txb_UserAccount.Size = new System.Drawing.Size(366, 33);
            this.txb_UserAccount.TabIndex = 0;
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.BackColor = System.Drawing.Color.White;
            this.labpass.Font = new System.Drawing.Font("新細明體", 16F);
            this.labpass.Location = new System.Drawing.Point(134, 247);
            this.labpass.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(76, 22);
            this.labpass.TabIndex = 7;
            this.labpass.Text = "密碼：";
            // 
            // labac
            // 
            this.labac.AutoSize = true;
            this.labac.BackColor = System.Drawing.Color.White;
            this.labac.Font = new System.Drawing.Font("新細明體", 16F);
            this.labac.Location = new System.Drawing.Point(134, 175);
            this.labac.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labac.Name = "labac";
            this.labac.Size = new System.Drawing.Size(76, 22);
            this.labac.TabIndex = 6;
            this.labac.Text = "帳號：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(279, 306);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "記住密碼";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btn_ForgetPwd
            // 
            this.btn_ForgetPwd.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_ForgetPwd.Location = new System.Drawing.Point(377, 341);
            this.btn_ForgetPwd.Margin = new System.Windows.Forms.Padding(7);
            this.btn_ForgetPwd.Name = "btn_ForgetPwd";
            this.btn_ForgetPwd.Size = new System.Drawing.Size(268, 63);
            this.btn_ForgetPwd.TabIndex = 4;
            this.btn_ForgetPwd.Text = "忘記密碼？(&P)";
            this.btn_ForgetPwd.UseVisualStyleBackColor = true;
            this.btn_ForgetPwd.Click += new System.EventHandler(this.btn_ForgetPwd_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_Cancel.Location = new System.Drawing.Point(238, 341);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(7);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 63);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::MyProgram.Properties.Resources.wecare2_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 445);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ForgetPwd);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_UserPwd);
            this.Controls.Add(this.txb_UserAccount);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labac);
            this.Font = new System.Drawing.Font("新細明體", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txb_UserPwd;
        private System.Windows.Forms.TextBox txb_UserAccount;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.Label labac;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_ForgetPwd;
        private System.Windows.Forms.Button btn_Cancel;
    }
}