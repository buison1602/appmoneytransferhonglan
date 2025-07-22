using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ReceiveCountryList
    {
        public string?  CountryCode { get; set; }
        public string?  CountryName { get; set; }
    
     
    }
    public class ReceiveCountryListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ReceiveCountryList[] Content { get; set; }
    }
}