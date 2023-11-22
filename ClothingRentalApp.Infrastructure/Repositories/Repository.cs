using ClothingRentalApp.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
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
            _dbContext.Add(e);
        }

        public void Update(T e)
        {
            _dbContext.Update(e);
        }

        public void Delete(T e)
        {
            _dbContext.Remove(e);
        }

        public async Task<List<T>> FindAllAsync(int Id)
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> FindByIdAsync(int Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
            // we can also do like this
            // return await _dbContext.Set<T>().Where(b => b.Id == Id).SingleAsync();
            // return await _dbContext.Set<T>().SingleAsync(x => x.Id == id);
        }

       
    }
}
