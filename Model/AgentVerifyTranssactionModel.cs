using System;

using System.Collections.Generic;
namespace AppMoneyTransferRS.Models
{
    public class RequestOfacTransaction
    {
        public String UserID { get; set; }
        public List<RequestReleaseOfacTransaction> Transactions { get; set; }

    }
    public class RequestReleaseOfacTransaction
    {
        public string?  Transaction { get; set; }
        public string?  CustID { get; set; }
        public string?  ReasonforReleaseOfac { get; set; }


    }
    public class RequestAgentVerifyTransaction
    {
        public string?  Transaction { get; set; }
        public string?  ReasonforCancel { get; set; }
        public string?  ReasonforRefund { get; set; }
        public string?  ReasonForPending { get; set; }
        public string?  FeedBack { get; set; }
        public string?  PaymentAgent { get; set; }
        public string?  TypeTran { get; set; }
        public string?  Comment_Ctrs { get; set; }
        public string?  Comment_Sars { get; set; }
        public string?  CustID { get; set; }
        public double TotalAmount { get; set; } = 0;
       

    }
    public class RequestAgentVerify
    {
        public String UserID { get; set; }
        public string?  Form { get; set; } = "";
        public string?  FormName { get; set; } = "";
        public string?  Action { get; set; } = "";
        public string?  UserName { get; set; } = "";
        public String TypeExport { get; set; }
        public String batchName { get; set; }
        public String paymentAgent { get; set; }
        public String Comment_Ctrs { get; set; }
        public String Comment_Sars { get; set; }
        public String FillingName { get; set; }
        public String FileName { get; set; }
        public byte[]? FileLoad { get; set; }

        public List<RequestAgentVerifyTransaction> Transactions { get; set; }
        public List<CustomerProfileFile> SenderDocumentsLists { get; set; }

    }
    public class RequestAgentVerifyTranssaction
    {
        public String UserID { get; set; }
        public String OptionDate { get; set; }
        public String FromDate { get; set; }
        public String ToDate { get; set; }
        public String PartnerID { get; set; }
        public String ProvinceID { get; set; }
        public String BranchID { get; set; }
        public String EmployeeID { get; set; }
        public String Currency { get; set; }
        public String ImportBatch { get; set; }
        public String PaymentMethod { get; set; }
        public String EmailBatch { get; set; }
        public decimal FromAmount { get; set; }
        public decimal ToAmount { get; set; }
        public string?  EmailStatus { get; set; }
        public string?  StatusID { get; set; }
        public string?  ApproveStatus { get; set; }
        public String SearchBy { get; set; }
        public String SearchContent { get; set; }
        public int pageIndex { get; set; }
        public Int64 pageSize { get; set; }
    }

