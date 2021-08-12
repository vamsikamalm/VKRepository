using Microsoft.AspNetCore.Mvc;
using OrdersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OffersController : Controller
    {
        public OfferService offerService { get; set; }
        public OffersController(OfferService offrService)
        {
            this.offerService = offrService;
        }
        [HttpGet]
        public IEnumerable<Offer> Get()
        {
            return offerService.GetTodaysOffers();
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return offerService.GetAllProducts().OrderBy(x=>x.Price).Take(3);
        }

        [HttpGet]
        [Route("GetSecondLowest")]
        public async Task<Product> GetSecondLowest()
        {
            return offerService.GetAllProducts().OrderBy(x => x.Price).Skip(1).First();
        }

        [HttpPost]
        public void Post(Product p)
        {
            offerService.Inventory.Add(p);
        }

    }
}
