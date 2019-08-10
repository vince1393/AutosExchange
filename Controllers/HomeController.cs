using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutosExchange.Models;
using AutosExchange.Extensions;
using Microsoft.AspNet.Identity;

namespace AutosExchange.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            IEnumerable<ListingUser> listings = 
                from l in db.Listings
                                                join u in db.Users
                                                on l.ListerId equals u.Id
                                                select new ListingUser
                                                {
                                                    Name = u.Name,
                                                    Address = u.Address,
                                                    City = u.City,
                                                    Province = u.Province,
                                                    Website = u.Website,
                                                    ListingId = l.ListingId,
                                                    VIN = l.VIN,
                                                    Year = l.Year,
                                                    Make = l.Make,
                                                    Model = l.Model,
                                                    Trim = l.Trim,
                                                    KM = l.KM,
                                                    isNewCar = l.isNewCar,
                                                    CarType = l.CarType,
                                                    Color = l.Color,
                                                    Drivetrain = l.Drivetrain,
                                                    FuelType = l.FuelType,
                                                    Transmission = l.Transmission,
                                                    FuelEconomy = l.FuelEconomy,
                                                    isAvailable = l.isAvailable,
                                                    SoldPrice = l.SoldPrice
                          };

            return View(listings.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}