    public class ReportAgentVerifyTranssactionDetail
    {        
        public Int64 RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  REF_NO { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        public DateTime TRANS_DATENEW { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  OCCUPATION { get; set; }
        public string?  B_CUST_ID { get; set; }
        public string?  B_LASTNAME { get; set; }
        public string?  B_MIDDLENAME { get; set; }
        public string?  B_FIRSTNAME { get; set; }
        public string?  COUNTRY_ISSUE { get; set; }
        public string?  STATUS { get; set; }
        public string?  B_ADDRESS { get; set; }
        public string?  B_PHONE1 { get; set; }
        public string?  B_COUNTRY { get; set; }
        public string?  B_PHONE2 { get; set; }
        public string?  B_COMMENT { get; set; }
        public string?  PASSCODE { get; set; }
        public DateTime TRANS_DATE { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  USER_ID { get; set; }
        public double AMOUNT { get; set; }
        public string?  A_IN_W { get; set; }
        public double SERVICE_FEE { get; set; }
        public double P_FEE { get; set; }
        public double DISCOUNT_FEE { get; set; }
        public double AG_COMM_AMT { get; set; }
        public double TOTAL_AMT_USD { get; set; }
        public double EXCHANGE_RATE { get; set; }
    
        public DateTime DATE_APPLY_EX_RATE { get; set; }
        public string?  B_PAY_BY { get; set; }
        public double B_AMT_PAY { get; set; }
        public string?  REASON_SENDING { get; set; }
        public string?  SEND2COUNTRY { get; set; }
        public string?  B_NOTE { get; set; }
        public string?  PAY_BY { get; set; }
        public string?  PAY_TYPE { get; set; }
        public string?  TYPE_DELIVER { get; set; }
        public string?  TRANS_TYPE { get; set; }
        public string?  PAYABLE_CODE { get; set; }
        public string?  BANK_CODE { get; set; }
        public string?  B_BANKCODE { get; set; }
        public string?  BRANCH_NAME { get; set; }
        public string?  ACCOUNT_NO { get; set; }
        public string?  LAND_CURR { get; set; }
        public double LAND_AMT { get; set; }
        public string?  MSG_TO_BENE_1 { get; set; }
        public string?  MSG_TO_BENE_2 { get; set; }
        public string?  BANK_ID { get; set; }
        public string?  R_BANK_NAME { get; set; }
        public string?  R_ACCOUNT_TYPE { get; set; }
        public string?  R_BANK_ACCT_NO { get; set; }
        public string?  R_BANK_CITY { get; set; }
        public string?  USER_INPUT { get; set; }
        public int VERIFIED { get; set; }
        public string?  VERIFIER { get; set; }
        public string?  COMMENT { get; set; }
        public string?  PAYMENT_AGENT { get; set; }
        public string?  B_FULLNAME { get; set; }
        public string?  B_FULLNAMEVN { get; set; }
        public double Total_Due { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  LOCALNAME { get; set; }
        public string?  FROMCURRENCY { get; set; }
        public string?  TOCURRENCY { get; set; }
        public int DISCOUNTID { get; set; }
        public string?  DISCOUNTNAME { get; set; }
        public string?  AGENT_PAYMENT_NAME { get; set; }
        public string?  FROMCOUNTRY { get; set; }
        public string?  TOCOUNTRY { get; set; }
        public string?  StateName { get; set; }
        public string?  R_StateName { get; set; }
        public string?  AGG { get; set; }
        public bool REFUND { get; set; }
        public bool CANCEL { get; set; }
        public string?  CountryName { get; set; }
        public string?  Approved { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public double OTHERFEE { get; set; }
        public double TAXFEE { get; set; }
        public string?  typetran { get; set; }
        public string?  DOB { get; set; }
        public string?  EXPIRATION { get; set; }
        public string?  ID_TYPE { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public int OFAC_CHK { get; set; }
        public bool ReviewRefund { get; set; }
        public double AGENT_COMM { get; set; }
        public string?  PASSPORT_NO { get; set; }
    }
    
     public class ReportAgentVerifyTranssactionSummary
    {

        public Int64 Trans_No { get; set; }

        public Int64 NoofTran { get; set; }
        public double TOTAL_AMOUNT { get; set; }
        public double TOTAL_FEE { get; set; }
        public double OTHER_FEE { get; set; }
        public double TOTAL_DISCOUNT_FEE { get; set; }
        public double TOTAL_HDFEE { get; set; }
        public double TOTAL_TAX { get; set; }
        public double GRANT_TOTAL { get; set; }
        public double AAGENT_FEE { get; set; }
        public double TOTALAGENT_COMM { get; set; }


    }
    public class ReportAgentVerifyTranssactionSum
    {

        public Int64 Trans_No { get; set; }

      


    }
    public class ContentAgentVerifyTranssactionGeneralResponse
    {
        public List<ReportAgentVerifyTranssactionDetail> ReportDetail { get; set; }
        public List<ReportAgentVerifyTranssactionSummary> ReportSummary { get; set; }
        public List<ReportAgentVerifyTranssactionSum> ReportRecordCount { get; set; }
        public List<ReportAgentVerifyTranssactionSum> ReportVerifyRecordCount { get; set; }

    }
    public class GeneralAgentVerifyTranssactionReportResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentAgentVerifyTranssactionGeneralResponse Content { get; set; }
    }
}
