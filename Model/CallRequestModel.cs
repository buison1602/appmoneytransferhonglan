using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class CallRequestModel
    {
        public Int64 TotalRec { get; set; }
        public Int64 RowNumber { get; set; }
        public Int64 ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public string?  FunctionName { get; set; }
        public string?  Request { get; set; }
        public string?  Form { get; set; }
        public string?  FormName { get; set; }
        public string?  Action { get; set; }
    }
    public class CallRequestModelList
    {
        public CallRequestModel[] ReportDetail { get; set; }
    }
    public class CallRequestListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CallRequestModelList Content { get; set; }
    }
}