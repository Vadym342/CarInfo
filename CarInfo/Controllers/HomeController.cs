using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarInfo.Models;

using CarInfo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using CarInfo.Data.Interfaces;

namespace CarInfo.Controllers
{
   
    public class HomeController : Controller
    {
       
        private readonly IAllCars _carRep;
        private readonly IAllBrands _brandRep;

        public HomeController(IAllCars carRep,IAllBrands brandRep)
        {
            _carRep = carRep;
            _brandRep = brandRep;
        }
    

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        public ViewResult Index()
        {
            var home = new HomeViewModel
            {
                favCars = _carRep.getFavCars,
                PopularBrand = _brandRep.getPopularBrand
            };

            return View(home);
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
