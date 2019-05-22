namespace CProj
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.refreshGoods = new System.Windows.Forms.Button();
            this.labelGoods = new System.Windows.Forms.Label();
            this.searchGoods = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.columnBox = new System.Windows.Forms.ComboBox();
            this.confirmGoods = new System.Windows.Forms.Button();
            this.goodsTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshSuppliers = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchSuppliers = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSuppliers = new System.Windows.Forms.Label();
            this.confirmSuppliers = new System.Windows.Forms.Button();
            this.suppliersTable = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.refreshClients = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.operationBoxClients = new System.Windows.Forms.ComboBox();
            this.columnBoxClients = new System.Windows.Forms.ComboBox();
            this.labelClients = new System.Windows.Forms.Label();
            this.searchClients = new System.Windows.Forms.Button();
            this.confirmClients = new System.Windows.Forms.Button();
            this.clientsTable = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.buttonRemGoods = new System.Windows.Forms.Button();
            this.textRemGoods = new System.Windows.Forms.TextBox();
            this.remGoods = new System.Windows.Forms.Label();
            this.remSuppliers = new System.Windows.Forms.Label();
            this.textRemSuppliers = new System.Windows.Forms.TextBox();
            this.buttonRemSuppliers = new System.Windows.Forms.Button();
            this.buttonRemClients = new System.Windows.Forms.Button();
            this.remClients = new System.Windows.Forms.Label();
            this.textRemClients = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 537);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.remGoods);
            this.tabPage1.Controls.Add(this.textRemGoods);
            this.tabPage1.Controls.Add(this.buttonRemGoods);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.refreshGoods);
            this.tabPage1.Controls.Add(this.labelGoods);
            this.tabPage1.Controls.Add(this.searchGoods);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.operationBox);
            this.tabPage1.Controls.Add(this.columnBox);
            this.tabPage1.Controls.Add(this.confirmGoods);
            this.tabPage1.Controls.Add(this.goodsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Are you sure?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(114, 482);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // refreshGoods
            // 
            this.refreshGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshGoods.Location = new System.Drawing.Point(600, 406);
            this.refreshGoods.Name = "refreshGoods";
            this.refreshGoods.Size = new System.Drawing.Size(114, 45);
            this.refreshGoods.TabIndex = 7;
            this.refreshGoods.Text = "Refresh table";
            this.refreshGoods.UseVisualStyleBackColor = true;
            this.refreshGoods.Click += new System.EventHandler(this.RefreshGoods_Click);
            // 
            // labelGoods
            // 
            this.labelGoods.AutoSize = true;
            this.labelGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoods.Location = new System.Drawing.Point(9, 418);
            this.labelGoods.Name = "labelGoods";
            this.labelGoods.Size = new System.Drawing.Size(55, 18);
            this.labelGoods.TabIndex = 6;
            this.labelGoods.Text = "Search";
            // 
            // searchGoods
            // 
            this.searchGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchGoods.Location = new System.Drawing.Point(339, 415);
            this.searchGoods.Name = "searchGoods";
            this.searchGoods.Size = new System.Drawing.Size(85, 26);
            this.searchGoods.TabIndex = 5;
            this.searchGoods.Text = "OK";
            this.searchGoods.UseVisualStyleBackColor = true;
            this.searchGoods.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(233, 415);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // operationBox
            // 
            this.operationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Location = new System.Drawing.Point(198, 415);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(30, 26);
            this.operationBox.TabIndex = 3;
            this.operationBox.SelectedIndexChanged += new System.EventHandler(this.OperationBox_SelectedIndexChanged);
            // 
            // columnBox
            // 
            this.columnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnBox.FormattingEnabled = true;
            this.columnBox.Location = new System.Drawing.Point(70, 415);
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(120, 26);
            this.columnBox.TabIndex = 2;
            this.columnBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // confirmGoods
            // 
            this.confirmGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmGoods.Location = new System.Drawing.Point(12, 453);
            this.confirmGoods.Name = "confirmGoods";
            this.confirmGoods.Size = new System.Drawing.Size(412, 24);
            this.confirmGoods.TabIndex = 1;
            this.confirmGoods.Text = "Confirm update";
            this.confirmGoods.UseVisualStyleBackColor = true;
            this.confirmGoods.Click += new System.EventHandler(this.ConfirmGoods_Click);
            // 
            // goodsTable
            // 
            this.goodsTable.AllowUserToResizeColumns = false;
            this.goodsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsTable.Location = new System.Drawing.Point(6, 6);
            this.goodsTable.Name = "goodsTable";
            this.goodsTable.Size = new System.Drawing.Size(761, 385);
            this.goodsTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonRemSuppliers);
            this.tabPage2.Controls.Add(this.textRemSuppliers);
            this.tabPage2.Controls.Add(this.remSuppliers);
            this.tabPage2.Controls.Add(this.refreshSuppliers);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.searchSuppliers);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.labelSuppliers);
            this.tabPage2.Controls.Add(this.confirmSuppliers);
            this.tabPage2.Controls.Add(this.suppliersTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refreshSuppliers
            // 
            this.refreshSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshSuppliers.Location = new System.Drawing.Point(600, 406);
            this.refreshSuppliers.Name = "refreshSuppliers";
            this.refreshSuppliers.Size = new System.Drawing.Size(114, 45);
            this.refreshSuppliers.TabIndex = 9;
            this.refreshSuppliers.Text = "Refresh table";
            this.refreshSuppliers.UseVisualStyleBackColor = true;
            this.refreshSuppliers.Click += new System.EventHandler(this.RefreshSuppliers_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(114, 482);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 22);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Yes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Are you sure?";
            // 
            // searchSuppliers
            // 
            this.searchSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSuppliers.Location = new System.Drawing.Point(339, 415);
            this.searchSuppliers.Name = "searchSuppliers";
            this.searchSuppliers.Size = new System.Drawing.Size(85, 26);
            this.searchSuppliers.TabIndex = 6;
            this.searchSuppliers.Text = "OK";
            this.searchSuppliers.UseVisualStyleBackColor = true;
            this.searchSuppliers.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(233, 415);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(198, 415);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(30, 26);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // labelSuppliers
            // 
            this.labelSuppliers.AutoSize = true;
            this.labelSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuppliers.Location = new System.Drawing.Point(9, 418);
            this.labelSuppliers.Name = "labelSuppliers";
            this.labelSuppliers.Size = new System.Drawing.Size(55, 18);
            this.labelSuppliers.TabIndex = 2;
            this.labelSuppliers.Text = "Search";
            // 
            // confirmSuppliers
            // 
            this.confirmSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmSuppliers.Location = new System.Drawing.Point(12, 453);
            this.confirmSuppliers.Name = "confirmSuppliers";
            this.confirmSuppliers.Size = new System.Drawing.Size(412, 24);
            this.confirmSuppliers.TabIndex = 1;
            this.confirmSuppliers.Text = "Confirm update";
            this.confirmSuppliers.UseVisualStyleBackColor = true;
            this.confirmSuppliers.Click += new System.EventHandler(this.ConfirmSuppliers_Click);
            // 
            // suppliersTable
            // 
            this.suppliersTable.AllowUserToResizeColumns = false;
            this.suppliersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersTable.Location = new System.Drawing.Point(6, 6);
            this.suppliersTable.Name = "suppliersTable";
            this.suppliersTable.Size = new System.Drawing.Size(761, 385);
            this.suppliersTable.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textRemClients);
            this.tabPage3.Controls.Add(this.remClients);
            this.tabPage3.Controls.Add(this.buttonRemClients);
            this.tabPage3.Controls.Add(this.refreshClients);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.operationBoxClients);
            this.tabPage3.Controls.Add(this.columnBoxClients);
            this.tabPage3.Controls.Add(this.labelClients);
            this.tabPage3.Controls.Add(this.searchClients);
            this.tabPage3.Controls.Add(this.confirmClients);
            this.tabPage3.Controls.Add(this.clientsTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(773, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // refreshClients
            // 
            this.refreshClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshClients.Location = new System.Drawing.Point(600, 406);
            this.refreshClients.Name = "refreshClients";
            this.refreshClients.Size = new System.Drawing.Size(114, 45);
            this.refreshClients.TabIndex = 9;
            this.refreshClients.Text = "Refresh table";
            this.refreshClients.UseVisualStyleBackColor = true;
            this.refreshClients.Click += new System.EventHandler(this.RefreshClients_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Are you sure?";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(114, 482);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(52, 22);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Yes";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(233, 415);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // operationBoxClients
            // 
            this.operationBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationBoxClients.FormattingEnabled = true;
            this.operationBoxClients.Location = new System.Drawing.Point(198, 415);
            this.operationBoxClients.Name = "operationBoxClients";
            this.operationBoxClients.Size = new System.Drawing.Size(30, 26);
            this.operationBoxClients.TabIndex = 5;
            this.operationBoxClients.SelectedIndexChanged += new System.EventHandler(this.OperationBoxClients_SelectedIndexChanged);
            // 
            // columnBoxClients
            // 
            this.columnBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnBoxClients.FormattingEnabled = true;
            this.columnBoxClients.Location = new System.Drawing.Point(70, 415);
            this.columnBoxClients.Name = "columnBoxClients";
            this.columnBoxClients.Size = new System.Drawing.Size(120, 26);
            this.columnBoxClients.TabIndex = 4;
            this.columnBoxClients.SelectedIndexChanged += new System.EventHandler(this.ColumnBoxClients_SelectedIndexChanged);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClients.Location = new System.Drawing.Point(9, 418);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(55, 18);
            this.labelClients.TabIndex = 3;
            this.labelClients.Text = "Search";
            // 
            // searchClients
            // 
            this.searchClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchClients.Location = new System.Drawing.Point(339, 415);
            this.searchClients.Name = "searchClients";
            this.searchClients.Size = new System.Drawing.Size(85, 26);
            this.searchClients.TabIndex = 2;
            this.searchClients.Text = "OK";
            this.searchClients.UseVisualStyleBackColor = true;
            this.searchClients.Click += new System.EventHandler(this.SearchClients_Click);
            // 
            // confirmClients
            // 
            this.confirmClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmClients.Location = new System.Drawing.Point(12, 453);
            this.confirmClients.Name = "confirmClients";
            this.confirmClients.Size = new System.Drawing.Size(412, 24);
            this.confirmClients.TabIndex = 1;
            this.confirmClients.Text = "Confirm update";
            this.confirmClients.UseVisualStyleBackColor = true;
            this.confirmClients.Click += new System.EventHandler(this.ConfirmClients_Click);
            // 
            // clientsTable
            // 
            this.clientsTable.AllowUserToResizeColumns = false;
            this.clientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsTable.Location = new System.Drawing.Point(6, 6);
            this.clientsTable.Name = "clientsTable";
            this.clientsTable.Size = new System.Drawing.Size(761, 385);
            this.clientsTable.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.ordersTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(773, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(594, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 108);
            this.listBox1.TabIndex = 1;
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            this.ordersTable.AllowUserToResizeColumns = false;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Location = new System.Drawing.Point(6, 6);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.ReadOnly = true;
            this.ordersTable.Size = new System.Drawing.Size(541, 278);
            this.ordersTable.TabIndex = 0;
            // 
            // buttonRemGoods
            // 
            this.buttonRemGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemGoods.Location = new System.Drawing.Point(637, 461);
            this.buttonRemGoods.Name = "buttonRemGoods";
            this.buttonRemGoods.Size = new System.Drawing.Size(77, 24);
            this.buttonRemGoods.TabIndex = 10;
            this.buttonRemGoods.Text = "Remove";
            this.buttonRemGoods.UseVisualStyleBackColor = true;
            this.buttonRemGoods.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textRemGoods
            // 
            this.textRemGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRemGoods.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textRemGoods.Location = new System.Drawing.Point(600, 461);
            this.textRemGoods.Multiline = true;
            this.textRemGoods.Name = "textRemGoods";
            this.textRemGoods.Size = new System.Drawing.Size(30, 24);
            this.textRemGoods.TabIndex = 11;
            // 
            // remGoods
            // 
            this.remGoods.AutoSize = true;
            this.remGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remGoods.Location = new System.Drawing.Point(504, 464);
            this.remGoods.Name = "remGoods";
            this.remGoods.Size = new System.Drawing.Size(90, 18);
            this.remGoods.TabIndex = 12;
            this.remGoods.Text = "CodeGoods";
            // 
            // remSuppliers
            // 
            this.remSuppliers.AutoSize = true;
            this.remSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remSuppliers.Location = new System.Drawing.Point(489, 464);
            this.remSuppliers.Name = "remSuppliers";
            this.remSuppliers.Size = new System.Drawing.Size(105, 18);
            this.remSuppliers.TabIndex = 10;
            this.remSuppliers.Text = "CodeSuppliers";
            // 
            // textRemSuppliers
            // 
            this.textRemSuppliers.Location = new System.Drawing.Point(600, 461);
            this.textRemSuppliers.Multiline = true;
            this.textRemSuppliers.Name = "textRemSuppliers";
            this.textRemSuppliers.Size = new System.Drawing.Size(30, 24);
            this.textRemSuppliers.TabIndex = 11;
            // 
            // buttonRemSuppliers
            // 
            this.buttonRemSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemSuppliers.Location = new System.Drawing.Point(637, 461);
            this.buttonRemSuppliers.Name = "buttonRemSuppliers";
            this.buttonRemSuppliers.Size = new System.Drawing.Size(77, 24);
            this.buttonRemSuppliers.TabIndex = 12;
            this.buttonRemSuppliers.Text = "Remove";
            this.buttonRemSuppliers.UseVisualStyleBackColor = true;
            this.buttonRemSuppliers.Click += new System.EventHandler(this.ButtonRemSuppliers_Click);
            // 
            // buttonRemClients
            // 
            this.buttonRemClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemClients.Location = new System.Drawing.Point(637, 461);
            this.buttonRemClients.Name = "buttonRemClients";
            this.buttonRemClients.Size = new System.Drawing.Size(77, 24);
            this.buttonRemClients.TabIndex = 10;
            this.buttonRemClients.Text = "Remove";
            this.buttonRemClients.UseVisualStyleBackColor = true;
            this.buttonRemClients.Click += new System.EventHandler(this.ButtonRemClients_Click);
            // 
            // remClients
            // 
            this.remClients.AutoSize = true;
            this.remClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remClients.Location = new System.Drawing.Point(504, 464);
            this.remClients.Name = "remClients";
            this.remClients.Size = new System.Drawing.Size(89, 18);
            this.remClients.TabIndex = 11;
            this.remClients.Text = "CodeClients";
            // 
            // textRemClients
            // 
            this.textRemClients.Location = new System.Drawing.Point(600, 461);
            this.textRemClients.Multiline = true;
            this.textRemClients.Name = "textRemClients";
            this.textRemClients.Size = new System.Drawing.Size(30, 24);
            this.textRemClients.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 541);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarketApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView goodsTable;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView suppliersTable;
        private System.Windows.Forms.DataGridView clientsTable;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.Button confirmGoods;
        private System.Windows.Forms.Button confirmSuppliers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox operationBox;
        private System.Windows.Forms.ComboBox columnBox;
        private System.Windows.Forms.Button confirmClients;
        private System.Windows.Forms.Button searchGoods;
        private System.Windows.Forms.Label labelGoods;
        private System.Windows.Forms.Button searchSuppliers;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSuppliers;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox operationBoxClients;
        private System.Windows.Forms.ComboBox columnBoxClients;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Button searchClients;
        private System.Windows.Forms.Button refreshGoods;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshSuppliers;
        private System.Windows.Forms.Button refreshClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textRemGoods;
        private System.Windows.Forms.Button buttonRemGoods;
        private System.Windows.Forms.Label remGoods;
        private System.Windows.Forms.Button buttonRemSuppliers;
        private System.Windows.Forms.TextBox textRemSuppliers;
        private System.Windows.Forms.Label remSuppliers;
        private System.Windows.Forms.TextBox textRemClients;
        private System.Windows.Forms.Label remClients;
        private System.Windows.Forms.Button buttonRemClients;
    }
}

