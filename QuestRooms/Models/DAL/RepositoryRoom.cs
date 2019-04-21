using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRooms.Models.DAL
{
    public static class RepositoryRoom
    {
        private  static List<QuestRoom> Rooms { get; set; } = new List<QuestRoom>();
        public static List<QuestRoom> GetRooms()
        {
            return Rooms;
        }

        public static void Add(QuestRoom room)
        {
            Rooms.Add(room);
        }

        public static QuestRoom Get(int Id)
        {
            return Rooms.FirstOrDefault(r => r.Id == Id);
        }

        public static void Del(int Id)
        {
            Rooms.RemoveAll(r => r.Id == Id);
        }
    }
}