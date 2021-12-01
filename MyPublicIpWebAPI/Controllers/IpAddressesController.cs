using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MyPublicIpWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPublicIpWebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class IpAddressesController : ControllerBase
    {
        private IPAddress _remoteIPAddress => HttpContext.Connection.RemoteIpAddress;
        private int _remotePort => HttpContext.Connection.RemotePort;


        [HttpGet("endpoint")]
        public ActionResult<SimpleEndpoint> GetEndpoint()
        {
            SimpleEndpoint endpoint = new SimpleEndpoint()
            {
                IPAddress = _remoteIPAddress.ToString(),
                Port = _remotePort
            };
            return Ok(endpoint);
        }

        [HttpGet("ip")]
        public ActionResult<string> GetIP()
        {
            return Ok(_remoteIPAddress.ToString());
        }

        [HttpGet("port")]
        public ActionResult<int> GetPort()
        {
            return Ok(_remotePort);
        }

    }
}
