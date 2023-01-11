using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Payment
    {
        public long value { get; set; }
        public decimal? vat_sum { get; set; }
        public int? vat_rate { get; set; }
    }
}
