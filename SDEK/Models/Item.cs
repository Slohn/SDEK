using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Item
    {
        public decimal cost { get; set; }
        public Payment payment { get; set; }
        public string ware_key { get; set; }
        public int Weight_gross { get; set; }
        public int value { get; set; }
        public string name { get; set; }
        public string? Marking { get; set; }
        public int amount { get; set; }
        public int weight { get; set; }
        public string Number { get; set; }
        public string name_i18n { get; set; }
        public string? brand { get; set; }
        public string? material { get; set; }
        public string? url { get; set; }
    }
}
