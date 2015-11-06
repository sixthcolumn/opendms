using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    class DERResponseException : Exception
    {
        public DERResponseException()
        {

        }

        public DERResponseException(string message)
            : base(message)
        {

        }
    }
}
