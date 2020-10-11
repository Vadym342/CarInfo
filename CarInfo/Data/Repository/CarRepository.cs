using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext appDbContext;

        public CarRepository(AppDbContext appDBContent)
        {
            this.appDbContext = appDBContent;
        }
        public IEnumerable<Car> Cars => appDbContext.Car.Include(x => x.Category);

        public IEnumerable<Car> getFavCars => appDbContext.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjCar(int carId) => appDbContext.Car.FirstOrDefault(p => p.id == carId);
    }
}
