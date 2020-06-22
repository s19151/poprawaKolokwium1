using PoprawaKolokwium1.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolokwium1.Services
{
    public interface IDbService
    {
        public TeamMemberResponse GetTeamMember(int idMember);
        public ProjectResponse DeleteProject(int idProject);
    }
}
