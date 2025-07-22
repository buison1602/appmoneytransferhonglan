using System.Collections.Generic;
namespace AppMoneyTransferRS.Models
{
    public class OfacImportModel
    {
        public Int64 No { get; set; }
        public DateTime ImportDate { get; set; }
    }
    public class OfacImportListModel
    {
        public List<OfacImportModel> OfacImportList { get; set; }
    
    }
    public class OfacImportListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public OfacImportListModel Content { get; set; }
    }
    public class OfacModel
    {
        public Int64 RowNumber { get; set; }
        public string?  FIRST_NAME { get; set; }
        public string?  LAST_NAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  AKA_FIRSTNAME { get; set; }
        public string?  AKA_LASTNAME { get; set; }
        public string?  AKA_FULLNAME { get; set; }
        public string?  ADDRESS_1 { get; set; }
        public string?  CITY { get; set; }
        public string?  Country { get; set; }
        public string?  TITLE { get; set; }
        public string?  SDN_TYPE { get; set; }
        public string?  REMARK { get; set; }
        public string?  TYPESDN { get; set; }
    }
    public class OfacListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public OfacListModel Content { get; set; }
    }
    public class OfacListModel
    { 
        public List<OfacModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }
    }

}
