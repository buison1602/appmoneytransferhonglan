using System;

namespace AppMoneyTransferRS.Models
{
    public class Partner
    {
        public String MaDV { get; set; }
        
        public String TenDV { get; set; }
    }

    public class PartnerInput
    {
        public String UserID { get; set; }
    }

    public class PartnerResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public Partner[] Content { get; set; }
    }
}
