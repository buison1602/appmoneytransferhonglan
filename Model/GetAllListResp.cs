using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class GetAllListResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public LoginRespContent Content { get; set; }
    }

    public class GetAllListRespContent
    {   
        public List<SendCountryList> SendCountryList { get; set; } = new List<SendCountryList>();
        public List<ReceiveCountryList> ReceiveCountryList { get; set; }= new List<ReceiveCountryList>();
        public List<SendCurrencyList> SendCurrencyList { get; set; } = new List<SendCurrencyList>();
        public List<ReceiveCurrencyList> ReceiveCurrencyList { get; set; } = new List<ReceiveCurrencyList>();
        public List<StateList> StateList { get; set; } = new List<StateList>();
        public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        public List<PaymentMethodList> PaymentMethodList { get; set; }
        public List<TypeTranList> TypeTranList { get; set; } = new List<TypeTranList>();
        public List<PaymentModeList> PaymentModeList { get; set; }
        public List<Province> ProvinceList { get; set; }
       
    }
   
}
