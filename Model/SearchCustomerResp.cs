using System.Collections.Generic;
using System;
namespace AppMoneyTransferRS.Models
{
    
    public class SearchCustomerResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public SearchCustomerRespContent Content { get; set; }
    }
    public class ReportRecordCountContent
    {
        public Int64 NoofTran { get; set; }
    
    }
    
    public class SearchCustomerRespContent
    {    
        public List<CustomerList> CustomerList { get; set; } = new List<CustomerList>();
        public List<CustomerComboList> CustomerComboList { get; set; }
        public List<ReportRecordCountContent> ReportRecordCount { get; set; }

    }
  

}
