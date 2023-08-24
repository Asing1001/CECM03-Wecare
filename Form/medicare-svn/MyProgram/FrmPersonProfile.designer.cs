namespace MyProgram
{
    partial class FrmPersonProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonProfile));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txb_UserAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txb_UserNewPwdCheck = new System.Windows.Forms.TextBox();
            this.txb_UserNewPwd = new System.Windows.Forms.TextBox();
            this.txb_UserOldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_UserJobID = new System.Windows.Forms.ComboBox();
            this.cbb_UserDivisionID = new System.Windows.Forms.ComboBox();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.txb_UserPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_UserEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.txb_UserAccount);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txb_UserName);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(452, 587);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(327, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 27);
            this.button3.TabIndex = 41;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(20, 159);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "修改密碼：";
            this.linkLabel1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(327, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // txb_UserAccount
            // 
            this.txb_UserAccount.BackColor = System.Drawing.Color.White;
            this.txb_UserAccount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserAccount.Location = new System.Drawing.Point(152, 112);
            this.txb_UserAccount.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserAccount.MinimumSize = new System.Drawing.Size(150, 4);
            this.txb_UserAccount.Name = "txb_UserAccount";
            this.txb_UserAccount.ReadOnly = true;
            this.txb_UserAccount.Size = new System.Drawing.Size(150, 30);
            this.txb_UserAccount.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(76, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "帳號：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "編輯 使用者資料";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_UserName
            // 
            this.txb_UserName.BackColor = System.Drawing.Color.White;
            this.txb_UserName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserName.Location = new System.Drawing.Point(152, 56);
            this.txb_UserName.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserName.MinimumSize = new System.Drawing.Size(4, 4);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.ReadOnly = true;
            this.txb_UserName.Size = new System.Drawing.Size(150, 30);
            this.txb_UserName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(76, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "姓名：";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txb_UserNewPwdCheck);
            this.splitContainer2.Panel1.Controls.Add(this.txb_UserNewPwd);
            this.splitContainer2.Panel1.Controls.Add(this.txb_UserOldPwd);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cbb_UserJobID);
            this.splitContainer2.Panel2.Controls.Add(this.cbb_UserDivisionID);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Modify);
            this.splitContainer2.Panel2.Controls.Add(this.txb_UserPhoneNumber);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Cancel);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.txb_UserEmail);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer2.Size = new System.Drawing.Size(452, 389);
            this.splitContainer2.SplitterDistance = 138;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // txb_UserNewPwdCheck
            // 
            this.txb_UserNewPwdCheck.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserNewPwdCheck.Location = new System.Drawing.Point(152, 105);
            this.txb_UserNewPwdCheck.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserNewPwdCheck.MinimumSize = new System.Drawing.Size(275, 4);
            this.txb_UserNewPwdCheck.Name = "txb_UserNewPwdCheck";
            this.txb_UserNewPwdCheck.PasswordChar = '*';
            this.txb_UserNewPwdCheck.Size = new System.Drawing.Size(275, 30);
            this.txb_UserNewPwdCheck.TabIndex = 2;
            // 
            // txb_UserNewPwd
            // 
            this.txb_UserNewPwd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserNewPwd.Location = new System.Drawing.Point(152, 55);
            this.txb_UserNewPwd.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserNewPwd.MinimumSize = new System.Drawing.Size(275, 4);
            this.txb_UserNewPwd.Name = "txb_UserNewPwd";
            this.txb_UserNewPwd.PasswordChar = '*';
            this.txb_UserNewPwd.Size = new System.Drawing.Size(275, 30);
            this.txb_UserNewPwd.TabIndex = 1;
            // 
            // txb_UserOldPwd
            // 
            this.txb_UserOldPwd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserOldPwd.Location = new System.Drawing.Point(152, 5);
            this.txb_UserOldPwd.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserOldPwd.MinimumSize = new System.Drawing.Size(275, 4);
            this.txb_UserOldPwd.Name = "txb_UserOldPwd";
            this.txb_UserOldPwd.PasswordChar = '*';
            this.txb_UserOldPwd.Size = new System.Drawing.Size(275, 30);
            this.txb_UserOldPwd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "確認新密碼：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(57, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "新密碼：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(38, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "原始密碼：";
            // 
            // cbb_UserJobID
            // 
            this.cbb_UserJobID.BackColor = System.Drawing.Color.White;
            this.cbb_UserJobID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_UserJobID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_UserJobID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb_UserJobID.FormattingEnabled = true;
            this.cbb_UserJobID.Location = new System.Drawing.Point(152, 60);
            this.cbb_UserJobID.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_UserJobID.MinimumSize = new System.Drawing.Size(275, 0);
            this.cbb_UserJobID.Name = "cbb_UserJobID";
            this.cbb_UserJobID.Size = new System.Drawing.Size(275, 27);
            this.cbb_UserJobID.TabIndex = 1;
            // 
            // cbb_UserDivisionID
            // 
            this.cbb_UserDivisionID.BackColor = System.Drawing.Color.White;
            this.cbb_UserDivisionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_UserDivisionID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb_UserDivisionID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbb_UserDivisionID.FormattingEnabled = true;
            this.cbb_UserDivisionID.Location = new System.Drawing.Point(152, 104);
            this.cbb_UserDivisionID.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_UserDivisionID.MinimumSize = new System.Drawing.Size(275, 0);
            this.cbb_UserDivisionID.Name = "cbb_UserDivisionID";
            this.cbb_UserDivisionID.Size = new System.Drawing.Size(275, 27);
            this.cbb_UserDivisionID.TabIndex = 2;
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modify.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Modify.Location = new System.Drawing.Point(111, 189);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(70, 40);
            this.btn_Modify.TabIndex = 4;
            this.btn_Modify.Text = "修改";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // txb_UserPhoneNumber
            // 
            this.txb_UserPhoneNumber.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserPhoneNumber.Location = new System.Drawing.Point(152, 146);
            this.txb_UserPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserPhoneNumber.MinimumSize = new System.Drawing.Size(275, 4);
            this.txb_UserPhoneNumber.Name = "txb_UserPhoneNumber";
            this.txb_UserPhoneNumber.Size = new System.Drawing.Size(275, 30);
            this.txb_UserPhoneNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(71, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(286, 189);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 40);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "關閉";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(76, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "電話：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(76, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "職稱：";
            // 
            // txb_UserEmail
            // 
            this.txb_UserEmail.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_UserEmail.Location = new System.Drawing.Point(152, 14);
            this.txb_UserEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txb_UserEmail.MinimumSize = new System.Drawing.Size(275, 4);
            this.txb_UserEmail.Name = "txb_UserEmail";
            this.txb_UserEmail.Size = new System.Drawing.Size(275, 30);
            this.txb_UserEmail.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(76, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "科別：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmPersonProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(254)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(452, 587);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPersonProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPersonProfile_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_UserAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txb_UserNewPwdCheck;
        private System.Windows.Forms.TextBox txb_UserNewPwd;
        private System.Windows.Forms.TextBox txb_UserOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_UserPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_UserEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.ComboBox cbb_UserJobID;
        private System.Windows.Forms.ComboBox cbb_UserDivisionID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}