using Newtonsoft.Json;
using QuestRooms.Models.Filtering;
using System.Collections.Generic;
using System.Linq;

namespace QuestRooms.Models.DAL
{
    public static class RepositoryRoom
    {
        public static List<QuestRoom> GetRooms()
        {
            using (Model1 conn = new Model1())
            {
                var p = conn.Rooms.ToList();

                foreach(var i in p)
                    i.Phones = JsonConvert.DeserializeObject<List<string>>(i.JsonPhones);
                

                return p;
            }
        }

        public static List<QuestRoom> GetConcrete(RoomProperties rp)
        {
            using (Model1 conn = new Model1())
            {
                var p = conn.Rooms.Where(x =>
                (x.MaxGamerCount <= rp.GamerCount && x.MinGamerCount >= rp.GamerCount) &&
                x.LevelOfFear == rp.LevelOfFear && x.LevelOfHard == rp.LevelOfHard
                ).ToList();

                foreach (var i in p)
                    i.Phones = JsonConvert.DeserializeObject<List<string>>(i.JsonPhones);


                return p;
            }
        }

        public static void Add(QuestRoom room)
        {
            using(Model1 conn = new Model1())
            {
                room.JsonPhones = JsonConvert.SerializeObject(room.Phones);
                conn.Rooms.Add(room);
                conn.SaveChanges();
            }
        }

        public static QuestRoom Get(int Id)
        {
            using (Model1 conn = new Model1())
            {
                var r = conn.Rooms.FirstOrDefault(q => q.Id == Id);

                r.Phones = JsonConvert.DeserializeObject<List<string>>(r.JsonPhones);
                return r;
            }
        }

        public static void Del(int Id)
        {
            using (Model1 conn = new Model1())
            {
                conn.Rooms.Remove(Get(Id));
            }
        }
    }
}