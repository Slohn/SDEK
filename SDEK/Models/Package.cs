using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Package
    {
        public string? package_id { get; set; }
        public string number { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string? comment { get; set; }
        public List<Item> items { get; set; }

        
    }
}
