using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class CountryList
    {
        public string?  CountryCode { get; set; }
        public string?  CountryName { get; set; }
    
     
    }
    public class CountryListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CountryList[] Content { get; set; }
    }
}