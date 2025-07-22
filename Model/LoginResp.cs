using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class LoginResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public LoginRespContent Content { get; set; }
    }

    public class LoginRespContent
    {
        public string?  UserID { get; set; }
        //public dynamic Users = new Array[] { };

        public List<Users> Users { get; set; } = new List<Users>();
        public List<MenuParentList> MenuParentList { get; set; } = new List<MenuParentList>();
        public List<MenuChildList> MenuChildList { get; set; } = new List<MenuChildList>();
        public List<SendCountryList> SendCountryList { get; set; } = new List<SendCountryList>();
        public List<SendCountryList> CountryList { get; set; } = new List<SendCountryList>();
        public List<ReceiveCountryList> ReceiveCountryList { get; set; }= new List<ReceiveCountryList>();
        public List<SendCurrencyList> SendCurrencyList { get; set; } = new List<SendCurrencyList>();
        public List<ReceiveCurrencyList> ReceiveCurrencyList { get; set; } = new List<ReceiveCurrencyList>();
        public List<SearchList> SearchList { get; set; } = new List<SearchList>();
        public List<TypeTranList> TypeTranList { get; set; } = new List<TypeTranList>();
        public List<AgentList> AgentList { get; set; } = new List<AgentList>();
        public List<AgentList> AgentListAll { get; set; } = new List<AgentList>();
        public List<StateList> StateList { get; set; } = new List<StateList>();
        public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        public List<OptionDate> OptionDate { get; set; } = new List<OptionDate>(); 
        public List<Partner> Partner { get; set; } = new List<Partner>();
        public List<Province> Province { get; set; } = new List<Province>();
        public List<Branch> Branch { get; set; } = new List<Branch>();
        public List<Employee> Employee { get; set; }= new List<Employee>();
        public List<PaymentModeList> PaymentMethod { get; set; } = new List<PaymentModeList>(); 
        public List<ImportBatch> ImportBatch { get; set; } = new List<ImportBatch>();
        public List<Currency> Currency { get; set; } = new List<Currency>(); 
        public List<EmailStatus> EmailStatus { get; set; } = new List<EmailStatus>();
        public List<TranStatus> TranStatus { get; set; } = new List<TranStatus>(); 
        public List<Search> Search { get; set; } = new List<Search>();
        public List<ApproveOption> ApproveOption { get; set; } = new List<ApproveOption>();
        public List<OptionCheckStatus> OptionCheckStatus { get; set; } = new List<OptionCheckStatus>();
        public List<PaymentMethodList> PaymentMethodList { get; set; }= new List<PaymentMethodList>();
        public List<PaymentMethodList> PaymentMethodReportList { get; set; } = new List<PaymentMethodList>();
        public List<IDTypeList> IDTypeList { get; set; } = new List<IDTypeList>();
        public List<UserType> UserTypeList { get; set; } = new List<UserType>();
        public List<TypeofStatusModel> TypeofStatusList { get; set; } = new List<TypeofStatusModel>();
        public List<AccessLevel> AccessLevelList { get; set; } = new List<AccessLevel>();
        public List<TransactionStatus> TransStatusList { get; set; } = new List<TransactionStatus>();
        public List<SOFModel> SOFList { get; set; } = new List<SOFModel>();
        public List<TypeofStatusModel> AgentStatusList { get; set; } = new List<TypeofStatusModel>();
        public List<TypeTranList> TypeofApproveList { get; set; } = new List<TypeTranList>();
        public List<RelationwithSenderList> RelationwithSenderList { get; set; } = new List<RelationwithSenderList>();
        public List<ControlPageList> ControlPageList { get; set; } = new List<ControlPageList>();
        public List<TypeofBlackList> TypeofBlackList { get; set; } = new List<TypeofBlackList>();
        public List<PageNameList> PageNameList { get; set; } = new List<PageNameList>();
        public List<AMLTypeModel> AMLTypeList { get; set; } = new List<AMLTypeModel>();
        public List<YearModel> YearList { get; set; } = new List<YearModel>();
        public List<QuartModel> QuartList { get; set; } = new List<QuartModel>();
        public List<StateList> StateAgentList { get; set; } = new List<StateList>();
        public List<MenuChildList> MenuChildChildList { get; set; } = new List<MenuChildList>();
        public List<NoteModel> NoteList { get; set; } = new List<NoteModel>();
        public List<StateList> StateListAll { get; set; }= new List<StateList>();
        public List<OccupationMModel> OccupationMList { get; set; }= new List<OccupationMModel>();
        public List<OccupationDModel> OccupationDList { get; set; } = new List<OccupationDModel>();
        public List<StateList> StatePayoutList { get; set; }= new List<StateList>();
        public List<StateList> CityPayoutList { get; set; } = new List<StateList>();
        public List<splitList> SplitList { get; set; } = new List<splitList>();
        public List<TypeofPaidModel> TypeofPaidList { get; set; } = new List<TypeofPaidModel>();
        public List<ExceptionModel> ExceptionList { get; set; }= new List<ExceptionModel>();
        public List<IDTypeList> BusinessList { get; set; } = new List<IDTypeList>();
        public List<TransTypeList> PaymentMethodListAll { get; set; } = new List<TransTypeList>();
        public List<TypeTranList> TypeofUpdateList { get; set; } = new List<TypeTranList>();


    }
    public class RequestLogin
    {
        public string?  UserName { get; set; }
        public string?  Password { get; set; }
    }
}
