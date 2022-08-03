using LoginExercise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExercise.Core.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Login(Login loginModel);
        Task<IEnumerable<Project>> GetProjectsByUser(string token);
    }
}
