using MyDB.MedicareDataSetTableAdapters;
namespace MyProgram
{
    partial class FrmEdit
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
            System.Windows.Forms.Label 病歷號碼Label;
            System.Windows.Forms.Label 用藥是否提醒Label;
            System.Windows.Forms.Label 檢驗是否提醒Label;
            System.Windows.Forms.Label vIPLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label 地址Label;
            System.Windows.Forms.Label 連絡電話Label;
            System.Windows.Forms.Label 出生年月日Label;
            System.Windows.Forms.Label 身分證字號Label;
            System.Windows.Forms.Label Ptt_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
            this.medicareDataSet = new MyDB.MedicareDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new MyDB.MedicareDataSetTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new MyDB.MedicareDataSetTableAdapters.TableAdapterManager();
            this.patientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.病歷號碼TextBox = new System.Windows.Forms.TextBox();
            this.用藥是否提醒CheckBox = new System.Windows.Forms.CheckBox();
            this.檢驗是否提醒CheckBox = new System.Windows.Forms.CheckBox();
            this.vIPCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.地址TextBox = new System.Windows.Forms.TextBox();
            this.連絡電話TextBox = new System.Windows.Forms.TextBox();
            this.出生年月日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.身分證字號TextBox = new System.Windows.Forms.TextBox();
            this.Ptt_NameTextBox = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            病歷號碼Label = new System.Windows.Forms.Label();
            用藥是否提醒Label = new System.Windows.Forms.Label();
            檢驗是否提醒Label = new System.Windows.Forms.Label();
            vIPLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            地址Label = new System.Windows.Forms.Label();
            連絡電話Label = new System.Windows.Forms.Label();
            出生年月日Label = new System.Windows.Forms.Label();
            身分證字號Label = new System.Windows.Forms.Label();
            Ptt_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // 病歷號碼Label
            // 
            病歷號碼Label.AutoSize = true;
            病歷號碼Label.Location = new System.Drawing.Point(57, 61);
            病歷號碼Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            病歷號碼Label.Name = "病歷號碼Label";
            病歷號碼Label.Size = new System.Drawing.Size(104, 19);
            病歷號碼Label.TabIndex = 21;
            病歷號碼Label.Text = "病歷號碼：";
            病歷號碼Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 用藥是否提醒Label
            // 
            用藥是否提醒Label.AutoSize = true;
            用藥是否提醒Label.Location = new System.Drawing.Point(19, 521);
            用藥是否提醒Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            用藥是否提醒Label.Name = "用藥是否提醒Label";
            用藥是否提醒Label.Size = new System.Drawing.Size(142, 19);
            用藥是否提醒Label.TabIndex = 19;
            用藥是否提醒Label.Text = "用藥是否提醒：";
            用藥是否提醒Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 檢驗是否提醒Label
            // 
            檢驗是否提醒Label.AutoSize = true;
            檢驗是否提醒Label.Location = new System.Drawing.Point(19, 475);
            檢驗是否提醒Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            檢驗是否提醒Label.Name = "檢驗是否提醒Label";
            檢驗是否提醒Label.Size = new System.Drawing.Size(142, 19);
            檢驗是否提醒Label.TabIndex = 17;
            檢驗是否提醒Label.Text = "檢驗是否提醒：";
            檢驗是否提醒Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vIPLabel
            // 
            vIPLabel.AutoSize = true;
            vIPLabel.Location = new System.Drawing.Point(104, 429);
            vIPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vIPLabel.Name = "vIPLabel";
            vIPLabel.Size = new System.Drawing.Size(57, 19);
            vIPLabel.TabIndex = 15;
            vIPLabel.Text = "VIP：";
            vIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(90, 383);
            emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(71, 19);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email：";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 地址Label
            // 
            地址Label.AutoSize = true;
            地址Label.Location = new System.Drawing.Point(95, 337);
            地址Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            地址Label.Name = "地址Label";
            地址Label.Size = new System.Drawing.Size(66, 19);
            地址Label.TabIndex = 11;
            地址Label.Text = "地址：";
            地址Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 連絡電話Label
            // 
            連絡電話Label.AutoSize = true;
            連絡電話Label.Location = new System.Drawing.Point(57, 291);
            連絡電話Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            連絡電話Label.Name = "連絡電話Label";
            連絡電話Label.Size = new System.Drawing.Size(104, 19);
            連絡電話Label.TabIndex = 9;
            連絡電話Label.Text = "連絡電話：";
            連絡電話Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 出生年月日Label
            // 
            出生年月日Label.AutoSize = true;
            出生年月日Label.Location = new System.Drawing.Point(38, 245);
            出生年月日Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            出生年月日Label.Name = "出生年月日Label";
            出生年月日Label.Size = new System.Drawing.Size(123, 19);
            出生年月日Label.TabIndex = 7;
            出生年月日Label.Text = "出生年月日：";
            出生年月日Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 身分證字號Label
            // 
            身分證字號Label.AutoSize = true;
            身分證字號Label.Location = new System.Drawing.Point(38, 153);
            身分證字號Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            身分證字號Label.Name = "身分證字號Label";
            身分證字號Label.Size = new System.Drawing.Size(123, 19);
            身分證字號Label.TabIndex = 5;
            身分證字號Label.Text = "身分證字號：";
            身分證字號Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ptt_NameLabel
            // 
            Ptt_NameLabel.AutoSize = true;
            Ptt_NameLabel.Location = new System.Drawing.Point(61, 107);
            Ptt_NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Ptt_NameLabel.Name = "Ptt_NameLabel";
            Ptt_NameLabel.Size = new System.Drawing.Size(104, 19);
            Ptt_NameLabel.TabIndex = 3;
            Ptt_NameLabel.Text = "病患姓名：";
            Ptt_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // medicareDataSet
            // 
            this.medicareDataSet.DataSetName = "MedicareDataSet";
            this.medicareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.medicareDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyDB.MedicareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientsBindingNavigator.BindingSource = this.patientsBindingSource;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientsBindingNavigatorSaveItem});
            this.patientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(659, 27);
            this.patientsBindingNavigator.TabIndex = 0;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
            this.patientsBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(80, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.patientsBindingNavigatorSaveItem.Text = "儲存資料";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientsBindingNavigatorSaveItem_Click);
            // 
            // 病歷號碼TextBox
            // 
            this.病歷號碼TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_Num", true));
            this.病歷號碼TextBox.Location = new System.Drawing.Point(171, 55);
            this.病歷號碼TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.病歷號碼TextBox.Name = "病歷號碼TextBox";
            this.病歷號碼TextBox.ReadOnly = true;
            this.病歷號碼TextBox.Size = new System.Drawing.Size(200, 30);
            this.病歷號碼TextBox.TabIndex = 0;
            // 
            // 用藥是否提醒CheckBox
            // 
            this.用藥是否提醒CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientsBindingSource, "Ptt_DrugRmd", true));
            this.用藥是否提醒CheckBox.Location = new System.Drawing.Point(171, 510);
            this.用藥是否提醒CheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.用藥是否提醒CheckBox.Name = "用藥是否提醒CheckBox";
            this.用藥是否提醒CheckBox.Size = new System.Drawing.Size(126, 40);
            this.用藥是否提醒CheckBox.TabIndex = 10;
            this.用藥是否提醒CheckBox.UseVisualStyleBackColor = true;
            // 
            // 檢驗是否提醒CheckBox
            // 
            this.檢驗是否提醒CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientsBindingSource, "Ptt_ExamRmd", true));
            this.檢驗是否提醒CheckBox.Location = new System.Drawing.Point(171, 464);
            this.檢驗是否提醒CheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.檢驗是否提醒CheckBox.Name = "檢驗是否提醒CheckBox";
            this.檢驗是否提醒CheckBox.Size = new System.Drawing.Size(126, 40);
            this.檢驗是否提醒CheckBox.TabIndex = 9;
            this.檢驗是否提醒CheckBox.UseVisualStyleBackColor = true;
            // 
            // vIPCheckBox
            // 
            this.vIPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientsBindingSource, "Ptt_VIP", true));
            this.vIPCheckBox.Location = new System.Drawing.Point(171, 418);
            this.vIPCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.vIPCheckBox.Name = "vIPCheckBox";
            this.vIPCheckBox.Size = new System.Drawing.Size(126, 40);
            this.vIPCheckBox.TabIndex = 8;
            this.vIPCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(171, 377);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 30);
            this.emailTextBox.TabIndex = 7;
            // 
            // 地址TextBox
            // 
            this.地址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_Addr", true));
            this.地址TextBox.Location = new System.Drawing.Point(171, 331);
            this.地址TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.地址TextBox.Name = "地址TextBox";
            this.地址TextBox.Size = new System.Drawing.Size(200, 30);
            this.地址TextBox.TabIndex = 6;
            // 
            // 連絡電話TextBox
            // 
            this.連絡電話TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_TN", true));
            this.連絡電話TextBox.Location = new System.Drawing.Point(171, 285);
            this.連絡電話TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.連絡電話TextBox.Name = "連絡電話TextBox";
            this.連絡電話TextBox.Size = new System.Drawing.Size(200, 30);
            this.連絡電話TextBox.TabIndex = 5;
            // 
            // 出生年月日DateTimePicker
            // 
            this.出生年月日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "Ptt_BD", true));
            this.出生年月日DateTimePicker.Location = new System.Drawing.Point(171, 239);
            this.出生年月日DateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.出生年月日DateTimePicker.Name = "出生年月日DateTimePicker";
            this.出生年月日DateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.出生年月日DateTimePicker.TabIndex = 4;
            // 
            // 身分證字號TextBox
            // 
            this.身分證字號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_PID", true));
            this.身分證字號TextBox.Location = new System.Drawing.Point(171, 147);
            this.身分證字號TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.身分證字號TextBox.Name = "身分證字號TextBox";
            this.身分證字號TextBox.ReadOnly = true;
            this.身分證字號TextBox.Size = new System.Drawing.Size(200, 30);
            this.身分證字號TextBox.TabIndex = 3;
            // 
            // Ptt_NameTextBox
            // 
            this.Ptt_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_Name", true));
            this.Ptt_NameTextBox.Location = new System.Drawing.Point(171, 101);
            this.Ptt_NameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Ptt_NameTextBox.Name = "Ptt_NameTextBox";
            this.Ptt_NameTextBox.Size = new System.Drawing.Size(200, 30);
            this.Ptt_NameTextBox.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(388, 54);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 40);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "確定";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 103);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 40);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ptt_Sex", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(171, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 27);
            this.comboBox1.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(95, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "性別：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "修改 病患資料";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(254)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(480, 558);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(Ptt_NameLabel);
            this.Controls.Add(this.Ptt_NameTextBox);
            this.Controls.Add(身分證字號Label);
            this.Controls.Add(this.身分證字號TextBox);
            this.Controls.Add(出生年月日Label);
            this.Controls.Add(this.出生年月日DateTimePicker);
            this.Controls.Add(連絡電話Label);
            this.Controls.Add(this.連絡電話TextBox);
            this.Controls.Add(地址Label);
            this.Controls.Add(this.地址TextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(vIPLabel);
            this.Controls.Add(檢驗是否提醒Label);
            this.Controls.Add(用藥是否提醒Label);
            this.Controls.Add(病歷號碼Label);
            this.Controls.Add(this.病歷號碼TextBox);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(this.vIPCheckBox);
            this.Controls.Add(this.檢驗是否提醒CheckBox);
            this.Controls.Add(this.用藥是否提醒CheckBox);
            this.Font = new System.Drawing.Font("新細明體", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯病患資料";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDB.MedicareDataSet medicareDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsTableAdapter patientsTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 病歷號碼TextBox;
        private System.Windows.Forms.CheckBox 用藥是否提醒CheckBox;
        private System.Windows.Forms.CheckBox 檢驗是否提醒CheckBox;
        private System.Windows.Forms.CheckBox vIPCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox 地址TextBox;
        private System.Windows.Forms.TextBox 連絡電話TextBox;
        private System.Windows.Forms.DateTimePicker 出生年月日DateTimePicker;
        private System.Windows.Forms.TextBox 身分證字號TextBox;
        private System.Windows.Forms.TextBox Ptt_NameTextBox;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}