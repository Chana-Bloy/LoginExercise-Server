using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginExercise.Resources
{
    public class PersonalDetailsResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime JoinedAt { get; set; }
        public string Avatar { get; set; }
    }
}
