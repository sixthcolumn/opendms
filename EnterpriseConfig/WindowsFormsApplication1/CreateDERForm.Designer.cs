namespace WindowsFormsApplication1
{
    partial class CreateDERForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DERView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wattCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DERGroupReactiveText = new System.Windows.Forms.TextBox();
            this.DERGroupRealText = new System.Windows.Forms.TextBox();
            this.DERGroupDeviceCountText = new System.Windows.Forms.TextBox();
            this.DERGroupSegmentText = new System.Windows.Forms.TextBox();
            this.DERGroupFeederText = new System.Windows.Forms.TextBox();
            this.DERGroupSubText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DERGroupNameText = new System.Windows.Forms.TextBox();
            this.DERGroupMRIDText = new System.Windows.Forms.TextBox();
            this.DERGroupRevisionText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.commentText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.messageTypeText = new System.Windows.Forms.TextBox();
            this.verbText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ackRequiredCheck = new System.Windows.Forms.CheckBox();
            this.contextText = new System.Windows.Forms.TextBox();
            this.organizationText = new System.Windows.Forms.TextBox();
            this.replyAddressText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endPointText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showXMLBox = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DERView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(288, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 34;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(207, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 33;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.DERView);
            this.groupBox3.Location = new System.Drawing.Point(3, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 143);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DERs";
            // 
            // DERView
            // 
            this.DERView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERView.AutoGenerateColumns = false;
            this.DERView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DERView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.mridDataGridViewTextBoxColumn,
            this.wattCapacityDataGridViewTextBoxColumn,
            this.varCapacityDataGridViewTextBoxColumn});
            this.DERView.DataSource = this.deviceBindingSource;
            this.DERView.Location = new System.Drawing.Point(8, 17);
            this.DERView.Name = "DERView";
            this.DERView.Size = new System.Drawing.Size(555, 115);
            this.DERView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mridDataGridViewTextBoxColumn
            // 
            this.mridDataGridViewTextBoxColumn.DataPropertyName = "Mrid";
            this.mridDataGridViewTextBoxColumn.HeaderText = "Mrid";
            this.mridDataGridViewTextBoxColumn.Name = "mridDataGridViewTextBoxColumn";
            // 
            // wattCapacityDataGridViewTextBoxColumn
            // 
            this.wattCapacityDataGridViewTextBoxColumn.DataPropertyName = "WattCapacity";
            this.wattCapacityDataGridViewTextBoxColumn.HeaderText = "WattCapacity";
            this.wattCapacityDataGridViewTextBoxColumn.Name = "wattCapacityDataGridViewTextBoxColumn";
            // 
            // varCapacityDataGridViewTextBoxColumn
            // 
            this.varCapacityDataGridViewTextBoxColumn.DataPropertyName = "VarCapacity";
            this.varCapacityDataGridViewTextBoxColumn.HeaderText = "VarCapacity";
            this.varCapacityDataGridViewTextBoxColumn.Name = "varCapacityDataGridViewTextBoxColumn";
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(DERMSInterface.CIMData.device);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DERGroupReactiveText);
            this.groupBox2.Controls.Add(this.DERGroupRealText);
            this.groupBox2.Controls.Add(this.DERGroupDeviceCountText);
            this.groupBox2.Controls.Add(this.DERGroupSegmentText);
            this.groupBox2.Controls.Add(this.DERGroupFeederText);
            this.groupBox2.Controls.Add(this.DERGroupSubText);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.DERGroupNameText);
            this.groupBox2.Controls.Add(this.DERGroupMRIDText);
            this.groupBox2.Controls.Add(this.DERGroupRevisionText);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(3, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 94);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DER Group";
            // 
            // DERGroupReactiveText
            // 
            this.DERGroupReactiveText.Location = new System.Drawing.Point(504, 38);
            this.DERGroupReactiveText.Name = "DERGroupReactiveText";
            this.DERGroupReactiveText.Size = new System.Drawing.Size(60, 20);
            this.DERGroupReactiveText.TabIndex = 50;
            // 
            // DERGroupRealText
            // 
            this.DERGroupRealText.Location = new System.Drawing.Point(504, 62);
            this.DERGroupRealText.Name = "DERGroupRealText";
            this.DERGroupRealText.Size = new System.Drawing.Size(60, 20);
            this.DERGroupRealText.TabIndex = 49;
            // 
            // DERGroupDeviceCountText
            // 
            this.DERGroupDeviceCountText.Location = new System.Drawing.Point(504, 15);
            this.DERGroupDeviceCountText.Name = "DERGroupDeviceCountText";
            this.DERGroupDeviceCountText.Size = new System.Drawing.Size(60, 20);
            this.DERGroupDeviceCountText.TabIndex = 48;
            // 
            // DERGroupSegmentText
            // 
            this.DERGroupSegmentText.Location = new System.Drawing.Point(289, 62);
            this.DERGroupSegmentText.Name = "DERGroupSegmentText";
            this.DERGroupSegmentText.Size = new System.Drawing.Size(124, 20);
            this.DERGroupSegmentText.TabIndex = 47;
            // 
            // DERGroupFeederText
            // 
            this.DERGroupFeederText.Location = new System.Drawing.Point(288, 38);
            this.DERGroupFeederText.Name = "DERGroupFeederText";
            this.DERGroupFeederText.Size = new System.Drawing.Size(124, 20);
            this.DERGroupFeederText.TabIndex = 46;
            // 
            // DERGroupSubText
            // 
            this.DERGroupSubText.Location = new System.Drawing.Point(288, 15);
            this.DERGroupSubText.Name = "DERGroupSubText";
            this.DERGroupSubText.Size = new System.Drawing.Size(124, 20);
            this.DERGroupSubText.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(421, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Total Reactive";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(442, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Total Real";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Feeder";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(234, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Segment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(426, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Device Count";
            // 
            // DERGroupNameText
            // 
            this.DERGroupNameText.Location = new System.Drawing.Point(60, 15);
            this.DERGroupNameText.Name = "DERGroupNameText";
            this.DERGroupNameText.Size = new System.Drawing.Size(165, 20);
            this.DERGroupNameText.TabIndex = 39;
            // 
            // DERGroupMRIDText
            // 
            this.DERGroupMRIDText.Location = new System.Drawing.Point(60, 38);
            this.DERGroupMRIDText.Name = "DERGroupMRIDText";
            this.DERGroupMRIDText.Size = new System.Drawing.Size(165, 20);
            this.DERGroupMRIDText.TabIndex = 38;
            // 
            // DERGroupRevisionText
            // 
            this.DERGroupRevisionText.Location = new System.Drawing.Point(60, 62);
            this.DERGroupRevisionText.Name = "DERGroupRevisionText";
            this.DERGroupRevisionText.Size = new System.Drawing.Size(67, 20);
            this.DERGroupRevisionText.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "MRID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Revision";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Substation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.commentText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.messageTypeText);
            this.groupBox1.Controls.Add(this.verbText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ackRequiredCheck);
            this.groupBox1.Controls.Add(this.contextText);
            this.groupBox1.Controls.Add(this.organizationText);
            this.groupBox1.Controls.Add(this.replyAddressText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userIDText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CIM Header";
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(337, 81);
            this.commentText.Multiline = true;
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(227, 66);
            this.commentText.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Comments";
            // 
            // messageTypeText
            // 
            this.messageTypeText.Location = new System.Drawing.Point(89, 13);
            this.messageTypeText.Name = "messageTypeText";
            this.messageTypeText.Size = new System.Drawing.Size(100, 20);
            this.messageTypeText.TabIndex = 36;
            // 
            // verbText
            // 
            this.verbText.Location = new System.Drawing.Point(195, 127);
            this.verbText.Name = "verbText";
            this.verbText.ReadOnly = true;
            this.verbText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.verbText.Size = new System.Drawing.Size(76, 20);
            this.verbText.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Verb";
            // 
            // ackRequiredCheck
            // 
            this.ackRequiredCheck.AutoSize = true;
            this.ackRequiredCheck.Location = new System.Drawing.Point(89, 130);
            this.ackRequiredCheck.Name = "ackRequiredCheck";
            this.ackRequiredCheck.Size = new System.Drawing.Size(15, 14);
            this.ackRequiredCheck.TabIndex = 33;
            this.ackRequiredCheck.UseVisualStyleBackColor = true;
            // 
            // contextText
            // 
            this.contextText.Location = new System.Drawing.Point(89, 104);
            this.contextText.Name = "contextText";
            this.contextText.Size = new System.Drawing.Size(182, 20);
            this.contextText.TabIndex = 32;
            // 
            // organizationText
            // 
            this.organizationText.Location = new System.Drawing.Point(89, 81);
            this.organizationText.Name = "organizationText";
            this.organizationText.Size = new System.Drawing.Size(182, 20);
            this.organizationText.TabIndex = 31;
            // 
            // replyAddressText
            // 
            this.replyAddressText.Location = new System.Drawing.Point(89, 35);
            this.replyAddressText.Name = "replyAddressText";
            this.replyAddressText.Size = new System.Drawing.Size(475, 20);
            this.replyAddressText.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Organization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reply Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Context";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ack Required";
            // 
            // userIDText
            // 
            this.userIDText.Location = new System.Drawing.Point(89, 58);
            this.userIDText.Name = "userIDText";
            this.userIDText.Size = new System.Drawing.Size(182, 20);
            this.userIDText.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Message Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Endpoint";
            // 
            // endPointText
            // 
            this.endPointText.Location = new System.Drawing.Point(88, 3);
            this.endPointText.Name = "endPointText";
            this.endPointText.Size = new System.Drawing.Size(475, 20);
            this.endPointText.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 484);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.endPointText);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 24);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showXMLBox);
            this.panel3.Controls.Add(this.createButton);
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Location = new System.Drawing.Point(3, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 29);
            this.panel3.TabIndex = 33;
            // 
            // showXMLBox
            // 
            this.showXMLBox.AutoSize = true;
            this.showXMLBox.Location = new System.Drawing.Point(3, 7);
            this.showXMLBox.Name = "showXMLBox";
            this.showXMLBox.Size = new System.Drawing.Size(78, 17);
            this.showXMLBox.TabIndex = 35;
            this.showXMLBox.Text = "Show XML";
            this.showXMLBox.UseVisualStyleBackColor = true;
            this.showXMLBox.CheckedChanged += new System.EventHandler(this.showXMLBox_CheckedChanged);
            // 
            // CreateDERForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateDERForm";
            this.Text = "CreateDERForm";
            this.Load += new System.EventHandler(this.FormLoad);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DERView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox verbText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ackRequiredCheck;
        private System.Windows.Forms.TextBox contextText;
        private System.Windows.Forms.TextBox organizationText;
        private System.Windows.Forms.TextBox endPointText;
        private System.Windows.Forms.TextBox replyAddressText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageTypeText;
        private System.Windows.Forms.TextBox commentText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DERView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wattCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DERGroupNameText;
        private System.Windows.Forms.TextBox DERGroupMRIDText;
        private System.Windows.Forms.TextBox DERGroupRevisionText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox DERGroupReactiveText;
        private System.Windows.Forms.TextBox DERGroupRealText;
        private System.Windows.Forms.TextBox DERGroupDeviceCountText;
        private System.Windows.Forms.TextBox DERGroupSegmentText;
        private System.Windows.Forms.TextBox DERGroupFeederText;
        private System.Windows.Forms.TextBox DERGroupSubText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox showXMLBox;
    }
}