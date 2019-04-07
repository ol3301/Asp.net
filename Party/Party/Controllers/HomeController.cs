using Party.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Party.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour < 12 ? "Доброго утра" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guest)
        {
            return View("Thanx", guest);
        }
    }
}