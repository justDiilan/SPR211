using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetMagazine;

namespace Collections_HW
{
    internal class DBContext
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Manufacturer> Manufacturers { get; set; } = new List<Manufacturer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
