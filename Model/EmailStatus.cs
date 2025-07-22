using System;

namespace AppMoneyTransferRS.Models
{
    public class EmailStatus
    {
        public String OptionID { get; set; }
        
        public String OptionName { get; set; }
    }

    public class EmailStatusInput
    {
        public String UserID { get; set; }
    }

    public class EmailStatusResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public EmailStatus[] Content { get; set; }
    }
}
