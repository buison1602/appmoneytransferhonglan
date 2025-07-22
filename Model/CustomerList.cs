using System.Collections.Generic;
using System;
namespace AppMoneyTransferRS.Models
{
    public class CustomerAddressCheck
    {
        public string?  CUST_ID { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  FULLADDRESS { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  StatusName { get; set; }
        public string?  FULLRESPONSE { get; set; }
    }
    public class CustomerTranList
    {
        public string?  TRANS_ID { get; set; }
    }
    public class CustomerList
    {
        public string?  TRANS_ID { get; set; }
        public DateTime? TRANS_DATE { get; set; }
        public string?  UserID { get; set; }
        public string?  UserName { get; set; }
        public int RowNumber { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ID_TYPE { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string? EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }
        public string?  SSN { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  FULLADDRESS { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  StatusName { get; set; }
        public string?  fullnameall { get; set; }
        public string?  Occupation { get; set; }
        public string? DOB { get; set; }
        public string? DOB_BK { get; set; }
        public DateTime? DOB_BK1 { get; set; }
        public string? ISSUE_DATE { get; set; }
        public DateTime? IssueDateBK { get; set; }
        public string?  IssueDate { get; set; }
        public string?  COUNTRY_ISSUE { get; set; }
        public string?  ReasonforBlock { get; set; }
        public string?  ReasonforUpdate { get; set; }
        public string?  LinkHistory { get; set; }
        public string?  History { get; set; }
        public string?  LinkProfile { get; set; }
        public string?  Profile { get; set; }
        public string?  HistoryTable { get; set; }
        public int? StatusID { get; set; }
        public int? STATUS { get; set; }
        public string?  CompanyNote { get; set; }
        public string?  ReasonHolding { get; set; }
        public string?  Comment { get; set; }
        public string?  ActionType { get; set; }
        public string?  ActionName { get; set; }
        public string?  ReleaseReasonHolding { get; set; }
        public string?  CustType { get; set; }
        public string?  ReasonforReleaseOfac { get; set; }
        public string?  OccupationM { get; set; }
        public string?  OccupationD { get; set; }
        public double? TOTAL_AMT_USD { get; set; }
        public string?  Idology_SSN { get; set; }
        public string?  Idology_ID { get; set; }
        public string?  KYC_REASON { get; set; }
        public string?  TypeofUpdate { get; set; }

    }
    public class CustomerListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CustomerList[] Content { get; set; }
    }
}