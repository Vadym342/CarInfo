using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Repository
{
    public class BrandRepository : IAllBrands
    {
        private readonly AppDbContext appDbContext;

        public BrandRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<CarBrand> CarBrand => appDbContext.CarBrands.Include(x => x.CarBrandCategory);

        public IEnumerable<CarBrand> getPopularBrand => appDbContext.CarBrands.Where(p => p.PopularBrand).Include(c => c.CarBrandCategory);

        public CarBrand getObjBrand(int brandid) => appDbContext.CarBrands.FirstOrDefault(p => p.id == brandid);

    }
}
