using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ReceiveStateList
    {
        public string?  StateCode { get; set; }
        public string?  StateName { get; set; }
        public string?  PaymentAgent { get; set; }
        public string?  CountryCode { get; set; }
    }
    public class ReceiveStateListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ReceiveStateList[] Content { get; set; }
    }
}