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

namespace WindowsFormsApplication1
{
    public partial class DNP3Control : UserControl
    {
        private CIMData.DNP dnp;

        public DNP3Control()
        {
            InitializeComponent();
        }

        public void reset()
        {
            dnP3BasicControl1.reset();
            dnP3Advanced1.reset();
        }

        public void bindDNP(CIMData.DNP dnp) {
            this.dnp = dnp;
            dnP3BasicControl1.bindDNPData(dnp);
            dnP3Advanced1.bindDNPData(dnp);
        }
    }
}
