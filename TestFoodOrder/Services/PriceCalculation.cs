using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFoodOrder.Services
{
    public class PriceCalculation : IPriceCalculation
    {
        //Assuming Service Charge to be 10%;
        //Because of simple requirement, not adding seperate class for tax calculations.

        private readonly double serviceCharge = 10;

        public Task<double> ItemTotalPrice(List<Item> items)
        {
            double itemPrice = 0;
            foreach (var item in items)
            {
                itemPrice += item.Price;
            }
            if (items.Any(x => x.ItemTypeId == (int)FoodType.Food))
                return Task.FromResult(itemPrice + (itemPrice * serviceCharge / 100));
            
            return Task.FromResult(itemPrice);
        }
    }
}
