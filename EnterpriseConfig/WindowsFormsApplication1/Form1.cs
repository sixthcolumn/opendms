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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string _filepath;
        public static DERMSInterface.CIMData _cim = new CIMData();
        private BindingSource ScadaBindingSource = new BindingSource();


        /// <summary>
        /// initializes the form and the event handlers
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            bindAllDataSources();
        }

        /// <summary>
        /// Binds all forms, child forms etc... with the cimdata
        /// object which is serialized to file
        /// </summary>
        private void bindAllDataSources()
        {
            scadaControl.BindDataSource(_cim);
            derGroupViewControl1.bindDataSource(_cim);
            derHeaderControl1.bindDataSource(_cim);
        }


        /// <summary>
        /// save the in memory cim data to a file
        /// </summary>
        /// <param name="_filepath">file name</param>
        private void saveFile(string _filepath)
        {
            foreach (CIMData.DERGroup group in _cim.Groups)
            {
                if (group.GroupName == null || group.GroupName.Length < 1)
                {
                    MessageBox.Show("Please set DERGroup names", "File Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            _cim.write(_filepath);
        }

        /// <summary>
        /// loads cim config file into memory
        /// </summary>
        /// <param name="path">file name</param>
        private void openFile(string path)
        {
            // read the xml config file
            this._filepath = path;
            _cim = DERMSInterface.CIMData.read(path);

            // load the header form based on which header type is set in combobox
            bindAllDataSources();
        }


        /// <summary>
        /// test => create DER : event handler. displays create DER form to send SOAP messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = derGroupViewControl1.getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                // name must be defined
                if (_cim.Groups[row].GroupName == null || _cim.Groups[row].GroupName.Length < 1)
                    MessageBox.Show("Name required to create DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    new CreateDERForm(_cim.clone(), _cim.Groups[row]).Show();
            }
            else if (_cim.Groups.Count == 0)
                MessageBox.Show("Please create and then select a DER Group", "Create DER", MessageBoxButtons.OK);
            else
                MessageBox.Show("Please select a single DER Group ROW", "Create DER", MessageBoxButtons.OK);
        }

        /// <summary>
        /// test => get DER status : event handler. Displays the GET DER Status form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDERStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = derGroupViewControl1.getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                // name must be defined
                if (_cim.Groups[row].GroupName == null || _cim.Groups[row].GroupName.Length < 1)
                    MessageBox.Show("Name required to create DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    new GetDERStatusForm(_cim.clone(), _cim.Groups[row]).Show();
            }
            else if (_cim.Groups.Count == 0)
                MessageBox.Show("Please create and then select a DER Group", "Create DER", MessageBoxButtons.OK);
            else
                MessageBox.Show("Please select a DER Group ROW", "Create DER", MessageBoxButtons.OK);

        }

        /// <summary>
        /// test => dispatch der : event handler. Displays the Dispatch DER form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatchDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = derGroupViewControl1.getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                if (_cim.Groups[row].Mrid == null || _cim.Groups[row].Mrid.Length < 1)
                    MessageBox.Show("MRID requried to dispatch DER Group", "Dispatch DER", MessageBoxButtons.OK);
                else
                    new DispatchDERForm(_cim.clone(), _cim.Groups[row]).Show();
            }
        }

        /// <summary>
        /// test => get der : event handler. Displays the get DER form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDERsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = derGroupViewControl1.getSingleSelectedRow(ref isValid);


            if (isValid == true)
            {
                if (_cim.Groups[row].Mrid == null || _cim.Groups[row].Mrid.Length < 1)
                    MessageBox.Show("MRID requried to dispatch DER Group", "Dispatch DER", MessageBoxButtons.OK);
                else
                    new GetDERGroupForm(_cim.clone(), _cim.Groups[row]).Show();
            }
        }

        /// <summary>
        /// open file : displays open file widget and opens new config file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// save : saves config information to file. If file name not set, calls save as...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cim.Groups.ToString();
            // if _filepath not set, send them to 'save as'
            if (_filepath == null || _filepath.Length < 1)
                saveAsToolStripMenuItem_Click(sender, e);
            else
                saveFile(_filepath);
        }

        /// <summary>
        /// save as : displays file save as menu, and saves config to xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "XML|*.xml";
            d.Title = "Save Header File";
            d.ShowDialog();

            if (d.FileName != "")
            {
                this._filepath = d.FileName;
                saveFile(d.FileName);
            }
        }

        /// <summary>
        /// New Button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cim = new CIMData();
            bindAllDataSources();
            derGroupViewControl1.updateDERGroupViewReadOnlyCells();
        }

    }
}
