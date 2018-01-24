using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using wcfusingunity;
using wcfusingunity.Dependencies;

namespace UnitTests
{
    [TestClass]
    public class ServiceUnitTest
    {
        [TestMethod]
        public void GetData_Success()
        {
            int value = 3;
            var mockDependency = new Mock<IDependency>();

            mockDependency.Setup(a => a.GetValue(value)).Returns("From Dependency " + value);
            Service service = new Service(mockDependency.Object);
            string expectedData = service.GetData(value);

            Assert.AreEqual("From Dependency " + 3, expectedData);
        }
    }
   
}
