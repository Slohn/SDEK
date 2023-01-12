using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Location
    {
        public string Country_code { get; set; }
        public int Region_code { get; set; }
        public string Region { get; set; }
        public int City_code { get; set; }
        public string City { get; set; }
        public string Postal_code { get; set; }
        public decimal Longitude { get; set; }
        public decimal latitude { get; set; }
        public string Address { get; set; }
        public string Address_full { get; set; }
    }
}
