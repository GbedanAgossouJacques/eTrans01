using eTrans.Client.Models.Transport;
using eTrans.Server.Services.TransportService;
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
    public class TransportController : ControllerBase
    {
        private readonly ITransportService _transportservice;

        public TransportController(ITransportService transportservice)
        {
            _transportservice = transportservice;
        }

        [HttpGet]
        public async Task<ActionResult<List<Transport>>> GetTransports()
        {
            return Ok(await _transportservice.GetTransports());
        }
    }
}
