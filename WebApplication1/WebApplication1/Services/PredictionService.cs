using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Controllers;


namespace WebApplication1.Services
{
    public class PredictionService : IPredictionService
    {
        private static List<MoodPred> users = new List<MoodPred>
        { new MoodPred(),
          new MoodPred{ Id = 1, Name = "Robert", Age = 30, Gender = "M", }
        };

        private string[] Mood = new[]
       {
            "Cheerful", "Reflective", "Gloomy", "Melancholy", "Idyllic", "Romantic", "Calm", "Angry", "Fearful", "Tense", "Lonely"
        };

        private string[] DayTime = new[] { "Morning", "Noon", "Night" };

        public ServiceResponse<List<MoodPred>> GetAllPred()
        {
            ServiceResponse<List<MoodPred>> serviceResponse = new ServiceResponse<List<MoodPred>>();
            serviceResponse.Data = users;
            return serviceResponse;
        }
        public ServiceResponse<MoodPred> GetMoodByName(string Name)
        {
            var rnd = new Random();
            int index = rnd.Next(Mood.Length);
            var rng = new Random();
            int index2 = rng.Next(DayTime.Length);
            ServiceResponse<MoodPred> serviceResponse = new ServiceResponse<MoodPred>();
            serviceResponse.Data = users.FirstOrDefault(u => u.Name == Name);
            serviceResponse.Message = $"{Name}, you feel {Mood[index]} in the {DayTime[index2]}";
            return serviceResponse;
        }

        public ServiceResponse<List<MoodPred>> AddUser(MoodPred newUser)
        {
            ServiceResponse<List<MoodPred>> serviceResponse = new ServiceResponse<List<MoodPred>>();
            users.Add(newUser);
            serviceResponse.Data = users;
            return serviceResponse;
        }
    }

}
