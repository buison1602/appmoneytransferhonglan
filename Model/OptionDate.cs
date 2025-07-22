using System;

namespace AppMoneyTransferRS.Models
{
    public class OptionDate
    {
        public String OptionID { get; set; }
        
        public String OptionName { get; set; }
    }

    public class OptionDateResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public OptionDate[] Content { get; set; }
    }
}
