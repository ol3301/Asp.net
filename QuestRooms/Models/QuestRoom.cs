using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace QuestRooms.Models
{
    public class QuestRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan time { get; set; }
        public int MinGamerCount { get; set; }
        public int MaxGamerCount { get; set; }
        public string Address { get; set; }
        public List<string> Phones { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int Raiting { get; set; }
        public int LevelOfFear { get; set; }
        public int LevelOfHard { get; set; }
        public Image Logo { get; set; }
        public List<string> GalaryOfImages { get; set; }
    }
}