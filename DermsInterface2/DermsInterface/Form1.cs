using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DERMSInterface;

namespace DermsConfig
{
    public partial class Form1 : Form
    {
        DERMSInterface.CIMData _cim = null;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private string verb(String name)
        {
            if (name.Equals("createDER") || name.Equals("dispatchDER"))
                return "create";
            else if (name.Equals("getDER") || name.Equals("getDERStatus"))
                return "get";
            else
                return null;
        }

        private DERMSInterface.CIMData.header getHeader(string name)
        {
            DERMSInterface.CIMData.header h = _cim.Headers.Find(x => x.Name.Equals(name));
            // if it doesn't exist, we'll create it
            if (h == null)
                h = new DERMSInterface.CIMData.header();
            return h;
        }

        private void endPointText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).EndPoint = ((TextBox)sender).Text;
        }

        private void replyAddressText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).ReplyAddress = ((TextBox)sender).Text;
        }

        private void ackRequiredCheck_CheckedChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).AckRequired = ((CheckBox)sender).Checked;
        }

        private void commentText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).Comment = ((TextBox)sender).Text;
        }

        private void userIDText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).UserID = ((TextBox)sender).Text;
        }

        private void organizationText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).UserOrganization = ((TextBox)sender).Text;
        }

        private void contextText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).Context = ((TextBox)sender).Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "XML|*.xml";
            d.Title = "Save Header File";
            d.ShowDialog();

            if (d.FileName != "")
            {
                this.filePath = d.FileName;
                _cim.write(d.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void openFile(string path)
        {
            string name = messageTypeCombo.Text;
            this.filePath = path;
            _cim = DERMSInterface.CIMData.read(path);
            DERMSInterface.CIMData.header h = _cim.Headers.Find(x => x.Name.Equals(name));
            if (h != null)
            {
                endPointText.Text = h.EndPoint;
                replyAddressText.Text = h.ReplyAddress;
                ackRequiredCheck.Checked = h.AckRequired;
                // hardcoded!
                verbText.Text = h.Verb = verb(name);
                userIDText.Text = h.UserID;
                organizationText.Text = h.UserOrganization;
                contextText.Text = h.Context;
                commentText.Text = h.Comment;
            }
        }

        private void saveFile(string path)
        {
            _cim.write(path);
        }

        private void messageTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = messageTypeCombo.Text;
            DERMSInterface.CIMData.header h = getHeader(messageTypeCombo.Text);
            endPointText.Text = h.EndPoint;
            replyAddressText.Text = h.ReplyAddress;
            ackRequiredCheck.Checked = h.AckRequired;
            userIDText.Text = h.UserID;
            organizationText.Text = h.UserOrganization;
            contextText.Text = h.Context;
            commentText.Text = h.Comment;
        }

    }
}
