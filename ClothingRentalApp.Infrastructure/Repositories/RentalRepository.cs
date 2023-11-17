using ClothingRentalApp.Domain.Models;
using ClothingRentalApp.Domain.Repositories;
using ClothingRentalApp.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Infrastructure.Repositories
{
    public class RentalRepository : Repository<Rental>, IRentalRepository
    {
        public RentalRepository(ClothingRentalAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
