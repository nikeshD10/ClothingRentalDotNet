using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class ClothingItemRepository: Repository<ClothingItem>, IClothingItemRepository
    {
        public ClothingItemRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<ClothingItem>> GetAvailableItemsByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClothingItem>> GetItemsByBrandAsync(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClothingItem>> GetItemsInStockAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalStockQuantityAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClothingItem>> SearchItemsAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
