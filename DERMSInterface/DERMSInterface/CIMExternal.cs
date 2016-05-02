using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;

namespace DERMSInterface
{
    class CIMExternal
    {
        const int _arraySize = 10;

        /// <summary>
        /// returns an xml string containing der names from the group, along
        /// with other information, the soap out/in message, return code,
        /// stack trace if failure.
        /// </summary>
        /// <param name="path">path to file containing der definitions</param>
        /// <param name="mrid">the unique id of the DER Group be be searched</param>
        /// <param name="xml">the return string</param>
        /// <returns>0 for success, 1 for failure</returns>
        [DllExport("requestDERGroupMembers", CallingConvention = CallingConvention.Cdecl)]
        public static int requestDERGroupMembers([MarshalAs(UnmanagedType.LPTStr)]String path,
            [MarshalAs(UnmanagedType.LPTStr)]String mrid,
            [MarshalAs(UnmanagedType.LPTStr)]ref String xml)
        {
            DERResult result = new DERResult();
            try
            {
                Console.WriteLine("DER file : " + path);
                Console.WriteLine("MRID : " + mrid);
                String SOAPMessage = null;
                String SOAPResponse = null;
                String[] rvalue = CIM.requestDERGroupMembers(path, mrid, ref SOAPMessage, ref SOAPResponse);

                result.Members = rvalue;
                result.SOAPMessage = SOAPMessage;
                result.SOAPResponse = SOAPResponse;
                result.Returncode = 0;

            }
            catch (Exception e)
            {
                result.Returncode = 1;
                result.ErrorMessage = e.ToString();
                Console.Write("Exception thrown by requestDERGroupMembers : ", e);
            }

            XmlSerializer ser = new XmlSerializer(typeof(DERResult));
            StringWriter writer = new StringWriter();
            ser.Serialize(writer, result);
            xml = writer.ToString();

            return result.Returncode;
        }

        [DllExport("dispatchDERGroup", CallingConvention = CallingConvention.Cdecl)]
        public static int dispatchDERGroup(
           [MarshalAs(UnmanagedType.LPTStr)]String path,
           [MarshalAs(UnmanagedType.LPTStr)]String mrid,
           [MarshalAs(UnmanagedType.LPTStr)]String q,
           [MarshalAs(UnmanagedType.LPTStr)]ref String xml,
           [MarshalAs(UnmanagedType.Bool)]bool isOverride,
           [MarshalAs(UnmanagedType.R8)]double overrideValue)
        {
            DERResult result = new DERResult();

            try
            {
                quantity qtype = (quantity)Enum.Parse(typeof(DERMSInterface.quantity), q);
                Console.WriteLine("DER file : " + path);
                Console.WriteLine("DERGroupName : " + mrid);
                Console.WriteLine("Override : " + isOverride);
                Console.WriteLine("Override value : " + overrideValue);
                String SOAPMessage = null;
                String SOAPResponse = null;
                int rvalue = CIM.DispatchDERGroup(path, mrid, qtype, ref SOAPMessage, ref SOAPResponse, isOverride, overrideValue);

                result.SOAPMessage = SOAPMessage;
                result.SOAPResponse = SOAPResponse;
                result.Returncode = 0;
            }
            catch (Exception e)
            {
                result.Returncode = 1;
                result.ErrorMessage = e.ToString();
                Console.WriteLine("Exception: {0}", e);
            }

            XmlSerializer ser = new XmlSerializer(typeof(DERResult));
            StringWriter writer = new StringWriter();
            ser.Serialize(writer, result);
            xml = writer.ToString();

            return result.Returncode;
        }



        [DllExport("createDERGroup", CallingConvention = CallingConvention.Cdecl)]
        public static int createDERGroup(
           [MarshalAs(UnmanagedType.LPTStr)]String path,
           [MarshalAs(UnmanagedType.LPTStr)]String mrid,
           [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeConst = _arraySize)] String[] names,
           [MarshalAs(UnmanagedType.LPTStr)] ref String xml)
        {
            DERResult result = new DERResult();
            List<String> nameList = new List<string>();

            try
            {
                /*
                 * the String[] names is terminated when we find
                 * a value = null. This is due to marshalling in
                 * c#. We build a list and then pass a normal string
                 * array to the createDerGroup
                 */
                for (int i = 0; i < _arraySize; i++)
                {
                    if (names[i] == null)
                        break;
                    nameList.Add(names[i]);
                }

                Console.WriteLine("DER file : " + path);
                Console.WriteLine("DERGroupName : " + mrid);
                String SOAPMessage = null;
                String SOAPResponse = null;
                int rvalue = CIM.CreateDERGroup(path, mrid, nameList.ToArray<String>(), ref SOAPMessage, ref SOAPResponse);
                result.SOAPMessage = SOAPMessage;
                result.SOAPResponse = SOAPResponse;
                result.Returncode = 0;

            }
            catch (Exception e)
            {
                result.Returncode = 1;
                result.ErrorMessage = e.ToString();
                Console.WriteLine("DERConfigureException: {0}", e);
            }

            XmlSerializer ser = new XmlSerializer(typeof(DERResult));
            StringWriter writer = new StringWriter();
            ser.Serialize(writer, result);
            xml = writer.ToString();

            return result.Returncode;
        }

        [DllExport("getDERGroupStatus", CallingConvention = CallingConvention.Cdecl)]
        public static int getDERGroupStatus(
           [MarshalAs(UnmanagedType.LPTStr)]String path,
           [MarshalAs(UnmanagedType.LPTStr)]String mrid,
           [MarshalAs(UnmanagedType.LPTStr)]String q,
           [MarshalAs(UnmanagedType.LPTStr)] ref String xml)
        {
            DERResult result = new DERResult();
            List<String> nameList = new List<string>();

            try
            {
                quantity qtype = (quantity)Enum.Parse(typeof(DERMSInterface.quantity), q);

                Console.WriteLine("DER file : " + path);
                Console.WriteLine("DERGroupName : " + mrid);
                String SOAPMessage = null;
                String SOAPResponse = null;
                CIMData.DERStatus status = CIM.getDERGroupStatus(path, mrid, qtype, ref SOAPMessage, ref SOAPResponse);
                int rvalue = CIM.CreateDERGroup(path, mrid, nameList.ToArray<String>(), ref SOAPMessage, ref SOAPResponse);
                result.Status = status;
                result.SOAPMessage = SOAPMessage;
                result.SOAPResponse = SOAPResponse;
                result.Returncode = 0;

            }
            catch (Exception e)
            {
                result.Returncode = 1;
                result.ErrorMessage = e.ToString();
                Console.WriteLine("DERConfigureException: {0}", e);
            }

            XmlSerializer ser = new XmlSerializer(typeof(DERResult));
            StringWriter writer = new StringWriter();
            ser.Serialize(writer, result);
            xml = writer.ToString();

            return result.Returncode;
        }



    }
}
