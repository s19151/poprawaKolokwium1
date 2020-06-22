using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium1.Services;

namespace PoprawaKolokwium1.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private IDbService _dbService;

        public TasksController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{idMember:int}")]
        public IActionResult GetTeamMember(int idMember)
        {
            try
            {
                return Ok(_dbService.GetTeamMember(idMember));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{idProject:int}")]
        public IActionResult DeleteProject(int idProject)
        {
            try
            {
                return Ok(_dbService.DeleteProject(idProject));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}