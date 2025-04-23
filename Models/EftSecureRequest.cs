using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class EftSecureRequest
    {
        public string BankName { get; set; } = "";
        public string AccountHolder { get; set; } = "";
        public decimal Amount { get; set; }
        public string Reference { get; set; } = "";
        public string CallbackUrl { get; set; } = "";
    }

}
