using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class CallActionModel
    {
        public Int64 TotalRec { get; set; }
        public Int64 RowNumber { get; set; }
        public Int64 ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string?  CreateBy { get; set; }
       
        public string?  Form { get; set; }
        public string?  FormName { get; set; }
        public string?  Action { get; set; }
    }
    public class CallActionModelList
    {
        public CallActionModel[] ReportDetail { get; set; }
    }
    public class CallActionListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CallActionModelList Content { get; set; }
    }
}