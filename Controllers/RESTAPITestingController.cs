using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WAISM_TestingAPI.Repositories;
using WAISM_TestingAPI.Dtos;
using WAISM_TestingAPI.Models;

namespace MessageBrokers_TestingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KaffkaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AddressRepository _addressRepository;

        public KaffkaController(IMapper mapper, AddressRepository addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        // GET testing/strings/concatenation?input1=przemek&input2=rodzik&input3=jest&input4=super
        [HttpGet("complexity", Name = "StringConcatenation")]
        public string StringConcatenation([FromQuery] string depth)
        {
            return depth;
        }

        [HttpGet("replication", Name = "StringConcatenation2")]
        public string StringConcatenation2([FromQuery] string quantity)
        {
            return quantity;
        }

        [HttpGet("messageSize", Name = "StringConcatenation3")]
        public string StringConcatenation3([FromQuery] string size)
        {
            return size;
        }

        [HttpGet("prodcons", Name = "StringConcatenation23")]
        public string StringConcatenation23([FromQuery] string producersCount, [FromQuery]  string consumersCount)
        {
            return producersCount;
        }
    }
}