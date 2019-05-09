using QuestRooms.Models;
using QuestRooms.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QuestRooms.Controllers
{

    public class AdminController : Controller
    {
        public AdminController()
        {

        }
        [Authorize]
        public ActionResult Index()
        {
            return View(RepositoryRoom.GetRooms());
        }

        public ActionResult Del(int Id)
        {
            RepositoryRoom.Del(Id);
            return View("Index", RepositoryRoom.GetRooms());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var res = FormsAuthentication.Authenticate(user.Name, user.Password);

            if (res)
            {
                FormsAuthentication.SetAuthCookie(user.Name,false);
                return View("Index", RepositoryRoom.GetRooms());
            }
            else
            {
                ModelState.AddModelError("","Не коррекный логин или пароль");
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}