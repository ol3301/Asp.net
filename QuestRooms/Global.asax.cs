using QuestRooms.Models;
using QuestRooms.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace QuestRooms
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //RepositoryRoom.Add(new QuestRoom
            //{
            //    Id = 1,
            //    Name = "Room",
            //    Description = "Desc",
            //    time = TimeSpan.FromMinutes(30),
            //    MinGamerCount = 4,
            //    MaxGamerCount = 6,
            //    Address = "address",
            //    Phones = new List<string> { "123123123" , "123123123", "123123123" },
            //    Email = "olegaedfge",
            //    Company = "12312312",
            //    Raiting = 4,
            //    LevelOfFear = 10,
            //    LevelOfHard = 10
            //});
            //
            //RepositoryRoom.Add(new QuestRoom
            //{
            //    Id = 1,
            //    Name = "Room",
            //    Description = "Desc",
            //    time = TimeSpan.FromMinutes(30),
            //    MinGamerCount = 4,
            //    MaxGamerCount = 6,
            //    Address = "address",
            //    Phones = new List<string> { "123123123", "123123123", "123123123" },
            //    Email = "olegaedfge",
            //    Company = "12312312",
            //    Raiting = 4,
            //    LevelOfFear = 10,
            //    LevelOfHard = 10
            //});
            //
            //RepositoryRoom.Add(new QuestRoom
            //{
            //    Id = 1,
            //    Name = "Room",
            //    Description = "Desc",
            //    time = TimeSpan.FromMinutes(30),
            //    MinGamerCount = 4,
            //    MaxGamerCount = 6,
            //    Address = "address",
            //    Phones = new List<string> { "123123123", "123123123", "123123123" },
            //    Email = "olegaedfge",
            //    Company = "12312312",
            //    Raiting = 4,
            //    LevelOfFear = 10,
            //    LevelOfHard = 10
            //});
        }
    }
}
