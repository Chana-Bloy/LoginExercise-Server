using AutoMapper;
using LoginExercise.Core.Models;
using LoginExercise.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginExercise.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<User, UserResource>();
            CreateMap<Project, ProjectResource>();
            CreateMap<PersonalDetails, PersonalDetailsResource>();

            // Resource to Domain
            CreateMap<UserResource, User>();
            CreateMap<ProjectResource, Project>();
            CreateMap<PersonalDetailsResource, PersonalDetails>();
        }
    }
}
