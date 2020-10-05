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
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;

        }
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart

            };

            return View(obj);

        }
        public RedirectToActionResult addToCard(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);  // item with int id 
            if (item != null)
            {
                _shopCart.AddToCard(item);
            }
            return RedirectToAction("Index");

        }



    }

}
