using ClothingRentalApp.Domain.SeedWork;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    public class Customer : Entity
    {
        // [Required]
        // [StringLength(100)]
        public Customer() {
            Rentals = new List<Rental>();
        }
        public string Name { get; set; }

        // [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        
        public List<Rental> Rentals { get; set; }

    }
}
