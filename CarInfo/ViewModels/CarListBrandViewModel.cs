using CarInfo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.ViewModels
{
    public class CarListBrandViewModel
    {
        public IEnumerable<CarBrand> AllBrands { get; set; }

        public string currCategory { get; set; }

    }
}
