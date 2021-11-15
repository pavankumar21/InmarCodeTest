using OOPfundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OOPfundamentals.Controllers
{
    public class ProductController : ApiController
    {
        private static OfferService _OfferService;
        public ProductController(OfferService OfferService)
        {
            _OfferService = OfferService;
        }
        

        public IEnumerable<Offer> GetTodaysOffers()
        {
            return _OfferService.GetTodaysOffers(); ;
        }

        public IEnumerable<Product> GetProduct()
        {
            var tempresult =  _OfferService.GetAllProducts();

            tempresult = tempresult.OrderBy(x => x.Price).ToList().Take(3).ToList();

            return tempresult;
        }

        public Product GetSecondLowestPriceProduct()
        {
            var tempresult = _OfferService.GetAllProducts();

            tempresult = tempresult.OrderBy(x => x.Price).ToList().Take(2).ToList();

            return tempresult[1];
        }
      
        // POST api/values
        public void Post([FromBody] Product value)
        {
             _OfferService.AddAProducts(value);           
        }

       
    }
}
