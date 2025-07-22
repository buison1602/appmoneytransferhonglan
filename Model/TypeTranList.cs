using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class TypeTranList
    {
        public string?  TypeID { get; set; }
        public string?  TypeName { get; set; }
    }
    public class TypeTranListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public TypeTranList[] Content { get; set; }
    }
}