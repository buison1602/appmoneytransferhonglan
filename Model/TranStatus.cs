using System;

namespace AppMoneyTransferRS.Models
{
    public class TranStatus
    {
        public String OptionID { get; set; }
        
        public String OptionName { get; set; }
    }

    public class TranStatusInput
    {
        public String UserID { get; set; }
    }

    public class TranStatusResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public TranStatus[] Content { get; set; }
    }
}
