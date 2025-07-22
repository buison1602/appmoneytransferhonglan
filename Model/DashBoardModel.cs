using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class TranSumDetailModel
    {
        public Int64 CountTran { get; set; }
        public string?  TypeTran { get; set; }
        public string?  Loai { get; set; }
        public string?  IP_ID { get; set; }
        public string?  Currency { get; set; }
        public double TotalAmount { get; set; }
        public string?  FULL_NAME { get; set; }
        public Int64 CountColumn { get; set; }
        public string?  PAYMENT_SERVICE_TYPE_ID { get; set; }
        public bool GroupRow { get; set; } = false;
    }
    public class DashBoardDetailList
    {
        public List<TranSumDetailModel> TranSumDetailList { get; set; }
    }
    public class DashBoardDetailResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public DashBoardDetailList Content { get; set; }
    }
    public class TranSumModel
    {
        public Int64 CountTran { get; set; }
        public double TotalAmount { get; set; }        
        public string?  TypeTran { get; set; }
        public string?  Loai { get; set; }
        public string?  IP_ID { get; set; }
        public string?  PAYMENT_SERVICE_TYPE_ID { get; set; }
    }
    public class DashBoardList
    {
        public List<TranSumModel> TranSumList { get; set; }
        public List<TranSumModel> TranSumTypeList { get; set; }
        public List<TranSumModel> TranSumDoiTacList { get; set; }
    }
    public class DashBoardResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public DashBoardList Content { get; set; }
    }

}