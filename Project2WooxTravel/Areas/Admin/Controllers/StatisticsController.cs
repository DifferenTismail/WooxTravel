using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            List<int> capacity = context.Destinations.Take(3).Select(x => x.Capacity).ToList();
            ViewBag.Capacity = capacity;

            List<decimal> price = context.Destinations.Take(3).Select(x => x.Price).ToList();
            ViewBag.Price = price;

            List<int> daynight = context.Destinations.Take(3).Select(x => x.DayNight).ToList();
            ViewBag.DayNight = daynight;

            var values = context.Destinations.ToList();
            return View(values);
        }
        public ActionResult Widgets()
        {
            var howManyTour = context.Destinations.Select(x => x.DestinationID).Count();
            ViewBag.hmTour = howManyTour;

            var mostExpensiveTour = context.Destinations.Max(x => x.Price);
            ViewBag.meTour = mostExpensiveTour;

            var lowestPrice = context.Destinations.Min(d => d.Price);
            ViewBag.lowestPrice = lowestPrice;

            var maxCapacityTour = context.Destinations.Max(x =>x.Capacity);
            ViewBag.maxCapacityTour = maxCapacityTour;

            var maxDayNight = context.Destinations.Max(x => x.DayNight);
            ViewBag.dayNight = maxDayNight;

            var howManyCategory = context.Categories.Select(x =>x.CategoryID).Count();
            ViewBag.howManyCategory = howManyCategory;

            var howManyMailSended = context.Messages.Count();
            ViewBag.howManyMailSended = howManyMailSended;

            var avgMoney = Math.Round(context.Destinations.Average(x => x.Price), 2);
            ViewBag.avgMoney = avgMoney;

            var howManyReservacion = context.Reservations.Count();
            ViewBag.howManyReservacion = howManyReservacion;

            var shortestTour = context.Destinations.Min(x => x.DayNight);
            ViewBag.shortestTour = shortestTour;

            var howManyMeesageReceive = context.Messages.Select(x=>x.ReceiverMail).Count();
            ViewBag.howManyMeesageReceive = howManyMeesageReceive;

            var howManyAdmin = context.Admins.Count();
            ViewBag.howManyAdmin = howManyAdmin;
            return View();
        }
    }
}