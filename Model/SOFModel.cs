using System;

namespace AppMoneyTransferRS.Models
{
    public class SOFModel
    {
        public String SOURCE_ID { get; set; }
        
        public String SOURCE_NAME { get; set; }
    }

    public class SOFModelInput
    {
        public String UserID { get; set; }
    }

    public class SOFModelResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public SOFModel[] Content { get; set; }
    }
}
