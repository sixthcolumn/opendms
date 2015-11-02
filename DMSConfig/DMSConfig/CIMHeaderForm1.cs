using DERMSInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.RegularExpressions;


namespace DMSConfig
{


    public partial class CIMHeaderForm1 : Form
    {

        private String filePath;
        private CIMDefaults header = new CIMDefaults();


        public CIMHeaderForm1()
        {
            InitializeComponent();
            initializeGetDERGroup();
            initializeCreateDERGroup();

            this.SaveAs.Click += new EventHandler(this.fileSaveAs_Click);
            this.openFileMenuItem.Click += new EventHandler(this.fileOpen_Click);
            this.saveMenuItem.Click += new EventHandler(this.fileSave_Click);
            this.ackRequired.SelectedIndex = 0;
            this.asyncReplyFlag.SelectedIndex = 0;
            this.created.Leave += new EventHandler(this.valiDate);
            this.timestamp.Leave += new EventHandler(this.valiDate);
            this.timestamp.Text = DateTime.Now.ToString();
            this.created.Text = DateTime.Now.ToString();
            this.exitMenuItem.Click += new EventHandler(this.exit_Click);
            this.dispatchRequestedValueText.TextChanged += new EventHandler(this.textDecimal_KeyPress);
        }

        public void openFile(String path)
        {
            DERMSInterface.CIMDefaults ch = new DERMSInterface.CIMDefaults();
            try
            {
                header.readHeader(path);
                this.Text = "Cim Header Config : " + new System.IO.FileInfo(path).Name.ToString();

            }
            catch (InvalidOperationException)
            {
                if (MessageBox.Show("File does not contain CIM header data. Use default values?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Text = "Cim Header Config : Default";
                }
                else
                {
                    return;
                }
            }

            this.replyAddress.Text = header.ReplyAddress;
            this.source.Text = header.Source;
            this.timestamp.Text = header.Timestamp.ToString();
            this.context.Text = header.Context;
            this.revision.Text = header.Revision;
            this.noun.Text = header.Noun;
            this.createDerGroupVerbCombo.Text = header.CreateVerb == null ? "create" : header.CreateVerb;
            this.getDERGroupCombo.Text = header.GetVerb == null ? "get" : header.GetVerb;
            this.GetDERGroupStatusCombo.Text = header.StatusVerb == null ? "get" : header.StatusVerb;
            this.DispatchDERGroupCombo.Text = header.DispatchVerb == null ? "change" : header.DispatchVerb;
            this.nonce.Text = header.ReplayDetectionNonce;
            this.created.Text = header.ReplayDetectionCreated.ToString();
            this.comment.Text = header.Comment;
            this.correlationID.Text = header.CorrelationID;
            this.messageID.Text = header.MessageID;
            this.asyncReplyFlag.Text = (header.AsyncReplyFlag == true) ? "True" : "False";
            this.ackRequired.Text = header.AckRequired == true ? "True" : "False";
            this.createDERGroupEndPointText.Text = header.CreateDERGroupEndPoint;
            this.getDERGroupEndpointText.Text = header.GetDERGroupEndPoint;
            this.dispatchDERGroupEndpointText.Text = header.DispatchDERGroupEndPoint;
            this.getDERGroupStatusEndpointText.Text = header.GetDERGroupStatusEndPoint;
            CIMDefaults.Property[] p = header.getProperties();
            if (p.Length > 0)
            {
                this.propertyValue.Text = p[0].Value;
                this.propertyName.Text = p[0].Name;
            }

            this.organization.Text = header.UserOrganization;
            this.userID.Text = header.UserID;

            this.filePath = path;
        }

        private void valiDate(object sender, System.EventArgs e)
        {
            TextBox text = (TextBox)sender;
            DateTime dateValue;
            if (text.Text.Length > 0 && !DateTime.TryParse(text.Text, out dateValue))
            {
                text.Text = DateTime.MinValue.ToString();
                MessageBox.Show("Invalid Date format: Try MM/DD/YYYY HH:MI:SS AM");
            }
        }

        public void saveHeader(String path)
        {

            header.ReplyAddress = this.replyAddress.Text;
            header.Source = this.source.Text;
            header.Timestamp = Convert.ToDateTime(this.timestamp.Text);
            header.Context = this.context.Text;
            header.Revision = this.revision.Text;
            header.Noun = this.noun.Text;
            header.CreateVerb = this.createDerGroupVerbCombo.Text;
            header.GetVerb = this.getDERGroupCombo.Text;
            header.DispatchVerb = this.DispatchDERGroupCombo.Text;
            header.StatusVerb = this.GetDERGroupStatusCombo.Text;
            header.ReplayDetectionCreated = Convert.ToDateTime(this.created.Text);
            header.ReplayDetectionNonce = this.nonce.Text;
            header.Comment = this.comment.Text;
            header.CorrelationID = this.correlationID.Text;
            header.MessageID = this.messageID.Text;
            header.AsyncReplyFlag = bool.Parse(this.asyncReplyFlag.Text);
            header.AckRequired = bool.Parse(this.ackRequired.Text);
            header.Properties = new List<DERMSInterface.CIMDefaults.Property>();
            CIMDefaults.Property p = new CIMDefaults.Property();
            p.Name = this.propertyName.Text;
            p.Value = this.propertyValue.Text;
            header.addProperty(p);
            header.UserID = this.userID.Text;
            header.UserOrganization = this.organization.Text;
            header.CreateDERGroupEndPoint = this.createDERGroupEndPointText.Text;
            header.GetDERGroupEndPoint = this.getDERGroupEndpointText.Text;
            header.DispatchDERGroupEndPoint = this.dispatchDERGroupEndpointText.Text;
            header.GetDERGroupStatusEndPoint = this.getDERGroupStatusEndpointText.Text;

            header.writeHeader(path);
        }



        private void fileSaveAs_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "XML|*.xml";
            d.Title = "Save Header File";
            d.ShowDialog();

            if (d.FileName != "")
            {
                saveHeader(d.FileName);
            }
        }



      

        private void exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void fileSave_Click(object sender, System.EventArgs e)
        {
            if (this.filePath == null)
                fileSaveAs_Click(sender, e);
            else
                saveHeader(this.filePath);
        }

        private void fileOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "XML|*.xml";
            d.Title = "Save Header File";
            d.ShowDialog();

            if (d.FileName != "")
            {
                openFile(d.FileName);
            }
        }

        private void CIMHeader_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void verb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dispatchResponseText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispatchGoButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cim = new CIM();
            cim.DispatchDERGroup(dispatchDERGroupIDText.Text, 1.0,quantity.RealPower);

        }

        private void dispatchRequestedValueText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDecimal_KeyPress(object sender, EventArgs e)
        {
            double result = 0.0;
            TextBox box = (TextBox)sender;
            if( Double.TryParse(box.Text, out result) != true)
            {
                MessageBox.Show("Floating point number required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verbGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void getDERGroupGo_Click(object sender, EventArgs e)
        {

        }
    }
}
