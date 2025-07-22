using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class RelationwithSenderList
    {
        public string?  Relation_ID { get; set; }
        public string?  Relation_Name { get; set; }
    }
    public class RelationwithSenderListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public RelationwithSenderList[] Content { get; set; }
    }
}