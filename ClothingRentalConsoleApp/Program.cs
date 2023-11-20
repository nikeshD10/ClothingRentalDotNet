using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Infrastructure;
using ClothingRentalApp.Infrastructure.Repositories;

class Program
{
    static void Main()
    {
        var dbContext = new ClothingRentalAppDbContext();
        var employeeService = new EmployeeRepository(dbContext);
        var customerService = new CustomerRepository(dbContext);
        var loggedInEmployee = default(Employee);
        var customer = new Customer();
        
        while (true)
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            if (loggedInEmployee != null)
            {
                Console.WriteLine("3. Search / Add Customer");
            }
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine()!;

            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine()!;

                    Console.Write("Enter your email: ");
                    string email = Console.ReadLine()!;

                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine()!;

                    Console.WriteLine("");
                    employeeService.Register(name, email, password);
                    Console.WriteLine("");
                    break;

                case "2":
                    Console.Write("Enter your email: ");
                    string loginEmail = Console.ReadLine()!;

                    Console.Write("Enter your password: ");
                    string loginPassword = Console.ReadLine()!;

                    Console.WriteLine("");
                    loggedInEmployee = employeeService.Login(loginEmail, loginPassword);
                    if (loggedInEmployee != null)
                    {
                        Console.WriteLine($"Welcome, {loggedInEmployee.Name}!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid email or password. Please try again.");
                    }
                    Console.WriteLine("");
                    break;
                case "3":

                    Console.Write("Enter customer email: ");
                    var custEmail = Console.ReadLine()!;

                    Console.WriteLine("");
                    var cust = customerService.findByEmailAsync(custEmail);
                    if(cust != null)
                    {
                        Console.WriteLine("");
                        break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Register Customer");

                    Console.Write("Enter customer name: ");
                    customer.Name = Console.ReadLine()!;

                    Console.Write("Enter customer email: ");
                    customer.Email = Console.ReadLine()!;

                    Console.Write("Enter customer phone number: ");
                    customer.Phone = Console.ReadLine()!;

                    Console.Write("Enter customer address: ");
                    customer.Address = Console.ReadLine()!;

                    customerService.RegisterCustomer(customer);
                    Console.WriteLine("");
                    break;

                case "4":
                    Console.WriteLine("Exiting the application.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
