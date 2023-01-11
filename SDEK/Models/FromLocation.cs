using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class FromLocation
    {
        public int? Code { get; set; }
        public string? Postal_code { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string? Country_code { get; set; }
        public string? Region { get; set; }
        public int? Region_code { get; set; }
        public string? City { get; set; }
        public string? Sub_region { get; set; }
        public string? Kladr_code { get; set; }
        public string Address { get; set; }
    }
}
