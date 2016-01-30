namespace WindowsFormsApplication1
{
    partial class DispatchDERForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.endPointText = new System.Windows.Forms.TextBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reactiveValueText = new System.Windows.Forms.TextBox();
            this.realRadio = new System.Windows.Forms.RadioButton();
            this.realValueText = new System.Windows.Forms.TextBox();
            this.reactiveRadio = new System.Windows.Forms.RadioButton();
            this.DERGroupMRIDText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dispatchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.log1 = new System.Windows.Forms.GroupBox();
            this.logControl1 = new WindowsFormsApplication1.LogControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.log1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.log1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 338);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.endPointText.Size = new System.Drawing.Size(416, 20);
            this.endPointText.TabIndex = 30;
            this.endPointText.TextChanged += new System.EventHandler(this.endPointText_TextChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(514, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CIM Header";
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(277, 81);
            this.commentText.Multiline = true;
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(227, 66);
            this.commentText.TabIndex = 38;
            this.commentText.TextChanged += new System.EventHandler(this.commentText_TextChanged);
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
            this.ackRequiredCheck.CheckedChanged += new System.EventHandler(this.ackRequiredCheck_CheckedChanged);
            // 
            // contextText
            // 
            this.contextText.Location = new System.Drawing.Point(89, 104);
            this.contextText.Name = "contextText";
            this.contextText.Size = new System.Drawing.Size(182, 20);
            this.contextText.TabIndex = 32;
            this.contextText.TextChanged += new System.EventHandler(this.contextText_TextChanged);
            // 
            // organizationText
            // 
            this.organizationText.Location = new System.Drawing.Point(89, 81);
            this.organizationText.Name = "organizationText";
            this.organizationText.Size = new System.Drawing.Size(182, 20);
            this.organizationText.TabIndex = 31;
            this.organizationText.TextChanged += new System.EventHandler(this.organizationText_TextChanged);
            // 
            // replyAddressText
            // 
            this.replyAddressText.Location = new System.Drawing.Point(89, 35);
            this.replyAddressText.Name = "replyAddressText";
            this.replyAddressText.Size = new System.Drawing.Size(415, 20);
            this.replyAddressText.TabIndex = 29;
            this.replyAddressText.TextChanged += new System.EventHandler(this.replyAddressText_TextChanged);
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
            this.userIDText.TextChanged += new System.EventHandler(this.userIDText_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.DERGroupMRIDText);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(3, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 94);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DER Group";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.reactiveValueText);
            this.groupBox4.Controls.Add(this.realRadio);
            this.groupBox4.Controls.Add(this.realValueText);
            this.groupBox4.Controls.Add(this.reactiveRadio);
            this.groupBox4.Location = new System.Drawing.Point(315, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 72);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Value";
            // 
            // reactiveValueText
            // 
            this.reactiveValueText.Location = new System.Drawing.Point(134, 44);
            this.reactiveValueText.Name = "reactiveValueText";
            this.reactiveValueText.Size = new System.Drawing.Size(49, 20);
            this.reactiveValueText.TabIndex = 44;
            this.reactiveValueText.TextChanged += new System.EventHandler(this.reactiveValueText_TextChanged);
            // 
            // realRadio
            // 
            this.realRadio.AutoSize = true;
            this.realRadio.Location = new System.Drawing.Point(6, 21);
            this.realRadio.Name = "realRadio";
            this.realRadio.Size = new System.Drawing.Size(47, 17);
            this.realRadio.TabIndex = 40;
            this.realRadio.TabStop = true;
            this.realRadio.Text = "Real";
            this.realRadio.UseVisualStyleBackColor = true;
            this.realRadio.CheckedChanged += new System.EventHandler(this.realRadio_CheckedChanged);
            // 
            // realValueText
            // 
            this.realValueText.Location = new System.Drawing.Point(134, 18);
            this.realValueText.Name = "realValueText";
            this.realValueText.Size = new System.Drawing.Size(49, 20);
            this.realValueText.TabIndex = 43;
            this.realValueText.TextChanged += new System.EventHandler(this.realValueText_TextChanged);
            // 
            // reactiveRadio
            // 
            this.reactiveRadio.AutoSize = true;
            this.reactiveRadio.Location = new System.Drawing.Point(6, 47);
            this.reactiveRadio.Name = "reactiveRadio";
            this.reactiveRadio.Size = new System.Drawing.Size(68, 17);
            this.reactiveRadio.TabIndex = 41;
            this.reactiveRadio.TabStop = true;
            this.reactiveRadio.Text = "Reactive";
            this.reactiveRadio.UseVisualStyleBackColor = true;
            this.reactiveRadio.CheckedChanged += new System.EventHandler(this.reactiveRadio_CheckedChanged);
            // 
            // DERGroupMRIDText
            // 
            this.DERGroupMRIDText.Location = new System.Drawing.Point(55, 19);
            this.DERGroupMRIDText.Name = "DERGroupMRIDText";
            this.DERGroupMRIDText.Size = new System.Drawing.Size(242, 20);
            this.DERGroupMRIDText.TabIndex = 38;
            this.DERGroupMRIDText.TextChanged += new System.EventHandler(this.DERGroupMRIDText_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "MRID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dispatchButton);
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Location = new System.Drawing.Point(3, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 29);
            this.panel3.TabIndex = 33;
            // 
            // dispatchButton
            // 
            this.dispatchButton.Location = new System.Drawing.Point(183, 3);
            this.dispatchButton.Name = "dispatchButton";
            this.dispatchButton.Size = new System.Drawing.Size(75, 23);
            this.dispatchButton.TabIndex = 33;
            this.dispatchButton.Text = "Dispatch";
            this.dispatchButton.UseVisualStyleBackColor = true;
            this.dispatchButton.Click += new System.EventHandler(this.dispatchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(277, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 34;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // log1
            // 
            this.log1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log1.Controls.Add(this.logControl1);
            this.log1.Location = new System.Drawing.Point(583, 3);
            this.log1.Name = "log1";
            this.tableLayoutPanel1.SetRowSpan(this.log1, 5);
            this.log1.Size = new System.Drawing.Size(302, 335);
            this.log1.TabIndex = 34;
            this.log1.TabStop = false;
            this.log1.Text = "Message Log";
            // 
            // logControl1
            // 
            this.logControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logControl1.Location = new System.Drawing.Point(6, 19);
            this.logControl1.Name = "logControl1";
            this.logControl1.Size = new System.Drawing.Size(291, 310);
            this.logControl1.TabIndex = 0;
            // 
            // DispatchDERForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DispatchDERForm";
            this.Text = "DispatchDER";
            this.Load += new System.EventHandler(this.DispatchDERForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.log1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox endPointText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox commentText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox messageTypeText;
        private System.Windows.Forms.TextBox verbText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ackRequiredCheck;
        private System.Windows.Forms.TextBox contextText;
        private System.Windows.Forms.TextBox organizationText;
        private System.Windows.Forms.TextBox replyAddressText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox realValueText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton realRadio;
        private System.Windows.Forms.RadioButton reactiveRadio;
        private System.Windows.Forms.TextBox DERGroupMRIDText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button dispatchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox reactiveValueText;
        private System.Windows.Forms.GroupBox log1;
        private LogControl logControl1;
    }
}