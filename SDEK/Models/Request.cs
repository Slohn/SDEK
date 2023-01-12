using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class Request
    {
        public string? request_uuid { get; set; }
        public string type { get; set; }
        public DateTime date_time { get; set; }
        public string state { get; set; }

    }
}
