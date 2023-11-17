using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Domain.Repositories
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        Task<Employee> findEmployeeByEmail(string email);
        Task<Employee> findByIdWithRentalsAsync(string email);
        Task<Employee> findByEmailWithRentalsAsync(int employeeId);
        Task<bool> IsEmployeeRegistered(string email);
    }
}
