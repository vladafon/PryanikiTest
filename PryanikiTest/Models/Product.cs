using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PryanikiTest.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
