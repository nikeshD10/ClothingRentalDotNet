using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Infrastructure;
using ClothingRentalApp.Infrastructure.Repositories;

class Program
{
    static void Main()
    {
        var dbContext = new ClothingRentalAppDbContext();
        var employeeService = new EmployeeRepository(dbContext);

        while (true)
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine()!;

                    Console.Write("Enter your email: ");
                    string email = Console.ReadLine()!;

                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine()!;

                    employeeService.Register(name, email, password);
                    break;

                case "2":
                    Console.Write("Enter your email: ");
                    string loginEmail = Console.ReadLine()!;

                    Console.Write("Enter your password: ");
                    string loginPassword = Console.ReadLine()!;

                    Employee loggedInEmployee = employeeService.Login(loginEmail, loginPassword);

                    break;

                case "3":
                    Console.WriteLine("Exiting the application.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
