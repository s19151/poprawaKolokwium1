using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolokwium1.DTOs.Responses
{
    public class TeamMemberResponse
    {
        public int IdTeamMember { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<TaskResponse> AssignedTasks { get; set; }
        public ICollection<TaskResponse> CreatedTasks { get; set; }
    }
}
