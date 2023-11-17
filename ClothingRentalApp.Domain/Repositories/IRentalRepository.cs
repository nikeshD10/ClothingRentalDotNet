using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Domain.Repositories
{
    public interface IRentalRepository : IRepository<Rental>
    {
        Task<List<Rental>> GetRentalsByCustomerIdAsync(int customerId);
        Task <List<Rental>> GetRentalsByEmployeeIdAsync(int employeeId);
        Task<Rental> GetRentalWithItemAsync(int rentalId);
        Task<double> GetTotalRentalCostAsync(int rentalId);
        Task<List<Rental>> GetActiveRentalsAsync();
        Task<List<Rental>> GetCompletedRentalsAsync();
        Task<List<Rental>> GetRentalsInDateRangeAsync(DateTime startDate, DateTime endTime);
    }
}
