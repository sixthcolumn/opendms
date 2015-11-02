using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    class MultiSpeakMsgHeader
    {
        private int _majorVersion;
        private int _minorVersion;
        private int _build;
        private string _buildString;
        private int _branch;
        private string _appName;
        private string _appVersion;
        private string _company;
        private string _auditID;
        private string _auditPassword;
        private string _systemID;
        private string _password;
        private string _codedNamePart;
        private string _codedNameType;
        private string _codedValue;
        private string _codedDescription;
        private string _CSIOtherKind;
        private string _CSAuthorityNameValue;
        private string _CSIValue;
        private string _CoordinateSystemAuthorityCode;
        private string _CSAuthorityNameOtherKind;
        private string _datum;

        public MultiSpeakMsgHeader(int majorVersion,
            int minorVersion,
            int build,
            string buildString,
            int branch,
            string appName,
            string appVersion,
            string company,
            string auditID,
            string auditPassword,
            string systemID,
            string password,
            string codedNamePart,
            string codedNameType,
            string codedValue,
            string codedDescription,
            string CSIOtherKind,
            string CSAuthorityNameValue,
            string CSIValue,
            string CoordinateSystemAuthorityCode,
            string CSAuthorityNameOtherKind,
            string datum)
        {
            _majorVersion = majorVersion;
            _minorVersion = minorVersion;
            _build = build;
            _buildString = buildString;
            _branch = branch;
            _appName = appName;
            _appVersion = appVersion;
            _company = company;
            _auditID = auditID;
            _auditPassword = auditPassword;
            _systemID = systemID;
            _password = password;
            _codedNamePart = codedNamePart;
            _codedNameType = codedNameType;
            _codedValue = codedValue;
            _codedDescription = codedDescription;
            _CSIOtherKind = CSIOtherKind;
            _CSAuthorityNameValue = CSAuthorityNameValue;
            _CSIValue = CSIValue;
            _CoordinateSystemAuthorityCode = CoordinateSystemAuthorityCode;
            _CSAuthorityNameOtherKind = CSAuthorityNameOtherKind;
            _datum = datum;
        }


        public int MajorVersion
        {
            get { return _majorVersion; }
        }


        public int MinorVersion
        {
            get { return _minorVersion; }
        }


        public int Build
        {
            get { return _build; }
        }


        public int Branch
        {
            get { return _branch; }
        }


        public string BuildString
        {
            get { return _buildString; }
        }


        public string AppName
        {
            get { return _appName; }
        }


        public string AppVersion
        {
            get { return _appVersion; }
        }


        public string Company
        {
            get { return _company; }
        }


        public string AuditID
        {
            get { return _auditID; }
        }


        public string AuditPassword
        {
            get { return _auditPassword; }
        }


        public string SystemID
        {
            get { return _systemID; }
        }


        public string Password
        {
            get { return _password; }
        }


        public string CodedNameType
        {
            get { return _codedNameType; }
        }


        public string CodedValue
        {
            get { return _codedValue; }
        }


        public string CodedNamePart
        {
            get { return _codedNamePart; }
        }


        public string CodedDescription
        {
            get { return _codedDescription; }
        }


        public string CSIOtherKind
        {
            get { return _CSIOtherKind; }
        }


        public string CSIValue
        {
            get { return _CSIValue; }
        }


        public string CSAuthorityNameOtherKind
        {
            get { return _CSAuthorityNameOtherKind; }
        }


        public string CSAuthorityNameValue
        {
            get { return _CSAuthorityNameValue; }
        }


        public string CoordinateSystemAuthorityCode
        {
            get { return _CoordinateSystemAuthorityCode; }
        }


        public string Datum
        {
            get { return _datum; }
        }
    }
}
