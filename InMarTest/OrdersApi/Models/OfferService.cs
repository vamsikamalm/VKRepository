using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class OfferService
    {
        public List<Product> Inventory;
         
        public OfferService()
        {
            Inventory = new List<Product>();
            PopulateInventory();
        }
        private void PopulateInventory()
        {
            Inventory.Add(new Product("P1", 1000, "P1 Desc"));
            Inventory.Add(new Product("P2", 200, "P2 Desc"));
            Inventory.Add(new Product("P3", 400, "P3 Desc"));
            Inventory.Add(new Product("P4", 700, "P4 Desc"));
            Inventory.Add(new Product("P5", 600, "P5 Desc"));
            Inventory.Add(new Product("P6", 800, "P6 Desc"));
        }
        public List<Offer> GetTodaysOffers()
        {
            List<Offer> offers = new List<Offer>();
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                offers.Add(new Offer("ComboPackage1", Inventory.GetRange(0, 2)));
                offers.Add(new Offer("ComboPackage1", Inventory.GetRange(1, 3)));
                offers.Add(new Offer("ComboPackage1", Inventory.GetRange(0, 2)));
                offers.Add(new Offer("ComboPackage1", Inventory.GetRange(0, 2)));
            }
            return offers;
        }

        public List<Product> GetAllProducts()
        {
            return Inventory; 
        }
    }
}
