namespace WindowsFormsApplication1
{
    partial class DNP3Advanced
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResponseTimeoutText = new System.Windows.Forms.TextBox();
            this.frameRetriesText = new System.Windows.Forms.TextBox();
            this.maxFragSizeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.taskRetryRateText = new System.Windows.Forms.TextBox();
            this.fragSizeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confirmTimeoutText = new System.Windows.Forms.TextBox();
            this.linkRetriesText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.physicalRetriesText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResponseTimeoutText);
            this.groupBox1.Controls.Add(this.frameRetriesText);
            this.groupBox1.Controls.Add(this.maxFragSizeText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Layer";
            // 
            // ResponseTimeoutText
            // 
            this.ResponseTimeoutText.Location = new System.Drawing.Point(135, 65);
            this.ResponseTimeoutText.Name = "ResponseTimeoutText";
            this.ResponseTimeoutText.Size = new System.Drawing.Size(100, 20);
            this.ResponseTimeoutText.TabIndex = 5;
            this.ResponseTimeoutText.TextChanged += new System.EventHandler(this.ResponseTimeoutText_TextChanged);
            // 
            // frameRetriesText
            // 
            this.frameRetriesText.Location = new System.Drawing.Point(135, 39);
            this.frameRetriesText.Name = "frameRetriesText";
            this.frameRetriesText.Size = new System.Drawing.Size(100, 20);
            this.frameRetriesText.TabIndex = 4;
            this.frameRetriesText.TextChanged += new System.EventHandler(this.frameRetriesText_TextChanged);
            // 
            // maxFragSizeText
            // 
            this.maxFragSizeText.Location = new System.Drawing.Point(135, 13);
            this.maxFragSizeText.Name = "maxFragSizeText";
            this.maxFragSizeText.Size = new System.Drawing.Size(100, 20);
            this.maxFragSizeText.TabIndex = 3;
            this.maxFragSizeText.TextChanged += new System.EventHandler(this.maxFragSizeText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Response Timeout (MS)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frame Retries:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Frag Size (Bytes):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.taskRetryRateText);
            this.groupBox2.Controls.Add(this.fragSizeText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(26, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Master Layer";
            // 
            // taskRetryRateText
            // 
            this.taskRetryRateText.Location = new System.Drawing.Point(135, 39);
            this.taskRetryRateText.Name = "taskRetryRateText";
            this.taskRetryRateText.Size = new System.Drawing.Size(100, 20);
            this.taskRetryRateText.TabIndex = 4;
            this.taskRetryRateText.TextChanged += new System.EventHandler(this.taskRetryRateText_TextChanged);
            // 
            // fragSizeText
            // 
            this.fragSizeText.Location = new System.Drawing.Point(135, 13);
            this.fragSizeText.Name = "fragSizeText";
            this.fragSizeText.Size = new System.Drawing.Size(100, 20);
            this.fragSizeText.TabIndex = 3;
            this.fragSizeText.TextChanged += new System.EventHandler(this.fragSizeText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Task Retry Rate (MS):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Frag Size (Bytes)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.confirmTimeoutText);
            this.groupBox3.Controls.Add(this.linkRetriesText);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(297, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 98);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Link Layer";
            // 
            // confirmTimeoutText
            // 
            this.confirmTimeoutText.Location = new System.Drawing.Point(87, 39);
            this.confirmTimeoutText.Name = "confirmTimeoutText";
            this.confirmTimeoutText.Size = new System.Drawing.Size(100, 20);
            this.confirmTimeoutText.TabIndex = 4;
            this.confirmTimeoutText.TextChanged += new System.EventHandler(this.confirmTimeoutText_TextChanged);
            // 
            // linkRetriesText
            // 
            this.linkRetriesText.Location = new System.Drawing.Point(87, 13);
            this.linkRetriesText.Name = "linkRetriesText";
            this.linkRetriesText.Size = new System.Drawing.Size(100, 20);
            this.linkRetriesText.TabIndex = 3;
            this.linkRetriesText.TextChanged += new System.EventHandler(this.linkRetriesText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirmation\r\nTimeout:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Num Retries:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.physicalRetriesText);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(297, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 71);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Physical Layer";
            // 
            // physicalRetriesText
            // 
            this.physicalRetriesText.Location = new System.Drawing.Point(87, 17);
            this.physicalRetriesText.Name = "physicalRetriesText";
            this.physicalRetriesText.Size = new System.Drawing.Size(100, 20);
            this.physicalRetriesText.TabIndex = 3;
            this.physicalRetriesText.TextChanged += new System.EventHandler(this.physicalRetriesText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Num Retries:";
            // 
            // DNP3Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DNP3Advanced";
            this.Size = new System.Drawing.Size(560, 240);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ResponseTimeoutText;
        private System.Windows.Forms.TextBox frameRetriesText;
        private System.Windows.Forms.TextBox maxFragSizeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox taskRetryRateText;
        private System.Windows.Forms.TextBox fragSizeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox confirmTimeoutText;
        private System.Windows.Forms.TextBox linkRetriesText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox physicalRetriesText;
        private System.Windows.Forms.Label label9;
    }
}
