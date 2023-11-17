using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClothingRentalApp.Domain.Repositories
{
    public interface IClothingItemRepository : IRepository<ClothingItem>
    {
        // Find the clothes by the category Id
        Task<List<ClothingItem>> GetAvailableItemsByCategoryAsync(int categoryId);
      
        // Find the clothes by the brand Id
        Task<List<ClothingItem>> GetItemsByBrandAsync(int brandId);

        // I am not sure about this method since this method needs to be implemented 
        // for the rentalitem associated entity
        // Find the clothes rented under rental id 
        Task<List<ClothingItem>> SearchItemsAsync(string searchTerm);

        //For specific term
        Task<int> GetTotalStockQuantityAsync(int itemId);
        // Retrieve a list of items that are currently in stock and available for rental.
        Task<List<ClothingItem>> GetItemsInStockAsync(); 

    }
}
