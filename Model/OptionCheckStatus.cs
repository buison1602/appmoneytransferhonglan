using System;

namespace AppMoneyTransferRS.Models
{
    public class OptionCheckStatus
    {
        public String OptionID { get; set; }
        
        public String OptionName { get; set; }
    }

    public class OptionCheckStatusInput
    {
        public String UserID { get; set; }
    }

    public class OptionCheckStatusResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public TranStatus[] Content { get; set; }
    }
}
