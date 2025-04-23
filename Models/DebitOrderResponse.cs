using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class DebitOrderResponse
    {
        public bool Success { get; set; }
        public string? Value { get; set; }
        public List<string>? Messages { get; set; }
    }

}
