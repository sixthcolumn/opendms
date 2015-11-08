using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    class DERConfigureException : Exception
    {
        public DERConfigureException()
        {

        }

        public DERConfigureException(string message)
            : base(message)
        {

        }
    }
}
