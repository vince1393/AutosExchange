using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutosExchange.Models
{
    public class ListingUser
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Website { get; set; }
        public int ListingId { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public int KM { get; set; }
        public bool isNewCar { get; set; }
        public string CarType { get; set; }
        public string Color { get; set; }
        public string Drivetrain { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public Nullable<double> FuelEconomy { get; set; }
        public bool isAvailable { get; set; }
        public Nullable<double> SoldPrice { get; set; }
    }
}