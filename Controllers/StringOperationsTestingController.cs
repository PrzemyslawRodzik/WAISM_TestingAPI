using Microsoft.AspNetCore.Mvc;

namespace WAISM_TestingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RabbitMqController : ControllerBase
    {

        private readonly ILogger<RabbitMqController> _logger;

        public RabbitMqController(ILogger<RabbitMqController> logger)
        {
            _logger = logger;
        }

        // GET testing/strings/concatenation?input1=przemek&input2=rodzik&input3=jest&input4=super
        [HttpGet("complexity", Name = "StringConcaatenation")]
        public string StringConcaatenation([FromQuery] string depth)
        {
            return depth;
        }

        [HttpGet("replication", Name = "StringConcatbenation2")]
        public string StringConcatbenation2([FromQuery] string quantity)
        {
            return quantity;
        }

        [HttpGet("messageSize", Name = "StringConcatcenation3")]
        public string StringConcatcenation3([FromQuery] string size)
        {
            return size;
        }

        [HttpGet("prodcons", Name = "StringConcatednation23")]
        public string StringConcatednation23([FromQuery] string producersCount, [FromQuery] string consumersCount)
        {
            return producersCount;
        }
    }
}