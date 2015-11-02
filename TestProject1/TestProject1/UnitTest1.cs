using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {

            String[] derms = new String[2] { "derms1", "derms2" };
            DERMSInterface.CIM cim = new DERMSInterface.CIM();
            cim.EndPoint = "http://10.3.253.100:8080/DERConnect/cim/getDERGroup";
            String[] reply = cim.getDERGroup(derms);
        }

        [TestMethod]
        public void TestMethod2()
        {
            String[] derms = new String[2] { "derms1", "derms2" };
            DERMSInterface.CIM cim = new DERMSInterface.CIM();
            cim.EndPoint = "http://10.3.253.100:8080/DERConnect/cim/changeDERGroup";
            int reply = cim.createDERGroup("DerGroup1", new string[2] { "dgsub1", "dbsub2" });
            Assert.IsTrue(reply == 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            String[] derms = new String[2] { "derms1", "derms2" };
            DERMSInterface.CIM cim = new DERMSInterface.CIM();
            cim.EndPoint = "http://10.3.253.100:8080/DERConnect/cim/getDERGroupStatus";
            DERMSInterface.DERGroupStatusResponse reply = cim.getDERGroupStatus(derms, DERMSInterface.quantity.RealPower);
        }

        [TestMethod]
        public void TestMethod4()
        {
            String derms = "derms1";
            DERMSInterface.CIM cim = new DERMSInterface.CIM();
            cim.EndPoint = "http://10.3.253.100:8080/DERConnect/cim/changeDERGroupDispatch";
            int reply = cim.DispatchDERGroup(derms, 0.177, DERMSInterface.quantity.ApparentPower);
            Assert.IsTrue(reply == 0);
        }
    }
}