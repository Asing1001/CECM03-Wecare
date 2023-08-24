namespace MyProgram
{
    partial class FrmNewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewStaff));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UserAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_UserEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_UserPwdCheck = new System.Windows.Forms.TextBox();
            this.txb_UserPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_UserJobID = new System.Windows.Forms.ComboBox();
            this.txb_UserPhoneNumber = new System.Windows.Forms.TextBox();
            this.ccb_UserDivisionID = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "新增 使用者帳號";
            // 
            // txb_UserAccount
            // 
            this.txb_UserAccount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserAccount.Location = new System.Drawing.Point(135, 114);
            this.txb_UserAccount.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserAccount.Name = "txb_UserAccount";
            this.txb_UserAccount.Size = new System.Drawing.Size(200, 30);
            this.txb_UserAccount.TabIndex = 1;
            this.txb_UserAccount.Leave += new System.EventHandler(this.txb_UserAccount_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label10.Location = new System.Drawing.Point(60, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "帳號：";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserName.Location = new System.Drawing.Point(137, 58);
            this.txb_UserName.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(200, 30);
            this.txb_UserName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label8.Location = new System.Drawing.Point(60, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "姓名：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(454, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label7.Location = new System.Drawing.Point(50, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(454, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label6.Location = new System.Drawing.Point(60, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "電話：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label9.Location = new System.Drawing.Point(60, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "職稱：";
            // 
            // txb_UserEmail
            // 
            this.txb_UserEmail.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserEmail.Location = new System.Drawing.Point(135, 277);
            this.txb_UserEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserEmail.Name = "txb_UserEmail";
            this.txb_UserEmail.Size = new System.Drawing.Size(200, 30);
            this.txb_UserEmail.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label11.Location = new System.Drawing.Point(60, 387);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "科別：";
            // 
            // txb_UserPwdCheck
            // 
            this.txb_UserPwdCheck.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserPwdCheck.Location = new System.Drawing.Point(135, 223);
            this.txb_UserPwdCheck.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserPwdCheck.Name = "txb_UserPwdCheck";
            this.txb_UserPwdCheck.PasswordChar = '*';
            this.txb_UserPwdCheck.Size = new System.Drawing.Size(200, 30);
            this.txb_UserPwdCheck.TabIndex = 3;
            // 
            // txb_UserPwd
            // 
            this.txb_UserPwd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserPwd.Location = new System.Drawing.Point(135, 167);
            this.txb_UserPwd.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserPwd.Name = "txb_UserPwd";
            this.txb_UserPwd.PasswordChar = '*';
            this.txb_UserPwd.Size = new System.Drawing.Size(200, 30);
            this.txb_UserPwd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label3.Location = new System.Drawing.Point(22, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "確認密碼：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label4.Location = new System.Drawing.Point(60, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "密碼：";
            // 
            // cbb_UserJobID
            // 
            this.cbb_UserJobID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_UserJobID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb_UserJobID.FormattingEnabled = true;
            this.cbb_UserJobID.Location = new System.Drawing.Point(134, 332);
            this.cbb_UserJobID.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_UserJobID.Name = "cbb_UserJobID";
            this.cbb_UserJobID.Size = new System.Drawing.Size(200, 27);
            this.cbb_UserJobID.TabIndex = 5;
            // 
            // txb_UserPhoneNumber
            // 
            this.txb_UserPhoneNumber.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserPhoneNumber.Location = new System.Drawing.Point(135, 433);
            this.txb_UserPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserPhoneNumber.Name = "txb_UserPhoneNumber";
            this.txb_UserPhoneNumber.Size = new System.Drawing.Size(200, 30);
            this.txb_UserPhoneNumber.TabIndex = 7;
            // 
            // ccb_UserDivisionID
            // 
            this.ccb_UserDivisionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_UserDivisionID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ccb_UserDivisionID.FormattingEnabled = true;
            this.ccb_UserDivisionID.Location = new System.Drawing.Point(134, 386);
            this.ccb_UserDivisionID.Margin = new System.Windows.Forms.Padding(5);
            this.ccb_UserDivisionID.Name = "ccb_UserDivisionID";
            this.ccb_UserDivisionID.Size = new System.Drawing.Size(200, 27);
            this.ccb_UserDivisionID.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(357, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(357, 211);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 43);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(376, 423);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(70, 40);
            this.btnDemo.TabIndex = 21;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // FrmNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(254)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(555, 478);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ccb_UserDivisionID);
            this.Controls.Add(this.cbb_UserJobID);
            this.Controls.Add(this.txb_UserPwdCheck);
            this.Controls.Add(this.txb_UserPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_UserPhoneNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_UserEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_UserAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmNewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNewStaffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_UserAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_UserEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_UserPwdCheck;
        private System.Windows.Forms.TextBox txb_UserPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_UserJobID;
        private System.Windows.Forms.TextBox txb_UserPhoneNumber;
        private System.Windows.Forms.ComboBox ccb_UserDivisionID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDemo;

    }
}