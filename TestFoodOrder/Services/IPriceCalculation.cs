using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFoodOrder.Services
{
    public interface IPriceCalculation
    {
        Task<double> ItemTotalPrice(List<Item> items);
    }
}
