using AutoMapper;
using WAISM_TestingAPI.Dtos;
using WAISM_TestingAPI.Models;

namespace WAISM_TestingAPI.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            //Source -> Target
            CreateMap<Address, AddressDto>();

            CreateMap<AddressDto, Address>();
        }



    }
}
