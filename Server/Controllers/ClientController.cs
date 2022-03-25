using eTrans.Server.Services.ClientService;
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
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientservice;

        public ClientController(IClientService clientservice)
        {
            _clientservice = clientservice;
        }

        [HttpGet]
        public async Task<ActionResult<List<CLient>>> GetClients()
        {
            return Ok(await _clientservice.GetClients());
        }
    }
}
