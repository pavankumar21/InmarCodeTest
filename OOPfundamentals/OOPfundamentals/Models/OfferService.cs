using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPfundamentals.Models
{
    public class OfferService
    {
        private List<Product> _inventory;

        public OfferService()
        {
            this.AddDataToInventory();
        }
        private void AddDataToInventory()
        {
            var listofProductis = new List<Product>() {
                new Product("p1",1000,"p1 desc"){ ProductName = "p1", Price=1000 ,Description="P1 desc"},
                new Product("p2",200,"p2 desc"){ ProductName = "p1", Price=1000 ,Description="P1 desc"},
                new Product("p3",400,"p3 desc"){ ProductName = "p1", Price=1000 ,Description="P1 desc"},
                new Product("p4",700,"p4 desc"){ ProductName = "p1", Price=1000 ,Description="P1 desc"},
                new Product("p5",600,"p5 desc"){ ProductName = "p1", Price=1000 ,Description="P1 desc"},
                new Product("p6",800,"p6 desc"){ ProductName = "p1", Price=1000 ,Description="P1 desc"},
            };
            _inventory = listofProductis;
        }

        public List<Product> GetAllProducts()
        {
            return this._inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            var result = new List<Offer>() {
                new Offer("“ComboPackage1”",_inventory.Take(3).ToList()),
                new Offer("“ComboPackage2”",_inventory.Take(3).ToList()),
                 new Offer("“ComboPackage3”",_inventory.Take(3).ToList()),
                  new Offer("“ComboPackage4”",_inventory.Take(3).ToList()),
            };
            return result;
        }
    }
}