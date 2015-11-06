namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DERs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nounText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.verbText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ackRequiredCheck = new System.Windows.Forms.CheckBox();
            this.commentText = new System.Windows.Forms.TextBox();
            this.contextText = new System.Windows.Forms.TextBox();
            this.organizationText = new System.Windows.Forms.TextBox();
            this.endPointText = new System.Windows.Forms.TextBox();
            this.replyAddressText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIDText = new System.Windows.Forms.TextBox();
            this.messageTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DERView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wattCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dERGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DERGroupsView = new System.Windows.Forms.DataGridView();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feederDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reactivePower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.getDERStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.DERs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DERView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERGroupBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DERGroupsView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDERToolStripMenuItem,
            this.dispatchDERToolStripMenuItem,
            this.getDERStatusToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // createDERToolStripMenuItem
            // 
            this.createDERToolStripMenuItem.Name = "createDERToolStripMenuItem";
            this.createDERToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createDERToolStripMenuItem.Text = "Create DER";
            this.createDERToolStripMenuItem.Click += new System.EventHandler(this.createDERToolStripMenuItem_Click);
            // 
            // dispatchDERToolStripMenuItem
            // 
            this.dispatchDERToolStripMenuItem.Name = "dispatchDERToolStripMenuItem";
            this.dispatchDERToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dispatchDERToolStripMenuItem.Text = "Dispatch DER";
            this.dispatchDERToolStripMenuItem.Click += new System.EventHandler(this.dispatchDERToolStripMenuItem_Click);
            // 
            // DERs
            // 
            this.DERs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERs.Controls.Add(this.tabPage1);
            this.DERs.Controls.Add(this.tabPage2);
            this.DERs.Location = new System.Drawing.Point(3, 0);
            this.DERs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.DERs.Name = "DERs";
            this.DERs.SelectedIndex = 0;
            this.DERs.Size = new System.Drawing.Size(632, 370);
            this.DERs.TabIndex = 2;
            this.DERs.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Headers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nounText);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.verbText);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ackRequiredCheck);
            this.panel1.Controls.Add(this.commentText);
            this.panel1.Controls.Add(this.contextText);
            this.panel1.Controls.Add(this.organizationText);
            this.panel1.Controls.Add(this.endPointText);
            this.panel1.Controls.Add(this.replyAddressText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userIDText);
            this.panel1.Controls.Add(this.messageTypeCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 310);
            this.panel1.TabIndex = 0;
            // 
            // nounText
            // 
            this.nounText.Location = new System.Drawing.Point(234, 113);
            this.nounText.Name = "nounText";
            this.nounText.ReadOnly = true;
            this.nounText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nounText.Size = new System.Drawing.Size(98, 20);
            this.nounText.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Noun";
            // 
            // verbText
            // 
            this.verbText.Location = new System.Drawing.Point(95, 113);
            this.verbText.Name = "verbText";
            this.verbText.ReadOnly = true;
            this.verbText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.verbText.Size = new System.Drawing.Size(76, 20);
            this.verbText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Verb";
            // 
            // ackRequiredCheck
            // 
            this.ackRequiredCheck.AutoSize = true;
            this.ackRequiredCheck.Location = new System.Drawing.Point(95, 92);
            this.ackRequiredCheck.Name = "ackRequiredCheck";
            this.ackRequiredCheck.Size = new System.Drawing.Size(15, 14);
            this.ackRequiredCheck.TabIndex = 4;
            this.ackRequiredCheck.UseVisualStyleBackColor = true;
            this.ackRequiredCheck.CheckedChanged += new System.EventHandler(this.ackRequiredCheck_CheckedChanged);
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(16, 161);
            this.commentText.Multiline = true;
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(327, 134);
            this.commentText.TabIndex = 8;
            this.commentText.TextChanged += new System.EventHandler(this.commentText_TextChanged);
            // 
            // contextText
            // 
            this.contextText.Location = new System.Drawing.Point(431, 89);
            this.contextText.Name = "contextText";
            this.contextText.Size = new System.Drawing.Size(182, 20);
            this.contextText.TabIndex = 7;
            this.contextText.TextChanged += new System.EventHandler(this.contextText_TextChanged);
            // 
            // organizationText
            // 
            this.organizationText.Location = new System.Drawing.Point(431, 62);
            this.organizationText.Name = "organizationText";
            this.organizationText.Size = new System.Drawing.Size(182, 20);
            this.organizationText.TabIndex = 6;
            this.organizationText.TextChanged += new System.EventHandler(this.organizationText_TextChanged);
            // 
            // endPointText
            // 
            this.endPointText.Location = new System.Drawing.Point(95, 40);
            this.endPointText.Name = "endPointText";
            this.endPointText.Size = new System.Drawing.Size(237, 20);
            this.endPointText.TabIndex = 2;
            this.endPointText.TextChanged += new System.EventHandler(this.endPointText_TextChanged);
            // 
            // replyAddressText
            // 
            this.replyAddressText.Location = new System.Drawing.Point(95, 66);
            this.replyAddressText.Name = "replyAddressText";
            this.replyAddressText.Size = new System.Drawing.Size(237, 20);
            this.replyAddressText.TabIndex = 3;
            this.replyAddressText.TextChanged += new System.EventHandler(this.replyAddressText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Comments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Endpoint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Organization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reply Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Context";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ack Required";
            // 
            // userIDText
            // 
            this.userIDText.Location = new System.Drawing.Point(431, 36);
            this.userIDText.Name = "userIDText";
            this.userIDText.Size = new System.Drawing.Size(182, 20);
            this.userIDText.TabIndex = 5;
            this.userIDText.TextChanged += new System.EventHandler(this.userIDText_TextChanged);
            // 
            // messageTypeCombo
            // 
            this.messageTypeCombo.FormattingEnabled = true;
            this.messageTypeCombo.Items.AddRange(new object[] {
            "createDER",
            "dispatchDER",
            "getDER",
            "getDERStatus"});
            this.messageTypeCombo.Location = new System.Drawing.Point(95, 13);
            this.messageTypeCombo.Name = "messageTypeCombo";
            this.messageTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.messageTypeCombo.TabIndex = 1;
            this.messageTypeCombo.Text = "createDER";
            this.messageTypeCombo.SelectedIndexChanged += new System.EventHandler(this.messageTypeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DER Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.DERView);
            this.groupBox1.Location = new System.Drawing.Point(3, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DERs";
            // 
            // DERView
            // 
            this.DERView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERView.AutoGenerateColumns = false;
            this.DERView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DERView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DERView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.mridDataGridViewTextBoxColumn1,
            this.wattCapacityDataGridViewTextBoxColumn,
            this.varCapacityDataGridViewTextBoxColumn});
            this.DERView.DataSource = this.devicesBindingSource;
            this.DERView.Location = new System.Drawing.Point(2, 15);
            this.DERView.Name = "DERView";
            this.DERView.Size = new System.Drawing.Size(604, 142);
            this.DERView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mridDataGridViewTextBoxColumn1
            // 
            this.mridDataGridViewTextBoxColumn1.DataPropertyName = "Mrid";
            this.mridDataGridViewTextBoxColumn1.HeaderText = "Mrid";
            this.mridDataGridViewTextBoxColumn1.Name = "mridDataGridViewTextBoxColumn1";
            // 
            // wattCapacityDataGridViewTextBoxColumn
            // 
            this.wattCapacityDataGridViewTextBoxColumn.DataPropertyName = "WattCapacity";
            this.wattCapacityDataGridViewTextBoxColumn.HeaderText = "Watts";
            this.wattCapacityDataGridViewTextBoxColumn.Name = "wattCapacityDataGridViewTextBoxColumn";
            // 
            // varCapacityDataGridViewTextBoxColumn
            // 
            this.varCapacityDataGridViewTextBoxColumn.DataPropertyName = "VarCapacity";
            this.varCapacityDataGridViewTextBoxColumn.HeaderText = "Variable";
            this.varCapacityDataGridViewTextBoxColumn.Name = "varCapacityDataGridViewTextBoxColumn";
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.dERGroupBindingSource;
            // 
            // dERGroupBindingSource
            // 
            this.dERGroupBindingSource.DataSource = typeof(DERMSInterface.CIMData.DERGroup);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.DERGroupsView);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DER Group";
            // 
            // DERGroupsView
            // 
            this.DERGroupsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERGroupsView.AutoGenerateColumns = false;
            this.DERGroupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DERGroupsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNameDataGridViewTextBoxColumn,
            this.mridDataGridViewTextBoxColumn,
            this.revisionDataGridViewTextBoxColumn,
            this.substationDataGridViewTextBoxColumn,
            this.feederDataGridViewTextBoxColumn,
            this.segmentDataGridViewTextBoxColumn,
            this.Members,
            this.realPower,
            this.reactivePower});
            this.DERGroupsView.DataSource = this.dERGroupBindingSource;
            this.DERGroupsView.Location = new System.Drawing.Point(6, 19);
            this.DERGroupsView.Name = "DERGroupsView";
            this.DERGroupsView.Size = new System.Drawing.Size(604, 138);
            this.DERGroupsView.TabIndex = 0;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // mridDataGridViewTextBoxColumn
            // 
            this.mridDataGridViewTextBoxColumn.DataPropertyName = "Mrid";
            this.mridDataGridViewTextBoxColumn.HeaderText = "Mrid";
            this.mridDataGridViewTextBoxColumn.Name = "mridDataGridViewTextBoxColumn";
            // 
            // revisionDataGridViewTextBoxColumn
            // 
            this.revisionDataGridViewTextBoxColumn.DataPropertyName = "Revision";
            this.revisionDataGridViewTextBoxColumn.HeaderText = "Revision";
            this.revisionDataGridViewTextBoxColumn.Name = "revisionDataGridViewTextBoxColumn";
            this.revisionDataGridViewTextBoxColumn.Width = 75;
            // 
            // substationDataGridViewTextBoxColumn
            // 
            this.substationDataGridViewTextBoxColumn.DataPropertyName = "Substation";
            this.substationDataGridViewTextBoxColumn.HeaderText = "Substation";
            this.substationDataGridViewTextBoxColumn.Name = "substationDataGridViewTextBoxColumn";
            // 
            // feederDataGridViewTextBoxColumn
            // 
            this.feederDataGridViewTextBoxColumn.DataPropertyName = "Feeder";
            this.feederDataGridViewTextBoxColumn.HeaderText = "Feeder";
            this.feederDataGridViewTextBoxColumn.Name = "feederDataGridViewTextBoxColumn";
            // 
            // segmentDataGridViewTextBoxColumn
            // 
            this.segmentDataGridViewTextBoxColumn.DataPropertyName = "Segment";
            this.segmentDataGridViewTextBoxColumn.HeaderText = "Segment";
            this.segmentDataGridViewTextBoxColumn.Name = "segmentDataGridViewTextBoxColumn";
            // 
            // Members
            // 
            this.Members.HeaderText = "Devices";
            this.Members.Name = "Members";
            this.Members.ReadOnly = true;
            this.Members.Width = 60;
            // 
            // realPower
            // 
            this.realPower.HeaderText = "Real Power";
            this.realPower.Name = "realPower";
            this.realPower.ReadOnly = true;
            this.realPower.Width = 75;
            // 
            // reactivePower
            // 
            this.reactivePower.HeaderText = "Reactive Power";
            this.reactivePower.Name = "reactivePower";
            this.reactivePower.ReadOnly = true;
            this.reactivePower.Width = 75;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.DERs, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 397);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 373);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(632, 21);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // getDERStatusToolStripMenuItem
            // 
            this.getDERStatusToolStripMenuItem.Name = "getDERStatusToolStripMenuItem";
            this.getDERStatusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getDERStatusToolStripMenuItem.Text = "Get DER Status";
            this.getDERStatusToolStripMenuItem.Click += new System.EventHandler(this.getDERStatusToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 424);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Enterprise Config";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DERs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DERView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERGroupBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DERGroupsView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl DERs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox verbText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ackRequiredCheck;
        private System.Windows.Forms.TextBox commentText;
        private System.Windows.Forms.TextBox contextText;
        private System.Windows.Forms.TextBox organizationText;
        private System.Windows.Forms.TextBox endPointText;
        private System.Windows.Forms.TextBox replyAddressText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIDText;
        private System.Windows.Forms.ComboBox messageTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DERGroupsView;
        private System.Windows.Forms.BindingSource dERGroupBindingSource;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DERView;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn substationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feederDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Members;
        private System.Windows.Forms.DataGridViewTextBoxColumn realPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn reactivePower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wattCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchDERToolStripMenuItem;
        private System.Windows.Forms.TextBox nounText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem getDERStatusToolStripMenuItem;
    }
}

