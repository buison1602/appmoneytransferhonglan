using System.Collections.Generic;
using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.Models
{
    
     public class AMLQuestionDetailModel
    {
        public Int64 RowNumber { get; set; }
        public Int64 IdCauHoi { get; set; }
        public int IdLoaiCauHoi { get; set; }
        public int PADung { get; set; }
        public string?  NoiDung { get; set; }
        public string?  NoiDungI { get; set; }
        public string?  PA1 { get; set; }
        public string?  PA2 { get; set; }
        public string?  PA3 { get; set; }
        public string?  PA4 { get; set; }
        public string?  PA5 { get; set; }
        public string?  PA6 { get; set; }
        public string?  PA7 { get; set; }
        public string?  PA8 { get; set; }
        public string?  PA9 { get; set; }
        public string?  PA10 { get; set; }
        public string?  PAI1 { get; set; }
        public string?  PAI2 { get; set; }
        public string?  PAI3 { get; set; }
        public string?  PAI4 { get; set; }
        public string?  PAI5 { get; set; }
        public string?  PAI6 { get; set; }
        public string?  PAI7 { get; set; }
        public string?  PAI8 { get; set; }
        public string?  PAI9 { get; set; }
        public string?  PAI10 { get; set; }
        public int DapAn { get; set; } = 0;
        public bool DungSai { get; set; } = false;
        
    }
        public class AMLTestModel
    {
        public Int64 RowNumber { get; set; }
        public int IdLoaiCauHoi { get; set; }
        public string?  CPI_NAME { get; set; }
        public string?  UserID { get; set; }
        
        public string?  NoiDung { get; set; }
        public string?  FILENAME { get; set; }
        public string?  FILE_IMAGE { get; set; }
        public string?  FROMCOUNTRY { get; set; }
        public string?  TOCOUNTRY { get; set; }
        public string?  Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime EditDate { get; set; }
        public string?  EditBy { get; set; }
        public DateTime? FromDate { get; set; } = DateTime.UtcNow.AddHours(-7);
        public DateTime? ToDate { get; set; } = DateTime.UtcNow.AddHours(-7);
        public bool show { get; set; }
        public string?  StateID { get; set; }
        public string?  AgentID { get; set; }
        public string?  Search { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  STATE { get; set; }
        public bool AgentShow { get; set; }
        public string?  LoaiCauHoi { get; set; }
        public int Year { get; set; }
        public string?  Module { get; set; } = "";
        public int IdType { get; set; } = 0;
        public string?  linkTransID { get; set; } = "";
        public string?  COMPLIANCE_OFFICER { get; set; } = "";
        public string?  Trainee_Name { get; set; } = "";
        public string?  Trainer_Name { get; set; } = "";
        public string?  Trainee_Signature { get; set; } = "";
        public bool Lock { get; set; } = false;

    }
    public class AMLTestRespContent
    {
        public List<AMLTestModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }

    }
    public class AMLTestResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AMLTestRespContent Content { get; set; }
    }
    public class AMLTestQuestionResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AMLTestQuestionRespContent Content { get; set; }
    }
    public class AMLTestQuestionRespContent
    {
        public List<AMLQuestionDetailModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }

    }
    public class AMLTestQuestionEditResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AMLTestQuestionEditRespContent Content { get; set; }
    }
    public class AMLTestQuestionEditRespContent
    {
        public List<AMLTestModel> ReportDetail { get; set; }
        public List<AMLQuestionDetailModel> ReportDetailEdit { get; set; }

    }
}