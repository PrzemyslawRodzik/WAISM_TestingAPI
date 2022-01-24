using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WAISM_TestingAPI.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string AddressName { get; set; }

        public string Street { get; set; }
        
        public string StreetNumber { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }



    }
}
