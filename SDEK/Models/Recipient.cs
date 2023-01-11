using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Recipient
    {
        public string name { get; set; }
        public string Tin { get; set; }
        public List<Phone> phones { get; set; }
        public string? company { get; set; }
        public string? Passport_series { get; set; }
        public string? Passport_number { get; set; }
        public DateTime? Passport_date_of_issue { get; set; }
        public DateTime? Passport_date_of_birth { get; set; }
        public string? email { get; set; }
        public string Additional { get; set; }
        public string? Passport_organization { get; set; }
    }
}
