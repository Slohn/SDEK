using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDEK.Models
{
    public class AuthResponseDTO
    {
        public string access_tolen { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string score { get; set; }
        public string jti { get; set; }
    }
}
