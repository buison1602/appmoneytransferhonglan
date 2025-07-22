using System.Collections.Generic;
using System;
namespace AppMoneyTransferRS.Models
{
    public class HistoryCustomerSendTran
    {
        public int RowNumber { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  AGENT_ID { get; set; }
        public DateTime TRANS_DATE { get; set; }
        public string?  R_FULLADDRESS { get; set; }
        public string?  B_FULLNAME { get; set; }
        public string?  B_PHONE1 { get; set; }
        public int IS_BH { get; set; }
        public double AMOUNT { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE1 { get; set; }
        public string?  COUNTRY_ISSUE { get; set; }
        public int StatusRec { get; set; }
        public string?  StatusNameBlock { get; set; }
        public string?  StatusName { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  B_CUST_ID { get; set; }
        public string?  S_FULLADDRESS { get; set; }
        public string?  B_COUNTRY { get; set; }
        public string?  B_PHONE11 { get; set; }
        public string?  ReOrder { get; set; }
        public string?  ComboSender { get; set; }
        public string?  ButtonSender { get; set; }
        public bool DisableButton { get; set; } = false;
        public string?  NewLink { get; set; }
        public string?  CustType { get; set; }
        public bool DisableAmount { get; set; } = false;
        public bool DisableEdit { get; set; }  = true;
        public string?  linkTransID { get; set; }
        public string?  CN_TRANS_NO { get; set; }
        
    }
    public class HistoryCustomerRespContent
    {
        public List<HistoryCustomerSendTran> HistoryCustomerSend { get; set; }       
        public List<ReportTranSummary> ReportSummary { get; set; }
    }


    public class HistoryCustomerSendResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }
        public HistoryCustomerRespContent Content { get; set; }
    }
}