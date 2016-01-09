namespace WindowsFormsApplication1
{
    partial class DERHeaderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.commentText = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ackRequiredCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nounText = new System.Windows.Forms.TextBox();
            this.verbText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.userIDText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.organizationText = new System.Windows.Forms.TextBox();
            this.contextText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.revVersionText = new System.Windows.Forms.TextBox();
            this.dateVersionPicker = new System.Windows.Forms.DateTimePicker();
            this.minorVersionText = new System.Windows.Forms.TextBox();
            this.majorVersionText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.endPointText = new System.Windows.Forms.TextBox();
            this.replyAddressText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messageTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.commentText);
            this.groupBox6.Location = new System.Drawing.Point(310, 209);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(305, 108);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Comments";
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(6, 19);
            this.commentText.Multiline = true;
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(293, 83);
            this.commentText.TabIndex = 8;
            this.commentText.TextChanged += new System.EventHandler(this.commentText_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.ackRequiredCheck);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.nounText);
            this.groupBox5.Controls.Add(this.verbText);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(19, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 109);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ack Required";
            // 
            // ackRequiredCheck
            // 
            this.ackRequiredCheck.AutoSize = true;
            this.ackRequiredCheck.Location = new System.Drawing.Point(96, 15);
            this.ackRequiredCheck.Name = "ackRequiredCheck";
            this.ackRequiredCheck.Size = new System.Drawing.Size(15, 14);
            this.ackRequiredCheck.TabIndex = 4;
            this.ackRequiredCheck.UseVisualStyleBackColor = true;
            this.ackRequiredCheck.CheckedChanged += new System.EventHandler(this.ackRequiredCheck_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Verb";
            // 
            // nounText
            // 
            this.nounText.Location = new System.Drawing.Point(96, 64);
            this.nounText.Name = "nounText";
            this.nounText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nounText.Size = new System.Drawing.Size(92, 20);
            this.nounText.TabIndex = 10;
            this.nounText.TextChanged += new System.EventHandler(this.nounText_TextChanged);
            // 
            // verbText
            // 
            this.verbText.Location = new System.Drawing.Point(96, 35);
            this.verbText.Name = "verbText";
            this.verbText.ReadOnly = true;
            this.verbText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.verbText.Size = new System.Drawing.Size(92, 20);
            this.verbText.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Noun";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.userIDText);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.organizationText);
            this.groupBox4.Controls.Add(this.contextText);
            this.groupBox4.Location = new System.Drawing.Point(20, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 115);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Organization";
            // 
            // userIDText
            // 
            this.userIDText.Location = new System.Drawing.Point(82, 19);
            this.userIDText.Name = "userIDText";
            this.userIDText.Size = new System.Drawing.Size(182, 20);
            this.userIDText.TabIndex = 5;
            this.userIDText.TextChanged += new System.EventHandler(this.userIDText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Context";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Organization";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "User ID";
            // 
            // organizationText
            // 
            this.organizationText.Location = new System.Drawing.Point(83, 45);
            this.organizationText.Name = "organizationText";
            this.organizationText.Size = new System.Drawing.Size(182, 20);
            this.organizationText.TabIndex = 6;
            this.organizationText.TextChanged += new System.EventHandler(this.organizationText_TextChanged);
            // 
            // contextText
            // 
            this.contextText.Location = new System.Drawing.Point(82, 72);
            this.contextText.Name = "contextText";
            this.contextText.Size = new System.Drawing.Size(182, 20);
            this.contextText.TabIndex = 7;
            this.contextText.TextChanged += new System.EventHandler(this.contextText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.revVersionText);
            this.groupBox3.Controls.Add(this.dateVersionPicker);
            this.groupBox3.Controls.Add(this.minorVersionText);
            this.groupBox3.Controls.Add(this.majorVersionText);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(310, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 115);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Version";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Date";
            // 
            // revVersionText
            // 
            this.revVersionText.Location = new System.Drawing.Point(45, 46);
            this.revVersionText.Name = "revVersionText";
            this.revVersionText.Size = new System.Drawing.Size(68, 20);
            this.revVersionText.TabIndex = 15;
            this.revVersionText.TextChanged += new System.EventHandler(this.revVersionText_TextChanged);
            // 
            // dateVersionPicker
            // 
            this.dateVersionPicker.CustomFormat = "";
            this.dateVersionPicker.Location = new System.Drawing.Point(45, 72);
            this.dateVersionPicker.Name = "dateVersionPicker";
            this.dateVersionPicker.Size = new System.Drawing.Size(200, 20);
            this.dateVersionPicker.TabIndex = 14;
            this.dateVersionPicker.Value = new System.DateTime(2015, 11, 7, 0, 0, 0, 0);
            this.dateVersionPicker.ValueChanged += new System.EventHandler(this.dateVersionPicker_ValueChanged);
            // 
            // minorVersionText
            // 
            this.minorVersionText.Location = new System.Drawing.Point(177, 20);
            this.minorVersionText.Name = "minorVersionText";
            this.minorVersionText.Size = new System.Drawing.Size(68, 20);
            this.minorVersionText.TabIndex = 12;
            this.minorVersionText.TextChanged += new System.EventHandler(this.minorVersionText_TextChanged);
            // 
            // majorVersionText
            // 
            this.majorVersionText.Location = new System.Drawing.Point(45, 19);
            this.majorVersionText.Name = "majorVersionText";
            this.majorVersionText.Size = new System.Drawing.Size(68, 20);
            this.majorVersionText.TabIndex = 11;
            this.majorVersionText.TextChanged += new System.EventHandler(this.majorVersionText_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Major";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Minor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Rev";
            // 
            // endPointText
            // 
            this.endPointText.Location = new System.Drawing.Point(100, 40);
            this.endPointText.Name = "endPointText";
            this.endPointText.Size = new System.Drawing.Size(515, 20);
            this.endPointText.TabIndex = 2;
            this.endPointText.TextChanged += new System.EventHandler(this.endPointText_TextChanged);
            // 
            // replyAddressText
            // 
            this.replyAddressText.Location = new System.Drawing.Point(100, 66);
            this.replyAddressText.Name = "replyAddressText";
            this.replyAddressText.Size = new System.Drawing.Size(515, 20);
            this.replyAddressText.TabIndex = 3;
            this.replyAddressText.TextChanged += new System.EventHandler(this.replyAddressText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Endpoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reply Address";
            // 
            // messageTypeCombo
            // 
            this.messageTypeCombo.FormattingEnabled = true;
            this.messageTypeCombo.Items.AddRange(new object[] {
            "createDER",
            "dispatchDER",
            "getDER",
            "getDERStatus"});
            this.messageTypeCombo.Location = new System.Drawing.Point(100, 13);
            this.messageTypeCombo.Name = "messageTypeCombo";
            this.messageTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.messageTypeCombo.TabIndex = 1;
            this.messageTypeCombo.Text = "createDER";
            this.messageTypeCombo.SelectedIndexChanged += new System.EventHandler(this.messageTypeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message Type";
            // 
            // DERHeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.messageTypeCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.replyAddressText);
            this.Controls.Add(this.endPointText);
            this.Controls.Add(this.label4);
            this.Name = "DERHeaderControl";
            this.Size = new System.Drawing.Size(629, 328);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox commentText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ackRequiredCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nounText;
        private System.Windows.Forms.TextBox verbText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox userIDText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox organizationText;
        private System.Windows.Forms.TextBox contextText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox revVersionText;
        private System.Windows.Forms.DateTimePicker dateVersionPicker;
        private System.Windows.Forms.TextBox minorVersionText;
        private System.Windows.Forms.TextBox majorVersionText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox endPointText;
        private System.Windows.Forms.TextBox replyAddressText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox messageTypeCombo;
        private System.Windows.Forms.Label label1;
    }
}
