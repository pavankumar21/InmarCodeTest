using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPfundamentals.Models
{
    public class Product
    {
        private string _ProductName;
        private decimal _Price;
        private string _Description;

        public Product(string ProductName, decimal Price, string Description)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Description = Description;
        }

        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public decimal Price { get => _Price; set => _Price = value; }
        public string Description { get => _Description; set => _Description = value; }
    }
}