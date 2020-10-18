using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Repository
{
    public class CarBrandCategoryRepository : ICarBrandCategory
    {
        private readonly AppDbContext appDbContext;

        public CarBrandCategoryRepository(AppDbContext appDBContent)
        {
            this.appDbContext = appDBContent;
        }
        public IEnumerable<CarBrandCategoryRepository> AllBrandCategoris => appDbContext.carBrandCategories;

        
    }
}
