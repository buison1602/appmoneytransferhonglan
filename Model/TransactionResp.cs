using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class TransactionResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public TransactionRespContent Content { get; set; }
    }
    public class TransactionEditResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public TransactionEditRespContent Content { get; set; }
    }
    public class TransactionEditRespContent
    {
        public List<CustomerList> CustomerList { get; set; } = new List<CustomerList>();
        public List<B_CustomerList> B_CustomerList { get; set; } = new List<B_CustomerList>();
        public List<SendCountryList> SendCountryList { get; set; } = new List<SendCountryList>();
        public List<ReceiveCountryList> ReceiveCountryList { get; set; }= new List<ReceiveCountryList>();
        public List<SendCurrencyList> SendCurrencyList { get; set; } = new List<SendCurrencyList>();
        public List<ReceiveCurrencyList> ReceiveCurrencyList { get; set; } = new List<ReceiveCurrencyList>();
        public List<SendStateList> SendStateList { get; set; }
        public List<ReceiveStateList> ReceiveStateList { get; set; }
        public List<ReasonforSendingList> ReasonforSendingList { get; set; }
        public List<TransTypeList> TransTypeList { get; set; }
        public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        public List<BankList> BankList { get; set; }
        public List<TransDetail> TransactionList { get; set; }
        public List<CustomerTranList> CustomerCountTranList { get; set; }
        public List<CustomerTranList> BCustomerCountTranList { get; set; }
        public List<CityModel> CityList { get; set; }


    }
    public class TransactionRespContent
    {     
        public List<CustomerList> CustomerList { get; set; } = new List<CustomerList>();
        public List<B_CustomerList> B_CustomerList { get; set; } = new List<B_CustomerList>();
        public List<SendCountryList> SendCountryList { get; set; } = new List<SendCountryList>();
        public List<ReceiveCountryList> ReceiveCountryList { get; set; }= new List<ReceiveCountryList>();
        public List<SendCurrencyList> SendCurrencyList { get; set; } = new List<SendCurrencyList>();
        public List<ReceiveCurrencyList> ReceiveCurrencyList { get; set; } = new List<ReceiveCurrencyList>();
        public List<SendStateList> SendStateList { get; set; }
        public List<ReceiveStateList> ReceiveStateList { get; set; }
        public List<ReasonforSendingList> ReasonforSendingList { get; set; }
        public List<TransTypeList> TransTypeList { get; set; }
        public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        public List<BankList> BankList { get; set; }
        public List<CityModel> CityList { get; set; }
    }
    public class BlackiListResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public BlackListContent Content { get; set; }
    }
    public class BlackListContent
    {        public List<BlackList> blackList { get; set; }
    }
    public class BlackList
    {
        public string?  ErrorMessage { get; set; }
    }

    }
