namespace WindowsFormsApplication1
{
    partial class DNP3BasicControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddressText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.class3Check = new System.Windows.Forms.CheckBox();
            this.class2Check = new System.Windows.Forms.CheckBox();
            this.Class1Check = new System.Windows.Forms.CheckBox();
            this.class0Check = new System.Windows.Forms.CheckBox();
            this.EnableUnsolCheck = new System.Windows.Forms.CheckBox();
            this.UnsolicitedCheck = new System.Windows.Forms.CheckBox();
            this.timeSyncCheck = new System.Windows.Forms.CheckBox();
            this.useConfirmsCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.udpRadio = new System.Windows.Forms.RadioButton();
            this.tcpRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.remoteRadio = new System.Windows.Forms.RadioButton();
            this.localRadio = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.doNoAckRadio = new System.Windows.Forms.RadioButton();
            this.DORadio = new System.Windows.Forms.RadioButton();
            this.SBORadio = new System.Windows.Forms.RadioButton();
            this.remoteAddressText = new System.Windows.Forms.TextBox();
            this.localAddressText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.integrityScanText = new System.Windows.Forms.TextBox();
            this.saveIntervalText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // ipAddressText
            // 
            this.ipAddressText.Location = new System.Drawing.Point(99, 9);
            this.ipAddressText.Name = "ipAddressText";
            this.ipAddressText.Size = new System.Drawing.Size(216, 20);
            this.ipAddressText.TabIndex = 1;
            this.ipAddressText.TextChanged += new System.EventHandler(this.ipAddressText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remote Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Local Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Integrity Scan\r\nRate (MS):\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Save Internal(S):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.class3Check);
            this.groupBox1.Controls.Add(this.class2Check);
            this.groupBox1.Controls.Add(this.Class1Check);
            this.groupBox1.Controls.Add(this.class0Check);
            this.groupBox1.Controls.Add(this.EnableUnsolCheck);
            this.groupBox1.Controls.Add(this.UnsolicitedCheck);
            this.groupBox1.Location = new System.Drawing.Point(10, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unsolicited Data";
            // 
            // class3Check
            // 
            this.class3Check.AutoSize = true;
            this.class3Check.Location = new System.Drawing.Point(239, 42);
            this.class3Check.Name = "class3Check";
            this.class3Check.Size = new System.Drawing.Size(60, 17);
            this.class3Check.TabIndex = 5;
            this.class3Check.Text = "Class 3";
            this.class3Check.UseVisualStyleBackColor = true;
            this.class3Check.CheckedChanged += new System.EventHandler(this.class3Check_CheckedChanged);
            // 
            // class2Check
            // 
            this.class2Check.AutoSize = true;
            this.class2Check.Location = new System.Drawing.Point(239, 19);
            this.class2Check.Name = "class2Check";
            this.class2Check.Size = new System.Drawing.Size(60, 17);
            this.class2Check.TabIndex = 4;
            this.class2Check.Text = "Class 2";
            this.class2Check.UseVisualStyleBackColor = true;
            this.class2Check.CheckedChanged += new System.EventHandler(this.class2Check_CheckedChanged);
            // 
            // Class1Check
            // 
            this.Class1Check.AutoSize = true;
            this.Class1Check.Location = new System.Drawing.Point(173, 42);
            this.Class1Check.Name = "Class1Check";
            this.Class1Check.Size = new System.Drawing.Size(60, 17);
            this.Class1Check.TabIndex = 3;
            this.Class1Check.Text = "Class 1";
            this.Class1Check.UseVisualStyleBackColor = true;
            this.Class1Check.CheckedChanged += new System.EventHandler(this.Class1Check_CheckedChanged);
            // 
            // class0Check
            // 
            this.class0Check.AutoSize = true;
            this.class0Check.Location = new System.Drawing.Point(173, 19);
            this.class0Check.Name = "class0Check";
            this.class0Check.Size = new System.Drawing.Size(60, 17);
            this.class0Check.TabIndex = 2;
            this.class0Check.Text = "Class 0";
            this.class0Check.UseVisualStyleBackColor = true;
            this.class0Check.CheckedChanged += new System.EventHandler(this.class0Check_CheckedChanged);
            // 
            // EnableUnsolCheck
            // 
            this.EnableUnsolCheck.AutoSize = true;
            this.EnableUnsolCheck.Location = new System.Drawing.Point(6, 42);
            this.EnableUnsolCheck.Name = "EnableUnsolCheck";
            this.EnableUnsolCheck.Size = new System.Drawing.Size(120, 17);
            this.EnableUnsolCheck.TabIndex = 1;
            this.EnableUnsolCheck.Text = "Enabled Unsolicited";
            this.EnableUnsolCheck.UseVisualStyleBackColor = true;
            this.EnableUnsolCheck.CheckedChanged += new System.EventHandler(this.EnableUnsolCheck_CheckedChanged);
            // 
            // UnsolicitedCheck
            // 
            this.UnsolicitedCheck.AutoSize = true;
            this.UnsolicitedCheck.Location = new System.Drawing.Point(6, 19);
            this.UnsolicitedCheck.Name = "UnsolicitedCheck";
            this.UnsolicitedCheck.Size = new System.Drawing.Size(130, 17);
            this.UnsolicitedCheck.TabIndex = 0;
            this.UnsolicitedCheck.Text = "Unsolicited on Startup";
            this.UnsolicitedCheck.UseVisualStyleBackColor = true;
            this.UnsolicitedCheck.CheckedChanged += new System.EventHandler(this.UnsolicitedCheck_CheckedChanged);
            // 
            // timeSyncCheck
            // 
            this.timeSyncCheck.AutoSize = true;
            this.timeSyncCheck.Location = new System.Drawing.Point(355, 11);
            this.timeSyncCheck.Name = "timeSyncCheck";
            this.timeSyncCheck.Size = new System.Drawing.Size(76, 17);
            this.timeSyncCheck.TabIndex = 8;
            this.timeSyncCheck.Text = "Time Sync";
            this.timeSyncCheck.UseVisualStyleBackColor = true;
            this.timeSyncCheck.CheckedChanged += new System.EventHandler(this.timeSyncCheck_CheckedChanged);
            // 
            // useConfirmsCheck
            // 
            this.useConfirmsCheck.AutoSize = true;
            this.useConfirmsCheck.Location = new System.Drawing.Point(355, 37);
            this.useConfirmsCheck.Name = "useConfirmsCheck";
            this.useConfirmsCheck.Size = new System.Drawing.Size(88, 17);
            this.useConfirmsCheck.TabIndex = 9;
            this.useConfirmsCheck.Text = "Use Confirms";
            this.useConfirmsCheck.UseVisualStyleBackColor = true;
            this.useConfirmsCheck.CheckedChanged += new System.EventHandler(this.useConfirmsCheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.udpRadio);
            this.groupBox2.Controls.Add(this.tcpRadio);
            this.groupBox2.Location = new System.Drawing.Point(355, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transport";
            // 
            // udpRadio
            // 
            this.udpRadio.AutoSize = true;
            this.udpRadio.Location = new System.Drawing.Point(6, 45);
            this.udpRadio.Name = "udpRadio";
            this.udpRadio.Size = new System.Drawing.Size(48, 17);
            this.udpRadio.TabIndex = 1;
            this.udpRadio.TabStop = true;
            this.udpRadio.Text = "UDP";
            this.udpRadio.UseVisualStyleBackColor = true;
            this.udpRadio.CheckedChanged += new System.EventHandler(this.udpRadio_CheckedChanged);
            // 
            // tcpRadio
            // 
            this.tcpRadio.AutoSize = true;
            this.tcpRadio.Location = new System.Drawing.Point(6, 22);
            this.tcpRadio.Name = "tcpRadio";
            this.tcpRadio.Size = new System.Drawing.Size(46, 17);
            this.tcpRadio.TabIndex = 0;
            this.tcpRadio.TabStop = true;
            this.tcpRadio.Text = "TCP";
            this.tcpRadio.UseVisualStyleBackColor = true;
            this.tcpRadio.CheckedChanged += new System.EventHandler(this.tcpRadio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.remoteRadio);
            this.groupBox3.Controls.Add(this.localRadio);
            this.groupBox3.Location = new System.Drawing.Point(477, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 71);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Initiation";
            // 
            // remoteRadio
            // 
            this.remoteRadio.AutoSize = true;
            this.remoteRadio.Location = new System.Drawing.Point(6, 45);
            this.remoteRadio.Name = "remoteRadio";
            this.remoteRadio.Size = new System.Drawing.Size(62, 17);
            this.remoteRadio.TabIndex = 1;
            this.remoteRadio.TabStop = true;
            this.remoteRadio.Text = "Remote";
            this.remoteRadio.UseVisualStyleBackColor = true;
            this.remoteRadio.CheckedChanged += new System.EventHandler(this.remoteRadio_CheckedChanged);
            // 
            // localRadio
            // 
            this.localRadio.AutoSize = true;
            this.localRadio.Location = new System.Drawing.Point(6, 22);
            this.localRadio.Name = "localRadio";
            this.localRadio.Size = new System.Drawing.Size(51, 17);
            this.localRadio.TabIndex = 0;
            this.localRadio.TabStop = true;
            this.localRadio.Text = "Local";
            this.localRadio.UseVisualStyleBackColor = true;
            this.localRadio.CheckedChanged += new System.EventHandler(this.localRadio_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.doNoAckRadio);
            this.groupBox4.Controls.Add(this.DORadio);
            this.groupBox4.Controls.Add(this.SBORadio);
            this.groupBox4.Location = new System.Drawing.Point(355, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 95);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DNP Function";
            // 
            // doNoAckRadio
            // 
            this.doNoAckRadio.AutoSize = true;
            this.doNoAckRadio.Location = new System.Drawing.Point(6, 68);
            this.doNoAckRadio.Name = "doNoAckRadio";
            this.doNoAckRadio.Size = new System.Drawing.Size(83, 17);
            this.doNoAckRadio.TabIndex = 2;
            this.doNoAckRadio.TabStop = true;
            this.doNoAckRadio.Text = "DO (no ack)";
            this.doNoAckRadio.UseVisualStyleBackColor = true;
            this.doNoAckRadio.CheckedChanged += new System.EventHandler(this.doNoAckRadio_CheckedChanged);
            // 
            // DORadio
            // 
            this.DORadio.AutoSize = true;
            this.DORadio.Location = new System.Drawing.Point(6, 45);
            this.DORadio.Name = "DORadio";
            this.DORadio.Size = new System.Drawing.Size(41, 17);
            this.DORadio.TabIndex = 1;
            this.DORadio.TabStop = true;
            this.DORadio.Text = "DO";
            this.DORadio.UseVisualStyleBackColor = true;
            this.DORadio.CheckedChanged += new System.EventHandler(this.DORadio_CheckedChanged);
            // 
            // SBORadio
            // 
            this.SBORadio.AutoSize = true;
            this.SBORadio.Location = new System.Drawing.Point(6, 22);
            this.SBORadio.Name = "SBORadio";
            this.SBORadio.Size = new System.Drawing.Size(47, 17);
            this.SBORadio.TabIndex = 0;
            this.SBORadio.TabStop = true;
            this.SBORadio.Text = "SBO";
            this.SBORadio.UseVisualStyleBackColor = true;
            this.SBORadio.CheckedChanged += new System.EventHandler(this.SBORadio_CheckedChanged);
            // 
            // remoteAddressText
            // 
            this.remoteAddressText.Location = new System.Drawing.Point(99, 35);
            this.remoteAddressText.Name = "remoteAddressText";
            this.remoteAddressText.Size = new System.Drawing.Size(216, 20);
            this.remoteAddressText.TabIndex = 13;
            this.remoteAddressText.TextChanged += new System.EventHandler(this.remoteAddressText_TextChanged);
            // 
            // localAddressText
            // 
            this.localAddressText.Location = new System.Drawing.Point(99, 62);
            this.localAddressText.Name = "localAddressText";
            this.localAddressText.Size = new System.Drawing.Size(216, 20);
            this.localAddressText.TabIndex = 14;
            this.localAddressText.TextChanged += new System.EventHandler(this.localAddressText_TextChanged);
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(99, 88);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(216, 20);
            this.portText.TabIndex = 15;
            this.portText.TextChanged += new System.EventHandler(this.portText_TextChanged);
            // 
            // integrityScanText
            // 
            this.integrityScanText.Location = new System.Drawing.Point(99, 114);
            this.integrityScanText.Name = "integrityScanText";
            this.integrityScanText.Size = new System.Drawing.Size(216, 20);
            this.integrityScanText.TabIndex = 16;
            this.integrityScanText.TextChanged += new System.EventHandler(this.integrityScanText_TextChanged);
            // 
            // saveIntervalText
            // 
            this.saveIntervalText.Location = new System.Drawing.Point(99, 153);
            this.saveIntervalText.Name = "saveIntervalText";
            this.saveIntervalText.Size = new System.Drawing.Size(216, 20);
            this.saveIntervalText.TabIndex = 17;
            this.saveIntervalText.TextChanged += new System.EventHandler(this.saveIntervalText_TextChanged);
            // 
            // DNP3BasicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveIntervalText);
            this.Controls.Add(this.integrityScanText);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.localAddressText);
            this.Controls.Add(this.remoteAddressText);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.useConfirmsCheck);
            this.Controls.Add(this.timeSyncCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddressText);
            this.Controls.Add(this.label1);
            this.Name = "DNP3BasicControl";
            this.Size = new System.Drawing.Size(627, 263);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox class3Check;
        private System.Windows.Forms.CheckBox class2Check;
        private System.Windows.Forms.CheckBox Class1Check;
        private System.Windows.Forms.CheckBox class0Check;
        private System.Windows.Forms.CheckBox EnableUnsolCheck;
        private System.Windows.Forms.CheckBox UnsolicitedCheck;
        private System.Windows.Forms.CheckBox timeSyncCheck;
        private System.Windows.Forms.CheckBox useConfirmsCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton udpRadio;
        private System.Windows.Forms.RadioButton tcpRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton remoteRadio;
        private System.Windows.Forms.RadioButton localRadio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton doNoAckRadio;
        private System.Windows.Forms.RadioButton DORadio;
        private System.Windows.Forms.RadioButton SBORadio;
        private System.Windows.Forms.TextBox remoteAddressText;
        private System.Windows.Forms.TextBox localAddressText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.TextBox integrityScanText;
        private System.Windows.Forms.TextBox saveIntervalText;
    }
}
