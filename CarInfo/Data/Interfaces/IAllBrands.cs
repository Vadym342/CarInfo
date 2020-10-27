using CarInfo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Interfaces
{
  public  interface IAllBrands
    {
        IEnumerable<CarBrand> CarBrand { get; }
        IEnumerable<CarBrand> getPopularBrand { get; }

        CarBrand getObjBrand(int brandid);

    }
}
