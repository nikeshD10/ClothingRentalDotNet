using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class RentalRepository : Repository<Rental>, IRentalRepository
    {
        public RentalRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Rental>> GetActiveRentalsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Rental>> GetCompletedRentalsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Rental>> GetRentalsByCustomerIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Rental>> GetRentalsByEmployeeIdAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Rental>> GetRentalsInDateRangeAsync(DateTime startDate, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public Task<Rental> GetRentalWithItemAsync(int rentalId)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetTotalRentalCostAsync(int rentalId)
        {
            throw new NotImplementedException();
        }
    }
}
