using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    public class ClothingItem : Entity
    {
        public string Name { get; set; }

        public double RentPrice { get; set; }

        public int StockQuantity { get; set; }

        public string AvailabilityStatus { get; set; }

        public string Description { get; set; }

        public int Size { get; set; }

        public byte[] Image { get; set; }

        public string Color { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
