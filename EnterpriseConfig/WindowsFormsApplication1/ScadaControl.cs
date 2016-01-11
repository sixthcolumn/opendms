using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DERMSInterface;
using System.IO;
using System.Xml.Serialization;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class ScadaControl : UserControl
    {


        // todo : I don't know what the state column contains, purpose

        private BindingSource ScadaBindingSource = new BindingSource();
        private List<CIMData.DeviceType> devices = new List<CIMData.DeviceType>();

        public ScadaControl()
        {
            InitializeComponent();
            scadaDeviceView.CellFormatting += scadaDeviceView_CellFormatting;
            scadaDeviceView.CellValueChanged += scadaDeviceView_CellValueChanged;
            scadaDeviceView.RowEnter += scadaDeviceView_RowEnter;
            // todo : Get real device type names from files

            string deviceDirectory = ConfigurationManager.AppSettings["deviceFilesDir"];
            loadDeviceTypes(deviceDirectory);

            scadaInfoControl1.setDeviceTypes(devices);

        }



        public void loadDeviceTypes(string path)
        {
            // todo : Put in place for code gen, fix
            if( path == null )
                path = "./";
            XmlSerializer serializer = new XmlSerializer(typeof(CIMData.DeviceType));
            var files = Directory.GetFiles(path, "*_device.xml");
            foreach (string f in files)
            {
                System.IO.FileStream file = new System.IO.FileStream(f, System.IO.FileMode.Open);
                try
                {
                    CIMData.DeviceType device = (CIMData.DeviceType)serializer.Deserialize(file);
                    devices.Add(device);
                }
                finally
                {
                    file.Close();
                }
            }
        }

        /// <summary>
        /// When the user selects a row, need to pass values to the info form so
        /// that it can sync data with the grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scadaDeviceView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            List<CIMData.SCADAInfo> list = (List<CIMData.SCADAInfo>)ScadaBindingSource.DataSource;
            CIMData.SCADAInfo row = list.ElementAt(e.RowIndex);
            scadaInfoControl1.bindScadaRecord(row, scadaDeviceView);
            dnP3Control1.bindDataSource(row.Dnp);
        }
/*
        public void reset()
        {
            scadaInfoControl1.reset();
            dnP3Control1.reset();
        }
        */

        /// <summary>
        /// Sets default values for the scada view table's columns. Currently
        /// sets the protocol only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scadaDeviceView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // DPN3 is always the default
            if (scadaDeviceView.Columns[e.ColumnIndex].Name == "ProtocolCombo")
                e.Value = "DNP3";
        }

        /// <summary>
        /// parent form calls this to pass the scada list from the main object
        /// to this form.
        /// </summary>
        /// <param name="scada"></param>
        public void BindDataSource(List<CIMData.SCADAInfo> scada)
        {
            ScadaBindingSource.DataSource = scada;
            scadaDeviceView.DataSource = ScadaBindingSource;

            // hide these columns
            scadaDeviceView.Columns["Mrid"].Visible = false;
            scadaDeviceView.Columns["LogLevel"].Visible = false;
            scadaDeviceView.Columns["Mrid"].Visible = false;
            scadaDeviceView.Columns["Description"].Visible = false;
            scadaDeviceView.Columns["Protocol"].Visible = false;
            scadaDeviceView.Columns["DeviceType"].Visible = false;
            scadaDeviceView.Columns["DNP"].Visible = false;

            // Protocol is a combo box
            if (scadaDeviceView.Columns["ProtocolCombo"] == null)
            {
                DataGridViewComboBoxColumn colbox = new DataGridViewComboBoxColumn();
                colbox.DataPropertyName = "Protocol";
                // todo : add additional communication protocols. Do the internals differ?
                colbox.Items.AddRange("DNP3");
                colbox.Name = "ProtocolCombo";
                colbox.HeaderText = "Protocol";
                scadaDeviceView.Columns.Add(colbox);
            }
        }

        /// <summary>
        /// Cell value change, updates the info form with the values from
        /// the grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scadaDeviceView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (scadaDeviceView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string value = scadaDeviceView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (scadaDeviceView.Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "Protocol": scadaInfoControl1.ProtocolCombo.Text = value; break;
                    case "Name": scadaInfoControl1.NameText.Text = value; break;
                    case "Mrid": scadaInfoControl1.MRIDText.Text = value; break;
                    case "Feeder": scadaInfoControl1.FeederText.Text = value; break;
                    case "DeviceType": scadaInfoControl1.TypeCombo.Text = value; break;
                    case "Substation": scadaInfoControl1.SubstationText.Text = value; break;
                }
            }
        }

    }
}
