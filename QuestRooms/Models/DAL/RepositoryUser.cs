using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRooms.Models.DAL
{
    public static class RepositoryUser
    {
        public static User Get(string name, string password)
        {
            using(Model1 conn = new Model1())
                return conn.Users.Where(u => u.Name == name && u.Password == password).FirstOrDefault();
        }
    }
}