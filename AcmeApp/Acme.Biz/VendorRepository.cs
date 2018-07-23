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
        public List<Vendor> Retrieve()
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
            Console.WriteLine(vendors);
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
    }
}
