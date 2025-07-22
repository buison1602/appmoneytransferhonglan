using System;

namespace AppMoneyTransferRS.Models
{
    public class Currency
    {
        public String LoaiNT { get; set; }
        
        public String TenNgoaiTe { get; set; }
    }

    public class CurrencyInput
    {
        public String UserID { get; set; }
    }

    public class CurrencyResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public Currency[] Content { get; set; }
    }
}
