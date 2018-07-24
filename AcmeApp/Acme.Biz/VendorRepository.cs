using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;
        /// <summary>
        /// Retrieve one vendor.  
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }
        /// <summary>
        /// Retrieves all of the approved vendors
        /// </summary>
        /// <returns></returns>
        public ICollection<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "Technossus", Email = "pranav@technossus.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "Infosys", Email = "pranav@infosys.com" });
            }
            WriteLine(vendors[1]);
            return vendors;
        }
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                {"T", new Vendor(){ VendorId = 1, CompanyName = "Technossus", Email = "pranav@technossus.com"} },
                {"I", new Vendor(){VendorId = 2, CompanyName = "Infosys", Email = "pranav@infosys.com" } }
            };
            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;
                WriteLine($"Key: {key} Value: {vendor}");

            }
            foreach (var vendor in vendors.Values)
            {
                WriteLine(vendor);
            }

            foreach (var companyName in vendors.Keys)
            {
                WriteLine(vendors[companyName]);
            }

            //if(vendors.ContainsKey("A"))
            //{
            //    WriteLine(vendors["A"]);
            //}
            //Vendor vendor;
            //if(vendors.TryGetValue("A", out vendor))
            //{
            //    WriteLine(vendor);
            //}
            //Console.WriteLine(vendors);
            return vendors;
        }
        public T Retrievevalue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }


        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
        /// <summary>
        /// Retrieves all of the approved vendors, one at a time
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            this.Retrieve();
            foreach (var vendor in vendors)
            {
                WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }

        public IEnumerable<Vendor> RetrieveAll()
        {
            var vendors = new List<Vendor>()
            {
                {new Vendor() { VendorId = 1, CompanyName = "Tech Technossus", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 2, CompanyName = "Tech Infosys", Email = "pranav@infosys.com" } },
                {new Vendor() { VendorId = 3, CompanyName = "Tech LiveDeftsoft", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 4, CompanyName = "Tech TCS", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 5, CompanyName = "Biorad", Email = "pranav@infosys.com" } },
                {new Vendor() { VendorId = 6, CompanyName = "Helix", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 7, CompanyName = "Word and Brown", Email = "pranav@infosys.com" } },
                {new Vendor() { VendorId = 8, CompanyName = "Hp", Email = "pranav@technossus.com" }},
                {new Vendor() { VendorId = 9, CompanyName = "Dell", Email = "pranav@infosys.com" } },
                {new Vendor() { VendorId =10, CompanyName = "Lenovo", Email = "pranav@infosys.com" } },
            };                                               
            return vendors;                                  

        }
    }
}
