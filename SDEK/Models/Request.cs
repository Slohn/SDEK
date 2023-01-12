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
        //public string date_time 
        //{
        //    get 
        //    {
        //        return date_time;
        //    } 
        //    set 
        //    {
        //        date_time = value;   
        //    } 
        //}

        public string date_time { get; set; }
        public string state { get; set; }
        public List<ErrorModel>? errors { get; set; }
        public List<WarningModel> warnings { get; set; }


    }
}
