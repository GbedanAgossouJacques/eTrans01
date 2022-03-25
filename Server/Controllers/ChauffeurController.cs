using eTrans.Server.Services.ChauffeurService;
using eTrans.Client.Models.Visitors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChauffeurController : ControllerBase
    {
        private readonly IChauffeurService _chauffeurService;

        public ChauffeurController(IChauffeurService chauffeurService)
        {
            _chauffeurService = chauffeurService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Chauffeur>>> GetChauffeur()
        {
            return Ok(await _chauffeurService.GetAllChauffeur());
        }
    }
}
