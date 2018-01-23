using System;
using IntegrationTests.ServiceReference1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
    [TestClass]
    public class ServiceUnitTest
    {
        [TestMethod]
        public void GetData_Sucess()
        {
            int value = 3;
            ServiceClient client = new ServiceClient();

            var data = client.GetData(value);

            Assert.AreEqual("From Dependency " + value, data);
        }
    }
}
