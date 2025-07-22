using System;

namespace AppMoneyTransferRS.Models
{
    public class Province
    {
        public String MaTinhThanh { get; set; }
        
        public String TenTinhThanh { get; set; }
    }

    public class ProvinceInput
    {
        public String UserID { get; set; }
    }

    public class ProvinceResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public Province[] Content { get; set; }
    }
}
