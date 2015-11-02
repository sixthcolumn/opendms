using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    public class DERGroupStatusResponse
    {
        private double presentMaxCapability;
        private double presentValue;
        private int quantity;
        private double presentMinCapability;
        private string mrid;

        public double PresentValue
        {
            get { return presentValue; }
            set { presentValue = value; }
        }

        public double PresentMinCapability
        {
            get { return presentMinCapability; }
            set { presentMinCapability = value; }
        }

        public string Mrid
        {
            get { return mrid; }
            set { mrid = value; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double PresentMaxCapability
        {
            get { return presentMaxCapability; }
            set { presentMaxCapability = value; }
        }

    }
}
