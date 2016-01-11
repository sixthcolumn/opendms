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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDERStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDERsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DERs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.derHeaderControl1 = new WindowsFormsApplication1.DERHeaderControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dERGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scadaControl = new WindowsFormsApplication1.ScadaControl();
            this.derGroupViewControl1 = new WindowsFormsApplication1.DERGroupViewControl();
            this.menuStrip1.SuspendLayout();
            this.DERs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERGroupBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
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
            this.getDERStatusToolStripMenuItem,
            this.getDERsToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // createDERToolStripMenuItem
            // 
            this.createDERToolStripMenuItem.Name = "createDERToolStripMenuItem";
            this.createDERToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createDERToolStripMenuItem.Text = "Create DER";
            this.createDERToolStripMenuItem.Click += new System.EventHandler(this.createDERToolStripMenuItem_Click);
            // 
            // dispatchDERToolStripMenuItem
            // 
            this.dispatchDERToolStripMenuItem.Name = "dispatchDERToolStripMenuItem";
            this.dispatchDERToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dispatchDERToolStripMenuItem.Text = "Dispatch DER";
            this.dispatchDERToolStripMenuItem.Click += new System.EventHandler(this.dispatchDERToolStripMenuItem_Click);
            // 
            // getDERStatusToolStripMenuItem
            // 
            this.getDERStatusToolStripMenuItem.Name = "getDERStatusToolStripMenuItem";
            this.getDERStatusToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.getDERStatusToolStripMenuItem.Text = "Get DER Status";
            this.getDERStatusToolStripMenuItem.Click += new System.EventHandler(this.getDERStatusToolStripMenuItem_Click);
            // 
            // getDERsToolStripMenuItem
            // 
            this.getDERsToolStripMenuItem.Name = "getDERsToolStripMenuItem";
            this.getDERsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.getDERsToolStripMenuItem.Text = "Get DERs";
            this.getDERsToolStripMenuItem.Click += new System.EventHandler(this.getDERsToolStripMenuItem_Click);
            // 
            // DERs
            // 
            this.DERs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERs.Controls.Add(this.tabPage1);
            this.DERs.Controls.Add(this.tabPage2);
            this.DERs.Location = new System.Drawing.Point(6, 3);
            this.DERs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.DERs.Name = "DERs";
            this.DERs.SelectedIndex = 0;
            this.DERs.Size = new System.Drawing.Size(758, 511);
            this.DERs.TabIndex = 2;
            this.DERs.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.derHeaderControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Headers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // derHeaderControl1
            // 
            this.derHeaderControl1.Location = new System.Drawing.Point(6, 6);
            this.derHeaderControl1.Name = "derHeaderControl1";
            this.derHeaderControl1.Size = new System.Drawing.Size(629, 328);
            this.derHeaderControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.derGroupViewControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DER Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 543);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DERs);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 517);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Enterprise Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scadaControl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(770, 517);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "SCADA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // scadaControl
            // 
            this.scadaControl.Location = new System.Drawing.Point(4, 7);
            this.scadaControl.Name = "scadaControl";
            this.scadaControl.Size = new System.Drawing.Size(763, 507);
            this.scadaControl.TabIndex = 0;
            // 
            // derGroupViewControl1
            // 
            this.derGroupViewControl1.Location = new System.Drawing.Point(3, 3);
            this.derGroupViewControl1.Name = "derGroupViewControl1";
            this.derGroupViewControl1.Size = new System.Drawing.Size(741, 476);
            this.derGroupViewControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 569);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Enterprise Config";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DERs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERGroupBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource dERGroupBindingSource;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDERStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDERsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ScadaControl scadaControl;
        private DERHeaderControl derHeaderControl1;
        private DERGroupViewControl derGroupViewControl1;
    }
}

