using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Customer> findByEmailAsync(string email)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
