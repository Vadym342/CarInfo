using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
    public class CarInformation
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public double Speed { get; set; }
        public string DriveTrain { get; set; }
        public double Consumption { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string Chassis { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
        public string Transmission { get; set; }
        public double Mileage { get; set; }
        public string City { get; set; }
        public List<MedianPriceCar> medianPriceCars { get; set; }
        
       // public List<CarOwners> owners { get; set; }

    }
}
