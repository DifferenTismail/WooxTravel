using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Project2WooxTravel.Context;

using Project2WooxTravel.Models.Entities;
namespace Project2WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        int pageSize = 3;
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var value = context.Destinations.Take(4).ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialCountry(int pageNo = 1)
        {
            var values = context.Destinations.ToList();
            var pageValue = new PagedList<Destination>(values, pageNo, pageSize);
            return PartialView(pageValue);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public ActionResult ExploreTour(int id)
        {
            var countryDetail = context.Destinations.Where(x =>x.DestinationID == id).ToList();
            return View(countryDetail);
        }
        public PartialViewResult ExploreTourBanner()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public ActionResult NewRezervation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewRezervation(Project2WooxTravel.Models.Entities.Reservation reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return View("Index");
        }
    }
}