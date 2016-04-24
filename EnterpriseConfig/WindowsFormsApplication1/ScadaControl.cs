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

        private DERMSInterface.CIMData _cim;

        // todo : I don't know what the state column contains, purpose

        // binds _cim.scada to scada forms
        private BindingSource ScadaBindingSource = new BindingSource();

        // list of supported device types, self loading
        private List<CIMData.DeviceType> devices = new List<CIMData.DeviceType>();

        public ScadaControl()
        {
            InitializeComponent();
            scadaDeviceView.CellFormatting += scadaDeviceView_CellFormatting;
            scadaDeviceView.CellValueChanged += scadaDeviceView_CellValueChanged;
            scadaDeviceView.RowEnter += scadaDeviceView_RowEnter;

            // todo : Get real device type names from files
            string deviceDirectory = ConfigurationManager.AppSettings["deviceFilesDir"];
            if (deviceDirectory != null)
            {
                Console.WriteLine("Current working dir: " + Directory.GetCurrentDirectory() + " devicedir: " + deviceDirectory);
                loadDeviceTypes(@".");
                //loadDeviceTypes(Directory.GetCurrentDirectory());

                scadaInfoControl1.setDeviceTypes(devices);
            }
            else
            {
                MessageBox.Show("deviceFilesDir not set in config file. Device types NOT loaded", "Device Types", MessageBoxButtons.OK);
            }

            // give link so that UI rebuild can happen when device type selections are changed
            scadaInfoControl1.setTestControls(testScadaControl1);
        }


        /// <summary>
        /// loads device types used in scada control from multiple device type xml files
        /// </summary>
        /// <param name="path">fully qualified path to file</param>
        public void loadDeviceTypes(string path)
        {

            Console.WriteLine("loading device types from: " + path);

            // todo : Put in place for code gen, fix
            XmlSerializer serializer = new XmlSerializer(typeof(CIMData.DeviceType));
            var files = Directory.GetFiles(path, "*_device.xml");

            foreach (string f in files)
            {
                System.IO.FileStream file = new System.IO.FileStream(f, System.IO.FileMode.Open);
                try
                {
                   CIMData.DeviceType device = (CIMData.DeviceType)serializer.Deserialize(file);
                    devices.Add(device);
                   

                    /*   test code
                    CIMData.DeviceType devicex = new CIMData.DeviceType();
                    devicex.Name = "testname";
                    devicex.Protocols = new List<CIMData.DeviceType.Protocol>();
                    CIMData.DeviceType.Protocol pp = new CIMData.DeviceType.Protocol();
                    pp.Name = "proto name";
                    pp.DNP3PointDefinitions = new List<CIMData.DeviceType.Protocol.DNP3PointTypeDef>();

                    CIMData.DeviceType.Protocol.DNP3PointTypeDef ptd= new CIMData.DeviceType.Protocol.DNP3PointTypeDef();
                    ptd.DNP3PointList = new List<CIMData.DeviceType.Protocol.DNP3PointTypeDef.DNP3PointDef>();

                    CIMData.DeviceType.Protocol.DNP3PointTypeDef.DNP3PointDef pd = new CIMData.DeviceType.Protocol.DNP3PointTypeDef.DNP3PointDef();
                    ptd.DNP3TypeName = "STATUS";
                    pd.DNP3EventClass = 1;
                    pd.DNP3PointDesc = "this is my descr";
                    pd.DNP3PointName = "breaker1";
                    pd.DNP3PointNum = 0;
                    ptd.DNP3PointList.Add(pd);

                    pp.DNP3PointDefinitions.Add(ptd);
                    devicex.Protocols.Add(pp);

                    serializer.Serialize(Console.Out, devicex);
                     * */
                }
                catch (Exception ex)
                {
                    DumpException(ex);
                }  
                finally
                {
                    file.Close();
                }
            }
                                 
}

public static void DumpException( Exception ex )
{
  Console.WriteLine( "--------- Outer Exception Data ---------" );        
  WriteExceptionInfo( ex );
  ex = ex.InnerException;                     
  if( null != ex )               
  {                                   
    Console.WriteLine( "--------- Inner Exception Data ---------" );                
    WriteExceptionInfo( ex.InnerException );    
    ex = ex.InnerException;
  }
}
public static void WriteExceptionInfo( Exception ex )
{
  Console.WriteLine( "Message: {0}", ex.Message );                  
  Console.WriteLine( "Exception Type: {0}", ex.GetType().FullName );
  Console.WriteLine( "Source: {0}", ex.Source );                    
  Console.WriteLine( "StrackTrace: {0}", ex.StackTrace );           
  Console.WriteLine( "TargetSite: {0}", ex.TargetSite );            
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
            testScadaControl1.bindDataSource(row);

        }

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
        public void BindDataSource(DERMSInterface.CIMData cim)
        {
            _cim = cim;
            ScadaBindingSource.DataSource = _cim.Scada;
            scadaDeviceView.DataSource = ScadaBindingSource;

            // hide these columns
            scadaDeviceView.Columns["Mrid"].Visible = false;
            scadaDeviceView.Columns["Channel"].Visible = false;
            scadaDeviceView.Columns["Connected"].Visible = false;
            scadaDeviceView.Columns["Master"].Visible = false;


            scadaDeviceView.Columns["LogLevel"].Visible = false;
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
