using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class XMLForm : Form
    {
        public XMLForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            this.textBox.Clear();
        }

        public void addText(String text)
        {
            this.textBox.SelectionFont = new Font("Verdana", 8, FontStyle.Regular);
            this.textBox.AppendText(text);
        }

        public void addBoldText(String text)
        {
            this.textBox.SelectionFont = new Font("Verdana", 8, FontStyle.Bold);
            this.textBox.AppendText(text);
        }
    }
}
