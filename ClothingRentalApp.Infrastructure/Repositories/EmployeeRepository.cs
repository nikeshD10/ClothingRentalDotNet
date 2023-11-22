using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Employee> findByEmailWithRentalsAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> findByIdWithRentalsAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> findEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEmployeeRegistered(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Login(string email, string password)
        {
            try
            {
                var employee = await _dbContext.Employees
               .Where(e => e.Email == email && e.Password == password)
               .FirstAsync();

                return employee;
            } catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Invalid Login Credentials", ex);
            }
           
        }

        public async Task<Employee>Register(Employee employee)
        {
            // check if the employee already exist with the email
            bool existenceStatus = await _dbContext.Employees.AnyAsync(e => e.Email == employee.Email);
            if (existenceStatus) {
                throw new InvalidOperationException("Employee with this email already exists");
            }
            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
            return employee;
        }
    }
}
