﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrievevalueTest()
        {
            var repository = new VendorRepository();
            var expected = 42;

            //Act
            var actual = repository.Retrievevalue<int>("Select ....", 42);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrievevalueStringTest()
        {
            var repository = new VendorRepository();
            var expected = "test";

            //Act
            var actual = repository.Retrievevalue<string>("Select ....", "test");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RetrievevalueObjectTest()
        {
            var repository = new VendorRepository();
            var vendor = new Vendor();
            var expected = vendor;

            //Act
            var actual = repository.Retrievevalue<Vendor>("Select ....", vendor);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            var repository = new VendorRepository();
            //  var expected = 2;
            var expected = new List<Vendor>();
            expected.Add(new Vendor() { VendorId = 1, CompanyName = "Technossus", Email = "pranav@technossus.com" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "Infosys", Email = "pranav@infosys.com" });

            //Act
            var actual = repository.Retrieve();
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}