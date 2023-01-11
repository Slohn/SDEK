using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class OfficesDTO
    {
        public int? postal_code { get; set; }
        public int? city_code { get; set; }
        public string type { get; set; }
        public string country_code { get; set; }
        public int? region_code { get; set; }
        public bool? have_cashless { get; set; }
        public bool? have_cash { get; set; }
        public bool? allowed_cod { get; set; }
        public bool? take_only { get; set; }
    }
}
