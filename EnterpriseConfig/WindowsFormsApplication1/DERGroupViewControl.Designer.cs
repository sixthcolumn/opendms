namespace WindowsFormsApplication1
{
    partial class DERGroupViewControl
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DERView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wattCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DERGroupsView = new System.Windows.Forms.DataGridView();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feederDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reactivePower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dERGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DERView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DERGroupsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 497);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.DERView);
            this.groupBox1.Location = new System.Drawing.Point(3, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DERs";
            // 
            // DERView
            // 
            this.DERView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERView.AutoGenerateColumns = false;
            this.DERView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DERView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DERView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.mridDataGridViewTextBoxColumn1,
            this.wattCapacityDataGridViewTextBoxColumn,
            this.varCapacityDataGridViewTextBoxColumn});
            this.DERView.DataSource = this.deviceBindingSource;
            this.DERView.Location = new System.Drawing.Point(2, 15);
            this.DERView.Name = "DERView";
            this.DERView.Size = new System.Drawing.Size(678, 222);
            this.DERView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mridDataGridViewTextBoxColumn1
            // 
            this.mridDataGridViewTextBoxColumn1.DataPropertyName = "Mrid";
            this.mridDataGridViewTextBoxColumn1.HeaderText = "Mrid";
            this.mridDataGridViewTextBoxColumn1.Name = "mridDataGridViewTextBoxColumn1";
            // 
            // wattCapacityDataGridViewTextBoxColumn
            // 
            this.wattCapacityDataGridViewTextBoxColumn.DataPropertyName = "WattCapacity";
            this.wattCapacityDataGridViewTextBoxColumn.HeaderText = "WattCapacity";
            this.wattCapacityDataGridViewTextBoxColumn.Name = "wattCapacityDataGridViewTextBoxColumn";
            // 
            // varCapacityDataGridViewTextBoxColumn
            // 
            this.varCapacityDataGridViewTextBoxColumn.DataPropertyName = "VarCapacity";
            this.varCapacityDataGridViewTextBoxColumn.HeaderText = "VarCapacity";
            this.varCapacityDataGridViewTextBoxColumn.Name = "varCapacityDataGridViewTextBoxColumn";
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(DERMSInterface.CIMData.device);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.DERGroupsView);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DER Group";
            // 
            // DERGroupsView
            // 
            this.DERGroupsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DERGroupsView.AutoGenerateColumns = false;
            this.DERGroupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DERGroupsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNameDataGridViewTextBoxColumn,
            this.mridDataGridViewTextBoxColumn,
            this.revisionDataGridViewTextBoxColumn,
            this.substationDataGridViewTextBoxColumn,
            this.feederDataGridViewTextBoxColumn,
            this.segmentDataGridViewTextBoxColumn,
            this.Members,
            this.realPower,
            this.reactivePower});
            this.DERGroupsView.DataSource = this.dERGroupBindingSource;
            this.DERGroupsView.Location = new System.Drawing.Point(6, 19);
            this.DERGroupsView.Name = "DERGroupsView";
            this.DERGroupsView.Size = new System.Drawing.Size(674, 217);
            this.DERGroupsView.TabIndex = 0;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // mridDataGridViewTextBoxColumn
            // 
            this.mridDataGridViewTextBoxColumn.DataPropertyName = "Mrid";
            this.mridDataGridViewTextBoxColumn.HeaderText = "Mrid";
            this.mridDataGridViewTextBoxColumn.Name = "mridDataGridViewTextBoxColumn";
            // 
            // revisionDataGridViewTextBoxColumn
            // 
            this.revisionDataGridViewTextBoxColumn.DataPropertyName = "Revision";
            this.revisionDataGridViewTextBoxColumn.HeaderText = "Revision";
            this.revisionDataGridViewTextBoxColumn.Name = "revisionDataGridViewTextBoxColumn";
            // 
            // substationDataGridViewTextBoxColumn
            // 
            this.substationDataGridViewTextBoxColumn.DataPropertyName = "Substation";
            this.substationDataGridViewTextBoxColumn.HeaderText = "Substation";
            this.substationDataGridViewTextBoxColumn.Name = "substationDataGridViewTextBoxColumn";
            // 
            // feederDataGridViewTextBoxColumn
            // 
            this.feederDataGridViewTextBoxColumn.DataPropertyName = "Feeder";
            this.feederDataGridViewTextBoxColumn.HeaderText = "Feeder";
            this.feederDataGridViewTextBoxColumn.Name = "feederDataGridViewTextBoxColumn";
            // 
            // segmentDataGridViewTextBoxColumn
            // 
            this.segmentDataGridViewTextBoxColumn.DataPropertyName = "Segment";
            this.segmentDataGridViewTextBoxColumn.HeaderText = "Segment";
            this.segmentDataGridViewTextBoxColumn.Name = "segmentDataGridViewTextBoxColumn";
            // 
            // Members
            // 
            this.Members.HeaderText = "Devices";
            this.Members.Name = "Members";
            this.Members.ReadOnly = true;
            this.Members.Width = 60;
            // 
            // realPower
            // 
            this.realPower.HeaderText = "Real Power";
            this.realPower.Name = "realPower";
            this.realPower.ReadOnly = true;
            this.realPower.Width = 75;
            // 
            // reactivePower
            // 
            this.reactivePower.HeaderText = "Reactive Power";
            this.reactivePower.Name = "reactivePower";
            this.reactivePower.ReadOnly = true;
            this.reactivePower.Width = 75;
            // 
            // dERGroupBindingSource
            // 
            this.dERGroupBindingSource.DataSource = typeof(DERMSInterface.CIMData.DERGroup);
            // 
            // DERGroupViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DERGroupViewControl";
            this.Size = new System.Drawing.Size(692, 497);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DERView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DERGroupsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DERView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DERGroupsView;
        private System.Windows.Forms.BindingSource dERGroupBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wattCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn substationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feederDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Members;
        private System.Windows.Forms.DataGridViewTextBoxColumn realPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn reactivePower;
    }
}
