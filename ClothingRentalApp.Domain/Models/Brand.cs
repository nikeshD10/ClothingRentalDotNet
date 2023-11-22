using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public ClothingItem ClothingItem { get; set; }
    }
}
