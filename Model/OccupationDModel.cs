using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class OccupationDModel
    {
        public string?  OccupationD { get; set; }
        public string?  OccupationM { get; set; }
    }
    public class OccupationDResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public OccupationDModel[] Content { get; set; }
    }
}