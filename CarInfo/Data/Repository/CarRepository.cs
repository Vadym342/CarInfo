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
        private readonly AppDbContext appDBContent;

        public CarRepository(AppDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(x => x.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
