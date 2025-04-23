using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class TransactionRecord
    {
        public string? Reference { get; set; }
        public decimal Amount { get; set; }
        public string? Status { get; set; }
        public DateTime TransactionDate { get; set; }
    }

}
