using System;

namespace AppMoneyTransferRS.Models
{
    public class Branch
    {
        public String MaCN { get; set; }
        
        public String TenCN { get; set; }
    }

    public class BranchInput
    {
        public String UserID { get; set; }
    }

    public class BranchResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public Branch[] Content { get; set; }
    }
}
