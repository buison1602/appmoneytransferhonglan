using System;

namespace AppMoneyTransferRS.Models
{
    public class EmailBatch
    {
        public String MaDot { get; set; }
        
        public String TenDot { get; set; }
    }

    public class EmailBatchInput
    {
        public String UserID { get; set; }
    }

    public class EmailBatchResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ImportBatch[] Content { get; set; }
    }
}
