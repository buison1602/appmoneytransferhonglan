using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class SendCurrencyList
    {
        public string?  CurrencyCode { get; set; }
        public string?  CurrencyName { get; set; }
    
     
    }
    public class SendCurrencyListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public SendCurrencyList[] Content { get; set; }
    }
}