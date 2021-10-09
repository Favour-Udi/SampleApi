using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoodPredictionController : ControllerBase
    {
        private readonly IPredictionService _predictionService;
        public MoodPredictionController(IPredictionService predictionService)
        {
            _predictionService = predictionService;
        }
       
        private static List<MoodPred> users = new List<MoodPred>
        { new MoodPred(),
          new MoodPred{ Name = "Robert", Age = 30, Gender = "M"}
        };
      
        private string[] Mood = new[]
        {
            "Cheerful", "Reflective", "Gloomy", "Melancholy", "Idyllic", "Romantic", "Calm", "Angry", "Fearful", "Tense", "Lonely"
        };
        
        
        private string[] DayTime = new[] { "Morning", "Noon", "Night" };

        

       
        [HttpGet("Users")]
        public IActionResult GetAll()
        {
            return Ok(_predictionService.GetAllPred());
        }

        [HttpGet("Prediction")]
        public IActionResult GetMood(string Name)
        {
            
            if (Name == null)
            {
                return Ok("Please write your name.");
            }
            else
                return Ok(_predictionService.GetMoodByName(Name));
            
        }
        
        [HttpPost]
        public IActionResult AddUser(MoodPred newUser)
        {
            if (newUser == null)
            {
                Console.WriteLine("Please write your details");
            }
            return Ok(_predictionService.AddUser(newUser));
        }

        
    }
}
