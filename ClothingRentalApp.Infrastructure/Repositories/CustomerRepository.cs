using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
