using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ErrorLogModel
    {
        public Int64 TotalRec { get; set; }
        public Int64 RowNumber { get; set; }
        public Int64 ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public string?  FunctionName { get; set; }
        public string?  ErrorLog { get; set; }
    }
    public class ErrorLogModelList
    {
        public ErrorLogModel[] ReportDetail { get; set; }
    }
    public class ErrorLogListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ErrorLogModelList Content { get; set; }
    }
}