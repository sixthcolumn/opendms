using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace DMSConfig
{
    public partial class MultiSpeakMsgHeaderForm : Form
    {
        public MultiSpeakMsgHeaderForm()
        {
            InitializeComponent();
           // string majorVersion = ConfigurationManager.AppSettings["MSMajorVersion"];
           // string minorVersion = ConfigurationManager.AppSettings["MSMinorVersion"];

            this.majorVersionText.Text = Settings1.Default.MSMajorVersion.ToString();
            this.minorVersionText.Text = Settings1.Default.MSMinorVersion.ToString();
            this.buildText.Text = Settings1.Default.MSBuild.ToString();
            this.branchText.Text = Settings1.Default.MSBranch.ToString();
            this.buildStringCombo.Text = Settings1.Default.MSBuildString.ToString();
            this.appNameText.Text = Settings1.Default.MSAppName.ToString();
            this.appVersionText.Text = Settings1.Default.MSAppVersion.ToString();
            this.companyText.Text = Settings1.Default.MSCompany;
            this.auditIDText.Text = Settings1.Default.MSAuditID;
            this.auditPasswordText.Text = Settings1.Default.MSAuditPassword;
            this.sysgtemIDText.Text = Settings1.Default.MSSystemID;
            this.CodeNameTypeCombo.Text = Settings1.Default.MSCodedNameType;
            this.codeValueText.Text = Settings1.Default.MSCodedValue;
            this.CSAuthorityNameOtherText.Text = Settings1.Default.MSCSAuthNameOther;
            this.CSAuthorityNameValueText.Text = Settings1.Default.MSCSAuthNameValue;
            this.CSUnitsOtherText.Text = Settings1.Default.MSCSUnitOther;
            this.CSUnitsCombo.Text = Settings1.Default.MSCSUnitValue;
            this.datumText.Text = Settings1.Default.MSCSDatum;



            this.saveButton.Click += new EventHandler(this.SaveButton_Click);
            this.cancelButton.Click += new EventHandler(this.ExitButton_Click);
        }

        void ExitButton_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        void SaveButton_Click(Object sender, EventArgs e)
        {
            Settings1.Default.MSMajorVersion = Convert.ToUInt32(this.majorVersionText.Text);
            Settings1.Default.MSMinorVersion = Convert.ToUInt16(this.minorVersionText.Text);
            Settings1.Default.MSBuild = Convert.ToUInt32(this.buildText.Text);
            Settings1.Default.MSBranch = Convert.ToUInt32(this.branchText.Text);
            Settings1.Default.MSBuildString = this.buildStringCombo.Text;
            Settings1.Default.MSAppName = this.appNameText.Text;
            Settings1.Default.MSAppVersion = this.appVersionText.Text;
            Settings1.Default.MSCompany = this.companyText.Text;
            Settings1.Default.MSAuditID = this.auditIDText.Text;
            Settings1.Default.MSAuditPassword = this.auditPasswordText.Text;
            Settings1.Default.MSSystemID = this.sysgtemIDText.Text;
            Settings1.Default.MSCodedNameType = this.CodeNameTypeCombo.Text;
            Settings1.Default.MSCodedValue = this.codeValueText.Text;
            Settings1.Default.MSCSAuthNameOther = this.CSAuthorityNameOtherText.Text;
            Settings1.Default.MSCSAuthNameValue = this.CSAuthorityNameValueText.Text;
            Settings1.Default.MSCSUnitOther = this.CSUnitsOtherText.Text;
            Settings1.Default.MSCSUnitValue = this.CSUnitsCombo.Text;
            Settings1.Default.MSCSDatum = this.datumText.Text;

            Settings1.Default.Save();

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void codeGroupBox_Enter(object sender, EventArgs e)
        {

        }

    }
}
