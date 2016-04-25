namespace WindowsFormsApplication1
{
    partial class ScadaControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scadaDeviceView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ScadaInfo = new System.Windows.Forms.TabPage();
            this.scadaInfoControl1 = new WindowsFormsApplication1.ScadaInfoControl();
            this.ScadaDNP3 = new System.Windows.Forms.TabPage();
            this.dnP3Control1 = new WindowsFormsApplication1.DNP3Control();
            this.ScadaTest = new System.Windows.Forms.TabPage();
            this.testScadaControl1 = new WindowsFormsApplication1.TestScadaControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scadaDeviceView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ScadaInfo.SuspendLayout();
            this.ScadaDNP3.SuspendLayout();
            this.ScadaTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.scadaDeviceView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scadaDeviceView
            // 
            this.scadaDeviceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scadaDeviceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scadaDeviceView.Location = new System.Drawing.Point(3, 3);
            this.scadaDeviceView.Name = "scadaDeviceView";
            this.scadaDeviceView.Size = new System.Drawing.Size(757, 158);
            this.scadaDeviceView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ScadaInfo);
            this.tabControl1.Controls.Add(this.ScadaDNP3);
            this.tabControl1.Controls.Add(this.ScadaTest);
            this.tabControl1.Location = new System.Drawing.Point(3, 167);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // ScadaInfo
            // 
            this.ScadaInfo.Controls.Add(this.scadaInfoControl1);
            this.ScadaInfo.Location = new System.Drawing.Point(4, 22);
            this.ScadaInfo.Name = "ScadaInfo";
            this.ScadaInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ScadaInfo.Size = new System.Drawing.Size(749, 374);
            this.ScadaInfo.TabIndex = 0;
            this.ScadaInfo.Text = "Info";
            this.ScadaInfo.UseVisualStyleBackColor = true;
            // 
            // scadaInfoControl1
            // 
            this.scadaInfoControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scadaInfoControl1.Enabled = false;
            this.scadaInfoControl1.Location = new System.Drawing.Point(3, 0);
            this.scadaInfoControl1.Name = "scadaInfoControl1";
            this.scadaInfoControl1.Size = new System.Drawing.Size(740, 308);
            this.scadaInfoControl1.TabIndex = 0;
            // 
            // ScadaDNP3
            // 
            this.ScadaDNP3.Controls.Add(this.dnP3Control1);
            this.ScadaDNP3.Location = new System.Drawing.Point(4, 22);
            this.ScadaDNP3.Name = "ScadaDNP3";
            this.ScadaDNP3.Padding = new System.Windows.Forms.Padding(3);
            this.ScadaDNP3.Size = new System.Drawing.Size(749, 374);
            this.ScadaDNP3.TabIndex = 1;
            this.ScadaDNP3.Text = "DNP3";
            this.ScadaDNP3.UseVisualStyleBackColor = true;
            // 
            // dnP3Control1
            // 
            this.dnP3Control1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dnP3Control1.Location = new System.Drawing.Point(7, 7);
            this.dnP3Control1.Name = "dnP3Control1";
            this.dnP3Control1.Size = new System.Drawing.Size(736, 361);
            this.dnP3Control1.TabIndex = 0;
            // 
            // ScadaTest
            // 
            this.ScadaTest.Controls.Add(this.testScadaControl1);
            this.ScadaTest.Location = new System.Drawing.Point(4, 22);
            this.ScadaTest.Name = "ScadaTest";
            this.ScadaTest.Padding = new System.Windows.Forms.Padding(3);
            this.ScadaTest.Size = new System.Drawing.Size(749, 374);
            this.ScadaTest.TabIndex = 2;
            this.ScadaTest.Text = "Test";
            this.ScadaTest.UseVisualStyleBackColor = true;
            // 
            // testScadaControl1
            // 
            this.testScadaControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testScadaControl1.AutoSize = true;
            this.testScadaControl1.Location = new System.Drawing.Point(0, 3);
            this.testScadaControl1.Name = "testScadaControl1";
            this.testScadaControl1.Size = new System.Drawing.Size(747, 517);
            this.testScadaControl1.TabIndex = 0;
            // 
            // ScadaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScadaControl";
            this.Size = new System.Drawing.Size(763, 570);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scadaDeviceView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ScadaInfo.ResumeLayout(false);
            this.ScadaDNP3.ResumeLayout(false);
            this.ScadaTest.ResumeLayout(false);
            this.ScadaTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView scadaDeviceView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ScadaInfo;
        private System.Windows.Forms.TabPage ScadaDNP3;
        private System.Windows.Forms.TabPage ScadaTest;
        private ScadaInfoControl scadaInfoControl1;
        private DNP3Control dnP3Control1;
        private TestScadaControl testScadaControl1;
    }
}
