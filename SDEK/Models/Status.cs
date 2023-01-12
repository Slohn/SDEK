using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Status
    {
        public string code { get; set; }
        public string name { get; set; }
        public DateTime date_time { get; set; }
        public string city { get; set; }
    }
}
