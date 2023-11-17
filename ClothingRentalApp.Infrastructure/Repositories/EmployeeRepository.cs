using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
