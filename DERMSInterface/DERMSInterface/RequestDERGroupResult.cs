using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
   public  class RequestDERGroupResult
    {
        private int _returncode;
        private string _errorMessage;
        private string _SOAPMessage;
        private string _SOAPResponse;
        private string[] _members;

        public int Returncode
        {
            get { return _returncode; }
            set { _returncode = value; }
        }


        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }


        public string SOAPMessage
        {
            get { return _SOAPMessage; }
            set { _SOAPMessage = value; }
        }


        public string SOAPResponse
        {
            get { return _SOAPResponse; }
            set { _SOAPResponse = value; }
        }


        public string[] Members
        {
            get { return _members; }
            set { _members = value; }
        }
    }
}
