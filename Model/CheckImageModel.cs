using System;

namespace AppMoneyTransferRS.Models
{
    public class RequestCheckImage
    {       
        public String UserID { get; set; }        
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public String PartnerID { get; set; }
        public String ProvinceID { get; set; }
        public String BranchID { get; set; }
        public String EmployeeID { get; set; }
        public String CheckStatus { get; set; }
        public String SearchBy { get; set; }
        public String SearchContent { get; set; }
    }

    public class ReponseCheckImage
    {
         
        public String OrderNo1 { get; set; }

        public String NguoiLap { get; set; }
        public DateTime Thoigianlap { get; set; }

        public String Nguoisua { get; set; }
        public DateTime Thoigiansua { get; set; }

        public String TenFile { get; set; }
       
        public string?  FileImage { get; set; }
        public bool TinhTrang { get; set; }
        public String SearchBy { get; set; }
        public String OrderNo2 { get; set; }
        public DateTime OrderDate { get; set; }
        public String AgentOrder { get; set; }
        public String Sender { get; set; }
        public String Currency { get; set; }
        public float Amount { get; set; }
        public String Beneficiary { get; set; }
        public String BenTelNo { get; set; }
        public String BenAddress { get; set; }
        public String District { get; set; }
        public String Ward { get; set; }
        public String BenCity { get; set; }
        public String Message { get; set; }
        public String CusID { get; set; }
        public String NVNL { get; set; }
        public String Employee { get; set; }
        public String IDCard { get; set; }
        public DateTime NgayHS { get; set; }
        public String Note { get; set; }
        public String HinhThucChi { get; set; }
        public String MaNV { get; set; }
        public bool Upload { get; set; }
        public String CorrespLocName { get; set; }
        public String Messageerror { get; set; }
        public String TenDV1 { get; set; }
        public bool Kiemtra { get; set; }

    }

    public class RequestCheckResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ReponseCheckImage[] Content { get; set; }
    }
}
