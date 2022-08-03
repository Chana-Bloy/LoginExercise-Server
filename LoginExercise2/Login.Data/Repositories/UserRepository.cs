using LoginExercise.Context;
using LoginExercise.Core.Models;
using LoginExercise.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginExercise.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _appContext;

        public UserRepository(ApplicationDbContext appContext)  {
            _appContext = appContext;
        }

        public async Task<IEnumerable<Project>> GetProjectsByUser(string token)
        {
            User user = _appContext.Users.Where(x => x.Token == token).FirstOrDefault();

            if (user != null)
                return _appContext.Projects.Where(s => s.UserId == user.Id).ToList();
            return null;
        }

        public async Task<IEnumerable<User>> Login(Core.Models.Login loginModel)
        {
            var result = _appContext.Users.Where(s => s.Email == loginModel.Email && s.Password == loginModel.Password).Include(user => user.PersonalDetails)
                           .ToList();
            return result;
        }

    }
}
