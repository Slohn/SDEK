using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class ResponeDTO
    {
        public OrderInfoModel entity { get; set; }
        public List<Request> requests { get; set; }
    }
}
