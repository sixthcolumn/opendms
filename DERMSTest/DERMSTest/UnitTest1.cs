using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DERMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DERMSInterface.CIM c = DERMSInterface.CIM.loadConfigFile("testConfig.xml");
            int rc = c.createDERGroup("dergroup1", null);
            Console.WriteLine("xml : " + c.LastMessageSent + c.LastMessageReceived);
            Assert.IsTrue(c.LastMessageSent.Length > 100);
            Assert.IsTrue(c.LastMessageReceived.Length > 100);
            Assert.AreEqual(rc, 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DERMSInterface.CIM c = DERMSInterface.CIM.loadConfigFile("testConfig.xml");
            int rc = c.DispatchDERGroup("dergroup1", DERMSInterface.quantity.RealPower);
            Console.WriteLine("xml : " + c.LastMessageSent + c.LastMessageReceived);
            Assert.IsTrue(c.LastMessageSent.Length > 100);
            Assert.IsTrue(c.LastMessageReceived.Length > 100);
            Assert.AreEqual(rc, 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DERMSInterface.CIM c = DERMSInterface.CIM.loadConfigFile("testConfig.xml");
            DERMSInterface.CIMData.DERStatus status = c.getDERGroupStatus("1234-5678", DERMSInterface.quantity.RealPower);
            Console.WriteLine("xml : " + c.LastMessageSent + c.LastMessageReceived);
            Assert.IsTrue(c.LastMessageSent.Length > 100);
            Assert.IsTrue(c.LastMessageReceived.Length > 100);
            Assert.AreEqual(status.PresentValue, (float)11.1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DERMSInterface.CIM c = DERMSInterface.CIM.loadConfigFile("testConfig.xml");
            String[] derms = c.requestDERGroupMembers("1234-5678");
            Console.WriteLine("xml : " + c.LastMessageSent + c.LastMessageReceived);
            Assert.IsTrue(c.LastMessageSent.Length > 100);
            Assert.IsTrue(c.LastMessageReceived.Length > 100);
            Assert.IsNotNull(derms);
            Assert.AreEqual(derms.Length, 1);
            Assert.IsTrue(derms[0].Equals("name1"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            String message = "";
            int rc = DERMSInterface.CIM.CreateDERGroup("testConfig.xml", "dergroup1", null, ref message);
            Console.WriteLine("xml : " + message);
            Assert.IsTrue(message.Length > 100);
            Assert.AreEqual(rc, 0);
        }

        [TestMethod]
        public void TestMethod6()
        {
            String message = "";
            int rc = DERMSInterface.CIM.DispatchDERGroup("testConfig.xml", "dergroup1", DERMSInterface.quantity.RealPower, ref message, false, 0.0);
            Console.WriteLine("xml : " + message);
            Assert.IsTrue(message.Length > 100);
            Assert.AreEqual(rc, 0);
        }

        [TestMethod]
        public void TestMethod7()
        {
            String message = "";
            DERMSInterface.CIMData.DERStatus status = DERMSInterface.CIM.getDERGroupStatus("testConfig.xml", "1234-5678", DERMSInterface.quantity.RealPower, ref message);
            Console.WriteLine("xml : " + message);
            Assert.IsTrue(message.Length > 100);
            Assert.AreEqual(status.PresentValue, (float)11.1);
        }

        [TestMethod]
        public void TestMethod8()
        {
            String message = "";
            DERMSInterface.CIM c = DERMSInterface.CIM.loadConfigFile("testConfig.xml");
            String[] derms = DERMSInterface.CIM.requestDERGroupMembers("testConfig.xml", "1234-5678", ref message);
            Console.WriteLine("xml : " + message);
            Assert.IsTrue(message.Length > 100);
            Assert.IsNotNull(derms);
            Assert.AreEqual(derms.Length, 1);
            Assert.IsTrue(derms[0].Equals("name1"));
        }

    }
}
