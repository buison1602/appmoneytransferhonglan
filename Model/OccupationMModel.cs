using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class OccupationMModel
    {
        public string?  OccupationM { get; set; }
        public int ID { get; set; }
    }
    public class OccupationMResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public OccupationMModel[] Content { get; set; }
    }
}