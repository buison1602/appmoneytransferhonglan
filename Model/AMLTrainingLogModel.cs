using System.Collections.Generic;
using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.Models
{
    public class AMLTrainingLogModel
    {
        public Int64 RowNumber { get; set; }
        public Int64 IdLoaiCauHoi { get; set; }
        public string?  NoiDung { get; set; }
        public DateTime CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string?  EditBy { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string?  IdType { get; set; }
        public string?  LoaiCauHoi { get; set; }
        public string?  Year { get; set; }
        public bool Show { get; set; }
        public string?  Agent_ID { get; set; }
        public string?  Agent_Name { get; set; }
        public string?  Trainee_Name { get; set; }
        public string?  Trainee_Signature { get; set; }
        public string?  AGENT_ADDRESS { get; set; }
        public string?  PHONE { get; set; }
        public string?  FAX { get; set; }
        public string?  COMPLIANCE_OFFICER { get; set; }
        public string?  Trainer_Name { get; set; }
        public string?  Comment { get; set; }
        public string?  StatusName { get; set; }
        public string?  STATE { get; set; }
        public string?  EMAIL { get; set; }
        public int Id { get; set; }
        public int TRALOIDUNG { get; set; }
        public int socauhoi { get; set; }
        public bool Lock { get; set; }
        public bool Marked { get; set; }
        public bool Submit { get; set; }
        public int STATUS { get; set; }
        public string?  TYPE_AGENTNAME { get; set; }
        public string?  Grade { get; set; }
        public string?  Result { get; set; }
        public string?  Answer { get; set; }
        public string?  linkTransID { get; set; }
        public string?  linkTransMark { get; set; }
        public string?  IDEn { get; set; }

    }
    public class AMLTrainingLogRespContent
    {
        public List<AMLTrainingLogModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }

    }
    public class AMLTrainingLogResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AMLTrainingLogRespContent Content { get; set; }
    }
}