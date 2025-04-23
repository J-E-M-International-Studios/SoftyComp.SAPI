using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class AvsRequest
    {
        public string BranchCode { get; set; } = "";
        public string AccountNumber { get; set; } = "";
        public int AccountTypeID { get; set; }
        public string IDNumber { get; set; } = "";
        public string Initials { get; set; } = "";
        public string Name { get; set; } = "";
        public string? EmailAddress { get; set; }
        public string? CellNo { get; set; }
        public string CallBackUrl { get; set; } = "";
    }
}
