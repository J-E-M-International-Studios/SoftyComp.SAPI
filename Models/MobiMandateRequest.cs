using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class MobiMandateRequest
    {
        public string Name { get; set; } = "";
        public string IDNumber { get; set; } = "";
        public string CellNumber { get; set; } = "";
        public decimal Amount { get; set; }
        public string Reference { get; set; } = "";
        public string CallbackUrl { get; set; } = "";
    }

}
