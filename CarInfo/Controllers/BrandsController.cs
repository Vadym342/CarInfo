using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using CarInfo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarInfo.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IAllBrands _allBrands;
        private readonly ICarBrandCategory _carBrandCategory;

        public BrandsController(IAllBrands iallBrands, ICarBrandCategory iCarBrand)
        {
            _carBrandCategory = iCarBrand;
            _allBrands = iallBrands;
        }

        [Route("Cars/ListBrand")]
        [Route("Cars/ListBrand/{carbrandcategory}")]
        public ViewResult BrandList(string brandCategory)
        {
            string _brandCategory = brandCategory;
            IEnumerable<CarBrand> brands = null;
            string currCategory = "";
            // list carbrands
            if (string.IsNullOrEmpty(brandCategory))
            {
                brands = _allBrands.CarBrand.OrderBy(i => i.id);
            }
            else
            {

            }
            var BrandObj = new CarListBrandViewModel
            {
                AllBrands  = brands,
                currCategory = currCategory
            };

            ViewBag.Title = "Page with cars";


            return View(BrandObj);
        }

        

    }
}
