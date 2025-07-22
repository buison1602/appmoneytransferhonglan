using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class SendCountryReportList
    {
        public string?  CountryCode { get; set; }
        public string?  CountryName { get; set; }
    
     
    }
    public class SendCountryReportListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public SendCountryReportList[] Content { get; set; }
    }
}