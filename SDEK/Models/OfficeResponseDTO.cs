using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class OfficeResponseDTO
    {
        public string code { get; set; }
        public string name { get; set; }
        public string nearest_station { get; set; }
        public string work_time { get; set; }
        public List<Phone> phones { get; set; }
        public string email { get; set; }
        public string owner_code { get; set; }
        public string type { get; set; }
        public bool take_only { get; set; }
        public bool is_handout { get; set; }
        public bool is_reception { get; set; }
        public bool is_dressing_room { get; set; }
        public bool have_cashless { get; set; }
        public bool have_cash { get; set; }
        public bool allowed_cod { get; set; }
        public bool fulfillment { get; set; }
        public List<Work_Time_List> work_Time_List { get; set; }
            
    }

    public class Work_Time_List
    {
        public int day { get; set; }
        public string time { get; set; }
    }
}
