using System;

namespace AppMoneyTransferRS.Models
{
    public class TypeofPaidModel
    {
        public String TypeID { get; set; }
        
        public String TypeName { get; set; }
        public String TypeAgent { get; set; }
        public bool OtherFee { get; set; }
    }

  

    public class TypeofPaidResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public TypeofPaidModel[] Content { get; set; }
    }
}
