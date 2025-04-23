using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class DebitOrderRequest
    {
        public string AccountNumber { get; set; } = "";
        public string BranchCode { get; set; } = "";
        public string Reference { get; set; } = "";
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

}
