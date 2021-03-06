﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
    public class CarBrand
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool PopularBrand { get; set; }
        public int YearCreation { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
       // public List<Car> cars { get; set; }
        
        public virtual CarBrandCategory CarBrandCategory { get; set; }

    }
}
