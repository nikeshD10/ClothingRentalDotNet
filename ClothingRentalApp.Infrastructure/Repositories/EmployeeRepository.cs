using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
            employees = new List<Employee>();
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

        public Employee Login(string email, string password)
        {
            var employee = employees.FirstOrDefault(e => e.Email == email);

            //Check of the employee exists and the provided password is correct
            if (employee != null && employee.Password == password)
            {
                Console.WriteLine("Login successfull.");
                return employee;
            }
            Console.WriteLine("Invalid email or password.");
            return null;
        }

        public void Register(string name, string email, string password, bool isAdmin = false)
        {
            if (employees.Any(e => e.Email == email))
            {
                Console.WriteLine("Email is already registered. Please use a different one.");
                return;
            }

            //Create a new employee and add to the list
            var newEmployee = new Employee()
            {
                Name = name,
                Email = email,
                Password = password,
                IsAdmin = isAdmin,
                //Rentals = new List<Rental>()
            };
            employees.Add(newEmployee);
            Console.WriteLine("Registration sucessfull.");
        }
    }
}
