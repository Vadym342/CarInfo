using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using CarInfo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;
        private readonly ICarBrandCategory _carBrandCategory;
        public CarsController(IAllCars iallCars, ICarsCategory iCarCat, ICarBrandCategory iCarBrand)
        {
            _allCars = iallCars;
            _carsCategory = iCarCat;
            _carBrandCategory = iCarBrand;
        }
        [Route("Cars/ListBrand")]
        [Route("Cars/ListBrand/{carbrandcategory}")]
        public ViewResult BrandList(string brandCategory)
        {

            // list carbrands

            return View();
        }


        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {       
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electro Cars")).OrderBy(i => i.id);
                    currCategory = "Electro";
                }
                else
                {
                    if (string.Equals("TDI", category, StringComparison.OrdinalIgnoreCase))
                    {
                        cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("TDI")).OrderBy(i => i.id);
                        currCategory = "TDI";
                    }



                }

            }
            var CarObj = new CarListViewModel
            {
                AllCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Page with cars";


            return View(CarObj);



        }




    }
}
