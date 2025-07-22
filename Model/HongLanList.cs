using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
      
    public class HongLanListModel
    {
        
        public Int64 RowNumber { get; set; }
        public string?  POS_NAME { get; set; }
        public string?  CustID { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  DOB { get; set; }
        public string?  DRIVER_ID { get; set; }
        public string?  SSN { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  PHONE2 { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public Double Amount { get; set; }
        public string?  Note { get; set; }
        public string?  Pos_Type { get; set; }
        public bool StatusID { get; set; }
        public Int64 ID { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public string?  CreatedBy { get; set; }
        public DateTime EditedDate { get; set; }
        public string?  EditedBy { get; set; }

    }
    public class HongLanListModelList
    {
        public HongLanListModel[] HongLanList{ get; set; }
    }
    public class HongLanListModelResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public HongLanListModelList Content { get; set; }
    }
}