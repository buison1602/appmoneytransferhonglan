using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class SendCurrencyReportList
    {
        public string?  CurrencyCode { get; set; }
        public string?  CurrencyName { get; set; }
    
     
    }
    public class SendCurrencyReportListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public SendCurrencyReportList[] Content { get; set; }
    }
}