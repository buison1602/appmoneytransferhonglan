using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ExceptionModel
    {
        public string?  Exception_string { get; set; }
        public string?  Ex_type { get; set; }
        
    }
    public class ExceptionListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ExceptionModel[] Content { get; set; }
    }
}