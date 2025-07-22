using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class PageNameList
    {
        public int RowNumber { get; set; }
        public string?  PageName { get; set; }
        public string?  SubjectPage { get; set; }
        
    }
    public class PageNameModelList
    {
        public PageNameList[] PageNameList { get; set; }
    }
    public class PagePageNameListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public PageNameModelList Content { get; set; }
    }
}