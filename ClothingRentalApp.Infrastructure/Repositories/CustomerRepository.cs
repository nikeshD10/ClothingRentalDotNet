using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private List<Customer> customers;

        public CustomerRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
            customers = new List<Customer>();
        }

        public Task<Customer> findByEmailAsync(string email)
        {
            var customer = customers.FirstOrDefault(e => e.Email == email);
            if (customer != null)
            {
                Console.WriteLine("Customer Found!");
                return Task.FromResult(customer);
            }
            Console.WriteLine("Customer Not Found!");
            return null;
        }

        public Task<Customer> FindByIdWithRentalsAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> findCustomerByRentalId(int rentalId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsCustomerRegisteredAsync(string email)
        {
            if (customers.Any(e => e.Email == email))
            {
                Console.WriteLine("Email is already registered. Please use a different one.");
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }
        public void RegisterCustomer(Customer customer)
        {
            if (customers.Any(e => e.Email == customer.Email))
            {
                Console.WriteLine("Email is already registered. Please use a different one.");
                return;
            }
            customers.Add(customer);
            Console.WriteLine("Customer registration successful.");

        }
    }
}
