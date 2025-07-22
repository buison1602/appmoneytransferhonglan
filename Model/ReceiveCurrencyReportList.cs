using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ReceiveCurrencyReportList
    {
        public string?  CurrencyCode { get; set; }
        public string?  CurrencyName { get; set; }
    
     
    }
    public class ReceiveCurrencyReportListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ReceiveCurrencyReportList[] Content { get; set; }
    }
}