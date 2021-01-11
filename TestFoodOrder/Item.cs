using System;
using System.ComponentModel.DataAnnotations;

namespace TestFoodOrder
{
    public class Item
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int ItemTypeId { get; set; }

        public virtual ItemType ItemType { get; set; }
    }
}
