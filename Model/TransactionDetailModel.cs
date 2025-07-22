using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class RequestTransactionDetail
    {
        public String UserID { get; set; }
        public String OrderNo1 { get; set; }
     
    }

    public class ReponseTransactionDetail
    {        
        public Int64 RowNumber { get; set; }
        public String OrderNo1 { get; set; }
        public String OrderNo2 { get; set; }
        public DateTime OrderDate { get; set; }
        public String CorrespLocName { get; set; }
        public float SeqIDPA { get; set; }
        public String AreaID { get; set; }
        public String Area { get; set; }
        public String BranchNo { get; set; }
        public String BranchName { get; set; }
        public String AgentOrder { get; set; }
        public String Sender { get; set; }
        public String Currency { get; set; }
        public float Amount { get; set; }
        public String Beneficiary { get; set; }
        public String BenTelNo { get; set; }
        public String BenAddress { get; set; }
        public String Ward { get; set; }
        public String District { get; set; }
        public String BenCity { get; set; }
        public String BenState { get; set; }
        public String SecondBenName { get; set; }
        public String SecondBenPhone { get; set; }
        public String Message { get; set; }
        public String CusID { get; set; }
        public float ExRate { get; set; }
        public String NVNL { get; set; }
        public bool Issue { get; set; }
        public String RBeneficiary { get; set; }
        public String IDCard { get; set; }
        public String LocIssue { get; set; }
        public DateTime DateIssue { get; set; }
        public String Employee { get; set; }
        public DateTime NgayHS { get; set; }
        public String Messageerror { get; set; }
        public bool Cancel { get; set; }
        public String Note { get; set; }
        public String ExternalNo { get; set; }
        public String MaNV { get; set; }
        public String HinhThucChi { get; set; }
        public String MySF01 { get; set; }
        public String MySF02 { get; set; }
        public String MySF03 { get; set; }
        public float MyDF01 { get; set; }
        public float MyDF02 { get; set; }
        public float MyDF03 { get; set; }
        public DateTime MyTF01 { get; set; }
        public DateTime MyTF02 { get; set; }
        public DateTime MyTF03 { get; set; }
        public bool Accept { get; set; }
        public String Loaichi { get; set; }
        public String NguoiLap { get; set; }
        public DateTime Thoigianlap { get; set; }
        public String Nguoisua { get; set; }
        public DateTime Thoigiansua { get; set; }
        public bool Upload { get; set; }
        public String NguoiGoi { get; set; }
        public String NguoiNhan { get; set; }
        public String TongHop { get; set; }
        //public String AgentID { get; set; }
        //public String AgentSeqID { get; set; }
        //public String PathHB { get; set; }
        //public String ApprovePartner { get; set; }
        //public DateTime ApprovePartnerDate { get; set; }
        //public String ApproveOwner { get; set; }
        //public DateTime ApproveOwnerDate { get; set; }
        public String NodeOwner { get; set; }
        public String NodeUrgent { get; set; }
        public String NodePartner { get; set; }
        public String NodeDelivery { get; set; }
        public String NodeCus { get; set; }
     
        public String DiaChiKhongDau { get; set; }
        public bool Duyet { get; set; }
        public String DuyetBy { get; set; }
        public bool Email { get; set; }
        public DateTime EmailDate { get; set; }
        public String EmailBy { get; set; }
        public DateTime DuyetDate { get; set; }
        public bool Excel { get; set; }
        public DateTime ExcelDate { get; set; }
        public String ExcelBy { get; set; }
        public DateTime NgayImport { get; set; }
        public String Passcode { get; set; }
        public bool SendMessage { get; set; }
       
        //public String SendMessageBy { get; set; }
        //public DateTime SendMessageDate { get; set; }
        //public DateTime SendMessageDate2 { get; set; }
        public Int16 EmailTime { get; set; }
        //public bool HoiBao { get; set; }
        //public bool SentM { get; set; }
        //public bool CheckPasscode { get; set; }
        //public String CheckPasscodeBy { get; set; }
        //public DateTime CheckPasscodeDate { get; set; }
        public float Sotienchi { get; set; }
        //public String ReceiverEmail { get; set; }
        //public bool CheckEmailToReceiver { get; set; }
        //public String CheckEmailToReceiverBy { get; set; }
        //public DateTime CheckEmailToReceiverDate { get; set; }
        public String TenCN { get; set; }
        public String TenDV { get; set; }
        public String HoTen { get; set; }
        public String DienThoaiDD { get; set; }
        public bool Other { get; set; }
        public String MaKH { get; set; }
        public String StatusID { get; set; }
        public String Download { get; set; }
    }
   
  
    public class TransactionDetailResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public List<ReponseTransactionDetail>  Content { get; set; }
    }
}
