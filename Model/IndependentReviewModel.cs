using System.Collections.Generic;
using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.Models
{
    public class IndependentReviewModel
    {
        public Int64 RowNumber { get; set; }
        public Int16 IV_ID { get; set; }
        public string?  AML_NAME { get; set; }
        public string?  NOIDUNG { get; set; }
        public string?  FILENAME { get; set; }
        public string?  FILE_IMAGE { get; set; }
        public string?  FROMCOUNTRY { get; set; }
        public string?  TOCOUNTRY { get; set; }
        public string?  Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool SHOW { get; set; }
        public string?  StateID { get; set; }
        public string?  AgentID { get; set; }
        public string?  Search { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  STATE { get; set; }
        public bool AgentShow { get; set; }

    }
    public class IndependentReviewRespContent
    {
        public List<IndependentReviewModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }

    }
    public class IndependentReviewResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public IndependentReviewRespContent Content { get; set; }
    }
}