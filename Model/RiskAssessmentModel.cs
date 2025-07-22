using System.Collections.Generic;
using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.Models
{
    public class RiskAssessmentModel
    {
        public Int64 RowNumber { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  LEGAL_NAME { get; set; }
        public string?  DBA { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE { get; set; }
        public double TranNo_01 { get; set; }
        public double TranNo_02 { get; set; }
        public double TranNo_03 { get; set; }
        public double TranNo_04 { get; set; }
        public double TranNo_05 { get; set; }
        public double TranNo_06 { get; set; }
        public double TranNo_07 { get; set; }
        public double TranNo_08 { get; set; }
        public double TranNo_09 { get; set; }
        public double TranNo_10 { get; set; }
        public double TranNo_11 { get; set; }
        public double TranNo_12 { get; set; }

        public double TranAmount_01 { get; set; }
        public double TranAmount_02 { get; set; }
        public double TranAmount_03 { get; set; }
        public double TranAmount_04 { get; set; }
        public double TranAmount_05 { get; set; }
        public double TranAmount_06 { get; set; }
        public double TranAmount_07 { get; set; }
        public double TranAmount_08 { get; set; }
        public double TranAmount_09 { get; set; }
        public double TranAmount_10 { get; set; }
        public double TranAmount_11 { get; set; }
        public double TranAmount_12 { get; set; }
        public string?  OverAmount_01 { get; set; }
        public string?  OverAmount_02 { get; set; }
        public string?  OverAmount_03 { get; set; }
        public string?  OverAmount_04 { get; set; }
        public string?  OverAmount_05 { get; set; }
        public string?  OverAmount_06 { get; set; }
        public string?  OverAmount_07 { get; set; }
        public string?  OverAmount_08 { get; set; }
        public string?  OverAmount_09 { get; set; }
        public string?  OverAmount_10 { get; set; }
        public string?  OverAmount_11 { get; set; }
        public string?  OverAmount_12 { get; set; }
        public double Amount { get; set; }
        public double CountOfTran { get; set; }
        public double AvgTran { get; set; }
        public double NoofCtrs { get; set; }
        public double NoofSars { get; set; }
        public double SarsNo_01 { get; set; }
        public double SarsNo_02 { get; set; }
        public double SarsNo_03 { get; set; }
        public double SarsNo_04 { get; set; }
        public double SarsNo_05 { get; set; }
        public double SarsNo_06 { get; set; }
        public double SarsNo_07 { get; set; }
        public double SarsNo_08 { get; set; }
        public double SarsNo_09 { get; set; }
        public double SarsNo_10 { get; set; }
        public double SarsNo_11 { get; set; }
        public double SarsNo_12 { get; set; }
        public double CtrsNo_01 { get; set; }        
        public double CtrsNo_02 { get; set; }
        public double CtrsNo_03 { get; set; }
        public double CtrsNo_04 { get; set; }
        public double CtrsNo_05 { get; set; }
        public double CtrsNo_06 { get; set; }
        public double CtrsNo_07 { get; set; }
        public double CtrsNo_08 { get; set; }
        public double CtrsNo_09 { get; set; }
        public double CtrsNo_10 { get; set; }
        public double CtrsNo_11 { get; set; }
        public double CtrsNo_12 { get; set; }
        public double SarsofTrans { get; set; }
        public double SarsofTotal { get; set; }
        public double HighRisk { get; set; }
        public double Destination { get; set; }
        public double HIFCA { get; set; }
        public double HIDTA { get; set; }
        public double Volumn { get; set; }
        public double AverageTransaction { get; set; }
        public double NumberofSAR { get; set; }
        public double SARsTotalTrans { get; set; }
        public double SARsTotalofHL { get; set; }
        public double NumberofCTRs { get; set; }
        public double Total { get; set; }
        
        public string?  Grade { get; set; }
        public string?  GradeDetail { get; set; }
        public string?  Comment { get; set; }
        public string?  linkTransID { get; set; }

    }
    public class RiskAssessmentRespContent
    {
        public List<RiskAssessmentModel> ReportDetail { get; set; }
        //public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportSummary { get; set; }


    }
    public class RiskAssessmentResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public RiskAssessmentRespContent Content { get; set; }
    }
}