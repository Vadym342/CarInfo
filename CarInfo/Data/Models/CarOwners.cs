using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
    public class CarOwners
    {
        public int id { get; set; }
        public List<CarInformation> carInfos { get; set; }

    }
}
