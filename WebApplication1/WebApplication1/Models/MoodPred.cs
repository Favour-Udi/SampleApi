using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MoodPred
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Tega";
        public string Gender { get; set; } = "F";
        public int Age { get; set; } = 24;
        public TimeOfDay Class { get; set; } = TimeOfDay.Morning;
        public string Mood { get; set; } 
        public string DayTime { get; set; }

       

    }
}
