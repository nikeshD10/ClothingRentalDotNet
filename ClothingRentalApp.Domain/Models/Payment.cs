using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    
    public class Payment : Entity
    {
        public enum PayMethod
        {
            card, cash
        }
        public DateTime PaymentDate { get; set; }

        public double PaymentAmount { get; set; }

        public PayMethod PaymentMethod { get; set; }

        public int RentalId { get; set; } // Foreign Key
        public Rental Rental { get; set; }
    }
}
