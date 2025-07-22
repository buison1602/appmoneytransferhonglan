using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class B_CustomerList
    {
        
             public Int64 RowNumber { get; set; }
        public string?  B_CUST_ID { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  CN_LASTNAME { get; set; }
        public string?  CN_FIRSTNAME { get; set; }
        public string?  CN_MIDDLENAME { get; set; }
        public string?  CORRECT_CN_NAME { get; set; }
        public string?  EMAIL { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  FULLADDRESS { get; set; }
        public string?  ADDRESS2 { get; set; }
        public string?  CN_ADDRESS { get; set; }
        public string?  CORRECT_CN_ADDRESS { get; set; }
        public string?  GENDER { get; set; }
        public string?  DOB { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  CN_CITY { get; set; }
        public string?  DISTRICT { get; set; }
        public string?  CN_DISTRICT { get; set; }
        public string?  PROVINCE_ID { get; set; }
        public string?  CN_PROVINCE { get; set; }
        public string?  ISO_CODE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  PHONE { get; set; }
        public string?  FAX { get; set; }
        public string?  OTHER_B { get; set; }
        public string?  COMMENT { get; set; }
        public int? STATUS { get; set; }
        public DateTime? CreateDate { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string?  EditBy { get; set; }
        public string?  LOCALNAME { get; set; }
        public string?  BANKCODE { get; set; }
        public string?  BANKNAME { get; set; }
        public string?  BANKADDRESS { get; set; }
        public string?  ACCOUNT_NO { get; set; }
        public string?  SWIFTCODE { get; set; }
        public string?  ID_TYPE { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  PASSPORT_NO { get; set; }
        public string?  STATE_ISSUE { get; set; }
        public string?  EXPIRATION { get; set; }
        public string?  SSN { get; set; }
        public string?  DOB_BK { get; set; }
        public string?  DRIVER_ID_BK { get; set; }
        public string?  SSN_BK { get; set; }
        public string?  Issue_Date { get; set; }
        public string?  Occupation { get; set; }
        public string?  ReasonforBlock { get; set; }
        public string?  LinkHistory { get; set; }
        public string?  History { get; set; }
        public string?  Profile { get; set; }
        public string?  LinkProfile { get; set; }
        public string?  StatusName { get; set; }
        public string?  ReasonwithSenderID { get; set; }
        public string?  RelationwithSenderNote { get; set; }
        public string?  IsAttachFile { get; set; } = "0";

    }
    public class B_CustomerListNew
    {
        public List<B_CustomerList> CustomerList { get; set; }
        public List<ReportRecordCountContent> ReportRecordCount { get; set; }
    }
    public class B_CustomerListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public B_CustomerListNew Content { get; set; }
    }
    public class B_CustomerListContent
    {
        public List<B_CustomerList> RecipientProfile { get; set; }
    }
    public class B_CustomerProfileListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public B_CustomerListContent Content { get; set; }
    }
}