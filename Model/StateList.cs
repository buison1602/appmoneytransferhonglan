using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    

    public class StateList
    {
        public string?  StateCode { get; set; }
        public string?  StateName { get; set; }
        public string?  CountryCode { get; set; }
        public string?  CITY { get; set; }
    }
    public class StatesList
    {
        public List<StateList> BankProvinceList { get; set; }
    }
    public class StateBankListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public StatesList Content { get; set; }
    }
    public class StateListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public StateList[] Content { get; set; }
    }
}