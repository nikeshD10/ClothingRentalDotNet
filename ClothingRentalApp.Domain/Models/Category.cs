using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }  
        public ClothingItem ClothingItem { get; set; }
    }
}
