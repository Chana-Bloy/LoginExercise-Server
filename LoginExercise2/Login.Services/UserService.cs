using LoginExercise.Core;
using LoginExercise.Core.Models;
using LoginExercise.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Login.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Project>> GetProjectsByUser(string token)
        {
            return await _unitOfWork.Users
                            .GetProjectsByUser(token);
        }

        public async Task<IEnumerable<User>> Login(LoginExercise.Core.Models.Login loginModel)
        {
            return await _unitOfWork.Users
                                      .Login(loginModel);
        }
    }
}
