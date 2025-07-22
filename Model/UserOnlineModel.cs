using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
      
    public class UserOnlineListModel
    {
        
            public Int64 Id { get; set; }
        public Int64 RowNumber { get; set; }
        public string?  Email { get; set; }
        public string?  Username { get; set; }
        public string?  FullName { get; set; }
        public string?  StatusId { get; set; }
        public string?  StatusAccount { get; set; }
        public string?  Comment { get; set; }
        public string?  PhoneNumber { get; set; }

    }
    public class UserOnlineListModelList
    {
        public List<UserOnlineListModel> ReportDetail { get; set; }
        public List<ReportSummary> ReportSummary { get; set; }
        public List<ReportTranSummary> ReportRecordCount { get; set; }
    }
    public class UserOnlineListModelResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public UserOnlineListModelList Content { get; set; }
    }
}