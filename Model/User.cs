using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class User
    {
        public string?  Id { get; set; }
        public string?  UserName { get; set; }
        public string?  AgentID { get; set; }
        public string?  TranAgentID { get; set; }
        public string?  AgentName { get; set; }
        public string?  AgentState { get; set; }
        
        public string?  FullName { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  LegalName { get; set; }
        public string?  OwnerName { get; set; }
        public string?  AgentType { get; set; }
        
        public string?  GroupID { get; set; }
        public string?  GroupName { get; set; }
        public string?  ImageUrl { get; set; }
        public int TimeOut { get; set; }
        public int TimeWarning { get; set; }
        public string?  methodBankList { get; set; }
        public string?  Occupation { get; set; }
        public string?  Expire { get; set; }
        public byte[]? FileImage { get; set; }
        public int EditProfile { get; set; }
        public bool Warning { get; set; } = false;
        
        //public List<Users> Users { get; set; } = new List<Users>();
        public List<AgentList> AgentList { get; set; } = new List<AgentList>();
        public List<AgentList> AgentListAll { get; set; } = new List<AgentList>();
        public List<Users> Users { get; set; } = new List<Users>();
        //public dynamic Users = new Array[] { };
        public List<MenuParentList> MenuParentList { get; set; } = new List<MenuParentList>();
        public List<MenuChildList> MenuChildList { get; set; } = new List<MenuChildList>();
        public List<SendCountryList> SendCountryList { get; set; } = new List<SendCountryList>();
        public List<ReceiveCountryList> ReceiveCountryList { get; set; }= new List<ReceiveCountryList>();
        public List<SendCurrencyList> SendCurrencyList { get; set; } = new List<SendCurrencyList>();
        public List<ReceiveCurrencyList> ReceiveCurrencyList { get; set; } = new List<ReceiveCurrencyList>();
        public List<SearchList> SearchList { get; set; } = new List<SearchList>();
        public List<TypeTranList> TypeTranList { get; set; } = new List<TypeTranList>();      
        public List<StateList> StateList { get; set; } = new List<StateList>();
        public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        public List<SendCountryList> CountryList { get; set; } = new List<SendCountryList>();
        public List<PaymentMethodList> PaymentMethodList { get; set; }
        public List<PaymentMethodList> PaymentMethodReportList { get; set; }
        public List<IDTypeList> IDTypeList { get; set; } = new List<IDTypeList>();
        public List<UserType> UserTypeList { get; set; }
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

        public List<IDTypeList>  BusinessList { get; set; }

        public List<TransTypeList> PaymentMethodListAll { get; set; } = new List<TransTypeList>();
        public List<TypeTranList> TypeofUpdateList { get; set; } = new List<TypeTranList>();

    }
}