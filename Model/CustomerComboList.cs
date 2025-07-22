using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class CustomerComboList
    {       
       
        public string?  CustID { get; set; }
        public string?  FullName { get; set; }
    }
    public class CustomerComboListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CustomerComboList[] Content { get; set; }
    }
}