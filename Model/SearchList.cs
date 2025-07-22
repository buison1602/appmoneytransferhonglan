using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class SearchList
    {
        public string?  SearchID { get; set; }
        public string?  SearchName { get; set; }
        public int ID { get; set; }
    }
    public class SearchListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public SearchList[] Content { get; set; }
    }
}