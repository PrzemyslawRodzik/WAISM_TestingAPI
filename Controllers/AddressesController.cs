using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WAISM_TestingAPI.Repositories;
using WAISM_TestingAPI.Dtos;
using WAISM_TestingAPI.Models;

namespace WAISM_TestingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AddressRepository _addressRepository;

        public AddressesController(IMapper mapper, AddressRepository addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        // GET addresses/
        [HttpGet("", Name = "GetAllAddresses")]
        public ActionResult<IEnumerable<AddressDto>> GetAllAddresses()
        {
            List<Address> addresses = null;
            addresses = _addressRepository.GetAll();

            if (addresses.Count <= 0)
                return NoContent();

            var addressesDto = _mapper.Map<IEnumerable<AddressDto>>(addresses);
            return Ok(addressesDto);
        }

        // GET addresses/5
        [HttpGet("{id}", Name = "GetAddressById")]
        public ActionResult<AddressDto> GetAddressById(int id)
        {

            var address = _addressRepository.GetById(id);
            var addressDto = _mapper.Map<AddressDto>(address);
            if (address != null)
                return Ok(addressDto);

            return NotFound();
        }

        // POST addresses
        [HttpPost("", Name = "CreateAddress")]
        public ActionResult<AddressDto> CreateAddress([FromBody] AddressDto addressDto)
        {
            var address = _mapper.Map<Address>(addressDto);
            _addressRepository.Add(address);

            var addressDtoResult = _mapper.Map<AddressDto>(address);

            return CreatedAtRoute(nameof(GetAddressById), new { Id = address.Id }, addressDtoResult);

        }

        // PUT addresses/5
        [HttpPut("{id}", Name= "UpdateAddress")]
        public IActionResult UpdateAddress(int id, [FromBody] AddressDto addressDto)
        {
            var address = _addressRepository.GetById(id);
            if (address is null)
                return NotFound();
            _mapper.Map(addressDto, address);

            _addressRepository.Update(address);

            return Ok();
        }

        // DELETE addresses/5
        [HttpDelete("{id}", Name = "DeleteAddress")]
        public IActionResult DeleteAddress(int id)
        {
            var address = _addressRepository.GetById(id);
            if (address is null)
                return NotFound();
            _addressRepository.Delete(address);
            return Ok();
        }
    }
}