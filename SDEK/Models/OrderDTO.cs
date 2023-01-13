using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class OrderDTO
    {
        public string? uuid { get; set; }
        public string? comment { get; set; }
        public string cdek_number { get; set; }
        public int? Tariff_code { get; set; }
        public Recipient Recipient { get; set; }
        public string? Shipment_point { get; set; }
        public string? Delivery_point { get; set; }
        public Sender Sender { get; set; }
        public string? From_location { get; set; }
        public List<Item> Items { get; set; }
        public ToLocation? ToLocation { get; set; }
        public FromLocation? FromLocation { get; set; }
        public List<Service> Services { get; set; }
        public List<Package> Packages { get; set; }

    }
}
