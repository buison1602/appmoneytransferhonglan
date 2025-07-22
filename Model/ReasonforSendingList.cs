using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ReasonforSendingList
    {
        
        public int NOTE_ID { get; set; }
        public string?  NOTE_SENDING { get; set; }
    }
    public class ReasonforSendingListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ReasonforSendingList[] Content { get; set; }
    }
}