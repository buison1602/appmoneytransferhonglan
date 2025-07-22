using System;

namespace AppMoneyTransferRS.Models
{
    public class ApproveOption
    {
        public String OptionID { get; set; }
        
        public String OptionName { get; set; }
    }

    public class ApproveOptionInput
    {
        public String UserID { get; set; }
    }

    public class ApproveOptionResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public EmailStatus[] Content { get; set; }
    }
}
