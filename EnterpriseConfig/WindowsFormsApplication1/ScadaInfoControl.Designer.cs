namespace WindowsFormsApplication1
{
    partial class ScadaInfoControl
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
            this.label10 = new System.Windows.Forms.Label();
            this.mridText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.substationText = new System.Windows.Forms.TextBox();
            this.feederText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.protocolCombo = new System.Windows.Forms.ComboBox();
            this.logLevelCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "MRID:";
            // 
            // mridText
            // 
            this.mridText.Location = new System.Drawing.Point(91, 14);
            this.mridText.Name = "mridText";
            this.mridText.Size = new System.Drawing.Size(245, 20);
            this.mridText.TabIndex = 1;
            this.mridText.TextChanged += new System.EventHandler(this.mridText_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Substation:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Feeder:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Description:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Log Level";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Protocol:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Type:";
            // 
            // substationText
            // 
            this.substationText.Location = new System.Drawing.Point(91, 137);
            this.substationText.Name = "substationText";
            this.substationText.Size = new System.Drawing.Size(195, 20);
            this.substationText.TabIndex = 10;
            this.substationText.TextChanged += new System.EventHandler(this.substationText_TextChanged);
            // 
            // feederText
            // 
            this.feederText.Location = new System.Drawing.Point(91, 165);
            this.feederText.Name = "feederText";
            this.feederText.Size = new System.Drawing.Size(195, 20);
            this.feederText.TabIndex = 11;
            this.feederText.TextChanged += new System.EventHandler(this.feederText_TextChanged);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(91, 66);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(195, 65);
            this.descriptionText.TabIndex = 12;
            this.descriptionText.TextChanged += new System.EventHandler(this.descriptionText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(91, 40);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(195, 20);
            this.nameText.TabIndex = 13;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(91, 191);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(157, 21);
            this.typeCombo.TabIndex = 14;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // protocolCombo
            // 
            this.protocolCombo.FormattingEnabled = true;
            this.protocolCombo.Location = new System.Drawing.Point(91, 218);
            this.protocolCombo.Name = "protocolCombo";
            this.protocolCombo.Size = new System.Drawing.Size(157, 21);
            this.protocolCombo.TabIndex = 15;
            this.protocolCombo.SelectedIndexChanged += new System.EventHandler(this.protocolCombo_SelectedIndexChanged);
            // 
            // logLevelCombo
            // 
            this.logLevelCombo.FormattingEnabled = true;
            this.logLevelCombo.Location = new System.Drawing.Point(91, 245);
            this.logLevelCombo.Name = "logLevelCombo";
            this.logLevelCombo.Size = new System.Drawing.Size(157, 21);
            this.logLevelCombo.TabIndex = 16;
            this.logLevelCombo.SelectedIndexChanged += new System.EventHandler(this.logLevelCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ScadaInfoControl
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logLevelCombo);
            this.Controls.Add(this.protocolCombo);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.feederText);
            this.Controls.Add(this.substationText);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mridText);
            this.Controls.Add(this.label10);
            this.Name = "ScadaInfoControl";
            this.Size = new System.Drawing.Size(484, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mridText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox substationText;
        private System.Windows.Forms.TextBox feederText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.ComboBox typeCombo;

        private System.Windows.Forms.ComboBox protocolCombo;
        private System.Windows.Forms.ComboBox logLevelCombo;
        private System.Windows.Forms.Button button1;
    }
}
