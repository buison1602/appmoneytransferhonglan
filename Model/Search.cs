using System;

namespace AppMoneyTransferRS.Models
{
    public class Search
    {
        public String SearchID { get; set; }
        
        public String SearchName { get; set; }
    }

    public class SearchInput
    {
        public String UserID { get; set; }
    }

    public class SearchResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public Search[] Content { get; set; }
    }
}
