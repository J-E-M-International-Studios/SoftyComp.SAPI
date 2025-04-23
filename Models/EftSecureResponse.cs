using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class EftSecureResponse
    {
        public string? Value { get; set; }
        public bool Success { get; set; }
        public List<string>? Messages { get; set; }
    }

}
