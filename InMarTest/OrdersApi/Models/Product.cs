using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string prodName, decimal price, string description)
        {
            this.ProductName = prodName;
            this.Price = price;
            this.Description = description; 
        }

    }
}
