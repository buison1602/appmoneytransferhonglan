using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMoneyTransferRS.Models
{
    public class ResponseTransactionService
    {

        public double SendAmount { get; set; }
        public double ServicesFee { get; set; }
        public double AgentFee { get; set; }
        public double OtherFee { get; set; }
        public double TaxFee { get; set; }
        public double DiscountAmount { get; set; }
        public double ExchangeRate { get; set; }
        public double TotalAmount { get; set; }
        public double LandedAmount { get; set; }
        public string?  ReadMoney { get; set; }
        public string?  ReadMoneyLanded { get; set; }

    }
    public class TransactionServiceResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public ResponseTransactionService Content { get; set; }
    }
    public class getAgentStateResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public string?  Content { get; set; }
    }
}
