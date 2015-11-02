using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    class HeaderNotFoundException : Exception
    {
        public HeaderNotFoundException()
        {

        }

        public HeaderNotFoundException(string message)
            : base(message)
        {

        }
    }
}
