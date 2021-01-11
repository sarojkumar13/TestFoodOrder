using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFoodOrder
{
    public class ItemType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }

    enum FoodType
    {
        Food = 1,
        Drink = 2
    };
}
