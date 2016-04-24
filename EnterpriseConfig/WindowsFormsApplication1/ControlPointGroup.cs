using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Automatak.DNP3.Interface;
using SCADAInterface;

namespace WindowsFormsApplication1
{
    public partial class ControlPointGroup : UserControl
    {
        private string _pname;
        private ushort _command_index;
        private string _device_mrid;

        public ControlPointGroup(string labelname)
        {
            InitializeComponent();
            this.groupBox.Text = labelname;
        }

        public String Device_mrid
        {
            get { return _device_mrid; }
            set { _device_mrid = value; }
        }

        public string PName
        {
            get { return _pname; }
            set { _pname = value; }
        }

        public ushort CommandIndex 
        {
            get { return _command_index; }
            set { _command_index = value; }
        }

        private void execute_button_clicked(object sender, EventArgs e)
        {
            string commandname = "unknown";
            //TODO get radio selection
            if (radioButton1.Checked)
            {
                commandname = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                commandname = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                commandname = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                commandname = radioButton4.Text;
            }
            else
            {
                Console.WriteLine("error - one command must be selected!");
                return;
            }

            // call DLL operate
            SCADAIFace.OperateDevice(_device_mrid, commandname, _command_index);
        }

        
    }
}
