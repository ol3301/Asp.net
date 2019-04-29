using QuestRooms.Models;
using QuestRooms.Models.DAL;
using QuestRooms.Models.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View(RepositoryRoom.GetRooms());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ShowConcrete(RoomProperties rp)
        {
            return View("Index", RepositoryRoom.GetConcrete(rp));
        }

        public ActionResult ShowRoom(int Id)
        {
            return View(RepositoryRoom.Get(Id));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}