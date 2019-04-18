using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRooms.Models.DAL
{
    public class RepositoryRoom
    {
        private List<QuestRoom> Rooms { get; set; } = new List<QuestRoom>();

        public RepositoryRoom()
        {

        }

        public List<QuestRoom> GetRooms()
        {
            return Rooms;
        }

        public void Add(QuestRoom room)
        {
            Rooms.Add(room);
        }


    }
}