using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class YearModel
    {
        public string?  Year { get; set; }
    }
    public class QuartModel
    {
        public string?  Quart { get; set; }
    }
    public class YearModelListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public YearModel[] Content { get; set; }
    }
}