using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("/")]
    public class DockerController : ControllerBase
    {
        private readonly ILogger<DockerController> _logger;

        public DockerController(ILogger<DockerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            //await Task.Delay(60000);
            return $"Hello wolrd from Docker Container: {Environment.MachineName}";
            //return Environment.MachineName;
        }
    }
}
