using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
      
    public class UserListModel
    {
        
        public Int64 RowNumber { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  OWNER_NAME { get; set; }
        public string?  LEGAL_NAME { get; set; }
        public string?  DBA { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE { get; set; }
        public string?  EMAIL { get; set; }
        public string?  FAX { get; set; }
        public string?  LICENSE_NO { get; set; }
        public string?  COMMENT { get; set; }
        public float? CREDIT_LINE { get; set; }
        public string? LAST_UPDATE { get; set; }
        public string?  UPDATE_BY { get; set; }
        public string?  COMMENT_UPDATE { get; set; }
        public string? LOGO { get; set; }
        public string?  DATE_CREATE { get; set; }
        public string?  DATE_STOP { get; set; }
        public string?  EIN { get; set; }
        public int? TYPE_AGENT { get; set; }
        public string?  BUSINESS_TYPE { get; set; }
        public string?  BUSINESS_STRUCT { get; set; }
        public string?  SENDING_COUNTRY { get; set; }
        public string? TO_COUNTRY { get; set; }
        public string?  USERID { get; set; }
        public string? TOCOUNTRY { get; set; }
        public string? FROMCOUNTRY { get; set; }
        public string? FROMCURRENCY { get; set; }
        public string? LANGUAGE { get; set; }
        public string? TOCURRENCY { get; set; }
        public string? LANGUAGENAME { get; set; }
        public string?  ALLOW_IP { get; set; }
        public string?  LEVEL_ACCESS { get; set; }
        public string?  PWD { get; set; }
        public string?  USERNAME { get; set; }
        public string? TYPE_USER { get; set; }
        public string?  TYPE_ACCESS { get; set; }
        public bool ShowAll { get; set; }
        public string?  Master { get; set; }
        public string?  GroupID { get; set; }
        public string?  STATUS { get; set; }
        public string?  TIME_TRY { get; set; }
        public string?  LAST_LOGIN { get; set; }
        public string?  LAST_LOGOUT { get; set; }
        public string?  STATUS_AGENT { get; set; }
        public string?  PAYMENTAGENT { get; set; }
        public string?  LEVEL_DESC { get; set; }
        public string?  StatusName { get; set; }
        public string?  ChangeDate { get; set; }       
        public bool chkCheckOfac { get; set; }
        public string?  UserGuid { get; set; }
        public string?  PASSWORD { get; set; }
        public string?  RE_PASSWORD { get; set; }
        public string?  UserNameNew { get; set; }
        public byte[]? FileSign { get; set; }
        public string?  FileImage { get; set; }
        public string?  LAST_LOGINConvert { get; set; }
        public string?  LAST_LOGOUTConvert { get; set; }
        public int? SetTimeOut { get; set; } = 0;
        public string?  ChangeDateConvert { get; set; }
        

    }
    public class UserListModelList
    {
        public UserListModel[] UserList { get; set; }
    }
    public class UserListModelResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public UserListModelList Content { get; set; }
    }
}