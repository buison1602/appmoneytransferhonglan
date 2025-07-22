using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class PaymentAgentList
    {
        public string?  PAY_AG_ID { get; set; }
        public string?  AGENT_PAYMENT_NAME { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  STATE { get; set; }
        public string?  CITY { get; set; }
        public bool? MATDINH { get; set; }
        public string?  PaymentMode { get; set; }
        

    }
    public class PaymentAgentListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public PaymentAgentList[] Content { get; set; }
    }
}