using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SomeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AliveController : ControllerBase
    {
        private ILogger<AliveController> _logger;

        public AliveController(ILogger<AliveController> logger)
        {
            _logger = logger;
        }

        public string Get()
        {
            var response = $"I'm Alive! Here's a Guid for you {Guid.NewGuid().ToString()}";
            _logger.LogInformation(response);
            return response;
        }
    }
}