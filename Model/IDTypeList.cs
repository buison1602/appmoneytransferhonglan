using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class IDTypeList
    {
        public string?  IDType  { get; set; }
        public string?  IDName { get; set; }
    }
    public class IDTypeListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public IDTypeList[] Content { get; set; }
    }
}