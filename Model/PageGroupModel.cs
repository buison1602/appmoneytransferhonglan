using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class PageGroupList
    {
        
            public Int64 RowNumber { get; set; }
        public int GroupID { get; set; }
        public string?  GroupName { get; set; }
        public string?  PageName { get; set; }
        public string?  SubjectPage { get; set; }
       
        public bool chkView { get; set; }
        public bool chkLoad { get; set; }
        public Int64 id { get; set; }

    }
    public class PageGroupModelList
    {
        public PageGroupList[] PageGroupList { get; set; }
    }
    public class PageGroupListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public PageGroupModelList Content { get; set; }
    }
}