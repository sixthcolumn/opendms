namespace DMSConfig
{
    partial class MultiSpeakMsgHeaderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.versionGroupBox = new System.Windows.Forms.GroupBox();
            this.buildStringCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.branchText = new System.Windows.Forms.TextBox();
            this.buildText = new System.Windows.Forms.TextBox();
            this.minorVersionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.majorVersionText = new System.Windows.Forms.TextBox();
            this.callerGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sysgtemIDText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.auditPasswordText = new System.Windows.Forms.TextBox();
            this.appNameText = new System.Windows.Forms.TextBox();
            this.auditIDText = new System.Windows.Forms.TextBox();
            this.appVersionText = new System.Windows.Forms.TextBox();
            this.companyText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codeGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeNameTypeCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.namePartText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.codeValueText = new System.Windows.Forms.TextBox();
            this.CoordinateSystemGroupBox = new System.Windows.Forms.GroupBox();
            this.CSAuthGroupBox = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.CSAuthorityNameValueText = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.CSAuthorityNameOtherText = new System.Windows.Forms.TextBox();
            this.CSGroupBox = new System.Windows.Forms.GroupBox();
            this.CSUnitsCombo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.CSUnitsOtherText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.datumText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.versionGroupBox.SuspendLayout();
            this.callerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.codeGroupBox.SuspendLayout();
            this.CoordinateSystemGroupBox.SuspendLayout();
            this.CSAuthGroupBox.SuspendLayout();
            this.CSGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(420, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 1;
            // 
            // versionGroupBox
            // 
            this.versionGroupBox.Controls.Add(this.buildStringCombo);
            this.versionGroupBox.Controls.Add(this.label5);
            this.versionGroupBox.Controls.Add(this.label4);
            this.versionGroupBox.Controls.Add(this.label3);
            this.versionGroupBox.Controls.Add(this.branchText);
            this.versionGroupBox.Controls.Add(this.buildText);
            this.versionGroupBox.Controls.Add(this.minorVersionText);
            this.versionGroupBox.Controls.Add(this.label2);
            this.versionGroupBox.Controls.Add(this.label1);
            this.versionGroupBox.Controls.Add(this.majorVersionText);
            this.versionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.versionGroupBox.Name = "versionGroupBox";
            this.versionGroupBox.Size = new System.Drawing.Size(209, 164);
            this.versionGroupBox.TabIndex = 2;
            this.versionGroupBox.TabStop = false;
            this.versionGroupBox.Text = "MultiSpeakVersion";
            // 
            // buildStringCombo
            // 
            this.buildStringCombo.DisplayMember = "Branch;PR";
            this.buildStringCombo.FormattingEnabled = true;
            this.buildStringCombo.Items.AddRange(new object[] {
            "Branch",
            "PR",
            "RC",
            "RD",
            "Release"});
            this.buildStringCombo.Location = new System.Drawing.Point(87, 137);
            this.buildStringCombo.Name = "buildStringCombo";
            this.buildStringCombo.Size = new System.Drawing.Size(100, 21);
            this.buildStringCombo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Build";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MinorVersion";
            // 
            // branchText
            // 
            this.branchText.Location = new System.Drawing.Point(87, 107);
            this.branchText.Name = "branchText";
            this.branchText.Size = new System.Drawing.Size(100, 20);
            this.branchText.TabIndex = 5;
            // 
            // buildText
            // 
            this.buildText.Location = new System.Drawing.Point(87, 80);
            this.buildText.Name = "buildText";
            this.buildText.Size = new System.Drawing.Size(100, 20);
            this.buildText.TabIndex = 4;
            // 
            // minorVersionText
            // 
            this.minorVersionText.Location = new System.Drawing.Point(87, 53);
            this.minorVersionText.Name = "minorVersionText";
            this.minorVersionText.Size = new System.Drawing.Size(100, 20);
            this.minorVersionText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BuildString";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MajorVersion";
            // 
            // majorVersionText
            // 
            this.majorVersionText.Location = new System.Drawing.Point(87, 26);
            this.majorVersionText.Name = "majorVersionText";
            this.majorVersionText.Size = new System.Drawing.Size(100, 20);
            this.majorVersionText.TabIndex = 0;
            // 
            // callerGroupBox
            // 
            this.callerGroupBox.Controls.Add(this.label12);
            this.callerGroupBox.Controls.Add(this.label11);
            this.callerGroupBox.Controls.Add(this.label7);
            this.callerGroupBox.Controls.Add(this.label8);
            this.callerGroupBox.Controls.Add(this.label9);
            this.callerGroupBox.Controls.Add(this.label10);
            this.callerGroupBox.Controls.Add(this.sysgtemIDText);
            this.callerGroupBox.Controls.Add(this.passwordText);
            this.callerGroupBox.Controls.Add(this.label6);
            this.callerGroupBox.Controls.Add(this.auditPasswordText);
            this.callerGroupBox.Controls.Add(this.appNameText);
            this.callerGroupBox.Controls.Add(this.auditIDText);
            this.callerGroupBox.Controls.Add(this.appVersionText);
            this.callerGroupBox.Controls.Add(this.companyText);
            this.callerGroupBox.Location = new System.Drawing.Point(3, 173);
            this.callerGroupBox.Name = "callerGroupBox";
            this.callerGroupBox.Size = new System.Drawing.Size(209, 229);
            this.callerGroupBox.TabIndex = 3;
            this.callerGroupBox.TabStop = false;
            this.callerGroupBox.Text = "Caller";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "SystemID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "AuditPassword";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "AuditID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Company";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "AppName";
            // 
            // sysgtemIDText
            // 
            this.sysgtemIDText.Location = new System.Drawing.Point(92, 165);
            this.sysgtemIDText.Name = "sysgtemIDText";
            this.sysgtemIDText.Size = new System.Drawing.Size(100, 20);
            this.sysgtemIDText.TabIndex = 17;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(92, 191);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "AppVersion";
            // 
            // auditPasswordText
            // 
            this.auditPasswordText.Location = new System.Drawing.Point(92, 139);
            this.auditPasswordText.Name = "auditPasswordText";
            this.auditPasswordText.Size = new System.Drawing.Size(100, 20);
            this.auditPasswordText.TabIndex = 15;
            // 
            // appNameText
            // 
            this.appNameText.Location = new System.Drawing.Point(91, 31);
            this.appNameText.Name = "appNameText";
            this.appNameText.Size = new System.Drawing.Size(100, 20);
            this.appNameText.TabIndex = 11;
            // 
            // auditIDText
            // 
            this.auditIDText.Location = new System.Drawing.Point(91, 112);
            this.auditIDText.Name = "auditIDText";
            this.auditIDText.Size = new System.Drawing.Size(100, 20);
            this.auditIDText.TabIndex = 14;
            // 
            // appVersionText
            // 
            this.appVersionText.Location = new System.Drawing.Point(91, 58);
            this.appVersionText.Name = "appVersionText";
            this.appVersionText.Size = new System.Drawing.Size(100, 20);
            this.appVersionText.TabIndex = 12;
            // 
            // companyText
            // 
            this.companyText.Location = new System.Drawing.Point(91, 85);
            this.companyText.Name = "companyText";
            this.companyText.Size = new System.Drawing.Size(100, 20);
            this.companyText.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.versionGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.callerGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.codeGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CoordinateSystemGroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 443);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // codeGroupBox
            // 
            this.codeGroupBox.Controls.Add(this.CodeNameTypeCombo);
            this.codeGroupBox.Controls.Add(this.label13);
            this.codeGroupBox.Controls.Add(this.descriptionText);
            this.codeGroupBox.Controls.Add(this.label14);
            this.codeGroupBox.Controls.Add(this.namePartText);
            this.codeGroupBox.Controls.Add(this.label15);
            this.codeGroupBox.Controls.Add(this.label16);
            this.codeGroupBox.Controls.Add(this.codeValueText);
            this.codeGroupBox.Location = new System.Drawing.Point(223, 3);
            this.codeGroupBox.Name = "codeGroupBox";
            this.codeGroupBox.Size = new System.Drawing.Size(215, 164);
            this.codeGroupBox.TabIndex = 4;
            this.codeGroupBox.TabStop = false;
            this.codeGroupBox.Text = "CodeNames";
            this.codeGroupBox.Enter += new System.EventHandler(this.codeGroupBox_Enter);
            // 
            // CodeNameTypeCombo
            // 
            this.CodeNameTypeCombo.FormattingEnabled = true;
            this.CodeNameTypeCombo.Items.AddRange(new object[] {
            "GlobalDomain",
            "RegisteredName",
            "SystemName",
            "NounType",
            "Other"});
            this.CodeNameTypeCombo.Location = new System.Drawing.Point(94, 19);
            this.CodeNameTypeCombo.Name = "CodeNameTypeCombo";
            this.CodeNameTypeCombo.Size = new System.Drawing.Size(100, 21);
            this.CodeNameTypeCombo.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Description";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(94, 104);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(100, 20);
            this.descriptionText.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "NamePart";
            // 
            // namePartText
            // 
            this.namePartText.Location = new System.Drawing.Point(94, 77);
            this.namePartText.Name = "namePartText";
            this.namePartText.Size = new System.Drawing.Size(100, 20);
            this.namePartText.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "CodeValue";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "CodeNameType";
            // 
            // codeValueText
            // 
            this.codeValueText.Location = new System.Drawing.Point(94, 50);
            this.codeValueText.Name = "codeValueText";
            this.codeValueText.Size = new System.Drawing.Size(100, 20);
            this.codeValueText.TabIndex = 12;
            // 
            // CoordinateSystemGroupBox
            // 
            this.CoordinateSystemGroupBox.Controls.Add(this.CSAuthGroupBox);
            this.CoordinateSystemGroupBox.Controls.Add(this.CSGroupBox);
            this.CoordinateSystemGroupBox.Controls.Add(this.label18);
            this.CoordinateSystemGroupBox.Controls.Add(this.datumText);
            this.CoordinateSystemGroupBox.Location = new System.Drawing.Point(223, 173);
            this.CoordinateSystemGroupBox.Name = "CoordinateSystemGroupBox";
            this.CoordinateSystemGroupBox.Size = new System.Drawing.Size(215, 234);
            this.CoordinateSystemGroupBox.TabIndex = 5;
            this.CoordinateSystemGroupBox.TabStop = false;
            this.CoordinateSystemGroupBox.Text = "CoordinateSystemInfo";
            // 
            // CSAuthGroupBox
            // 
            this.CSAuthGroupBox.Controls.Add(this.label23);
            this.CSAuthGroupBox.Controls.Add(this.CSAuthorityNameValueText);
            this.CSAuthGroupBox.Controls.Add(this.label24);
            this.CSAuthGroupBox.Controls.Add(this.CSAuthorityNameOtherText);
            this.CSAuthGroupBox.Location = new System.Drawing.Point(7, 111);
            this.CSAuthGroupBox.Name = "CSAuthGroupBox";
            this.CSAuthGroupBox.Size = new System.Drawing.Size(200, 80);
            this.CSAuthGroupBox.TabIndex = 29;
            this.CSAuthGroupBox.TabStop = false;
            this.CSAuthGroupBox.Text = "CSAuthorityName";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "OtherKind (attr)";
            // 
            // CSAuthorityNameValueText
            // 
            this.CSAuthorityNameValueText.Location = new System.Drawing.Point(91, 45);
            this.CSAuthorityNameValueText.Name = "CSAuthorityNameValueText";
            this.CSAuthorityNameValueText.Size = new System.Drawing.Size(100, 20);
            this.CSAuthorityNameValueText.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Value";
            // 
            // CSAuthorityNameOtherText
            // 
            this.CSAuthorityNameOtherText.Location = new System.Drawing.Point(91, 18);
            this.CSAuthorityNameOtherText.Name = "CSAuthorityNameOtherText";
            this.CSAuthorityNameOtherText.Size = new System.Drawing.Size(100, 20);
            this.CSAuthorityNameOtherText.TabIndex = 20;
            // 
            // CSGroupBox
            // 
            this.CSGroupBox.Controls.Add(this.CSUnitsCombo);
            this.CSGroupBox.Controls.Add(this.label21);
            this.CSGroupBox.Controls.Add(this.label22);
            this.CSGroupBox.Controls.Add(this.CSUnitsOtherText);
            this.CSGroupBox.Location = new System.Drawing.Point(7, 25);
            this.CSGroupBox.Name = "CSGroupBox";
            this.CSGroupBox.Size = new System.Drawing.Size(200, 80);
            this.CSGroupBox.TabIndex = 28;
            this.CSGroupBox.TabStop = false;
            this.CSGroupBox.Text = "CSUnits";
            // 
            // CSUnitsCombo
            // 
            this.CSUnitsCombo.FormattingEnabled = true;
            this.CSUnitsCombo.Items.AddRange(new object[] {
            "Feet",
            "Meters",
            "USSurveyFeet",
            "Other"});
            this.CSUnitsCombo.Location = new System.Drawing.Point(92, 45);
            this.CSUnitsCombo.Name = "CSUnitsCombo";
            this.CSUnitsCombo.Size = new System.Drawing.Size(99, 21);
            this.CSUnitsCombo.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "OtherKind (attr)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Value";
            // 
            // CSUnitsOtherText
            // 
            this.CSUnitsOtherText.Location = new System.Drawing.Point(91, 18);
            this.CSUnitsOtherText.Name = "CSUnitsOtherText";
            this.CSUnitsOtherText.Size = new System.Drawing.Size(100, 20);
            this.CSUnitsOtherText.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Datum";
            // 
            // datumText
            // 
            this.datumText.Location = new System.Drawing.Point(98, 197);
            this.datumText.Name = "datumText";
            this.datumText.Size = new System.Drawing.Size(100, 20);
            this.datumText.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(223, 413);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 30);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(137, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(56, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // MultiSpeakMsgHeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 443);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MultiSpeakMsgHeaderForm";
            this.Text = "MultispeakRequestHeader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.versionGroupBox.ResumeLayout(false);
            this.versionGroupBox.PerformLayout();
            this.callerGroupBox.ResumeLayout(false);
            this.callerGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.codeGroupBox.ResumeLayout(false);
            this.codeGroupBox.PerformLayout();
            this.CoordinateSystemGroupBox.ResumeLayout(false);
            this.CoordinateSystemGroupBox.PerformLayout();
            this.CSAuthGroupBox.ResumeLayout(false);
            this.CSAuthGroupBox.PerformLayout();
            this.CSGroupBox.ResumeLayout(false);
            this.CSGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox versionGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox branchText;
        private System.Windows.Forms.TextBox buildText;
        private System.Windows.Forms.TextBox minorVersionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox majorVersionText;
        private System.Windows.Forms.GroupBox callerGroupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sysgtemIDText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox auditPasswordText;
        private System.Windows.Forms.TextBox appNameText;
        private System.Windows.Forms.TextBox auditIDText;
        private System.Windows.Forms.TextBox appVersionText;
        private System.Windows.Forms.TextBox companyText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox codeGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox namePartText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox codeValueText;
        private System.Windows.Forms.GroupBox CoordinateSystemGroupBox;
        private System.Windows.Forms.GroupBox CSGroupBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox CSUnitsOtherText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox datumText;
        private System.Windows.Forms.GroupBox CSAuthGroupBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox CSAuthorityNameValueText;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox CSAuthorityNameOtherText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox buildStringCombo;
        private System.Windows.Forms.ComboBox CodeNameTypeCombo;
        private System.Windows.Forms.ComboBox CSUnitsCombo;

    }
}

