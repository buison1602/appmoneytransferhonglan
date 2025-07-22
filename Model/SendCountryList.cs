using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class SendCountryList
    {
        public string?  CountryCode { get; set; }
        public string?  CountryName { get; set; }
    
     
    }
    public class SendCountryListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public SendCountryList[] Content { get; set; }
    }
}