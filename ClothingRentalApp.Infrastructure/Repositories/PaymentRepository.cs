using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Payment>> GetPaymentsByCustomerIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Payment>> GetPaymentsByRentalIdAsync(int rentalId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Payment>> GetPaymentsInDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetTotalPaymentsByCustomerIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetTotalPaymentsByRentalIdAsync(int rentalId)
        {
            throw new NotImplementedException();
        }
    }
}
