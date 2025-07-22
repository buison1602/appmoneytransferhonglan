using System.Collections.Generic;
//using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.Models
{
    public class ComplianceModel
    {
        public Int64 RowNumber { get; set; }
        public int CPI_ID { get; set; }
        public string?  CPI_NAME { get; set; }
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
    public class ComplianceSubmitModel
    {
        public Int64 RowNumber { get; set; }
        public Int64 CPI_ID { get; set; }
        
        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  UserName { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FullName { get; set; }
        public string?  Comment { get; set; }
        public DateTime SubmitDate { get; set; }
        public string?  NOIDUNG { get; set; }

    }
    public class ComplianceRespContent
    {
        public List<ComplianceModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }

    }
    public class ComplianceResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ComplianceRespContent Content { get; set; }
    }
    public class ComplianceSubmitRespContent
    {
        public List<ComplianceSubmitModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }

    }
    public class ComplianceSubmitResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ComplianceSubmitRespContent Content { get; set; }
    }
}