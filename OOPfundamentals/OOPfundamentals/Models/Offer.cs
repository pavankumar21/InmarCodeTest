using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPfundamentals.Models
{
        public class Offer
        {
            private string _OfferName;
            private List<Product> _Products;           
            public Offer(string OfferName, List<Product> product)
            {
                this.OfferName = OfferName;
                this.Products = product;                
            }

        public string OfferName { get => _OfferName; set => _OfferName = value; }
        public List<Product> Products { get => _Products; set => _Products = value; }
    }    
}