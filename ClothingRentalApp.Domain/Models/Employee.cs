using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    public class Employee: Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string IsAdmin { get; set; }

        public List<Rental> Rentals { get; set; }
    }
}
