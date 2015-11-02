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

namespace DMSConfig
{
    /*
     * definitions and event handlers for the Get DER Group functionality
     * of the cim config form
     */
    public partial class CIMHeaderForm1 : Form
    {

        /*
         * Called by parent to initialize the get der group panel of
         * the cim form
         */
        public void initializeCreateDERGroup()
        {
            this.generateDERGroupButton.Click += new EventHandler(this.generateDERName_Click);
            this.generateDERMemberButton.Click += new EventHandler(this.generateDERMember_Click);
            this.addRowButton.Click += new EventHandler(this.addDERMember_Click);
            this.createDERGroupButton.Click += new EventHandler(this.createDERGroup_Click);
        }

        private void createDERGroup_Click(object sender, System.EventArgs e)
        {
            //  DERMSInterface.GetDERGroupHeader header = new DERMSInterface.GetDERGroupHeader();
            DERMSInterface.CIM cim = new DERMSInterface.CIM();

            // default endpoint from app config if not set
            if (this.getDERGroupEndPoint.Text != null && this.getDERGroupEndPoint.Text.Length > 0)
                cim.EndPoint = this.getDERGroupEndPoint.Text;

            List<String> derms = new List<string>();
            foreach (Control c in DerMemberPanel.Controls.OfType<TextBox>())
            {
                if (c.Text != null && c.Text.Length > 0)
                    derms.Add(c.Text);

            }

            if (derms.Count > 0)
            {
                int reply = cim.createDERGroup(DERGroupText.Text, derms.ToArray<String>());

                createDERGroupLogText.Text = "";
                createDERGroupLogText.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
                createDERGroupLogText.AppendText("Sent:" + Environment.NewLine + Environment.NewLine);
                createDERGroupLogText.SelectionFont = new Font("Verdana", 10, FontStyle.Regular);
                createDERGroupLogText.AppendText(cim.LastMessageSent + Environment.NewLine + Environment.NewLine);

                createDERGroupLogText.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
                createDERGroupLogText.AppendText("Reply:" + Environment.NewLine + Environment.NewLine);
                createDERGroupLogText.SelectionFont = new Font("Verdana", 10, FontStyle.Regular);
                createDERGroupLogText.AppendText(cim.LastMessageReceived + Environment.NewLine + Environment.NewLine);

            }
        }


        private void generateDERName_Click(object sender, System.EventArgs e)
        {
            DERGroupText.Text = CIM.getUUID();
        }

        private void generateDERMember_Click(object sender, System.EventArgs e)
        {
            foreach (Control c in this.DerMemberPanel.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.TextBox) && c.Text.Length < 1)
                    c.Text = CIM.getUUID();

            }
            Control.ControlCollection controls = this.DerMemberPanel.Controls;
        }

        private void addDERMember_Click(object sender, System.EventArgs e)
        {
            TextBox t = new System.Windows.Forms.TextBox();
            this.DerMemberPanel.Controls.Add(t);
            t.Location = new System.Drawing.Point(3, 32);
            t.Name = "groupMemberText1";
            t.Size = new System.Drawing.Size(270, 20);
            t.TabIndex = 4;
            t.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            DerMemberPanel.PerformLayout();
        }

    }
}
