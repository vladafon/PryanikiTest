using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PryanikiTest.Models;

namespace PryanikiTest.DB
{
    public static class DB
    {
        public static List<Product> Products = new List<Product>();
        public static List<Order> Orders = new List<Order>();

        private static int _orderId = 0;

        public static int GetOrderId()
        {
            _orderId++;
            return _orderId;
        }
        //putting some values to our "DB"
        public static void Initialize()
        {
            Product product = new Product
            {
                ProductId = 1,
                Name = "Milk",
                Price = 60,
                ExpirationDate = DateTime.Parse("17.11.2019"),
                Quantity = 100,
                Manufacturer = "Prostokvashino"
            };
            Products.Add(product);

            product = new Product
            {
                ProductId = 2,
                Name = "Bread",
                Price = 40,
                ExpirationDate = DateTime.Parse("19.11.2019"),
                Quantity = 231,
                Manufacturer = "Dobryninsky"
            };
            Products.Add(product);

            product = new Product
            {
                ProductId = 3,
                Name = "Chocolate",
                Price = 120,
                ExpirationDate = DateTime.Parse("15.12.2019"),
                Quantity = 15,
                Manufacturer = "Rossiya"
            };
            Products.Add(product);
            product = new Product
            {
                ProductId = 4,
                Name = "Water",
                Price = 60,
                ExpirationDate = DateTime.Parse("20.12.2019"),
                Quantity = 300,
                Manufacturer = "BonAqua"
            };
            Products.Add(product);
            product = new Product
            {
                ProductId = 3,
                Name = "Eggs",
                Price = 100,
                ExpirationDate = DateTime.Parse("21.11.2019"),
                Quantity = 50,
                Manufacturer = "Krasnaya cena"
            };
            Products.Add(product);
        }
    }
}
