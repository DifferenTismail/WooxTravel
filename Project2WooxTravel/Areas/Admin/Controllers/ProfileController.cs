using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project2WooxTravel.Context;
using Project2WooxTravel.Models.Entities;
namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.Admins.Where(x => x.Username == a).FirstOrDefault();
            return View(values);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            Session["x"] = null;

            return RedirectToAction("Index", "Login");
        }
    }
}