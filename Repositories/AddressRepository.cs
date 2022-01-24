using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WAISM_TestingAPI.Models;

namespace WAISM_TestingAPI.Repositories
{
    public class AddressRepository
    {
        private List<Address> _addresses;

        public AddressRepository()
        {
            _addresses = new List<Address>();
        }

        public List<Address> GetAll() => _addresses;

        public Address GetById(int id) => _addresses.FirstOrDefault(address => address.Id == id);

        public void Add(Address address) => _addresses.Add(address);

        public void Update(Address address) => _addresses.Where(a => a.Id == address.Id).Select(a =>  address).ToList();
        public void Delete(Address address) => _addresses.Remove(address);

    }
}
