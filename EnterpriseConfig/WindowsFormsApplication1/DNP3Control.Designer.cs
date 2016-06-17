namespace WindowsFormsApplication1
{
    partial class DNP3Control
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
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.dnP3Advanced1 = new WindowsFormsApplication1.DNP3Advanced();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.dnP3BasicControl1 = new WindowsFormsApplication1.DNP3BasicControl();
            this.basicControlTab = new System.Windows.Forms.TabControl();
            this.advancedTab.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.basicControlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedTab
            // 
            this.advancedTab.Controls.Add(this.dnP3Advanced1);
            this.advancedTab.Location = new System.Drawing.Point(4, 22);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Size = new System.Drawing.Size(698, 274);
            this.advancedTab.TabIndex = 2;
            this.advancedTab.Text = "Advanced";
            this.advancedTab.UseVisualStyleBackColor = true;
            // 
            // dnP3Advanced1
            // 
            this.dnP3Advanced1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dnP3Advanced1.Enabled = false;
            this.dnP3Advanced1.Location = new System.Drawing.Point(3, 3);
            this.dnP3Advanced1.Name = "dnP3Advanced1";
            this.dnP3Advanced1.Size = new System.Drawing.Size(695, 312);
            this.dnP3Advanced1.TabIndex = 0;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.dnP3BasicControl1);
            this.basicTab.Location = new System.Drawing.Point(4, 22);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(698, 274);
            this.basicTab.TabIndex = 1;
            this.basicTab.Text = "Basic";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // dnP3BasicControl1
            // 
            this.dnP3BasicControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dnP3BasicControl1.Enabled = false;
            this.dnP3BasicControl1.Location = new System.Drawing.Point(0, 0);
            this.dnP3BasicControl1.Name = "dnP3BasicControl1";
            this.dnP3BasicControl1.Size = new System.Drawing.Size(627, 274);
            this.dnP3BasicControl1.TabIndex = 0;
            // 
            // basicControlTab
            // 
            this.basicControlTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicControlTab.Controls.Add(this.basicTab);
            this.basicControlTab.Controls.Add(this.advancedTab);
            this.basicControlTab.Location = new System.Drawing.Point(0, 0);
            this.basicControlTab.Name = "basicControlTab";
            this.basicControlTab.SelectedIndex = 0;
            this.basicControlTab.Size = new System.Drawing.Size(706, 300);
            this.basicControlTab.TabIndex = 0;
            // 
            // DNP3Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicControlTab);
            this.Name = "DNP3Control";
            this.Size = new System.Drawing.Size(706, 300);
            this.advancedTab.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.basicControlTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage advancedTab;
        private DNP3Advanced dnP3Advanced1;
        private System.Windows.Forms.TabPage basicTab;
        private DNP3BasicControl dnP3BasicControl1;
        private System.Windows.Forms.TabControl basicControlTab;


    }
}
