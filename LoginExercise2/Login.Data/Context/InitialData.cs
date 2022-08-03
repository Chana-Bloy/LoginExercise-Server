using LoginExercise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginExercise.Context
{

    public static class InitialData
    {
        public static void Seed(this ApplicationDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                dbContext.Users.Add(new User
                {
                    Email = "chany55488@gmail.com",
                    Password = "111111Aa",
                    Token = "111-222-333",
                    PersonalDetails = new PersonalDetails()
                    {
                        Team = "Developer",
                        JoinedAt = DateTime.Now,
                        Name = "Chana",
                        Avatar = "https://avatarfiles.alphacoders.com/164/thumb-164632.jpg"
                    }
                });
                dbContext.Users.Add(new User
                {
                    Email = "cccc@gmail.com",
                    Password = "222222Bb",
                    Token = "222-222-222",
                    PersonalDetails = new PersonalDetails()
                    {
                        Team = "UI",
                        JoinedAt = DateTime.Now,
                        Name = "Dov",
                        Avatar = "https://avatarfiles.alphacoders.com/164/thumb-164632.jpg"
                    }
                });

                dbContext.SaveChanges();
            }
            if (!dbContext.Projects.Any())
            {
                dbContext.Projects.Add(new Project
                {
                   Name= "Backend Project",
                   BugsCount=3,
                   DurationInDays=2,
                   MadeDadeline=true,
                   Score=93,
                   UserId=1
                });
                dbContext.Projects.Add(new Project
                {
                    Name = "FullStack Project",
                    BugsCount = 1,
                    DurationInDays = 3,
                    MadeDadeline = false,
                    Score = 93,
                    UserId=2
                });

                dbContext.SaveChanges();
            }


        }
    }
}
