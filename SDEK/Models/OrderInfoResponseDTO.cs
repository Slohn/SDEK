using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class OrderInfoResponseDTO
    {

        public OrderInfoModel entity { get; set; }
        public List<Status> statuses { get; set; }
        public List<Request> requests { get; set; }
    }

    public class OrderInfoModel 
    {
        public string uuid { get; set; }
        public bool is_return { get; set; }
        public bool is_reverse { get; set; }
        public bool is_client_return { get; set; }
        public int type { get; set; }
        public int tariff_code { get; set; }
        public Sender sender { get; set; }
        public Recipient recipient { get; set; }
        public FromLocation from_location { get; set; }
        public ToLocation to_location { get; set; }
        public List<Service> services { get; set; }
        public List<Package> packages { get; set; }
    }
}
