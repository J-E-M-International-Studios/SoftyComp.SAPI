using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class TokenResponse
    {
        public string token { get; set; } = string.Empty;
        public DateTime expiration { get; set; }
    }

}
