namespace QuestRooms
{
    using QuestRooms.Models;
    using System.Data.Entity;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<QuestRoom> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

}