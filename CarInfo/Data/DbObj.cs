using CarInfo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data
{
    public class DbObj
    {
        public static void Initial(AppDbContext content)
        {


            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { name = "Tesla", shortDesc = "Electro, so fast ", longDesc = "New type of electro car whick can ride with speed more than 300k/h ", img = "https://autoreview.ru/images/Article/1700/Article_170068_860_575.jpg", price = 45000, isFavourite = true, mark = "Tesla", Year = 2019, avaible = true, Category = Categories["Electro Cars"] },
                    new Car { name = "Land Cruiser", shortDesc = "Bisnes class", longDesc = "So comfortable auto for drive", img = "https://s.auto.drom.ru/i24207/c/photos/fullsize/toyota/land_cruiser/toyota_land_cruiser_699944.jpg", price = 100000, isFavourite = true, mark = "Toyota", Year = 2018, avaible = true, Category = Categories["TDI"] }


                    );




            }
            content.SaveChanges();
        }
        private static Dictionary<string, CarBrandCategory> _carBrandCategory;

        public static Dictionary<string, CarBrandCategory> CarBrandCategory
        {
            get
            {
                if (_carBrandCategory == null)
                {
                    var list = new CarBrandCategory[] {
                        new CarBrandCategory{CategoryName="BMW", Description="...",Year=1927},
                        new CarBrandCategory{ CategoryName="Mercedes-Benz", Description="...",Year=1926},
                        new CarBrandCategory{ CategoryName="Volkswagen", Description="...",Year=1938}
                    };
                    _carBrandCategory = new Dictionary<string, CarBrandCategory>();

                    foreach (CarBrandCategory el in list)
                    {
                        _carBrandCategory.Add(el.CategoryName, el);
                    }
                }
                return _carBrandCategory;
            
            }

        }





        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[] {
                        new Category{categoryName="Electro Cars", description="New kind cars"},
                        new Category{ categoryName="TDI", description="Usual cars"}

                    };
                    _category = new Dictionary<string, Category>();

                    foreach (Category el in list)
                    {
                        _category.Add(el.categoryName, el);
                    }
                }
                return _category;
            }

        }
    }
}
