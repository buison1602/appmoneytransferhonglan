using System;

namespace AppMoneyTransferRS.Models
{
    public class HongLanBlackListModel
    {
        public Int64 RowNumber { get; set; }
        public Int64 ID { get; set; }

        public String BlackListName { get; set; }
        
        public String TypeID { get; set; }
        public String TypeName { get; set; }
        public String ErrorMessage { get; set; }
    }

    public class HongLanBlackListModelResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public HongLanBlackListModelResponse Content { get; set; }
    }
    public class HongLanBlackListModelResponse
    {
        public List<HongLanBlackListModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }
    }
}
