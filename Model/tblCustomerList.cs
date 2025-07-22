using System.Collections.Generic;
using System;
namespace AppMoneyTransferRS.Models
{
    public class tblCustomerList
    {
        public string?  TRANS_ID { get; set; }
        public DateTime TRANS_DATE { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string? DOB { get; set; }
        public DateTime? DOBBK { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ID_TYPE { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string? EXPIRATION { get; set; }
        public DateTime? EXPIRATIONBK { get; set; }
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
        public string?  COMMENT { get; set; }
        public int KYC { get; set; }
        public int KYC_CNT { get; set; }
        public int? STATUS { get; set; }
        public int? IS_COMPLETE { get; set; }
        public int? IS_PROMO { get; set; }
        public string?  PROMO_TYPE { get; set; }
        public DateTime? CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public string?  EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string?  FILEIDNAME { get; set; }
        public byte[] FILEIDIMAGE { get; set; }
        public string?  FILESOURCENAME { get; set; }
        public byte[] FILESOURCEIMAGE { get; set; }
        public string? ISSUE_DATE { get; set; }
        public DateTime? ISSUE_DATEBK { get; set; }
        
        public string?  TYPE_SOURCEOFFUND { get; set; }
        public string?  SOURCEOFFUND { get; set; }
        public string?  BANKCODE { get; set; }
        public string?  BANKNAME { get; set; }
        public string?  BANKADDRESS { get; set; }
        public string?  ACCOUNT_NO { get; set; }
        public string?  SWIFTCODE { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  ReasonforUpdate { get; set; }
        public string?  ReasonforBlock { get; set; }
        public string?  CompanyNote { get; set; }      
        public string?  ReasonHolding { get; set; }
        public string?  Comment { get; set; }
        public int? StatusID { get; set; }
    }
    public class tblCustomerListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CustomerList[] Content { get; set; }
        //public CustomerAddressCheck[] CustomerAddressCheck { get; set; }
    }
    public class CustomerAddressResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

       
        public CustomerAddressCheck[] Content { get; set; }
    }
}