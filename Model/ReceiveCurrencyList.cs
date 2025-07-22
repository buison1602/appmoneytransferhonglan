using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ReceiveCurrencyList
    {
        public string?  CurrencyCode { get; set; }
        public string?  CurrencyName { get; set; }
        public string?  CountryCode { get; set; }   
    }
    public class ReceiveCurrencyListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ReceiveCurrencyList[] Content { get; set; }
    }
}