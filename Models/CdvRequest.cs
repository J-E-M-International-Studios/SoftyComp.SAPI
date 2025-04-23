using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class CdvRequest
    {
        public string BranchCode { get; set; } = "";
        public string AccountNumber { get; set; } = "";
        public int AccountTypeID { get; set; }
    }

}
