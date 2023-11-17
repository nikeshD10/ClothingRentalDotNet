using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        // we need to have something to set the database context
        protected readonly ClothingRentalAppDbContext _dbContext; // property

        public Repository(ClothingRentalAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(T e)
        {
            throw new NotImplementedException();
        }

        public void Delete(T e)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindAllAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T e)
        {
            throw new NotImplementedException();
        }
    }
}
