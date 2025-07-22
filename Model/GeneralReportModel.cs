using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.AspNetCore.Components.Forms;
using System;

using System.Collections.Generic;
using static ClosedXML.Excel.XLPredefinedFormat;
using DateTime = System.DateTime;

namespace AppMoneyTransferRS.Models
{
    public class RequestGeneralReport
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
    public class ReportDetailExport
    {
        public Int64 RowNumber { get; set; }
      public DateTime TRANS_DATENEW { get; set; }
      public string?  CUST_ID { get; set; }
      public string?  LASTNAME { get; set; }
      public string?  FIRSTNAME { get; set; }
      public string?  MIDDLENAME { get; set; }
      public string?  FULLNAME { get; set; }
      public string?  DOB { get; set; }
      public string?  EMAIL { get; set; }
      public string?  ID_TYPE { get; set; }
      public string?  DRIVER_ID { get; set; }
      public string?  PASSPORT_NO { get; set; }
      public string?  STATE_ISSUE { get; set; }
      public string?  EXPIRATION { get; set; }
      public string?  SSN { get; set; }
      public string?  ADDRESS { get; set; }
      public string?  CITY { get; set; }
      public string?  STATE { get; set; }
      public string?  ZIP_CODE { get; set; }
      public string?  COUNTRY { get; set; }
      public string?  PHONE1 { get; set; }
      public string?  PHONE2 { get; set; }
      public string?  FAX { get; set; }
      public string?  OCCUPATION { get; set; }
      public string?  COUNTRY_ISSUE { get; set; }
      public string?  IMAGE_DOC { get; set; }
      public string?  C_COMMENT { get; set; }
      public int? KYC_CNT { get; set; }
      public int? STATUS { get; set; }
      public int? IS_COMPLETE { get; set; }
      public int? IS_PROMO { get; set; }
      public string?  PROMO_TYPE { get; set; }
      public DateTime CreateDate { get; set; }
      public string?  B_CUST_ID { get; set; }
      public string?  B_LASTNAME { get; set; }
      public string?  B_FIRSTNAME { get; set; }
      public string?  B_MIDDLENAME { get; set; }
      public string?  CN_LASTNAME { get; set; }
      public string?  CN_FIRSTNAME { get; set; }
      public string?  CN_MIDDLENAME { get; set; }
      public string?  B_CORRECT_CN_NAME { get; set; }
      public string?  B_ADDRESS { get; set; }
      public string?  ADDRESS2 { get; set; }
      public string?  CN_ADDRESS { get; set; }
      public string?  B_CORRECT_CN_ADDRESS { get; set; }
      public string?  GENDER { get; set; }
      public string?  B_CITY { get; set; }
      public string?  B_STATE { get; set; }
      public string?  CN_CITY { get; set; }
      public string?  DISTRICT { get; set; }
      public string?  CN_DISTRICT { get; set; }
      public string?  B_PROVINCE_ID { get; set; }
      public string?  CN_PROVINCE { get; set; }
      public string?  ISO_CODE { get; set; }
      public string?  B_ZIPCODE { get; set; }
      public string?  B_COUNTRY { get; set; }
      public string?  B_PHONE1 { get; set; }
      public string?  B_PHONE2 { get; set; }
      public string?  B_PHONENEW { get; set; }
      public string?  B_FAX { get; set; }
      public string?  OTHER_B { get; set; }
      public string?  B_COMMENT { get; set; }
      public string?  B_STATUS { get; set; }
      public string?  TRANS_ID { get; set; }
      public string?  PASSCODE { get; set; }
      public DateTime TRANS_DATE { get; set; }
      public string?  USER_ID { get; set; }
      public string?  AGENT_ID { get; set; }
      public string?  B_FIRSTNAME2 { get; set; }
      public string?  B_LASTNAME2 { get; set; }
      public string?  B_MIDDLENAME2 { get; set; }
      public string?  B_RECIPIENT2 { get; set; }
        public int? IS_BH { get; set; }
      public string?  FIRSTNAME_BH { get; set; }
      public string?  MIDDLENAME_BH { get; set; }
      public string?  LASTNAME_BH { get; set; }
      public string?  FULLNAMEBH { get; set; }
      public string?  ADDRESS_BH { get; set; }
      public string?  CITY_BH { get; set; }
      public string?  STATE_BH { get; set; }
      public string?  ZIPCODE_BH { get; set; }
      public string?  COUNTRY_BH { get; set; }
      public string?  PHONE_BH { get; set; }
      public string?  PROVINCE_ID { get; set; }
      public string?  VN_ZONE { get; set; }
      public string?  B_CMND { get; set; }
      public double? AMOUNT { get; set; }
      public string?  A_IN_W { get; set; }
      public double? SERVICE_FEE { get; set; }
      public double? P_FEE { get; set; }
      public double? DISCOUNT_FEE { get; set; }
      public double? AG_COMM_AMT { get; set; }
      public double TOTAL_AMT_USD { get; set; }
      public double? EXCHANGE_RATE { get; set; }
      public string?  DATE_APPLY_EX_RATE { get; set; }
      public string?  B_PAY_BY { get; set; }
      public double? B_AMT_PAY { get; set; }
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
      public double? LAND_AMT { get; set; }
      public string?  MSG_TO_BENE_1 { get; set; }
      public string?  MSG_TO_BENE_2 { get; set; }
      public string?  BANK_ID { get; set; }
      public string?  R_BANK_NAME { get; set; }
      public string?  R_ACCOUNT_TYPE { get; set; }
      public string?  R_BANK_ACCT_NO { get; set; }
      public string?  R_BANK_CITY { get; set; }
      public string?  USER_INPUT { get; set; }
      public string?  VERIFIED { get; set; }
      public string?  VERIFIER { get; set; }
      public string?  VERIFIED2 { get; set; }
      public string?  VERIFIER2 { get; set; }
      public string?  BATCH_ID { get; set; }
      public DateTime? DATE_VERIFY { get; set; }
      public string?  STATUS_ID { get; set; }
      public string?  WHO_DELIVER { get; set; }
      public string?  DELIVER_DATE { get; set; }
      public string?  REASON { get; set; }
      public string?  IMG_RECEIPT { get; set; }
      public int? OFAC_CHK { get; set; }
      public int? OFAC { get; set; }
      public int? CTR { get; set; }
      public int? SAR { get; set; }
      public string?  FILE_SAR { get; set; }
      public string?  FILE_CTR { get; set; }
      public string?  FILE_BY { get; set; }
      public string?  PRINTED { get; set; }
      public string?  PRINT_FOR { get; set; }
      public string?  PAID_STATUS { get; set; }
      public string?  PROCESSER { get; set; }
      public double? POINT { get; set; }
      public string?  INVOICE_NO { get; set; }
      public int? INVOICE { get; set; }
      public string?  REF_NO { get; set; }
      public string?  COMMENT { get; set; }
      public string?  OFFICE_NOTE { get; set; }
      public string?  TRX_TYPE { get; set; }
      public string?  PAYMENT_AGENT { get; set; }
      public string?  CN_TRANS_NO { get; set; }
      public string?  CN_CUST_NO { get; set; }
      public string?  CN_NOTE { get; set; }
      public string?  CORRECT_CN_NAME { get; set; }
      public string?  CORRECT_CN_ADDRESS { get; set; }
      public string?  CN_EXP_ID { get; set; }
      public string?  KYC_REASON { get; set; }
      public string?  B_FULLNAME { get; set; }
      public string?  B_FULLNAMEVN { get; set; }
      public string?  CURRENCY { get; set; }
      public string?  AGENT_NAME { get; set; }
      public double? Total_Due { get; set; }
      public string?  LOCALNAME { get; set; }
      public string?  A_ADDRESS { get; set; }
      public string?  A_CITY { get; set; }
      public string?  A_STATE { get; set; }
      public string?  A_ZIP_CODE { get; set; }
      public string?  A_COUNTRY { get; set; }
      public string?  A_PHONE { get; set; }
      public string?  A_EMAIL { get; set; }
      public string?  A_FAX { get; set; }
      public int KYC { get; set; }
      public string?  FROMCURRENCY { get; set; }
      public string?  TOCURRENCY { get; set; }
      public string?  FROMCOUNTRY { get; set; }
      public string?  TOCOUNTRY { get; set; }
      public string?  DISCOUNTID { get; set; }
      public string?  DISCOUNTNAME { get; set; }
      public string?  AGENT_PAYMENT_NAME { get; set; }
      public string?  StateName { get; set; }
      public string?  R_StateName { get; set; }
      public int AGG { get; set; }
      public string?  AGG_REASON { get; set; }
      public string?  AGG_CHINA { get; set; }
      public string?  AGG_CHINA_REASON { get; set; }
      public bool? CANCEL { get; set; }
        public DateTime? CANCELDATE { get; set; }
      public string?  CANCELBY { get; set; }
      public bool? REFUND { get; set; }
      public DateTime? REFUNDDATE { get; set; }
      public string?  REFUNDBY { get; set; }
      public string?  REFUNDREASON { get; set; }
      public string?  CANCELREASON { get; set; }
      public string?  A_IN_W_VN { get; set; }
      public string?  CountryName { get; set; }
      public string?  Approved { get; set; }
      public string?  StatusNameBlock { get; set; }
      public string?  B_SSN { get; set; }
      public string?  B_OCCUPATION { get; set; }
      public string?  B_EXPIRATION { get; set; }
      public string?  B_STATE_ISSUE { get; set; }
      public string?  B_PASSPORT_NO { get; set; }
      public string?  B_DRIVER_ID { get; set; }
      public string?  B_ID_TYPE { get; set; }
      public string?  B_EMAIL { get; set; }
      public string?  B_DOB { get; set; }
      public string?  TYPE_AGENT { get; set; }
      public string?  LEGAL_NAME { get; set; }
      public string?  S_FULLADDRESS { get; set; }
      public string?  R_FULLADDRESS { get; set; }
      public string?  R_FULLADDRESSVN { get; set; }
      public string?  FILESOURCENAME { get; set; }
      public bool? REVIEWREFUND { get; set; }
      public string?  REVIEWREFUNDBY { get; set; }
        public DateTime? REVIEWREFUNDDATE { get; set; }
      public string?  REVIEWREFUNDREASON { get; set; }
      public string?  License { get; set; }
      public string?  FileReceiptName { get; set; }
      public string?  FileImageName { get; set; }
      public bool? chkEmail { get; set; }
      public bool? chkPhone { get; set; }
      public string?  ReasonForPending { get; set; }
      public string?  TypeSourceOfFund { get; set; }
      public double? OTHERFEE { get; set; }
      public double? TAXFEE { get; set; }
      public string?  SourceOfFund { get; set; }
      public string?  BBVA { get; set; }
      public string?  REVIEWREFUNDFULL { get; set; }
      public string?  PASSCODEBBVA { get; set; }
      public double? AMOUNTBK { get; set; }
      public double? SERVICE_FEEBK { get; set; }
      public double? P_FEEBK { get; set; }
      public double? DISCOUNT_FEEBK { get; set; }
      public double? AG_COMM_AMTBK { get; set; }
      public double? TOTAL_AMT_USDBK { get; set; }
      public double? OtherFeeBK { get; set; }
      public double? TAXFEEBK { get; set; }
      public string?  Case_Sender_Full_Name { get; set; }
      public string?  Case_Sender_Address { get; set; }
      public string?  Case_Sender_Phone { get; set; }
      public string?  Case_Receiver_Full_Name { get; set; }
      public string?  Case_Receiver_Address { get; set; }
      public string?  Case_Receiver_Phone { get; set; }
      public string?  Case_SS { get; set; }
      public string?  Case_Driver_ID { get; set; }
      public string?  Case_BankAccount { get; set; }
      public bool? CHECKSARS { get; set; }
      public bool? ChkSentEmail { get; set; }
      public bool? ChkSentPhone { get; set; }
      public string?  trans_id2 { get; set; }
      public string?  OWNER_NAME { get; set; }
      public string?  LICENSE_NO { get; set; }
      public string?  BUSINESS_TYPE { get; set; }
      public string?  BUSINESS_STRUCT { get; set; }
      public string?  COMPLIANCE_OFFICER { get; set; }
      public string?  REASONFORBLOCK { get; set; }
      public string?  BANK_TYPE { get; set; }
      public string?  A_BANK_NAME { get; set; }
      public string?  A_BANK_ADDRESS { get; set; }
      public string?  EIN { get; set; }
      public string?  TRANTYPENAME { get; set; }
      public double? OtherFeeBK2 { get; set; }
      public double? TAXFEEBK2 { get; set; }
      public double? TOTAL_AMT_USDBK2 { get; set; }
      public double? AG_COMM_AMTBK2 { get; set; }
      public double? DISCOUNT_FEEBK2 { get; set; }
      public double? P_FEEBK2 { get; set; }
      public double? SERVICE_FEEBK2 { get; set; }
      public double? AMOUNTBK2 { get; set; }
      public string?  AGENT_STATUS { get; set; }
      public string?  kyc_folder { get; set; }
      public DateTime? SAR_Date { get; set; }
      public DateTime? CTR_Date { get; set; }
      public string?  SAR_Filing_Name { get; set; }
      public string?  AgentStateName { get; set; }
      public string?  FILEIDNAME { get; set; }
      public string?  ISSUE_DATE { get; set; }
      public string?  ExportQuickBook { get; set; }
      public string?  ExportQuickBookBy { get; set; }
        public DateTime? ExportQuickBookDate { get; set; }
      public string?  SSN_BK { get; set; }
      public string?  DRIVER_ID_BK { get; set; }
      public string?  DOB_BK { get; set; }
      public string?  CompanyNote { get; set; }
      public string?  securityanswer { get; set; }
      public string?  FeedBack { get; set; }
      public string?  BB_COUNTRY { get; set; }
      public string?  DFI { get; set; }
      public string?  UserFullName { get; set; }
      public string?  R_DOB { get; set; }
      public string?  R_ID_TYPE { get; set; }
      public string?  R_DRIVER_ID { get; set; }
      public string?  R_PASSPORT_NO { get; set; }
      public string?  R_STATE_ISSUE { get; set; }
      public string?  R_EXPIRATION { get; set; }
      public string?  R_SSN { get; set; }
      public string?  R_DOB_BK { get; set; }
      public string?  R_DRIVER_ID_BK { get; set; }
      public string?  R_SSN_BK { get; set; }
      public string?  R_Issue_Date { get; set; }
      public string?  BANKCODE { get; set; }
      public string?  BANK_NAME { get; set; }
      public string?  BANK_ADDRESS { get; set; }
      public string?  B_ACCOUNT_NO { get; set; }
      public string?  SWIFTCODE { get; set; }
      public string?  P_ADDRESS { get; set; }
      public string?  P_PHONE { get; set; }
      public string?  P_FAX { get; set; }
      public string?  R_Occupation { get; set; }
      public string?  DEDUCOTHERFEE_BK { get; set; }
      public string?  DEDUCOTHERFEE { get; set; }
      public double? AMOUNTPAID { get; set; }
      public string?  DBA { get; set; }
      public string?  TYPE_AGENTNAME { get; set; }
      public string?  StatusName { get; set; }
      public string?  BankCity { get; set; }
      public string?  ImageReceiver { get; set; }
      public string?  Case_Ctr { get; set; }
      public string?  Case_Sar { get; set; }
      public string?  StatusRec { get; set; }
      public string?  ReasonHolding { get; set; }
      public string?  VerifyBy { get; set; }
      public DateTime? VerifyDate { get; set; }
      public string?  Verify { get; set; }
      public string?  ExportBy { get; set; }
        public DateTime? ExportDate { get; set; }
      public bool? Export { get; set; }
      public string?  PaidBy { get; set; }
        public DateTime? PaidDate { get; set; }
      public bool? Paid { get; set; }
      public string?  D_TYPE { get; set; }
      public string?  F_TABLE { get; set; }
      public string?  ID { get; set; }
      public string?  SUB_AGENT_PAYMENT_NAME { get; set; }
      public string?  SUB_PAYMENT_ADDRESS { get; set; }
      public string?  SUB_PAYMENT_PHONE { get; set; }
      public string?  SUB_PAYMENT_FAX { get; set; }
      public string?  PaymentCurrency { get; set; }
      public double? payment_servicefee { get; set; }
      public double? payment_servicefeebk { get; set; }
      public string?  BANKCODE3 { get; set; }
      public string?  Rec_BankState { get; set; }
      public string?  Rec_CityState { get; set; }
      public string?  Rec_BankStateHoa { get; set; }
      public string?  TypeTran { get; set; }
      public string?  CCARDID { get; set; }
      public string?  R_FULLNAME { get; set; }
      public string?  ReleaseHoldingBy { get; set; }
      public string?  ReleaseHolding { get; set; }
      public string?  ReleaseHoldingReason { get; set; }
      public string?  IdProcessPayment { get; set; }
      public string?  RefProcessPayment { get; set; }
      public string?  IdCapture { get; set; }
      public string?  RefCapture { get; set; }
      public string?  IdVoidCapture { get; set; }
      public string?  RefVoidCapture { get; set; }
      public string?  IdReversal { get; set; }
      public string?  RefReversal { get; set; }
      public string?  IdRefund { get; set; }
      public string?  RefRefund { get; set; }
      public bool? Review { get; set; }
      public string?  ReviewBy { get; set; }
        public DateTime? ReviewDate { get; set; }
      public bool? NotPaid { get; set; }
      public string?  NotPaidBy { get; set; }
        public DateTime? NotPaidDate { get; set; }
      public string?  ReasonReview { get; set; }
      public string?  ReasonReviewApproved { get; set; }
        public bool? chkCheckOfac { get; set; }
      public bool?  chkCheckAgg { get; set; }
      public bool? Pay { get; set; }
      public string?  Payby { get; set; }
        public DateTime? PayDate { get; set; }
      public string?  State_Input { get; set; }
      public string?  IP { get; set; }
      public string?  Case_Receiver_ID { get; set; }
      public string?  reasonforreviewpayment { get; set; }
        public DateTime? CyberDMDate { get; set; }
      public string?  CyberPaymentPayment { get; set; }
        public DateTime? CyberRefundDate { get; set; }
      public string?  SOCT { get; set; }
      public bool? CheckIDAgg { get; set; }
      public string?  CUST_ID_REF { get; set; }
      public string?  B_CUST_ID_REF { get; set; }
      public string?  TRANS_REF { get; set; }
        public string?  TransIDDerypt { get; set; }
        public string?  linkTransID { get; set; }
        public string?  ACTION_TYPE { get; set; }
        public string?  AG_COMMENT { get; set; }
        public string?  ActionBy { get; set; }
        public string?  ActionDate { get; set; }
        public string?  COMMENT_OFAC { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  Idology_ID { get; set; }
        public string?  HoldingBy { get; set; }
        public DateTime? HoldingDate { get; set; }
        public string?  COMMENTHOLD { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  OfacReceiver { get; set; }
        public string?  OfacSenderBH { get; set; }
        public string?  OfacSender { get; set; }
        public string?  FundDateConvent { get; set; }
        


    }
    public class ExportReportResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentExportResponse Content { get; set; }
    }
    public class ContentExportResponse
    {
        public List<ReportDetailExport> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }
        public List<ReportTranSummary> ReportVerifyRecordCount { get; set; }
    }
    public class ReceiptResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentReportResponse Content { get; set; }
    }
    public class ContentReportResponse
    {
        public List<TransDetail>  reportDetail { get; set; }
      
    }
    public class ReceiptDomesticResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentDomesticReportResponse Content { get; set; }
    }
    public class ContentDomesticReportResponse
    {
        public List<DomesticTransDetail> reportDetail { get; set; }

    }
    public class DomesticTransDetail
    {
        public Int64? RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  REF_NO { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        public string?  TRANS_REF { get; set; }

        public DateTime TRANS_DATENEW { get; set; }
        public string?  CUST_ID1 { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
        public string?  OCCUPATION { get; set; }
        public string?  B_CUST_ID { get; set; }
        public string?  B_CUST_ID1 { get; set; }
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
        public double PayoutFee { get; set; }
        public DateTime DATE_APPLY_EX_RATE { get; set; }
        public string?  B_PAY_BY { get; set; }
        public double B_AMT_PAY { get; set; }
        public double TOAMOUNT { get; set; }
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
        public int? AGG { get; set; }
        public int? IS_BH { get; set; }

        public bool? REFUND { get; set; }
        public bool? CANCEL { get; set; }
        public string?  CANCELBY { get; set; }
        public DateTime? CANCELDATE { get; set; }
        public string?  CountryName { get; set; }
        public string?  Approved { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public double OTHERFEE { get; set; }
        public double TAXFEE { get; set; }
        public string?  typetran { get; set; }
        public string?  DOB { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }

        public string?  ID_TYPE { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string?  ISSUE_DATE { get; set; }
        public DateTime? IssueDateBK { get; set; }

        public int? OFAC_CHK { get; set; }
        public int? RequestRefund { get; set; }
        public bool? ReviewRefund { get; set; }
        public int? OFAC { get; set; }
        public int? ISKYC { get; set; }
        public DateTime? REVIEWREFUNDDATE { get; set; }
        public DateTime? PaidDate { get; set; }
        public string?  REVIEWREFUNDBY { get; set; }
        public double AGENT_COMM { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  ReasonforCancel { get; set; }
        public string?  ReasonforRefund { get; set; }
        public string?  ReasonforReviewRefund { get; set; }
        public string?  ReasonforReleaseOfac { get; set; }
        public string?  ReasonforHolding { get; set; }
        public string?  KYC_REASON { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  ReasonHolding { get; set; }
        public string?  ReasonforReleaseKYC { get; set; }
        public int STATUS_ID { get; set; }
        public string?  DownloadReceipt { get; set; }
        public string?  DownloadBSA { get; set; }
        public string?  DownloadBeHafl { get; set; }
        public string?  ReasonforUpdate { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ReleaseHoldingReason { get; set; }
        public string?  Verify { get; set; }
        public string?  VerifyBy { get; set; }
        public DateTime? VerifyDate { get; set; }
        public bool ProcessApprove { get; set; }
        public string?  TRANTYPENAME { get; set; }
        public string?  Type { get; set; }
        public DateTime? CANCEL_DATE { get; set; }
        public string?  FIRSTNAME_BH { get; set; }
        public string?  MIDDLENAME_BH { get; set; }
        public string?  LASTNAME_BH { get; set; }
        public string?  ADDRESS_BH { get; set; }
        public string?  CITY_BH { get; set; }
        public string?  STATE_BH { get; set; }
        public string?  ZIPCODE_BH { get; set; }
        public string?  PHONE_BH { get; set; }
        public string?  EMAIL_BH { get; set; }
        public string?  IDTYPE_BH { get; set; }

        public string?  ID_BH { get; set; }
        public string?  COUNTRYISSUE_BH { get; set; }
        public string?  STATEISSUE_BH { get; set; }
        public string?  SBHSSN { get; set; }
        public string?  BH_OCCUPATION { get; set; }
        public string?  ISSUEDATE_BH { get; set; }
        public string?  EXPIREDATE_BH { get; set; }
        public string?  DOB_BH { get; set; }

        public string?  B_RECIPIENT2 { get; set; }
        public string?  B_CITY { get; set; }
        public string?  B_PROVINCE_ID { get; set; }
        public string?  B_ZIPCODE { get; set; }
        
        public string?  linkTransID { get; set; }
        public string?  TransIDDerypt { get; set; }
        public string?  A_ADDRESS { get; set; }
        public string?  A_CITY { get; set; }
        public string?  A_STATE { get; set; }
        public string?  A_ZIP_CODE { get; set; }
        public string?  A_PHONE { get; set; }
        public string?  A_FAX { get; set; }
        public string?  A_EMAIL { get; set; }
        public string?  CompanyNote { get; set; }
        public string?  SecurityAnswer { get; set; }
        public string?  REASON_SENDING_ID { get; set; }
        public string?  ReasonwithSenderID { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  TYPESOURCEOFFUND { get; set; }
        public string?  SOURCEOFFUND { get; set; }
        public string?  R_DRIVER_ID { get; set; }
        public string?  R_SSN { get; set; }
        public string?  R_DRIVER_ID_BK { get; set; }
        public string?  R_SSN_BK { get; set; }
        public string?  R_ID_TYPE { get; set; }
        public string?  R_CountryIssue { get; set; }
        public string?  R_STATE_ISSUE { get; set; }
        public string?  R_Issue_Date { get; set; }
        public string?  R_EXPIRATION { get; set; }
        public string?  R_DOB { get; set; }
        public string?  R_DOB_BK { get; set; }
        public DateTime? B_Issue_Date1 { get; set; }
        public DateTime? B_EXPIRATION1 { get; set; }
        public DateTime? B_DOB1 { get; set; }
        public string?  R_Occupation { get; set; }
        public double Deduct { get; set; } = 0;
        public string?  DOMESTIC_AGENT_NAME { get; set; }
        public string?  DOMESTIC_AGENT_ADDRESS { get; set; }
        public string?  DOMESTIC_AGENT_PHONE { get; set; }
        public string?  DOMESTIC_AGENT_FAX { get; set; }
        
        public bool AGG_CHECK0 { get; set; } = false;
        public bool AGG_CHECK1 { get; set; } = false;
        public bool AGG_CHECK2 { get; set; } = false;
        public bool AGG_CHECK3 { get; set; } = false;
        public bool AGG_CHECK4 { get; set; } = false;
        public bool AGG_CHECK5 { get; set; } = false;
        public bool AGG_CHECK6 { get; set; } = false;
        public bool AGG_CHECK7 { get; set; } = false;
        public bool AGG_CHECK8 { get; set; } = false;
        public bool AGG_CHECK9 { get; set; } = false;
        public bool AGG_CHECK10 { get; set; } = false;
        public int AGG_DATE0 { get; set; } = 0;
        public int AGG_DATE1 { get; set; } = 0;
        public int AGG_DATE2 { get; set; } = 0;
        public int AGG_DATE3 { get; set; } = 0;
        public int AGG_DATE4 { get; set; } = 0;
        public int AGG_DATE5 { get; set; } = 0;
        public int AGG_DATE6 { get; set; } = 0;
        public int AGG_DATE7 { get; set; } = 0;
        public int AGG_DATE8 { get; set; } = 0;
        public int AGG_DATE9 { get; set; } = 0;
        public int AGG_DATE10 { get; set; } = 0;
        public bool IDCheck { get; set; } = false;
        public bool CheckID { get; set; } = false;
        public bool CheckSSN { get; set; } = false;
        public string?  messageVerifyID { get; set; } = "";
        public string?  messageVerifySSN { get; set; } = "";

    }
    public class TransDetail
    {
        public Int64? RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  REF_NO { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        public string?  TRANS_REF { get; set; }
        
        public DateTime TRANS_DATENEW { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
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
        public double TOAMOUNT { get; set; }
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
        public int? AGG { get; set; }
        public int? IS_BH { get; set; }

        public bool? REFUND { get; set; }
        public bool? CANCEL { get; set; }
        public string?  CANCELBY { get; set; }
        public DateTime? CANCELDATE { get; set; }
        public string?  CountryName { get; set; }
        public string?  Approved { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public double OTHERFEE { get; set; }
        public double TAXFEE { get; set; }
        public string?  typetran { get; set; }
        public string?  DOB { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }

        public string?  ID_TYPE { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string?  ISSUE_DATE { get; set; }
        public DateTime? IssueDateBK { get; set; }

        public int? OFAC_CHK { get; set; }
        public int? RequestRefund { get; set; }
        public bool? ReviewRefund { get; set; }
        public int? OFAC { get; set; }
        public int? ISKYC { get; set; }
        public DateTime? REVIEWREFUNDDATE { get; set; }
        public DateTime? PaidDate { get; set; }
        public string?  REVIEWREFUNDBY { get; set; }
        public double AGENT_COMM { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  ReasonforCancel { get; set; }
        public string?  ReasonforRefund { get; set; }
        public string?  ReasonforReviewRefund { get; set; }
        public string?  ReasonforReleaseOfac { get; set; }
        public string?  ReasonforHolding { get; set; }
        public string?  KYC_REASON { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  ReasonHolding { get; set; }
        public string?  ReasonforReleaseKYC { get; set; }
        public int STATUS_ID { get; set; }
        public string?  DownloadReceipt { get; set; }
        public string?  DownloadBSA { get; set; }
        public string?  DownloadBeHafl { get; set; }
        public string?  ReasonforUpdate { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ReleaseHoldingReason { get; set; }
        public string?  Verify { get; set; }
        public string?  VerifyBy { get; set; }
        public DateTime? VerifyDate { get; set; }
        public bool ProcessApprove { get; set; }
        public string?  TRANTYPENAME { get; set; }
        public string?  Type { get; set; }
        public DateTime? CANCEL_DATE { get; set; }
        public string?  FIRSTNAME_BH { get; set; }
        public string?  MIDDLENAME_BH { get; set; }
        public string?  LASTNAME_BH { get; set; }
        public string?  ADDRESS_BH { get; set; }
        public string?  CITY_BH { get; set; }
        public string?  STATE_BH { get; set; }
        public string?  ZIPCODE_BH { get; set; }
        public string?  PHONE_BH { get; set; }
        public string?  EMAIL_BH { get; set; }
        public string?  IDTYPE_BH { get; set; }
        
        public string?  ID_BH { get; set; }
        public string?  COUNTRYISSUE_BH { get; set; }
        public string?  STATEISSUE_BH { get; set; }
        public string?  SBHSSN { get; set; }
        public string?  BH_OCCUPATION { get; set; }
        public string?  ISSUEDATE_BH { get; set; }
        public string?  EXPIREDATE_BH { get; set; }
        public string?  DOB_BH { get; set; }

        public string?  B_RECIPIENT2 { get; set; }
        public string?  B_CITY { get; set; }
        public string?  B_PROVINCE_ID { get; set; }
        public string?  B_ZIPCODE { get; set; }
        public string?  linkTransID { get; set; }
        public string?  TransIDDerypt { get; set; }
        public string?  A_ADDRESS { get; set; }
        public string?  A_CITY { get; set; }
        public string?  A_STATE { get; set; }
        public string?  A_ZIP_CODE { get; set; }
        public string?  A_PHONE { get; set; }
        public string?  A_FAX { get; set; }
        public string?  A_EMAIL { get; set; }
        public string?  CompanyNote { get; set; }
        public string?  SecurityAnswer { get; set; }
        public string?  REASON_SENDING_ID { get; set; }
        public string?  ReasonwithSenderID { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  TYPESOURCEOFFUND { get; set; }
        public string?  SOURCEOFFUND { get; set; }
        public string?  B_DRIVER_ID { get; set; }
        public string?  B_SSN { get; set; }
        public string?  B_IDType { get; set; }
        public string?  B_CountryIssue { get; set; }
        public string?  B_StateIssue { get; set; }
        //public DateTime? B_IssueDate { get; set; }
        //public DateTime? B_ExpireDate { get; set; }
        //public DateTime? B_DOB { get; set; }
        public string?  B_Occupation { get; set; }
        public double Deduct { get; set; } = 0;
        
    }
    public class AccountBalanceSummaryMocel
    {
        public Int64? ID { get; set; }
        public Int64? STT { get; set; }
        public Int64? RowNumber { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }
        public double? BEGIN_BALANCEDK { get; set; }
        public double? CREDIT_LINE { get; set; }
        public double? CREDIT_LINEAPP { get; set; }
        public double? PAYMENTTK { get; set; }
        public double? TRAN_AMOUNTTK { get; set; }
        public double? TRAN_AMOUNTREFUNDTK { get; set; }
        public double? TRAN_AMOUNTCANCELTK { get; set; }
        public double? DOMESTICTK { get; set; }
        public double? END_BALANCEDK { get; set; }
        public string?  PaymentStatus { get; set; }
        public string?  TYPEOPTION { get; set; }
        public DateTime? TranApprove { get; set; }
        public DateTime? trandate { get; set; }
        public string?  NUM { get; set; }
        public double? AMOUNT { get; set; }
        public double? BALANCE { get; set; }
        public double? TRANS_AVE { get; set; }
        public double? BondAmount { get; set; }
        public double? ACREDIT { get; set; }
        public double? EndBold { get; set; }
        
    }
    public class ReportDetail
    {
        
             public Int64? NoofTran { get; set; }
        public Int64? RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  REF_NO { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        public string?  TRANS_REF { get; set; }
        public string?  IdProcessPayment { get; set; }
        
        public DateTime TRANS_DATENEW { get; set; }
        //public DateTime Case_No_Date { get; set; }
        
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  S_PHONE { get; set; }
        
        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
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
        public double FEE { get; set; }
        public double payment_servicefee { get; set; }
        public string?  B_PAY_BY { get; set; }
        public DateTime DATE_APPLY_EX_RATE { get; set; }
        public string?  PaymentCurrency { get; set; }
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
        public bool AGG { get; set; }
        public bool IS_BH { get; set; }
        
        public bool REFUND { get; set; }
        public bool CANCEL { get; set; }
        public string?  CANCELBY { get; set; }
        public DateTime? CANCELDATE { get; set; }
        public string?  CountryName { get; set; }
        public string?  Approved { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public double OTHERFEE { get; set; }
        public double TAXFEE { get; set; }
        public string?  typetran { get; set; }
        public string?  DOB { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }
        
        public string?  ID_TYPE { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string?  ISSUE_DATE { get; set; }
        public string?  STATE_ISSUENAME { get; set; }        
        public DateTime? IssueDateBK { get; set; }        
        public int OFAC_CHK { get; set; }
        public bool RequestRefund { get; set; }
        public bool ReviewRefund { get; set; }
        public bool OFAC { get; set; }
        public bool ISKYC { get; set; }
        public DateTime? REVIEWREFUNDDATE { get; set; }
        public DateTime? PaidDate { get; set; }
        public string?  REVIEWREFUNDBY { get; set; }
        public double AGENT_COMM { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  ReasonforCancel { get; set; }
        public string?  ReasonforRefund { get; set; }
        public string?  ReasonforReviewRefund { get; set; }
        public string?  ReasonforReleaseOfac { get; set; }
        public string?  ReasonforHolding { get; set; }
        public string? KYC_REASON { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  ReasonHolding { get; set; }
        public string?  ReasonforReleaseKYC { get; set; }
        public int STATUS_ID { get; set; }
        public string?  DownloadReceipt { get; set; }
        public string?  DownloadBSA { get; set; }
        public string?  DownloadBeHafl { get; set; }
        public string?  ReasonforUpdate { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ReleaseHoldingReason { get; set; }
        public string?  ReleaseHoldingBy { get; set; }
        public DateTime? ReleaseHolding { get; set; }
        public string?  Verify { get; set; }
        public string?  VerifyBy { get; set; }
        public DateTime? VerifyDate { get; set; }
        public bool ProcessApprove { get; set; }
        public string?  TRANTYPENAME { get; set; }
        public string?  Type { get; set; }
        public DateTime? CANCEL_DATE { get; set; }
        public string?  FIRSTNAME_BH { get; set; }
        public string?  MIDDLENAME_BH { get; set; }
        public string?  LASTNAME_BH { get; set; }
        public string?  FULLNAMEBH { get; set; }
        
        public string?  ADDRESS_BH { get; set; }
        public string?  CITY_BH { get; set; }
        public string?  STATE_BH { get; set; }
        public string?  ZIPCODE_BH { get; set; }
        public string?  PHONE_BH { get; set; }
        public string?  B_RECIPIENT2 { get; set; }
        public string?  B_CITY { get; set; }
        public string?  linkTransID { get; set; }
        public string?  TransIDDerypt { get; set; }
        public string?  bgcolor { get; set; }
        public string?  bgcolors { get; set; }
        public string?  Case_No { get; set; }
        public DateTime Case_No_Date { get; set; }
        public string?  Case_No_DateNew { get; set; }
        public string?  Sender_Full_Name { get; set; }
        public string?  Sender_Address { get; set; }
        public string?  Phone_No { get; set; }
        public string?  Phone { get; set; }
        
        public string?  SS { get; set; }
        public string?  Receiver_Full_Name { get; set; }
        public string?  Receiver_Phone { get; set; }
        public string?  BankAccount { get; set; }
       
        public double TOTAL { get; set; }
        public DateTime Case_SarsDate { get; set; }
        public DateTime Case_CtrsDate { get; set; }
        public string?  Comment_Sars { get; set; }
        public string?  Comment_Ctrs { get; set; }
        public string?  FillingName { get; set; }
        public Int64 STT { get; set; }
        public string?  CreateBy { get; set; }
        public bool CheckSumSars { get; set; }
        public string?  FileSarsName { get; set; }
        public string?  FileCTRsName { get; set; }
        public Int64 SumCustSars { get; set; }
        public Int64 SumTransSars { get; set; }
        public string?  LinkHistoryTranSARs { get; set; }
        public string?  LinkHistoryCustSARs { get; set; }
        public Int64 SumCustCtrs { get; set; }
        public Int64 SumTransCtrs { get; set; }
        public string?  LinkHistoryTranCTRs { get; set; }
        public string?  LinkHistoryCustCTRs { get; set; }
        public Int64 NoTran { get; set; }
        public Int64 No { get; set; }
        public Int64 NoofDay { get; set; }
        public string?  Receiver_Address { get; set; }
        public string?  REFUNDREASON { get; set; }
        public string?  REFUNDBY { get; set; }
        public DateTime? REFUNDDATE { get; set; }
        public string?  ReasonReview { get; set; }
        public string?  ReasonForPending { get; set; }
        public string?  ReasonForPendingEnter { get; set; }
        public bool CheckPending { get; set; } = false;
        public string?  FeedBack { get; set; }
        public string?  FeedBackEnter { get; set; }
        public bool CheckSARs { get; set; } = false;
        public bool CheckCTRs { get; set; } = false;
        public string?  ACTION_TYPE { get; set; }
        public string?  ActionBy { get; set; }
        public DateTime ActionDate { get; set; }
        public Int64 NoofTranRefund { get; set; }
        public string?  LinkAgent { get; set; }
        public string?  LinkState { get; set; }
        public double TOTAL_AMOUNT { get; set; }
        public double TOTAL_FEE { get; set; }
        public double TOTAL_AGENTFEE { get; set; }
        public double TOTAL_OTHERFEE { get; set; }
        public double TOTAL_TAXFEE { get; set; }
        public double TOTAL_DISCOUNT_FEE { get; set; }
        public Int64 NumberRecord { get; set; }
        public double TOTAL_AMOUNTREFUND { get; set; }
        public double TOTAL_OTHERFEEREFUND { get; set; }
        public double TOTAL_TAXFEEFUND { get; set; }
        public double TOTAL_FEEREFUND { get; set; }
        public double TOTAL_DISCOUNT_FEEREFUND { get; set; }
        public double TOTALREFUND { get; set; }
        public Int64 NumberRecordREFUND { get; set; }
        public string?  Description { get; set; }
        public DateTime Date { get; set; }
        public string?  SenderFullName { get; set; }
        public string?  SenderPhone { get; set; }
        public string?  Receivername { get; set; }
        public string?  ReceiverID { get; set; }
        public string?  ReceiverPhone { get; set; }
        public string?  Note { get; set; }
        public string?  HoldingBy { get; set; }
        public DateTime? HoldingDate { get; set; }
        public string?  ReasonwithSenderID { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  Idology_ID { get; set; }
        public string?  B_ZIPCODE { get; set; }
        public bool FileDownload { get; set; } = false;
        public bool FileDownloadRecID { get; set; } = false;
        
        public string?  OfacReceiver { get; set; } = "";
        public string?  OfacSender { get; set; } = "";
        public string?  OfacSenderBH { get; set; } = "";
        public string?  FundDateConvent { get; set; } = "";
        public string?  EDITBY { get; set; } = "";
        public DateTime? EDITDATE { get; set; }
        public string?  UpdatePendingBy { get; set; } = "";
        public DateTime? UpdatePendingDate { get; set; }
        public string?  UpdateFeedbackBy { get; set; } = "";
        public DateTime? UpdateFeedbackDate { get; set; }
        public string?  ApproveFeedbackBy { get; set; } = "";
        public DateTime? ApproveFeedbackDate { get; set; }
        public string?  StatusFeedback { get; set; } = "";
        public string?  AG_COMMENT { get; set; } = "";
        //public string?  Idology_SSN { get; set; } = "";
        //public string?  Idology_ID { get; set; } = "";

    }
    public class ReportDetailKYC
    {
        public Int64? RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  REF_NO { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        public string?  TRANS_REF { get; set; }

        public DateTime TRANS_DATENEW { get; set; }
        //public DateTime Case_No_Date { get; set; }

        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  S_PHONE { get; set; }

        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
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
        public double FEE { get; set; }
        public double payment_servicefee { get; set; }
        public string?  B_PAY_BY { get; set; }
        public DateTime DATE_APPLY_EX_RATE { get; set; }
        public string?  PaymentCurrency { get; set; }
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
    
        public string?  S_FULLADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public double OTHERFEE { get; set; }
        public double TAXFEE { get; set; }
        public string?  typetran { get; set; }
        public string?  DOB { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }

        public string?  ID_TYPE { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string?  STATE_ISSUENAME { get; set; }
        public string?  ISSUE_DATE { get; set; }
        public DateTime? IssueDateBK { get; set; }

      
        public double AGENT_COMM { get; set; }
        public string?  PASSPORT_NO { get; set; }
      
        public string?  ReasonforHolding { get; set; }
        public string? KYC_REASON { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  ReasonHolding { get; set; }
        public string?  ReasonforReleaseKYC { get; set; }
        public int STATUS_ID { get; set; }
      
        public string?  EMAIL { get; set; }
        public string?  ReleaseHoldingReason { get; set; }
        public string?  ReleaseHoldingBy { get; set; }
        public DateTime? ReleaseHolding { get; set; }
      
        public string?  TRANTYPENAME { get; set; }
        public string?  Type { get; set; }
      
        public string?  B_CITY { get; set; }
        public string?  linkTransID { get; set; }
        public string?  TransIDDerypt { get; set; }
       
        public double TOTAL { get; set; }
      
        public Int64 STT { get; set; }
      
        public string?  Receiver_Address { get; set; }
       
        public string?  ReasonReview { get; set; }
        public string?  ReasonForPending { get; set; }
        public string?  ReasonForPendingEnter { get; set; }
        public bool CheckPending { get; set; } = false;
        public string?  FeedBack { get; set; }
        public string?  FeedBackEnter { get; set; }
      
        public string?  ACTION_TYPE { get; set; }
        public string?  ActionBy { get; set; }
     
        public string?  LinkAgent { get; set; }
        public string?  LinkState { get; set; }
        public double TOTAL_AMOUNT { get; set; }
        public double TOTAL_FEE { get; set; }
        public double TOTAL_AGENTFEE { get; set; }
        public double TOTAL_OTHERFEE { get; set; }
        public double TOTAL_TAXFEE { get; set; }
        public double TOTAL_DISCOUNT_FEE { get; set; }
        public Int64 NumberRecord { get; set; }
        public double TOTAL_AMOUNTREFUND { get; set; }
        public double TOTAL_OTHERFEEREFUND { get; set; }
        public double TOTAL_TAXFEEFUND { get; set; }
        public double TOTAL_FEEREFUND { get; set; }
        public double TOTAL_DISCOUNT_FEEREFUND { get; set; }
        public double TOTALREFUND { get; set; }
        public Int64 NumberRecordREFUND { get; set; }
        public string?  Description { get; set; }
        public DateTime Date { get; set; }
        public string?  SenderFullName { get; set; }
        public string?  SenderPhone { get; set; }
        public string?  Receivername { get; set; }
        public string?  ReceiverID { get; set; }
        public string?  ReceiverPhone { get; set; }
        public string?  Note { get; set; }
        public string?  HoldingBy { get; set; }
        public DateTime? HoldingDate { get; set; }
        public string?  ReasonwithSenderID { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  B_ZIPCODE { get; set; }
        public string?  Idology_ID { get; set; }
        public string?  ActionType { get; set; }
        public string?  Condition { get; set; } = "";



    }

    public class ReportSummary
    {
        public string?  CUST_ID { get; set; }
        public string?  TranType { get; set; }
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
        public double TOTAL_AMT_USD { get; set; }
        
    }
    public class ReportTranSummary
    {
        public Int64 NoofTran { get; set; }
    }
    public class ReportTranAgentSummary
    {
        public Int64 RowNumber { get; set; }
        public string?  Agent_ID { get; set; }
        public string?  Agent_Name { get; set; }
        public Int64 NoofTran { get; set; }
        public string?  LinkAgent { get; set; }
    }
    public class ReportTranStateSummary
    {
        public Int64 RowNumber { get; set; }
        public string?  State_ID { get; set; }
        public string?  StateName { get; set; }
        public Int64 NoofTran { get; set; }
        public string?  LinkState { get; set; }
    }
    public class ContentGeneralResponse
    {
        public List<ReportDetail> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }
        public List<ReportTranSummary> ReportVerifyRecordCount { get; set; }
    }
    public class ContentSummaryResponse
    {
        public List<ReportTranAgentSummary> ReportDetail { get; set; }
        public List<ReportTranStateSummary> ReportDetail1 { get; set; }
        public List<ReportTranSummary> ReportSummary { get; set; }
    }
    public class GeneralSummaryCTRsResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentSummaryResponse Content { get; set; }
    }
    public class GeneralReportResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentGeneralResponse Content { get; set; }
    }
    
    public class SendPhoneResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentPhoneResponse Content { get; set; }
    }
    public class ContentPhoneResponse
    {
        public List<ReportPhoneDetail> ReportDetail { get; set; }
    }
    public class ReportPhoneDetail
    {
        public Int64? RowNumber { get; set; }
        public Int64? ID { get; set; }
        public String Phone { get; set; }
    }
        public class ContentTransactionResponse
    {
        public List<ReportDetail> ReportDetail { get; set; }
    }
    public class GeneralTransactionDetailResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentTransactionResponse Content { get; set; }
    }

    public class ContentViewKYCList
    {
        public List<ReportDetailKYC> ViewKYCLists { get; set; }
    }
    public class ViewKYCListResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentViewKYCList Content { get; set; }
    }
    public class BillingReportResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentBillingReportResponse Content { get; set; }
    }

    public class AccountBalanceSummaryResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentAccountBalanceSummaryResponse Content { get; set; }
    }
    public class ContentAccountBalanceSummaryResponse
    {
        public List<AccountBalanceSummaryMocel> ReportDetail { get; set; }
     

    }
    public class ContentBillingReportResponse
    {
        public List<ReportDetail> ReportDetail { get; set; }
        public List<ReportBillingSummary> ReportSummary { get; set; }
        public List<ReportDetail> ReportDetail2 { get; set; }
        public List<ReportDetail> ReportDetail3 { get; set; }

    }
    public class ReportBillingSummary
    {
        public string?  TransDate { get; set; }
        public string?  TranType { get; set; }
        public Int64? Trans_No { get; set; }
        public double? TOTAL_AMOUNT { get; set; }
        public double? TOTAL_FEE { get; set; }
        public double? OTHER_FEE { get; set; }
        public double? TOTAL_DISCOUNT_FEE { get; set; }
        public double? TOTAL_HDFTOTAL_HDFEEEE { get; set; }
        public double? TOTAL_TAX { get; set; }
        public double? GRANT_TOTAL { get; set; }
        public double? AAGENT_FEE { get; set; }
        public double? TOTALAGENT_COMM { get; set; }
        public double? Total_Due { get; set; }

    }
    public class aggregationModel
    {
        public string? LOAI { get; set; }
        public string? OptionDate { get; set; }
        public string? TYPE { get; set; }
        public double? Amount { get; set; }
        public double? KYCFolder { get; set; }
        public double? MaxAmount { get; set; }
        public double? SSNAmount { get; set; }
        public double? TOTAL_AMT_USD { get; set; }
    }
    public class CheckIdologyResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public object Content { get; set; }
    }
    public class aggregationResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public aggregationContentResponse Content { get; set; }
    }
    public class aggregationContentResponse
    {
        public List<aggregationModel> aggregationList { get; set; }

    }
    public class aggregationListResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public aggregationContentListResponse Content { get; set; }
    }
    public class aggregationContentListResponse
    {
        public List<ReportDetail> SenderAddressList { get; set; }
        public List<ReportDetail> SenderPhoneList { get; set; }
        public List<ReportDetail> ReceiverLocalNameList { get; set; }
        public List<ReportDetail> ReceiverAddressList { get; set; }
        public List<ReportDetail> ReceiverPhoneList { get; set; }
        public List<ReportDetail> ReceiverBankAccountList { get; set; }
        public List<ReportDetail> ReceiverIDList { get; set; }
        public List<ReportDetail> SenderNameList { get; set; }
        public List<ReportDetail> SenderCustIDList { get; set; }

    }
    public class AddnewTransactionResponse
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public TranResponse Content { get; set; }
    }
    public class TranResponse
    {
        public string?  TransID { get; set; }
        public string?  CustID { get; set; }
        public string?  BCustID { get; set; }
        public string?  fc { get; set; }
        public string?  tc { get; set; }
    }

    public class duplicateResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public duplicateContentResponse Content { get; set; }
    }
    public class CreditLineAllResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public object Content { get; set; }
    }
    public class duplicateAllResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public object Content { get; set; }
    }
    public class duplicateContentResponse
    {
        public List<dupTransaction> duplicateList { get; set; }

    }
    public class dupTransaction
    {
             public string?  AGENT_ID { get; set; }
        public string?  TRANS_ID { get; set; }
        public DateTime TRANS_DATE { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  S_ADDRESS { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIPCODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  S_PHONE { get; set; }

        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
        public string?  OCCUPATION { get; set; }
        public string?  B_CUST_ID { get; set; }
        public string?  LocalName { get; set; }
        public string?  B_LASTNAME { get; set; }
        public string?  B_MIDDLENAME { get; set; }
        public string?  B_FIRSTNAME { get; set; }
        public string?  B_FULLNAME { get; set; }
        public string?  COUNTRY_ISSUE { get; set; }
        public string?  STATUS { get; set; }
        public string?  B_ADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        
        public string?  B_CITY { get; set; }
        public string?  PROVINCE_ID { get; set; }
        public string?  B_PHONE1 { get; set; }
        public string?  B_COUNTRY { get; set; }
        public string?  B_PHONE2 { get; set; }
        public string?  ACCOUNT_NO { get; set; }
        public string?  B_COMMENT { get; set; }
        public string?  PASSCODE { get; set; }
        public string?  USER_ID { get; set; }
        public double AMOUNT { get; set; }
        public double TOTAL_AMT_USD { get; set; }


    }
    public class ReportRefundDetail
    {
        public List<IBrowserFile>? loadedFiles { get; set; } = new List<IBrowserFile>();
        public Int64? NoofTran { get; set; }
        public Int64? RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  REF_NO { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        public string?  TRANS_REF { get; set; }
        public string?  IdProcessPayment { get; set; }

        public DateTime TRANS_DATENEW { get; set; }
        //public DateTime Case_No_Date { get; set; }

        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  S_PHONE { get; set; }

        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
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
        public double FEE { get; set; }
        public double payment_servicefee { get; set; }
        public string?  B_PAY_BY { get; set; }
        public DateTime DATE_APPLY_EX_RATE { get; set; }
        public string?  PaymentCurrency { get; set; }
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
        public bool AGG { get; set; }
        public bool IS_BH { get; set; }

        public bool REFUND { get; set; }
        public bool CANCEL { get; set; }
        public string?  CANCELBY { get; set; }
        public DateTime? CANCELDATE { get; set; }
        public string?  CountryName { get; set; }
        public string?  Approved { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public double OTHERFEE { get; set; }
        public double TAXFEE { get; set; }
        public string?  typetran { get; set; }
        public string?  DOB { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }

        public string?  ID_TYPE { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string?  ISSUE_DATE { get; set; }
        public DateTime? IssueDateBK { get; set; }

        public int OFAC_CHK { get; set; }
        public bool RequestRefund { get; set; }
        public bool ReviewRefund { get; set; }
        public bool OFAC { get; set; }
        public bool ISKYC { get; set; }
        public DateTime? REVIEWREFUNDDATE { get; set; }
        public DateTime? PaidDate { get; set; }
        public string?  REVIEWREFUNDBY { get; set; }
        public double AGENT_COMM { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  ReasonforCancel { get; set; }
        public string?  ReasonforRefund { get; set; }
        public string?  ReasonforReviewRefund { get; set; }
        public string?  ReasonforReleaseOfac { get; set; }
        public string?  ReasonforHolding { get; set; }
        public string? KYC_REASON { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  ReasonHolding { get; set; }
        public string?  ReasonforReleaseKYC { get; set; }
        public int STATUS_ID { get; set; }
        public string?  DownloadReceipt { get; set; }
        public string?  DownloadBSA { get; set; }
        public string?  DownloadBeHafl { get; set; }
        public string?  ReasonforUpdate { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ReleaseHoldingReason { get; set; }
        public string?  ReleaseHoldingBy { get; set; }
        public DateTime? ReleaseHolding { get; set; }
        public string?  Verify { get; set; }
        public string?  VerifyBy { get; set; }
        public DateTime? VerifyDate { get; set; }
        public bool ProcessApprove { get; set; }
        public string?  TRANTYPENAME { get; set; }
        public string?  Type { get; set; }
        public DateTime? CANCEL_DATE { get; set; }
        public string?  FIRSTNAME_BH { get; set; }
        public string?  MIDDLENAME_BH { get; set; }
        public string?  LASTNAME_BH { get; set; }
        public string?  FULLNAMEBH { get; set; }

        public string?  ADDRESS_BH { get; set; }
        public string?  CITY_BH { get; set; }
        public string?  STATE_BH { get; set; }
        public string?  ZIPCODE_BH { get; set; }
        public string?  PHONE_BH { get; set; }
        public string?  B_RECIPIENT2 { get; set; }
        public string?  B_CITY { get; set; }
        public string?  linkTransID { get; set; }
        public string?  TransIDDerypt { get; set; }
        public string?  bgcolor { get; set; }
        public string?  bgcolors { get; set; }
        public string?  Case_No { get; set; }
        public DateTime Case_No_Date { get; set; }
        public string?  Case_No_DateNew { get; set; }
        public string?  Sender_Full_Name { get; set; }
        public string?  Sender_Address { get; set; }
        public string?  Phone_No { get; set; }
        public string?  Phone { get; set; }

        public string?  SS { get; set; }
        public string?  Receiver_Full_Name { get; set; }
        public string?  Receiver_Phone { get; set; }
        public string?  BankAccount { get; set; }

        public double TOTAL { get; set; }
        public DateTime Case_SarsDate { get; set; }
        public DateTime Case_CtrsDate { get; set; }
        public string?  Comment_Sars { get; set; }
        public string?  Comment_Ctrs { get; set; }
        public string?  FillingName { get; set; }
        public Int64 STT { get; set; }
        public string?  CreateBy { get; set; }
        public bool CheckSumSars { get; set; }
        public string?  FileSarsName { get; set; }
        public string?  FileCTRsName { get; set; }
        public Int64 SumCustSars { get; set; }
        public Int64 SumTransSars { get; set; }
        public string?  LinkHistoryTranSARs { get; set; }
        public string?  LinkHistoryCustSARs { get; set; }
        public Int64 SumCustCtrs { get; set; }
        public Int64 SumTransCtrs { get; set; }
        public string?  LinkHistoryTranCTRs { get; set; }
        public string?  LinkHistoryCustCTRs { get; set; }
        public Int64 NoTran { get; set; }
        public Int64 No { get; set; }
        public Int64 NoofDay { get; set; }
        public string?  Receiver_Address { get; set; }
        public string?  REFUNDREASON { get; set; }
        public string?  REFUNDBY { get; set; }
        public DateTime? REFUNDDATE { get; set; }
        public string?  ReasonReview { get; set; }
        public string?  ReasonForPending { get; set; }
        public string?  ReasonForPendingEnter { get; set; }
        public bool CheckPending { get; set; } = false;
        public string?  FeedBack { get; set; }
        public string?  FeedBackEnter { get; set; }
        public bool CheckSARs { get; set; } = false;
        public bool CheckCTRs { get; set; } = false;
        public string?  ACTION_TYPE { get; set; }
        public string?  ActionBy { get; set; }
        public DateTime ActionDate { get; set; }
        public Int64 NoofTranRefund { get; set; }
        public string?  LinkAgent { get; set; }
        public string?  LinkState { get; set; }
        public double TOTAL_AMOUNT { get; set; }
        public double TOTAL_FEE { get; set; }
        public double TOTAL_AGENTFEE { get; set; }
        public double TOTAL_OTHERFEE { get; set; }
        public double TOTAL_TAXFEE { get; set; }
        public double TOTAL_DISCOUNT_FEE { get; set; }
        public Int64 NumberRecord { get; set; }
        public double TOTAL_AMOUNTREFUND { get; set; }
        public double TOTAL_OTHERFEEREFUND { get; set; }
        public double TOTAL_TAXFEEFUND { get; set; }
        public double TOTAL_FEEREFUND { get; set; }
        public double TOTAL_DISCOUNT_FEEREFUND { get; set; }
        public double TOTALREFUND { get; set; }
        public Int64 NumberRecordREFUND { get; set; }
        public string?  Description { get; set; }
        public DateTime Date { get; set; }
        public string?  SenderFullName { get; set; }
        public string?  SenderPhone { get; set; }
        public string?  Receivername { get; set; }
        public string?  ReceiverID { get; set; }
        public string?  ReceiverPhone { get; set; }
        public string?  Note { get; set; }
        public string?  HoldingBy { get; set; }
        public DateTime? HoldingDate { get; set; }
        public string?  ReasonwithSenderID { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  Idology_ID { get; set; }
        public string?  B_ZIPCODE { get; set; }
        public bool FileDownload { get; set; } = false;
        public bool FileDownloadRecID { get; set; } = false;

        public string?  OfacReceiver { get; set; } = "";
        public string?  OfacSender { get; set; } = "";
        public string?  OfacSenderBH { get; set; } = "";
        public string?  FundDateConvent { get; set; } = "";
        public string?  EDITBY { get; set; } = "";
        public DateTime? EDITDATE { get; set; }
        public string?  UpdatePendingBy { get; set; } = "";
        public DateTime? UpdatePendingDate { get; set; }
        public string?  UpdateFeedbackBy { get; set; } = "";
        public DateTime? UpdateFeedbackDate { get; set; }
        public string?  ApproveFeedbackBy { get; set; } = "";
        public DateTime? ApproveFeedbackDate { get; set; }
        public string?  StatusFeedback { get; set; } = "";
        public string?  AG_COMMENT { get; set; } = "";

    }
    public class GeneralReportRefundResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentGeneralRefundResponse Content { get; set; }
    }
    public class ContentGeneralRefundResponse
    {
        public List<ReportRefundDetail> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }
        public List<ReportTranSummary> ReportVerifyRecordCount { get; set; }
    }

}
