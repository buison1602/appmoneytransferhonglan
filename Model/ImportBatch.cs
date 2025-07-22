using System;

namespace AppMoneyTransferRS.Models
{
    public class ImportBatch
    {
        public String MaDot { get; set; }
        
        public String TenDot { get; set; }
    }

    public class ImportBatchInput
    {
        public String UserID { get; set; }
    }

    public class ImportBatchResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ImportBatch[] Content { get; set; }
    }
}
