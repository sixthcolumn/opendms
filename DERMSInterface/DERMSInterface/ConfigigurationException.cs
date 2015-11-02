using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    class ConfigureException : Exception
    {
        public ConfigureException()
        {

        }

        public ConfigureException(string message)
            : base(message)
        {

        }
    }
}
