using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Domain.Repositories
{
    public interface ICustomerRepository : IRepository <Customer>
    {
        Task<Customer> findCustomerByRentalId(int rentalId);

        Task<Customer> findByEmailAsync(string email);
        // To check whethere customer is already registered in the database or is customer new
        Task<bool> IsCustomerRegisteredAsync(string email);
        // retrieve customer with all rental history
        Task<Customer> FindByIdWithRentalsAsync(int customerId);
        void RegisterCustomer(Customer customer);


    }
}
