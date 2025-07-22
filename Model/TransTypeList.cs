using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class TransTypeList
    {
        public string?  PAYABLE_CODE { get; set; }
        public string?  DESCRIPTION { get; set; }
        public string?  PAYMENT_AGENT { get; set; }
        public string?  CountryCode { get; set; }
        
    }
    public class TransTypeListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public TransTypeList[] Content { get; set; }
    }
}