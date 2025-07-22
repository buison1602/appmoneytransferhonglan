using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class RecipientComboList
    {       
       
        public string?  B_CUST_ID { get; set; }
        public string?  B_FULLNAME { get; set; }
    }
    public class RecipientComboRespContent
    {
        public List<RecipientComboList> RecipientComboList { get; set; }

    }
    public class RecipientComboListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public RecipientComboRespContent Content { get; set; }
    }
}