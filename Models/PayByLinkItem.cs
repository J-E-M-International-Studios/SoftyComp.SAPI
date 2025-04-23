using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftyComp.SAPI.Models
{
    public class PayByLinkItem
    {
        public string Description { get; set; } = "";
        public string Amount { get; set; } = "0.00"; // as string per Postman example
        public string FrequencyTypeID { get; set; } = "1"; // e.g., "1" for once-off
        public string DisplayCompanyName { get; set; } = "";
        public string DisplayCompanyContactNo { get; set; } = "";
        public string DisplayCompanyEmailAddress { get; set; } = "";
        public string DisplayCompanyLogo { get; set; } = ""; // Base64 PNG
    }
}
