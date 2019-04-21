using QuestRooms.Models;
using QuestRooms.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.Controllers
{
    public class AdminController : Controller
    {

        public AdminController()
        {

        }
        public ActionResult Index()
        {
            return View(RepositoryRoom.GetRooms());
        }

        public ActionResult Del(int Id)
        {
            RepositoryRoom.Del(Id);
            return View("Index", RepositoryRoom.GetRooms());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}