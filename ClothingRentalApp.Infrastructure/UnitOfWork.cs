using ClothingRentalApp.Domain;
using ClothingRentalApp.Domain.Repositories;
using ClothingRentalApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure
{
    public class UnitOfWork :IUnitOfWork
    {
        // public ClothingRentalAppDbContext _dbContext { get; private set; }
        private readonly ClothingRentalAppDbContext _dbContext;

        public UnitOfWork()
        {
            _dbContext = new ClothingRentalAppDbContext();
            //Create database only if not exists
            //_dbContext.Database.EnsureCreated();

            // Apply a migration
            _dbContext.Database.Migrate();
        }

        
        public ICategoryRepository CategoryRepository => new CategoryRepository(_dbContext);

        public IBrandRepository BrandRepository =>  new BrandRepository(_dbContext);

        public IClothingItemRepository ClothingItemRepository => new ClothingItemRepository(_dbContext);

        public ICustomerRepository CustomerRepository =>  new CustomerRepository(_dbContext);

        public IEmployeeRepository EmployeeRepository =>  new EmployeeRepository(_dbContext);

        public IPaymentRepository PaymentRepository =>  new PaymentRepository(_dbContext);

        public IRentalRepository RentalRepository => new RentalRepository(_dbContext);

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public string PrintDbPath()
        {
            return _dbContext.PrintDbPath();
        }
    }
}
