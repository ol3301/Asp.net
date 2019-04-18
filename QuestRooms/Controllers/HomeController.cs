using QuestRooms.Models;
using QuestRooms.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryRoom rooms = new RepositoryRoom();
        public ActionResult Index()
        {
            rooms.Add(new QuestRoom { Name="Room", Description="Desc", time = TimeSpan.FromMinutes(30),
                MinGamerCount =4, MaxGamerCount=6, Address="address", Phones = new List<string> {"123","312","1231231" }, Email="olegaedfge",
                Company ="12312312", Raiting=4, LevelOfFear=10, LevelOfHard=10 });

            return View(rooms.GetRooms().First());
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