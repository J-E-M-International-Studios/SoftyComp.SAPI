using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class CdvResponse
    {
        public bool Success { get; set; }
        public List<string>? Messages { get; set; }
    }
}
