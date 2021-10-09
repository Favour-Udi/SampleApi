using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPredictionService
    {
        ServiceResponse<List<MoodPred>> GetAllPred();
        ServiceResponse<MoodPred> GetMoodByName(string Name);
        ServiceResponse<List<MoodPred>> AddUser(MoodPred newUser);
    }
}
