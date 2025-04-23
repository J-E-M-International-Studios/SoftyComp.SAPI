using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class AvsResponse
    {
        public string Value { get; set; } = string.Empty;
        public bool Success { get; set; }
        public List<string> Messages { get; set; } = new();
    }
}
