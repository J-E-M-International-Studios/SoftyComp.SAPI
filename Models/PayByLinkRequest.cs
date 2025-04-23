using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class PayByLinkRequest
    {
        public string Name { get; set; } = "";
        public int ModeTypeID { get; set; } // 4 for once-off
        public string EmailAddress { get; set; } = "";
        public string CellNo { get; set; } = "";
        public List<PayByLinkItem> Items { get; set; } = new();
    }
}
