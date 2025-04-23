using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class DebiCheckRequest
    {
        public string MandateReference { get; set; } = "";
        public string IDNumber { get; set; } = "";
        public string BankAccount { get; set; } = "";
        public string BranchCode { get; set; } = "";
        public decimal Amount { get; set; }
        public string CellNumber { get; set; } = "";
        public string StartDate { get; set; } = ""; // ISO 8601 format
    }

}
