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
        public void initializeGetDERGroup()
        {
            this.getDERGroupAddRowButton.Click += new EventHandler(this.addDERGroup_Click);
            this.getDERGroupGo.Click += new EventHandler(this.getDERGroup_Click);
        }

        /*
         * Simply adds a new text widget to the list of ders you want to
         * get
         */
        private void addDERGroup_Click(object sender, System.EventArgs e)
        {
            TextBox t = new System.Windows.Forms.TextBox();
            this.getDERGroupMemberPanel.Controls.Add(t);
            t.Location = new System.Drawing.Point(3, 32);
            t.Name = "groupMemberText1";
            t.Size = new System.Drawing.Size(240, 20);
            t.TabIndex = 4;
            t.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.getDERGroupMemberPanel.PerformLayout();
        }

        /*
         * Go button : Execute the get der group request
         */
        private void getDERGroup_Click(object sender, System.EventArgs e)
        {
            List<String> derms = new List<string>();
            foreach (Control c in getDERGroupMemberPanel.Controls.OfType<TextBox>())
            {
                if (c.Text != null && c.Text.Length > 0)
                    derms.Add(c.Text);

            }

            if (derms.Count > 0)
            {
                //  DERMSInterface.GetDERGroupHeader header = new DERMSInterface.GetDERGroupHeader();
                DERMSInterface.CIM cim = new DERMSInterface.CIM();

                // default endpoint from app config if not set
                if (this.getDERGroupEndPoint.Text != null && this.getDERGroupEndPoint.Text.Length > 0)
                    cim.EndPoint = this.getDERGroupEndPoint.Text;

                String[] reply = cim.getDERGroup(derms.ToArray<String>());

                GetDERGroupLogText.Clear();
                GetDERGroupLogText.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
                GetDERGroupLogText.AppendText("Sent:" + Environment.NewLine + Environment.NewLine);
                GetDERGroupLogText.SelectionFont = new Font("Verdana", 10, FontStyle.Regular);
                GetDERGroupLogText.AppendText(cim.LastMessageSent + Environment.NewLine + Environment.NewLine);

                GetDERGroupLogText.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
                GetDERGroupLogText.AppendText("Reply:" + Environment.NewLine + Environment.NewLine);
                GetDERGroupLogText.SelectionFont = new Font("Verdana", 10, FontStyle.Regular);
                GetDERGroupLogText.AppendText(cim.LastMessageReceived + Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
