using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class OfficesSearchParams
    {
        public int? postal_code { get; set; }
        public int? city_code { get; set; }
        public int? weight_min { get; set; }
        public int? weight_max { get; set; }
        public string? type { get; set; }
        public string? country_code { get; set; }
        public int? region_code { get; set; }
        public bool? have_cashless { get; set; }
        public bool? have_cash { get; set; }
        public bool? is_handout { get; set; }
        public bool? is_reception { get; set; }
        public bool? allowed_cod { get; set; }
        public bool? is_dressing_room { get; set; }
        public bool? take_only { get; set; }
    }
}
