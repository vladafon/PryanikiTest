using System;

namespace PryanikiTest.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string CustomerName { get; set; }
    }
}
