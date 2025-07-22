using System;

namespace AppMoneyTransferRS.Models
{
    public class PaymentMethodList
    {
        public String PayTypeID { get; set; }
        
        public String PayTypeName { get; set; }
    }
 

    public class PaymentMethodListResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public PaymentMethodList[] Content { get; set; }
    }
}
