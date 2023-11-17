using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Domain.Models
{
    public enum RentStatus
    {
        Pending,
        Returned,
        Overdue
    }
    public class Rental : Entity
    {
        public Rental() { 
            Payments = new List<Payment>();
        }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public RentStatus RentalStatus { get; set; }

        public int EmployeeId { get; set; } // Foregin Key
        public Employee Employee { get; set; }
        public int CustomerId { get; set; } // Foregin Key
        public Customer Customer { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
