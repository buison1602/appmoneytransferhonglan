using System;

namespace AppMoneyTransferRS.Models
{
    public class PaymentModeList
    {
        public String MALH { get; set; }
        
        public String TenLoaiHinh { get; set; }
    }

  

    public class PaymentModeListResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public PaymentModeList[] Content { get; set; }
    }
}
