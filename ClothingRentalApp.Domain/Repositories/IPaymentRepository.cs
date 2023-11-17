using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Domain.Repositories
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Task<List<Payment>> GetPaymentsByCustomerIdAsync(int customerId);

        Task<List<Payment>> GetPaymentsByRentalIdAsync (int rentalId);

        Task<double> GetTotalPaymentsByCustomerIdAsync (int customerId);

        Task<double> GetTotalPaymentsByRentalIdAsync(int rentalId);

        Task<List<Payment>> GetPaymentsInDateRangeAsync(DateTime startDate, DateTime endDate);
    }
}
