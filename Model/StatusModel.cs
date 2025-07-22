using System;

namespace AppMoneyTransferRS.Models
{
    public class StatusModel
    {
        public String StatusID { get; set; }
        
        public String StatusName { get; set; }
    }

    public class StatusInput
    {
        public String UserID { get; set; }
    }

    public class StatusResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public StatusModel[] Content { get; set; }
    }
}
