// See https://aka.ms/new-console-template for more information
using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Infrastructure;
using SQLitePCL;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

using (var uow = new UnitOfWork())
{
    Console.WriteLine("*****************                                      *********************");
    Console.WriteLine("*****************       Welcome to Clothing Rental     *********************");
    Console.WriteLine("*****************                                      *********************");
    Console.WriteLine("*****************                  ||                  *********************\n\n");

    

    async void RegisterEmployee()
    {
        try
        {
            Console.WriteLine("\n---------------------        Register        ---------------------------\n");
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the password: ");
            string password = Console.ReadLine();

            Console.Write("Want to assign admin role type yes or no: ");
            string isYesOrNoAdmin = Console.ReadLine();
            bool isAdmin = false;
            if (isYesOrNoAdmin.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }

            var newEmployee = new Employee()
            {
                Name = name,
                Email = email,
                Password = password,
                IsAdmin = isAdmin
            };
            var employee = await uow.EmployeeRepository.Register(newEmployee);
            await uow.SaveAsync();
        } catch (InvalidOperationException ex)
        {
            Console.WriteLine("Employee already exists ", ex.Message);
        }
    }

    async Task<Employee> LoginEmployee()
    {
        try
        {
            Console.WriteLine("\n---------------------        Login        ---------------------------\n");

            Console.Write("Enter the email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the password: ");
            string password = Console.ReadLine();

            Console.WriteLine("");
            return await uow.EmployeeRepository.Login(email, password);
        } catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid Credentials ", ex.Message);
            return null;
        }

    }

    bool isRegistered = false;
    bool isLoggedIn = false;
    var loggedInEmployee = default(Employee);
    string crudChoice = null;
    string productChoice = null;
    string customerChoice = null;

    async void AddBrand()
    {
        Brand brand = new Brand()
        {
            Name = "Zara"
        };
        uow.BrandRepository.Create(brand);
        await uow.SaveAsync();
    }

    async void ReadBrandById()
    {
        int brandId = 1;
        Brand brand = await uow.BrandRepository.FindByIdAsync(brandId);
        if (brand == null) {
            Console.WriteLine($"Brand with id {brandId} doesn't exists");
            return;
        }
        Console.WriteLine($"Brand name is {brand.Name} with Id {brand.Id}");
    }

    async void DeleteBrandById()
    {
        int brandId = 1;
        Brand brand = await uow.BrandRepository.FindByIdAsync(brandId);
        if (brand == null)
        {
            Console.WriteLine($"Brand with id {brandId} doesn't exists");
            return;
        }
        uow.BrandRepository.Delete(brand);
        await uow.SaveAsync();
    }




    async void AddProduct()
    {
        ClothingItem item = new ClothingItem()
        {
            Name = "Clothin Item 1",
            RentPrice = 20.00,
            StockQuantity =  5,
            AvailabilityStatus = "Available",
            Description = "Clothing Item 1 Description",
            Size = 40,
            Color = "Black",
            BrandId = 1,
            CategoryId = 1,
        };

    }

    
    while (true)
    {
       
        Console.WriteLine("++++++++++++++++++\n");
        if (loggedInEmployee == null)
        {
            if (!isRegistered)
            {
                Console.WriteLine("1. Register");
            }
            if (!isLoggedIn)
            {
                Console.WriteLine("2. Login");
            }
        } else {
            if (crudChoice == "1")
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Read Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("0. Exit");

                Console.Write("\nYour Input : ");
                productChoice = Console.ReadLine(); 

            } else if (crudChoice == "2")
            {
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Update Customer");
                Console.WriteLine("3. Read Customer");
                Console.WriteLine("4. Delete Customer");
                Console.WriteLine("0. Exit");

                Console.Write("\nYour Input : ");
                customerChoice = Console.ReadLine();
            } else
            {
                Console.WriteLine("1. CRUD Product");
                Console.WriteLine("2. CRUD Customer");
                Console.WriteLine("3. Create Rental");
                Console.WriteLine("4. List Rental");
                Console.WriteLine("5. List Customer");
                Console.WriteLine("6. Search employee by email");
                Console.WriteLine("7. Search customer by email");
                Console.WriteLine("8. Search product by id");
                Console.WriteLine("9. CRUD Brand");
                Console.WriteLine("10. CRUD Category");
            }
        }
        
        Console.WriteLine("0. Exit");
        Console.WriteLine("\n++++++++++++++++++\n");
        string choice = null; 
        if (customerChoice == null && productChoice == null)
        {
            
            Console.Write("\nYour Input : ");
            choice = Console.ReadLine();
        }

        if (loggedInEmployee == null)
        {
            switch (choice)
            {
                case "0":
                    return;
                case "1":
                    RegisterEmployee();
                    isRegistered = true;
                    break;
                case "2":
                    loggedInEmployee = await LoginEmployee();
                    if (loggedInEmployee == null)
                    {
                        Console.WriteLine("Invalid email or password. Please try again");
                        isLoggedIn = false;
                        isRegistered = false;
                        break;
                    }
                    Console.WriteLine($"Welcome, {loggedInEmployee.Name}!!!\n");
                    isLoggedIn = true;
                    isRegistered = true;
                    break;
                
                default:
                    Console.WriteLine("Please write number either 1, 2 or 3");
                    break;
            }
        } else if (productChoice != null)
        {
            switch (productChoice)
            {
                case "0":
                    return;
                case "1":
                    Console.WriteLine("Product 1");
                    break;
                case "2":
                    Console.WriteLine("Product 2");
                    break;
                default:
                    Console.WriteLine("Please write number either 1, 2 or 3");
                    break;
            }
        } else if (customerChoice != null)
        {
            switch (customerChoice)
            {
                case "0":
                    return;
                case "1":
                    Console.WriteLine("Customer 1");
                    break;
                case "2":
                    Console.WriteLine("Customer 2");
                    break;
                default:
                    Console.WriteLine("Please write number either 1, 2 or 3");
                    break;
            }
        } else
        {
            switch (choice)
            {
                case "0":
                    return;
                case "1":
                    crudChoice = choice;
                    Console.WriteLine("Crud choice 1");
                    break;
                case "2":
                    crudChoice = choice;
                    Console.WriteLine("Crud choice 2");
                    break;
                default:
                    Console.WriteLine("Please write number either 1, 2 or 3");
                    break;
            }
        }
    }
};
