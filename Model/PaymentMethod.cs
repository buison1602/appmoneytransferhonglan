using System;

namespace AppMoneyTransferRS.Models
{
    public class PaymentMethod
    {
        public String MALH { get; set; }
        
        public String TenLoaiHinh { get; set; }
    }

    public class PaymentMethodInput
    {
        public String UserID { get; set; }
    }

    public class PaymentMethodResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public PaymentMethod[] Content { get; set; }
    }
}
