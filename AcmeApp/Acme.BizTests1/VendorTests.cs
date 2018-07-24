using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void SendEmailTest()
        {
            //Arrange
            var vendorRepository = new VendorRepository();
            var vendors = vendorRepository.Retrieve();
            var expected = new List<string>()
            {
                "Message Sent: Important message for: ABC Corp",
                "Message Sent: Important message for: XYZ Inc"
            };
            //Act
            var actual = Vendor.SendEmail(vendors.ToList(), "Test Message");
            //Assert
            CollectionAssert.AreEqual(expected, actual);
    }
        [TestMethod()]
        public void SendEmailTestArray()
        {
            //Arrange
            var vendorRepository = new VendorRepository();
            var vendors = vendorRepository.Retrieve();
            var expected = new List<string>()
            {
                "Message Sent: Important message for: ABC Corp",
                "Message Sent: Important message for: XYZ Inc"
            };
            //Act
            var actual = Vendor.SendEmail(vendors.ToArray(), "Test Message");
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}