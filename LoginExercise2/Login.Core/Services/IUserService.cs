using LoginExercise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExercise.Core.Services
{
     public interface IUserService
    {
        Task<IEnumerable<User>> Login(Login loginModel);
        Task<IEnumerable<Project>> GetProjectsByUser(string token);
    }
}
