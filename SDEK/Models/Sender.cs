using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Sender
    {
        public string? company { get; set; }
        public string? name { get; set; }  
        public string? email { get; set; }
        public List<Phone> phones { get; set; }
        public string? inn { get; set; }
        public int? ownership_form { get; set; }
    }
}
