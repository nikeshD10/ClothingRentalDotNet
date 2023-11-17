using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class ClothingItemRepository: Repository<ClothingItem>
    {
        public ClothingItemRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
