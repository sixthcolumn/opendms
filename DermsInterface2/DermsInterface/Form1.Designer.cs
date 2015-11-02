namespace DermsConfig
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DERs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.menuStrip1.SuspendLayout();
            this.DERs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
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
            // DERs
            // 
            this.DERs.Controls.Add(this.tabPage1);
            this.DERs.Controls.Add(this.tabPage2);
            this.DERs.Location = new System.Drawing.Point(0, 27);
            this.DERs.Name = "DERs";
            this.DERs.SelectedIndex = 0;
            this.DERs.Size = new System.Drawing.Size(630, 396);
            this.DERs.TabIndex = 1;
            this.DERs.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Headers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 344);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // verbText
            // 
            this.verbText.Location = new System.Drawing.Point(106, 126);
            this.verbText.Name = "verbText";
            this.verbText.Size = new System.Drawing.Size(76, 20);
            this.verbText.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Verb";
            // 
            // ackRequiredCheck
            // 
            this.ackRequiredCheck.AutoSize = true;
            this.ackRequiredCheck.Location = new System.Drawing.Point(106, 106);
            this.ackRequiredCheck.Name = "ackRequiredCheck";
            this.ackRequiredCheck.Size = new System.Drawing.Size(15, 14);
            this.ackRequiredCheck.TabIndex = 17;
            this.ackRequiredCheck.UseVisualStyleBackColor = true;
            this.ackRequiredCheck.CheckedChanged += new System.EventHandler(this.ackRequiredCheck_CheckedChanged);
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(16, 196);
            this.commentText.Multiline = true;
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(327, 134);
            this.commentText.TabIndex = 16;
            this.commentText.TextChanged += new System.EventHandler(this.commentText_TextChanged);
            // 
            // contextText
            // 
            this.contextText.Location = new System.Drawing.Point(432, 113);
            this.contextText.Name = "contextText";
            this.contextText.Size = new System.Drawing.Size(182, 20);
            this.contextText.TabIndex = 15;
            this.contextText.TextChanged += new System.EventHandler(this.contextText_TextChanged);
            // 
            // organizationText
            // 
            this.organizationText.Location = new System.Drawing.Point(432, 84);
            this.organizationText.Name = "organizationText";
            this.organizationText.Size = new System.Drawing.Size(182, 20);
            this.organizationText.TabIndex = 14;
            this.organizationText.TextChanged += new System.EventHandler(this.organizationText_TextChanged);
            // 
            // endPointText
            // 
            this.endPointText.Location = new System.Drawing.Point(106, 54);
            this.endPointText.Name = "endPointText";
            this.endPointText.Size = new System.Drawing.Size(237, 20);
            this.endPointText.TabIndex = 13;
            this.endPointText.TextChanged += new System.EventHandler(this.endPointText_TextChanged);
            // 
            // replyAddressText
            // 
            this.replyAddressText.Location = new System.Drawing.Point(106, 80);
            this.replyAddressText.Name = "replyAddressText";
            this.replyAddressText.Size = new System.Drawing.Size(237, 20);
            this.replyAddressText.TabIndex = 12;
            this.replyAddressText.TextChanged += new System.EventHandler(this.replyAddressText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Comments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Endpoint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Organization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reply Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Context";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ack Required";
            // 
            // userIDText
            // 
            this.userIDText.Location = new System.Drawing.Point(432, 54);
            this.userIDText.Name = "userIDText";
            this.userIDText.Size = new System.Drawing.Size(182, 20);
            this.userIDText.TabIndex = 2;
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
            this.messageTypeCombo.Location = new System.Drawing.Point(106, 13);
            this.messageTypeCombo.Name = "messageTypeCombo";
            this.messageTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.messageTypeCombo.TabIndex = 1;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DER Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 455);
            this.Controls.Add(this.DERs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DERs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

