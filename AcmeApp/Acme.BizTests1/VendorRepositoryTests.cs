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
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveAllTest()
        {
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                {new Vendor() { VendorId = 1, CompanyName = "Tech Technossus", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 2, CompanyName = "Tech Infosys", Email = "pranav@infosys.com" } },
                {new Vendor() { VendorId = 3, CompanyName = "Tech LiveDeftsoft", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 4, CompanyName = "Tech TCS", Email = "pranav@technossus.com" }}
            };

            //Act
            var vendors = repository.RetrieveAll();
            //var vendorQuery = from v in vendors
            //                  where v.CompanyName.Contains("Tech")
            //                  orderby v.CompanyName
            //                  select v;
            var vendorQuery = vendors.Where(FilterCompanies)
                .OrderBy(OrderCompaniesByName);

            //Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }
        private bool FilterCompanies(Vendor v)=>
             v.CompanyName.Contains("Tech");
        private string OrderCompaniesByName(Vendor v) => v.CompanyName;
        
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
            var actual = repository.Retrieve().ToList();
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            var repository = new VendorRepository();
            var expected = new Dictionary<string, Vendor>()
            {
               {"T", new Vendor(){ VendorId = 1, CompanyName = "Technossus", Email = "pranav@technossus.com"} },
               {"I", new Vendor(){VendorId = 2, CompanyName = "Infosys", Email = "pranav@infosys.com" } }
            };
            //Act
            var actual = repository.RetrieveWithKeys();
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveWithIteratorTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                { new Vendor(){ VendorId=1, CompanyName="Technossus", Email="pranav@technossus.com"} },
                 { new Vendor(){VendorId = 2, CompanyName = "Infosys", Email = "pranav@infosys.com" } }
            };
            //Act
            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var item in vendorIterator)
            {
                Console.WriteLine(item);
            }
            var actual = vendorIterator.ToList();
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}