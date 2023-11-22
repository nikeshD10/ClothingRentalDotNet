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

        public bool IsAdmin { get; set; }

        public List<Rental> Rentals { get; set; }

        public override string ToString()
        {
            return $"Employee with name : {Name}, email : {Email} and password : {Password} and role : {IsAdmin}";
        }
    }
}
