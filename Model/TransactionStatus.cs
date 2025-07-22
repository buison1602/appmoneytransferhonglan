using System;

namespace AppMoneyTransferRS.Models
{
    public class TransactionStatus
    {
        public String STATUS_ID { get; set; }
        
        public String STATUS_DESC { get; set; }
    }

    public class TransactionStatusInput
    {
        public String UserID { get; set; }
    }

    public class TransactionStatusResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public TransactionStatus[] Content { get; set; }
    }
}
