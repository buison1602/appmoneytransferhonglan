using System;

namespace AppMoneyTransferRS.Models
{
    public class SetRiskAssetmentDetail
    {
        public Int64 RowNumber { get; set; }
        public Int64 STT { get; set; }
        public Int64 Year { get; set; }       
        public int FromScore { get; set; }
        public int ToScore { get; set; }
        public string?  RiskRateID { get; set; }
        public string?  Type { get; set; }
        public string?  RiskRateIDDetail { get; set; }
        public string?  RiskRateNote { get; set; }
        public string?  RiskRateContent { get; set; }

    }
    public class SetRiskAssetmentSum
    {
        public Int64 RowNumber { get; set; }
        public Int64 STT { get; set; }
        public Int64 Year { get; set; }
        public int FromScore { get; set; }
        public int ToScore { get; set; }
        public string?  RiskRateID { get; set; }
        public string?  Type { get; set; }
        public string?  PrepareBy { get; set; }
        public string?  PrepareDate { get; set; }
        public string?  ApproveBy { get; set; }
        public string?  ApproveDate { get; set; }

    }

    public class SetRiskAssetmentContent
    {
        public List<SetRiskAssetmentDetail> ReportDetail { get; set; }
        public List<SetRiskAssetmentSum> ReportSummary { get; set; }
    }

    public class SetRiskAssetmentResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public SetRiskAssetmentContent Content { get; set; }
    }
}
