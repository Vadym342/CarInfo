using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
   public class CarBrandCategory
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ImgBrand { get; set; }
        public List<Car> Cars { get; set; }
    }
}
