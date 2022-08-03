using AutoMapper;
using LoginExercise.Core.Models;
using LoginExercise.Core.Services;
using LoginExercise.Resources;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginExercise.Controllers
{

    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<IEnumerable<User>>> Login(Core.Models.Login loginModel)
        {

            var result = await _userService.Login(loginModel);
            var userResources = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(result);
            return Ok(userResources);
        }


        [HttpGet]
        [Route("GetProjectsByUser")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsByUser()
        {
            Request.Headers.TryGetValue("UserToken", out var headerValue);

            var projects = await _userService.GetProjectsByUser(headerValue);
            if (projects != null)
            {
                var projectsResources = _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectResource>>(projects);

                return Ok(projectsResources);
            }

            return null;
        }


    }
}
