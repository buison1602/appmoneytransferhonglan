using System;

namespace AppMoneyTransferRS.Models
{
    public class TypeofBlackList
    {
        public String TypeID { get; set; }
        
        public String TypeName { get; set; }
        public String ErrorMessage { get; set; }
    }

  

    public class TypeofBlacklistResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public TypeofBlackList[] Content { get; set; }
    }
}
