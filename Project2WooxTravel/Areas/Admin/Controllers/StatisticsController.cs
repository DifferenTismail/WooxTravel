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
            return View();
        }
    }
}