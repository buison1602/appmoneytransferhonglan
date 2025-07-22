using AppMoneyTransferRS.Class;
using AppMoneyTransferRS.Helpers;
using AppMoneyTransferRS.Models;
using AppMoneyTransferRS.Services;
using Blazored.Toast.Services;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System;
using System.Data.Common;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using static MudBlazor.FilterOperator;
using Microsoft.JSInterop;

using System.Collections.Generic;


namespace AppMoneyTransferRS.Pages.Transaction
{
    public partial class NewTransaction
    {
        [Inject]

        public NavigationManager? NavManager { get; set; } 
        public class ModelBank
        {
            public string?  ID { get; set; } = "";
            public string?  MainBank { get; set; } = "";
            public string?  bankCity { get; set; } = "";
            public string?  Province { get; set; } = "";
            public string?  City { get; set; } = "";
            public string?  BankID { get; set; } = "";
            public string?  AccountNo { get; set; } = "";
            public string?  Branch { get; set; } = "";
            public string?  Swiftcode { get; set; } = "";
            public string?  Currency { get; set; } = "";
            public string?  BANK_NAME { get; set; } = "";
            

        }
        bool IsAddNewBank = false;
        bool IsEditBank = false;
        bool isAddBank = false;
        bool IsEBank = false;
        bool IsDelEBank = false;
        bool IsChangeExpire = false;
        bool IsBehalf = false;
        bool IsShow = true;
        bool IsShowStatus = false;
        bool IsEditBankButton = true;
        private string checkedValue = "No";
        //initial
        private string displayBank = "None";
        private string displayUS = "None";
        private string displayBankCountry = "None";
        private string TypeServices = "0";
        private string fc = "";
        private string tc = "";
        private string displayVerificationChecked = "None";
        private string displaymessageVerifyID = "None";
        private string displaymessageVerifySSN = "None";
        private string displayReason = "None";
        private string displayCityPH = "None";
        private string displayCityNoPH = "Initial";

        private string isViewingSender = "None";
        private bool isViewingReport = false;
        private bool LoadingReport = true;
        private bool isBankOther = true;
        private string displayBankOther = "None";
        private dynamic reports = null;
        private dynamic Table = new Array[] { };
        private dynamic Table1 = new Array[] { };
        private dynamic Table2 = new Array[] { };
        private string error = "";
        private bool IsAttachFile = false;
        public List<CustomerProfileFile> SenderDocumentsList { get; set; } = new List<CustomerProfileFile>();
        public List<CustomerProfileFile> SenderDocumentsListDownload { get; set; } = new List<CustomerProfileFile>();
        private TransactionModel model = new TransactionModel();
        private ModelBank modelAddBank = new ModelBank();
        private ModelBank modelEditBank = new ModelBank();

        //public List<CountryList> CountryList { get; set; }
        private dynamic CountryList = new Array[] { };
        CountryList CountryLists { get; set; }
        private string CountryCode = "";

        private List<OccupationMModel> OccupationMList = new List<OccupationMModel>();
        OccupationMModel OccupationMs { get; set; }
        private List<OccupationDModel> OccupationDAllList = new List<OccupationDModel>();
        private List<OccupationDModel> OccupationDList = new List<OccupationDModel>();
        OccupationDModel OccupationDs { get; set; }


        private List<ControlPageList> ControlPageList = new List<ControlPageList>();

        private dynamic IDTypeList = new Array[] { };
        public List<CustomerList> CustomerList { get; set; } = new List<CustomerList>();
        CustomerList CustomerLists { get; set; }
        private string CustID = "";

        public List<B_CustomerList> B_CustomerList { get; set; } = new List<B_CustomerList>(); 
        B_CustomerList B_CustomerLists { get; set; }
        private string BCustID = "";

        //public List<SendCountryList> SendCountryList { get; set; } = new List<SendCountryList>();
        private dynamic SendCountryList = new Array[] { };
        SendCountryList SendCountryLists { get; set; }
        private string SendCountryCode = "";

        string DisableColor = "#f3f4f4!important";
        public List<BankIDList> BankIDList { get; set; } = new List<BankIDList>();
        public List<BankIDList> BankIDAllList { get; set; } = new List<BankIDList>();
        BankIDList BankIDLists { get; set; }
        private string BID = "";


        public List<MainBanks> MainBanksList { get; set; } = new List<MainBanks>();
        MainBanks MainBank { get; set; }
        private string MainBanksID = "";


        //public List<ReceiveCountryList> ReceiveCountryList { get; set; }= new List<ReceiveCountryList>();
        private dynamic ReceiveCountryList = new Array[] { };
        ReceiveCountryList ReceiveCountryLists { get; set; }
        private string ReceiveCountryCode = "";

        //public List<SendCurrencyList> SendCurrencyList { get; set; } = new List<SendCurrencyList>();
        private dynamic SendCurrencyList = new Array[] { };
        SendCurrencyList SendCurrencyLists { get; set; }
        private string SendCurrencyCode = "";

        //public List<ReceiveCurrencyList> ReceiveCurrencyList { get; set; } = new List<ReceiveCurrencyList>();
        private dynamic ReceiveCurrencyList = new Array[] { };
        ReceiveCurrencyList ReceiveCurrencyLists { get; set; }
        private string ReceiveCurrencyCode = "";

        private SendStateList[] SendStateListNew = new SendStateList[] { };

        private List<SendStateList> SendStateList { get; set; } = new List<SendStateList>();
        SendStateList SendStateLists { get; set; }
        private string SendStateID = "";

        //public List<SendCountryList> SendCountryIssueList { get; set; }
        private dynamic SendCountryIssueList = new Array[] { };
        SendCountryList SendCountryIssueLists { get; set; }
        private string SendCountryIssueCode = "";

        //public List<SendStateList> SendStateBHList { get; set; }
        private dynamic SendStateBHList = new Array[] { };
        SendStateList SendStateBHLists { get; set; }
        private string SendStateBHID = "";

        //public List<SendStateList> SendStateIssueList { get; set; }
        private dynamic SendStateIssueList = new Array[] { };
        SendStateList SendStateIssueLists { get; set; }
        private string SendStateIssueID = "";



        private dynamic SendBHStateIssueList = new Array[] { };
        // public List<ReceiveStateList> ReceiveStateList { get; set; }
        //private dynamic ReceiveStateList = new Array[] { };
        List<ReceiveStateList> ReceiveStateList { get; set; } = new List<ReceiveStateList>();
        ReceiveStateList ReceiveStateLists { get; set; }
        private string ReceiveStateID = "";

        //public List<ReasonforSendingList> ReasonforSendingList { get; set; }
        private dynamic ReasonforSendingList = new Array[] { };
        ReasonforSendingList ReasonforSendingLists { get; set; }
        private string ReasonID = "";

        //public List<TransTypeList> TransTypeList { get; set; }
        private dynamic PaymentMethodList = new Array[] { };

        public List<TransTypeList> TransTypeListNew { get; set; } = new List<TransTypeList>();
        public List<TransTypeList> TransTypeList { get; set; } = new List<TransTypeList>();
        public List<CityModel> CityList { get; set; } = new List<CityModel>();
        public List<CityModel> CityStateList { get; set; } = new List<CityModel>();
        public List<ExceptionModel> ExceptionList { get; set; }= new List<ExceptionModel>(); 
        public List<ExceptionModel> ExceptionSAList { get; set; } = new List<ExceptionModel>();

        //private dynamic TransTypeList = new Array[] { };
        TransTypeList TransTypeLists { get; set; }
        private string TranstypeID = "";

        //private dynamic PaymentAgentList = new Array[] { };
        //private dynamic PaymentAgentListAll = new Array[] { };
        public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        public List<PaymentAgentList> PaymentAgentListAll { get; set; } = new List<PaymentAgentList>();
        //public List<PaymentAgentList> PaymentAgentList { get; set; } = new List<PaymentAgentList>();
        //private dynamic PaymentAgentList = new Array[] { };
        PaymentAgentList PaymentAgentLists { get; set; }
        private string PAY_AG_ID = "";

        public List<BankList> BankList { get; set; } = new List<BankList>();
        //private dynamic BankList = new Array[] { };
        BankList BankLists { get; set; }
        private string BANK_CODE = "";
        public List<StateList> StatePayoutAll { get; set; } = new List<StateList>();
        public List<StateList> CityPayoutAll { get; set; } = new List<StateList>();
        public List<StateList> StatePayoutList { get; set; }= new List<StateList>();
        public List<StateList> CityPayoutList { get; set; } = new List<StateList>();
        public List<StateList> ProvinceBankList { get; set; } = new List<StateList>();
        StateList ProvinceList { get; set; }
        private string ProvinceCode = "";

        public List<BankCity> BankCityList { get; set; } = new List<BankCity>();
        BankCity BankCityLists { get; set; }
        private string CityCode = "";

        public List<BankCity> BankDistrictList { get; set; } = new List<BankCity>();
        BankCity DistrictList { get; set; }
        private string DistrictCode = "";

        public List<DiscountList> DiscountList { get; set; } = new List<DiscountList>();

        public List<AgentList> AgentListAll { get; set; } = new List<AgentList>();
        public List<AgentList> AgentList { get; set; } = new List<AgentList>();
        public List<AgentList> AgentPayoutList { get; set; } = new List<AgentList>();
        //private dynamic AgentList = new Array[] { };
        AgentList AgentLists { get; set; }
        private string Agent_ID = "";


        public List<RelationwithSenderList> RelationwithSenderList { get; set; } = new List<RelationwithSenderList>();
        //private dynamic AgentList = new Array[] { };
        RelationwithSenderList RelationwithSenderLists { get; set; }
        private string relationID = "";


        public List<SOFModel> SOFList { get; set; } = new List<SOFModel>();
        //private dynamic AgentList = new Array[] { };
        SOFModel SOFModels { get; set; }
        private string SOF = "";
        bool ViewDuplicate = false;

        public List<ReportDetail> SenderAddressList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> SenderPhoneList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> ReceiverLocalNameList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> ReceiverAddressList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> ReceiverPhoneList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> ReceiverBankAccountList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> ReceiverIDList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> SenderNameList { get; set; } = new List<ReportDetail>();
        public List<ReportDetail> SenderCustIDList { get; set; } = new List<ReportDetail>();
        bool ViewAggList = false;
        public List<TypeofPaidModel> typeofPaidAllList { get; set; } = new List<TypeofPaidModel>();
        public List<TypeofPaidModel> TypeofPaidList { get; set; } = new List<TypeofPaidModel>();
        public List<TypeofPaidModel> TypeofPaidListSelect { get; set; } = new List<TypeofPaidModel>();

        public string?  C_AgentID { get; set; } = "white!important"; 
        public string?  C_SFirstName { get; set; } = "white!important";
        public string?  C_SMiddleName { get; set; } = "white!important";
        public string?  C_SLastName { get; set; } = "white!important";
        public string?  C_SAddress { get; set; } = "white!important";
        public string?  C_SCity { get; set; } = "white!important";
        public string?  C_SState { get; set; } = "white!important";
        public string?  C_SZipcode { get; set; } = "white!important";
        public string?  C_SPhone { get; set; } = "white!important";
        public string?  C_SEmail { get; set; } = "white!important";
        public string?  C_SBHFirstName { get; set; } = "white!important";
        public string?  C_SBHMiddleName { get; set; } = "white!important";
        public string?  C_SBHLastName { get; set; } = "white!important";
        public string?  C_SBHAddress { get; set; } = "white!important";
        public string?  C_SBHState { get; set; } = "white!important";
        public string?  C_SBHCity { get; set; } = "white!important";
        public string?  C_SBHZipcode { get; set; } = "white!important";
        public string?  C_SBHPhone { get; set; } = "white!important";
        public string?  C_SBHEmail { get; set; } = "white!important";
        public string?  C_SBHIDType { get; set; } = "white!important";
        public string?  C_SBHID { get; set; } = "white!important";
        public string?  C_SBHCountryIssue { get; set; } = "white!important";
        public string?  C_SBHStateIssue { get; set; } = "white!important";
        public string?  C_SBHIssueDate { get; set; } = "white!important";
        public string?  C_SBHExpireDate { get; set; } = "white!important";
        public string?  C_SBHDOB { get; set; } = "white!important";
        public string?  C_SBHSSN { get; set; } = "white!important";
        public string?  C_SBHOccupation { get; set; } = "white!important";

        public string?  C_RFirstName { get; set; } = "white!important";
        public string?  C_RMiddleName { get; set; } = "white!important";
        public string?  C_RLastName { get; set; } = "white!important";
        public string?  C_RLocalName { get; set; } = "white!important";
        public string?  C_RID { get; set; } = "white!important";
        public string?  C_RFullName2 { get; set; } = "white!important";
        public string?  C_RAddress { get; set; } = "white!important";
        public string?  C_RState { get; set; } = "white!important";
        public string?  C_RCity { get; set; } = "white!important";
        public string?  C_RZipcode { get; set; } = "white!important";
        public string?  C_REmail { get; set; } = "white!important";
        public string?  C_RPhone { get; set; } = "white!important";
        public string?  C_RPhone2 { get; set; } = "white!important";

        public string?  C_RefNo { get; set; } = "white!important";
        public string?  C_FromCountry { get; set; } = "white!important";
        public string?  C_FromCurrency { get; set; } = "white!important";
        public string?  C_ToCountry { get; set; } = "white!important";
        public string?  C_ToCurrency { get; set; } = "white!important";
        public string?  C_SendAmount { get; set; } = "white!important";
        public string?  C_TransferFee { get; set; } = "white!important";
        public string?  C_AgentFee { get; set; } = "white!important";
        public string?  C_OtherFee { get; set; } = "white!important";
        public string?  C_TaxFee { get; set; } = "white!important";
        public string?  C_DiscountID { get; set; } = "white!important";
        public string?  C_Discount { get; set; } = "white!important";
        public string?  C_TotalAmount { get; set; } = "white!important";
        public string?  C_ExchangeRate { get; set; } = "white!important";
        public string?  C_LandedAmount { get; set; } = "white!important";
        public string?  C_ReadMoney { get; set; } = "white!important";
        public string?  C_Paidby { get; set; } = "white!important";
        public string?  C_PaymentMode { get; set; } = "white!important";
        public string?  C_PaymentMethod { get; set; } = "white!important";
        public string?  C_PaymentAgent { get; set; } = "white!important";
        public string?  C_SelectAccount { get; set; } = "white!important";
        public string?  C_BankName { get; set; } = "white!important";
        public string?  C_AccountNo { get; set; } = "white!important";
        public string?  C_Accountype { get; set; } = "white!important";
        public string?  C_RelationwithSenderNote { get; set; } = "white!important";
        public string?  C_IDType { get; set; } = "white!important";
        public string?  C_ID { get; set; } = "white!important";
        public string?  C_CountryIssue { get; set; } = "white!important";
        public string?  C_StateIssue { get; set; } = "white!important";
        public string?  C_IssueDate { get; set; } = "white!important";
        public string?  C_ExpireDate { get; set; } = "white!important";
        public string?  C_DOB { get; set; } = "white!important";
        public string?  C_SSN { get; set; } = "white!important";
        public string?  C_Occupation { get; set; } = "white!important";
        public string?  C_Message { get; set; } = "white!important";
        public string?  C_SelectReason { get; set; } = "white!important";
        public string?  C_ReasonforSending { get; set; } = "white!important";
        public string?  C_SecurityAnswer { get; set; } = "white!important";
        public string?  C_CompanyNote { get; set; } = "white!important";
        public string?  C_SelectSOF { get; set; } = "white!important";
        public string?  C_SOF { get; set; } = "white!important";
        public string?  C_MainBank { get; set; } = "white!important";
        public string?  C_BankAddress { get; set; } = "white!important";
        public string?  C_BankCode { get; set; } = "white!important";
        public string?  C_BankProvince { get; set; } = "white!important";
        public string?  C_BankCity { get; set; } = "white!important";
        public string?  C_PayoutState { get; set; } = "white!important";
        public string?  C_PayoutCity { get; set; } = "white!important";
        public string?  C_PayoutAddress { get; set; } = "white!important";
        public string?  C_VerifyIDCheck { get; set; } = "white!important";
        public string?  C_RelationwithSender { get; set; } = "white!important";
        public bool D_AgentID { get; set; } = false;
        public bool D_SFirstName { get; set; } = false;
        public bool D_SMiddleName { get; set; } = false;
        public bool D_SLastName { get; set; } = false;
        public bool D_SAddress { get; set; } = false;
        public bool D_SCity { get; set; } = false;
        public bool D_SState { get; set; } = false;
        public bool D_SZipcode { get; set; } = false;
        public bool D_SPhone { get; set; } = false;
        public bool D_SEmail { get; set; } = false;
        public bool D_SBHFirstName { get; set; } = false;
        public bool D_SBHMiddleName { get; set; } = false;
        public bool D_SBHLastName { get; set; } = false;
        public bool D_SBHAddress { get; set; } = false;
        public bool D_SBHState { get; set; } = false;
        public bool D_SBHCity { get; set; } = false;
        public bool D_SBHZipcode { get; set; } = false;
        public bool D_SBHPhone { get; set; } = false;
        public bool D_SBHEmail { get; set; } = false;
        public bool D_SBHIDType { get; set; } = false;
        public bool D_SBHID { get; set; } = false;
        public bool D_SBHCountryIssue { get; set; } = false;
        public bool D_SBHStateIssue { get; set; } = false;
        public bool D_SBHIssueDate { get; set; } = false;
        public bool D_SBHExpireDate { get; set; } = false;
        public bool D_SBHDOB { get; set; } = false;
        public bool D_SBHSSN { get; set; } = false;
        public bool D_SBHOccupation { get; set; } = false;

        public bool D_RFirstName { get; set; } = false;
        public bool D_RMiddleName { get; set; } = false;
        public bool D_RLastName { get; set; } = false;
        public bool D_RLocalName { get; set; } = false;
        public bool D_RID { get; set; } = false;
        public bool D_RFullName2 { get; set; } = false;
        public bool D_RAddress { get; set; } = false;
        public bool D_RState { get; set; } = false;
        public bool D_RCity { get; set; } = false;
        public bool D_RZipcode { get; set; } = false;
        public bool D_REmail { get; set; } = false;
        public bool D_RPhone { get; set; } = false;
        public bool D_RPhone2 { get; set; } = false;
        public bool D_RelationwithSender { get; set; } = false;
        public bool D_RelationwithSenderNote { get; set; } = false;

        public bool D_RefNo { get; set; } = false;
        public bool D_FromCountry { get; set; } = false;
        public bool D_FromCurrency { get; set; } = false;
        public bool D_ToCountry { get; set; } = false;
        public bool D_ToCurrency { get; set; } = false;
        public bool D_SendAmount { get; set; } = false;
        public bool D_TransferFee { get; set; } = false;
        public bool D_AgentFee { get; set; } = false;
        public bool D_OtherFee { get; set; } = false;
        public bool D_TaxFee { get; set; } = false;
        public bool D_DiscountID { get; set; } = false;
        public bool D_Discount { get; set; } = true;
        public bool D_TotalAmount { get; set; } = false;
        public bool D_ExchangeRate { get; set; } = false;
        public bool D_LandedAmount { get; set; } = false;
        public bool D_ReadMoney { get; set; } = false;
        public bool D_Paidby { get; set; } = false;
        public bool D_PaymentMode { get; set; } = false;
        public bool D_PaymentMethod { get; set; } = false;
        public bool D_PaymentAgent { get; set; } = false;
        public bool D_SelectAccount { get; set; } = false;
        public bool D_BankName { get; set; } = false;
        public bool D_AccountNo { get; set; } = false;
        public bool D_Accountype { get; set; } = false;

        public bool D_IDType { get; set; } = false;
        public bool D_ID { get; set; } = false;
        public bool D_CountryIssue { get; set; } = false;
        public bool D_StateIssue { get; set; } = false;
        public bool D_IssueDate { get; set; } = false;
        public bool D_ExpireDate { get; set; } = false;
        public bool D_DOB { get; set; } = false;
        public bool D_SSN { get; set; } = false;
        public bool D_Occupation { get; set; } = false;
        public bool D_Message { get; set; } = false;
        public bool D_SelectReason { get; set; } = false;
        public bool D_ReasonforSending { get; set; } = false;
        public bool D_SecurityAnswer { get; set; } = false;
        public bool D_CompanyNote { get; set; } = false;
        public bool D_SelectSOF { get; set; } = false;
        public bool D_SOF { get; set; } = false;
        public bool isNewCustomer { get; set; } = false;
        public bool isNewReceiver { get; set; } = false;
        public bool D_PayoutState { get; set; } = false;
        public bool D_PayoutCity { get; set; } = false;
        public bool D_PayoutAddress { get; set; } = false;
        public bool TypeOtherFee { get; set; } = false;
        public string?  back { get; set; } = "white!important";
        public string?  backerror { get; set; } = "yellow!important";
        public string?  IdBackground { get; set; } = "BackgroundWhite";
        public string?  SSNBackground { get; set; } = "BackgroundWhite NumberOnly";
        public string?  DOBBackground { get; set; } = "did-floating-input";
        public string?  IssueDateBackground { get; set; } = "did-floating-input";
        public string?  ExpireBackground { get; set; } = "did-floating-input";
        public string?  ReceiverIDCheckBackground { get; set; } = "BackgroundWhite";
        public string?  cssBackError { get; set; } = "BackgroundError";
        public string?  cssBack { get; set; } = "BackgroundWhite";
        public string?  cssbackSZipCode { get; set; } = "BackgroundWhite";
        public string?  cssbackServiceFee { get; set; } = "BackgroundWhite";
        public string?  cssbackAmount { get; set; } = "BackgroundWhite";
        public string?  cssbackLandedAmount { get; set; } = "BackgroundWhite";
        public string?  cssbackSPhone { get; set; } = "BackgroundWhite";

        readonly System.Drawing.Color ERROR = System.Drawing.Color.Yellow;
       
        readonly System.Drawing.Color OK = System.Drawing.Color.White;

        System.Drawing.Color backOK = System.Drawing.Color.White;
        System.Drawing.Color backAmount = System.Drawing.Color.White;
        System.Drawing.Color backSZipCode = System.Drawing.Color.White;
        System.Drawing.Color backServiceFee = System.Drawing.Color.White;
        //System.Drawing.Color cssbackLandedAmount = System.Drawing.Color.White;


        private ElementReference E_SFirstName;
        private ElementReference E_SMiddleName;
        private ElementReference E_SLastName;
        private ElementReference E_SAddress;
        private ElementReference E_SCity;
        private ElementReference E_SState;
        private ElementReference E_SZipcode;
        private ElementReference E_SPhone;
        private ElementReference E_SEmail;
        private ElementReference E_SBHFirstName;
        private ElementReference E_SBHMiddleName;
        private ElementReference E_SBHLastName;
        private ElementReference E_SBHAddress;
        private ElementReference E_SBHState;
        private ElementReference E_SBHCity;
        private ElementReference E_SBHZipcode;
        private ElementReference E_SBHPhone;
        private ElementReference E_SBHEmail;
        private ElementReference E_SBHIDType;
        private ElementReference E_SBHID;
        private ElementReference E_SBHCountryIssue;
        private ElementReference E_SBHStateIssue;
        private ElementReference E_SBHIssueDate;
        private ElementReference E_SBHExpireDate { get; set; }
        private ElementReference E_SBHDOB;
        private ElementReference E_SBHSSN;
        private ElementReference E_SBHOccupation;

        private ElementReference E_RFirstName;
        private ElementReference E_RMiddleName;
        private ElementReference E_RLastName;
        private ElementReference E_RLocalName;
        private ElementReference E_RID;
        private ElementReference E_RFullName2;
        private ElementReference E_RAddress;
        private ElementReference E_RState;
        private ElementReference E_RCity;
        private ElementReference E_RZipcode;
        private ElementReference E_REmail;
        private ElementReference E_RPhone;
        private ElementReference E_RPhone2;
        private ElementReference E_RelationwithSenderNote;
        private ElementReference E_RefNo;
        private ElementReference E_FromCountry;
        private ElementReference E_FromCurrency;
        private ElementReference E_ToCountry;
        private ElementReference E_ToCurrency;
        private ElementReference E_SendAmount;
        private ElementReference E_TransferFee;
        private ElementReference E_AgentFee;
        private ElementReference E_OtherFee;
        private ElementReference E_TaxFee;
        private ElementReference E_DiscountID;
        private ElementReference E_Discount;
        private ElementReference E_TotalAmount;
        private ElementReference E_ExchangeRate;
        private ElementReference E_LandedAmount;
        private ElementReference E_ReadMoney;
        private ElementReference E_Paidby;
        private ElementReference E_PaymentMode;
        private ElementReference E_PaymentMethod;
        private ElementReference E_RelationwithSender;

        private ElementReference E_PaymentAgent;
        private ElementReference E_SelectAccount;
        private ElementReference E_BankName;
        private ElementReference E_AccountNo;
        private ElementReference E_Accountype;

        private ElementReference E_IDType;
        private ElementReference E_ID;
        private ElementReference E_CountryIssue;
        private ElementReference E_StateIssue;
        public ElementReference E_IssueDate;
        public ElementReference E_ExpireDate;
        public ElementReference E_DOB;
        private ElementReference E_SSN;
        private ElementReference E_Occupation;
        private ElementReference E_Message;
        private ElementReference E_SelectReason;
        private ElementReference E_ReasonforSending;
        private ElementReference E_SecurityAnswer;
        private ElementReference E_CompanyNote;
        private ElementReference E_SelectSOF;
        private ElementReference E_SOF;
        private ElementReference E_MainBank;
        private ElementReference E_BankAddress;
        private ElementReference E_BankCode;
        private ElementReference E_BankProvince;
        private ElementReference E_BankCity;
        private ElementReference E_PayoutState;
        private ElementReference E_PayoutCity;
        private ElementReference E_PayoutAddress;

        private ElementReference E_VerifyIDCheck;
        int activeIndex = 0;
        List<dupTransaction> duptransaction = new List<dupTransaction>();
        ResponseTransactionService transactionservice = new ResponseTransactionService();
        private List<IBrowserFile> loadedSigns = new();
        private List<IBrowserFile> loadedFileIDs = new();
        private List<IBrowserFile> loadedFileSOFs = new();
        private List<IBrowserFile> loadedReFileIDs = new();
        private long maxFileSize = 1024 * 15 * 1024;
        private int maxAllowedFiles = 100;
        private bool isLoading = false;
        private bool isLoadingRe = false;
        private bool isLoadingID=false;
        private bool isLoadingISOF = false;
        bool isShow;
        bool isShowID;
        bool isShowBH;
        bool isShowIDBH;
        InputType PasswordInput = InputType.Password;
        string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
        InputType PasswordInputID = InputType.Password;
        string PasswordInputIconID = Icons.Material.Filled.VisibilityOff;
        InputType PasswordInputBH = InputType.Password;
        string PasswordInputIconBH = Icons.Material.Filled.VisibilityOff;
        InputType PasswordInputIDBH = InputType.Password;
        string PasswordInputIconIDBH = Icons.Material.Filled.VisibilityOff;
        private double KYCAmountNew = 0;
        private int i = 0;
        private string reason = "";
        private string reasonView = "";
        private bool travesof = true;
        private bool travessn = true;
        private bool trave = true;
        private string prompMsg = "";
        private int erragg = 0;
        private int errorint = 0;
        DialogOptions dialogOptionsDuplicate = new DialogOptions() { MaxWidth = MaxWidth.Medium, FullWidth = true, CloseOnEscapeKey = true, CloseButton = true, Position = DialogPosition.Center };
        DialogOptions dialogOptions = new DialogOptions() { MaxWidth = MaxWidth.Medium, FullWidth = true, CloseOnEscapeKey = true, CloseButton = true, Position = DialogPosition.Center };
        private const string bgcolorVN = "#d8ebff";
        private const string bgcolorCN = "#e1dfcc";
        private const string bgcolorPH = "#e6e6e6";
        private const string bgcolorUS = "#e6faff";
        private string bgcolor = "#d8ebff";
        public CultureInfo _de = CultureInfo.GetCultureInfo("de-DE");
        public CultureInfo _en = CultureInfo.GetCultureInfo("en-US");
        public string?  MaxHeightBody { get; set; } = "800px";
        public int HeightBody { get; set; } = 800;
        //private CultureInfo _en = new CultureInfo.GetCultureInfo("en-US");
        //CultureInfo.CurrentCulture = new CultureInfo("en-US");
        private string labeID = "";
        //var _en = CultureInfo.GetCultureInfo("en-US");
        public string?  MinHeghtSAmount { get; set; } = "384px";
        


        public int Height { get; set; } = 800;
       
        string pagename = "/Transaction/NewTransaction";
        public List<MenuChildList> menuChildLists { get; set; } = new List<MenuChildList>();
        private void OnAutoCompleteChanged(ReceiveStateList customer)
        {
            if( customer!= null)
            {
                model.RState = customer.StateCode;
                StateHasChanged();
                Console.WriteLine($"'{customer?.StateName}' selected.");
            }
            
        }
        // Commented out due to BlazorBootstrap dependency removal
        /*
        {
            List<ReceiveStateList> customers = new List<ReceiveStateList>();
            if (customers.Count==0) // pull customers only one time for client-side autocomplete
                customers = ReceiveStateList; // call a service or an API to pull the customers
            StateHasChanged();
            return await Task.FromResult(request.ApplyTo(customers.OrderBy(cust => cust.StateName)));
        }
        */
        private async Task<IEnumerable<SendStateList>> SearchSendState(string value)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, show complete list
            if (string.IsNullOrEmpty(value))
                return SendStateListNew.ToList();
            return SendStateListNew.Where(x => x.StateName.Contains(value)).ToList();
        }
        void ButtonTestclick()
        {
            if (isShow)
            {
                isShow = false;
                PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                PasswordInput = InputType.Password;
            }
            else
            {
                isShow = true;
                PasswordInputIcon = Icons.Material.Filled.Visibility;
                PasswordInput = InputType.Text;
            }
        }
        void ButtonTestIDclick()
        {
            if (isShowID)
            {
                isShowID = false;
                PasswordInputIconID = Icons.Material.Filled.VisibilityOff;
                PasswordInputID = InputType.Password;
            }
            else
            {
                isShowID = true;
                PasswordInputIconID = Icons.Material.Filled.Visibility;
                PasswordInputID = InputType.Text;
            }
        }
        void ButtonTestBHclick()
        {
            if (isShowBH)
            {
                isShowBH = false;
                PasswordInputIconBH = Icons.Material.Filled.VisibilityOff;
                PasswordInputBH = InputType.Password;
            }
            else
            {
                isShowBH = true;
                PasswordInputIconBH = Icons.Material.Filled.Visibility;
                PasswordInputBH = InputType.Text;
            }
        }
        void ButtonTestIDBHclick()
        {
            if (isShowIDBH)
            {
                isShowIDBH = false;
                PasswordInputIconIDBH = Icons.Material.Filled.VisibilityOff;
                PasswordInputIDBH = InputType.Password;
            }
            else
            {
                isShowIDBH = true;
                PasswordInputIconIDBH = Icons.Material.Filled.Visibility;
                PasswordInputIDBH = InputType.Text;
            }
        }
        private UserListModel modelAddNewUser = new UserListModel();

        private async Task CloseEditBank()
        {
            IsEditBank = false;
            this.StateHasChanged();
        }
        private async Task EditBank()
        {
            modelEditBank = new ModelBank();
            
            IsEditBank = true;
            
            modelEditBank.Currency = model.ToCurrency;
            await getBank();
            var bankList = BankIDList.Find(x => x.ID == model.BankID);
            if (bankList != null)
            {
                modelEditBank.MainBank = bankList.MAINBANK;
                if (modelEditBank.MainBank == "OTHER")
                {
                    isBankOther = false;
                }
                else
                {
                    isBankOther = true;
                }
                modelEditBank.Province = bankList.BankProvince == null ? "" : bankList.BankProvince;
                modelEditBank.City = bankList.BankCity == null ? "" : bankList.BankCity;
                StateHasChanged();
               
                modelEditBank.bankCity = bankList.CITY;
                modelEditBank.BANK_NAME = bankList.BANK_NAME == null ? "" : bankList.BANK_NAME;
                modelEditBank.Swiftcode = bankList.SWIFTCODE;
                modelEditBank.Currency = bankList.CURRENCY;
                modelEditBank.ID = bankList.ID;
                modelEditBank.AccountNo = bankList.ACCOUNT_NO;
                modelEditBank.BankID = bankList.SWIFTCODE;
                await getBankCity(modelEditBank.BankID, "Edit");
                this.StateHasChanged();
            }
           
           
         

            this.StateHasChanged();

        }
        private async Task CloseNewBank()
        {
            IsAddNewBank = false;
            this.StateHasChanged();

        }
        private async Task CloseNewAgg()
        {
            ViewAggList = false;
            this.StateHasChanged();

        }
        private async Task AddNewBank()
        {
            modelAddBank = new ModelBank();
            modelAddBank.Currency = model.ToCurrency;
            IsAddNewBank = true;
            await getBank();
            await getBankCity(modelAddBank.BankID,"Add");
            //dynamic payload = new
            //{
            //    Form = "/Transaction/NewTransaction",
            //    FormName = "New Transaction",
            //    Action = "GetBankList",
            //    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
            //    UserID = model.UserID,
            //    CountryCode = model.ToCountry,
            //    Country = model.ToCountry,
            //    PaymentAgent = "",
            //    CurrencyCode = model.ToCurrency,
            //    pageIndex = 1,
            //    pageSize = 50
            //};
            //if (model.ToCountry == "CN")
            //{
            //    dynamic payload1 = new
            //    {
            //        Form = "/Transaction/NewTransaction",
            //        FormName = "New Transaction",
            //        Action = "getMainBank",
            //        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
            //        UserID = model.UserID,
            //        CountryCode = model.ToCountry,
            //        Country = model.ToCountry,
            //        PaymentAgent = model.PaymentAgent,
            //        Currency = model.ToCurrency
            //    };
            //    displayBankCountry = "initial";
            //    MainBanksListResp respMain = await HttpService.Post<MainBanksListResp>("/Customer/getMainBank", payload1);
            //    if (respMain.Status == 200)
            //    {
            //        MainBanksList = respMain.Content.MainBankList;
            //    }
            //    else
            //    {
            //        MainBanksList = new List<MainBanks>();
            //    }
            //    dynamic payload2 = new
            //    {
            //        Form = "/Transaction/NewTransaction",
            //        FormName = "New Transaction",
            //        Action = "GetBankProvince",
            //        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
            //        UserID = model.UserID,
            //        Country = model.ToCountry
            //    };
            //    StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
            //    if (respProvince.Status == 200)
            //    {
            //        ProvinceBankList = respProvince.Content.BankProvinceList;
            //    }
            //    else
            //    {
            //        ProvinceBankList = new List<StateList>();
            //    }
            //}
            //else
            //{
            //    displayBankCountry = "none";
            //}

            //BankListResp resp = await HttpService.Post<BankListResp>("/Index/GetBankList", payload);
            //if (resp.Status == 200)
            //{

            //    BankList = resp.Content.ListBank;
            //    modelAddBank.BankID = resp.Content.ListBank[0].BANK_CODE.ToString();
            //    modelAddBank.BANK_NAME = resp.Content.ListBank[0].BANK_NAME.ToString();
            //}
            //else
            //{
            //    if (resp.Status == 99)
            //    {
            //        toastService.ShowWarning("User is not Exist or Expire");
            //        await AuthService.Logout();
            //    }
            //    BankList = new List<BankList>();
            //}
            ChangeBank0();
            this.StateHasChanged();

        }
        protected async void ChangetoCurrency(ChangeEventArgs e)
        {
            TypeServices = "1";
            StateHasChanged();
            model.ToCurrency = e.Value.ToString();
            
            UpdateServiceFee();
            BankIDList = BankIDAllList.Where(x => x.CURRENCY == model.ToCurrency || x.CURRENCY == "").OrderByDescending(x => x.Hidedate).ToList();
            ChangeBank0();
            StateHasChanged();
        }
        private async Task AddNewBankAPI()
        {
            if (await ValidateAddBank())
            {
                //modelAddBank = new ModelBank();
                IsAddNewBank = true;
                if (string.IsNullOrEmpty(BCustID))
                {
                    BCustID = (System.Guid.NewGuid().ToString() + "-B" + System.DateTime.UtcNow.AddHours(-7).ToString("yyMMddHHmmss")).ToUpper();
                    model.BCustID = BCustID;
                }
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "AddNewReceiverBank",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    B_CustID = BCustID,
                    BankCode = modelAddBank.BankID,
                    AccountNo = modelAddBank.AccountNo,
                    BankProvince = modelAddBank.Province,
                    BankCity = modelAddBank.City,
                    PaymentAgent = model.PaymentAgent,
                    Country = model.ToCountry,
                    Currency = modelAddBank.Currency,
                    BANK_NAME = modelAddBank.BANK_NAME,
                    pageIndex = 1,
                    pageSize = 50
                };

                BankListIDResp resp = await HttpService.Post<BankListIDResp>("/Customer/AddNewReceiverBank", payload);
                if (resp.Status == 200)
                {
                    BankIDAllList = resp.Content.BankList;
                    BankIDList = resp.Content.BankList.Where(x => x.CURRENCY == model.ToCurrency || x.CURRENCY == "").OrderByDescending(x => x.Hidedate).ToList();
                    ChangeBank0();
                    this.StateHasChanged();
                    IsAddNewBank = false;
                    //modelAddBank.BankID = resp.Content.ListBank[0].BANK_CODE.ToString();
                }
                else
                {
                    if (resp.Status == 99)
                    {
                        toastService.ShowWarning("User is not Exist or Expire");
                        await AuthService.Logout();
                    }
                    BankList = new List<BankList>();
                }
            }

            this.StateHasChanged();

        }
        private async Task DeleteBankAPI()
        {
            if (await ValidateDeleteBank())
            {
                modelAddBank = new ModelBank();
                IsDelEBank = true;
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "DeleteReceiverBank",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    B_CustID = BCustID,
                    ID = modelEditBank.ID,
                    pageIndex = 1,
                    pageSize = 50
                };

                BankListIDResp resp = await HttpService.Post<BankListIDResp>("/Customer/DeleteReceiverBank", payload);
                if (resp.Status == 200)
                {
                    BankIDList = resp.Content.BankList;

                    BankIDLists = BankIDList.FirstOrDefault();
                    model.BankID = BankIDLists.ID.ToString();
                    model.AccountNo = BankIDLists.ACCOUNT_NO;
                    model.BankName = BankIDLists.BANK_NAME;
                    model.BankCode = BankIDLists.SWIFTCODE;
                    IsDelEBank = false;
                    IsEditBank = false;
                }
                else
                {
                    if (resp.Status == 99)
                    {
                        toastService.ShowWarning("User is not Exist or Expire");
                        await AuthService.Logout();
                    }
                    BankList = new List<BankList>();
                }
            }

            this.StateHasChanged();
        }
        private async Task UpdateBankAPI()
        {
            if (await ValidateUpdateBank())
            {
                modelAddBank = new ModelBank();
                IsEBank = true;
                dynamic payload = new
                {
                    UserID = model.UserID,
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "UpdateReceiverBank",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    B_CustID = BCustID,
                    ID = modelEditBank.ID,
                    BankCode = modelEditBank.BankID,
                    AccountNo = modelEditBank.AccountNo,
                    BankProvince = modelEditBank.Province,
                    BankCity = modelEditBank.City,
                    PaymentAgent = model.PaymentAgent,
                    Country = model.ToCountry,
                    Currency = modelEditBank.Currency,
                    BANK_NAME = modelEditBank.BANK_NAME,
                    pageIndex = 1,
                    pageSize = 50
                };

                BankListIDResp resp = await HttpService.Post<BankListIDResp>("/Customer/UpdateReceiverBank", payload);
                if (resp.Status == 200)
                {
                    BankIDAllList = resp.Content.BankList;
                    BankIDList = resp.Content.BankList.Where(x=>x.CURRENCY==model.ToCurrency || x.CURRENCY == "").OrderByDescending(x => x.Hidedate).ToList();
                   
                    this.StateHasChanged();
                     ChangeBankUpdate(modelEditBank.ID);
                    //if (BankIDList.Count() > 0)
                    //{
                    //    foreach (var item in BankIDList)
                    //    {
                    //        if (model.BankID == item.ID.ToString())
                    //        {
                    //            model.AccountNo = item.ACCOUNT_NO;
                    //        }
                    //    }
                    //}
                    IsEBank = false;
                    IsEditBank = false;
                }
                else
                {
                    if (resp.Status == 99)
                    {
                        toastService.ShowWarning("User is not Exist or Expire");
                        await AuthService.Logout();
                    }
                    BankList = new List<BankList>();
                }
            }

            this.StateHasChanged();
        }
        private void LoadSigns(InputFileChangeEventArgs e)
        {
            StateHasChanged();
            isLoading = true;
            loadedSigns.Clear();
            StateHasChanged();
            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                try
                {
                    loadedSigns.Add(file);
                }
                catch (Exception ex)
                {
                    toastService.ShowWarning("File:" + file.Name + ", Error: " + ex.Message);
                    //    file.Name, ex.Message);
                    //Logger.LogError("File: {Filename} Error: {Error}", 
                    //    file.Name, ex.Message);
                }
            }

            isLoading = false;
            StateHasChanged();
        }
        private void LoadFiles(InputFileChangeEventArgs e)
        {
            StateHasChanged();
            isLoadingID = true;
            loadedFileIDs.Clear();
            StateHasChanged();
            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                try
                {
                    loadedFileIDs.Add(file);
                }
                catch (Exception ex)
                {
                    toastService.ShowWarning("File:" + file.Name + ", Error: " + ex.Message);
                    //    file.Name, ex.Message);
                    //Logger.LogError("File: {Filename} Error: {Error}", 
                    //    file.Name, ex.Message);
                }
            }

            isLoadingID = false;
            StateHasChanged();
        }
        private void LoadReceiveFiles(InputFileChangeEventArgs e)
        {
            StateHasChanged();
            isLoadingRe = true;
            loadedReFileIDs.Clear();
            StateHasChanged();
            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                try
                {
                    loadedReFileIDs.Add(file);
                }
                catch (Exception ex)
                {
                    toastService.ShowWarning("File:" + file.Name + ", Error: " + ex.Message);
                    //    file.Name, ex.Message);
                    //Logger.LogError("File: {Filename} Error: {Error}", 
                    //    file.Name, ex.Message);
                }
            }

            isLoadingRe = false;
            StateHasChanged();
        }
        private void LoadFileSOFs(InputFileChangeEventArgs e)
        {
            StateHasChanged();
            isLoadingISOF = true;
            loadedFileSOFs.Clear();
            StateHasChanged();
            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                try
                {
                    loadedFileSOFs.Add(file);
                }
                catch (Exception ex)
                {
                    toastService.ShowWarning("File:" + file.Name + ", Error: " + ex.Message);
                    //Logger.LogError("File: {Filename} Error: {Error}", 
                    //    file.Name, ex.Message);
                }
            }

            isLoadingISOF = false;
            StateHasChanged();
        }
        private async Task<bool> ValidateAddBank()
        {
            StateHasChanged();
            bool result = true;
            bool focus = true;
            if (string.IsNullOrEmpty(modelAddBank.BANK_NAME))
            {
                result = false;
                C_BankName = backerror;
                toastService.ShowWarning("Enter Bank Name");
                await E_BankName.FocusAsync();
                focus = false;
            }
            else
            {
                C_BankName = back;
            }
            if (string.IsNullOrEmpty(modelAddBank.AccountNo))
            {
                result = false;
                C_AccountNo = backerror;
                toastService.ShowWarning("Enter Account No");
                await E_AccountNo.FocusAsync();
                focus = false;
            }
            else
            {
                C_AccountNo = back;
            }
            if (modelAddBank.BankID.ToUpper().Contains("SELECT ONE"))
            {
                result = false;
                C_BankCode = backerror;
                toastService.ShowWarning("Select Bank");
                if (focus)
                {
                    await E_BankCode.FocusAsync();
                    focus = false;
                }
            }
            else
            {
                C_BankCode = back;
            }
            if (model.ToCountry == "CN" || model.ToCountry == "HK")
            {
                //if (modelAddBank.MainBank.ToUpper().Contains("SELECT ONE"))
                //{
                //    result = false;
                //    C_MainBank = backerror;
                //    toastService.ShowWarning("Select Main Bank");
                //    if (focus)
                //    {
                //        await E_MainBank.FocusAsync();
                //        focus = false;
                //    }
                //}
                //else
                //{
                //    C_MainBank = back;
                //}
                if(string.IsNullOrEmpty(modelAddBank.bankCity))
                {
                    result = false;
                    C_BankCity = backerror;
                    toastService.ShowWarning("Select City");
                    if (focus)
                    {
                        await E_BankCity.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (modelAddBank.bankCity.ToUpper().Contains("SELECT ONE"))
                    {
                        result = false;
                        C_BankCity = backerror;
                        toastService.ShowWarning("Select City");
                        if (focus)
                        {
                            await E_BankCity.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankAddress = back;
                    }
                }
               
                if (string.IsNullOrEmpty(modelAddBank.Province))
                {
                    result = false;
                    C_BankProvince = backerror;
                    toastService.ShowWarning("Select Province");
                    if (focus)
                    {
                        await E_BankAddress.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (modelAddBank.Province.ToUpper().Contains("SELECT ONE"))
                    {
                        result = false;
                        C_BankProvince = backerror;
                        toastService.ShowWarning("Select Province");
                        if (focus)
                        {
                            await E_BankAddress.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankProvince = back;
                    }
                }
                if (string.IsNullOrEmpty(modelAddBank.City))
                {
                    result = false;
                    C_BankCity = backerror;
                    toastService.ShowWarning("Select City");
                    if (focus)
                    {
                        await E_BankCity.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (modelAddBank.City.ToUpper().Contains("SELECT ONE"))
                    {
                        result = false;
                        C_BankCity = backerror;
                        toastService.ShowWarning("Select City");
                        if (focus)
                        {
                            await E_BankCity.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankCity = back;
                    }
                }
            }
            StateHasChanged();
            return result;
        }
        private async Task<bool> ValidateDeleteBank()
        {
            StateHasChanged();
            bool result = true;
            bool focus = true;
            if (string.IsNullOrEmpty(modelEditBank.AccountNo))
            {
                result = false;
                C_AccountNo = backerror;
                toastService.ShowWarning("Enter Account No");
                await E_AccountNo.FocusAsync();
                focus = false;
            }
            else
            {
                C_AccountNo = back;
            }
            if (modelEditBank.BankID.ToUpper().Contains("SELECT ONE"))
            {
                result = false;
                C_BankCode = backerror;
                toastService.ShowWarning("Select Bank");
                if (focus)
                {
                    await E_BankCode.FocusAsync();
                    focus = false;
                }
            }
            else
            {
                C_BankCode = back;
            }
           

            StateHasChanged();
            return result;
        }
        private async Task<bool> ValidateUpdateBank()
        {
            StateHasChanged();
            bool result = true;
            bool focus = true;
            if (string.IsNullOrEmpty(modelEditBank.BANK_NAME))
            {
                result = false;
                C_BankName = backerror;
                toastService.ShowWarning("Enter Bank Name");
                await E_BankName.FocusAsync();
                focus = false;
            }
            else
            {
                C_BankName = back;
            }
            if (string.IsNullOrEmpty(modelEditBank.AccountNo))
            {
                result = false;
                C_AccountNo = backerror;
                toastService.ShowWarning("Enter Account No");
                await E_AccountNo.FocusAsync();
                focus = false;
            }
            else
            {
                C_AccountNo = back;
            }
            if (modelEditBank.BankID.ToUpper().Contains("SELECT ONE"))
            {
                result = false;
                C_BankCode = backerror;
                toastService.ShowWarning("Select Bank");
                if (focus)
                {
                    await E_BankCode.FocusAsync();
                    focus = false;
                }
            }
            else
            {
                C_BankCode = back;
            }
            if (model.ToCountry == "CN" || model.ToCountry == "HK")
            {
                //if (modelAddBank.MainBank.ToUpper().Contains("SELECT ONE"))
                //{
                //    result = false;
                //    C_MainBank = backerror;
                //    toastService.ShowWarning("Select Main Bank");
                //    if (focus)
                //    {
                //        await E_MainBank.FocusAsync();
                //        focus = false;
                //    }
                //}
                //else
                //{
                //    C_MainBank = back;
                //}
                if (string.IsNullOrEmpty(modelEditBank.bankCity))
                {
                    result = false;
                    C_BankCity = backerror;
                    toastService.ShowWarning("Select City");
                    if (focus)
                    {
                        await E_BankCity.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (modelEditBank.bankCity.ToUpper().Contains("SELECT ONE"))
                    {
                        result = false;
                        C_BankCity = backerror;
                        toastService.ShowWarning("Select City");
                        if (focus)
                        {
                            await E_BankCity.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankCity = back;
                    }
                }
                
                if (string.IsNullOrEmpty(modelEditBank.Province))
                {
                    result = false;
                    C_BankProvince = backerror;
                    toastService.ShowWarning("Select Province");
                    if (focus)
                    {
                        await E_BankAddress.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (modelEditBank.Province.ToUpper().Contains("SELECT ONE"))
                    {
                        result = false;
                        C_BankProvince = backerror;
                        toastService.ShowWarning("Select Province");
                        if (focus)
                        {
                            await E_BankAddress.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankProvince = back;
                    }
                }
               
                if (string.IsNullOrEmpty(modelEditBank.City))
                {
                    result = false;
                    C_BankCity = backerror;
                    toastService.ShowWarning("Select City");
                    if (focus)
                    {
                        await E_BankCity.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (modelEditBank.City.ToUpper().Contains("SELECT ONE"))
                    {
                        result = false;
                        C_BankCity = backerror;
                        toastService.ShowWarning("Select City");
                        if (focus)
                        {
                            await E_BankCity.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankCity = back;
                    }
                }
               
            }


            StateHasChanged();
            return result;
        }
        private async Task<bool> ValidateIdology()
        {
            bool result = true;
            string ID = "";
            string ID_BK = "";
            string SSN = "";
            string SSN_BK = "";
            string MDOB = "";
            string YDOB = "";
            ID = (model.ID == null ? "" : model.ID);
            ID_BK = (model.ID_BK == null ? "" : model.ID_BK);
            SSN = (model.SSN == null ? "" : model.SSN);
            SSN_BK = (model.SSN_BK == null ? "" : model.SSN_BK);
            if(string.IsNullOrEmpty(ID_BK))
            {
                ID_BK = ID;
            }
            if (string.IsNullOrEmpty(SSN_BK))
            {
                SSN_BK = SSN;
            }
            if (!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(ID_BK) && !model.CheckID
                && model.IDType == "DL" && model.CountryIssue == "US")
            {
                MDOB = model.DOB.ToString().Substring(0, 2);
                YDOB = model.DOB.ToString().Substring(6, 4);
                if (MDOB.Length == 1)
                {
                    MDOB = "0" + MDOB;
                }
                dynamic payload = new
                {
                    UserID = model.UserID,
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "CheckIdologyID",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    CUST_ID = model.CustID,
                    FIRSTNAME = model.SFirstName,
                    LASTNAME = model.SLastName,
                    ADDRESS = model.SAddress,
                    CITY = model.SCity,
                    STATE = model.SState,
                    ZIP_CODE = model.SZipcode,
                    DOB_BK = model.DOB,
                    DRIVER_ID_BK = ID_BK,
                    STATE_ISSUE = model.StateIssue,
                    SSN = SSN_BK
                };
                CheckIdologyResponse Resp = await HttpService.Post<CheckIdologyResponse>("/Transaction/CheckIdologyID", payload);
                if (Resp.Status == 200)
                {
                    model.messageVerifyID = Resp.Content.ToString().ToUpper();
                }
                else
                {
                    result = false;
                    model.messageVerifyID = Resp.Message.ToString().ToUpper();
                }
                if (model.messageVerifyID.Contains("PASS") || string.IsNullOrEmpty(model.messageVerifyID))
                {
                    model.CheckID = true;
                    displaymessageVerifyID = "initial";
                }
                else
                {
                    displaymessageVerifyID = "initial";
                    toastService.ShowWarning(model.messageVerifyID);
                    result = false;
                    model.CheckID = false;
                }
                StateHasChanged();
            }
            if (result)
            {
                if (!string.IsNullOrEmpty(SSN) && !string.IsNullOrEmpty(SSN_BK) 
                    && !model.CheckSSN)
                {
                    MDOB = model.DOB.ToString().Substring(0, 2);
                    YDOB = model.DOB.ToString().Substring(6, 4);
                    if (MDOB.Length == 1)
                    {
                        MDOB = "0" + MDOB;
                    }
                    dynamic payload = new
                    {
                        UserID = model.UserID,
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "CheckIdologySSN",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        CUST_ID = model.CustID,
                        FIRSTNAME = model.SFirstName,
                        LASTNAME = model.SLastName,
                        ADDRESS = model.SAddress,
                        CITY = model.SCity,
                        STATE = model.SState,
                        ZIP_CODE = model.SZipcode,
                        DOB_BK = model.DOB,
                        DRIVER_ID_BK = ID_BK,
                        STATE_ISSUE = model.StateIssue,
                        SSN = SSN_BK
                    };
                    CheckIdologyResponse Resp = await HttpService.Post<CheckIdologyResponse>("/Transaction/CheckIdologySSN", payload);
                    if (Resp.Status == 200)
                    {
                        model.messageVerifySSN = Resp.Content.ToString().ToUpper();
                    }
                    else
                    {
                        result = false;
                        model.messageVerifySSN = Resp.Message.ToString().ToUpper();
                    }
                    if (model.messageVerifySSN.Contains("PASS") || string.IsNullOrEmpty(model.messageVerifySSN))
                    {
                        model.CheckSSN = true;
                        displaymessageVerifySSN = "initial";
                    }
                    else
                    {
                        displaymessageVerifySSN = "initial";
                        toastService.ShowWarning(model.messageVerifySSN);
                        result = false;
                        model.CheckSSN = false;
                    }
                    StateHasChanged();
                }
            }
            return result;
        }
        private async Task<bool> ValidateCreditLine()
        {
            bool result = true;
            prompMsg = "";
            bool focus = true;
            double Amount = 0;
            double.TryParse(model.TotalAmount == null ? "0" : model.TotalAmount.ToString(), out Amount);
            if (Amount>0)
            {
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "GetCreditLine",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    AgentID = model.AgentID,
                    Amount = Amount,
                    AmountOld = 0
                };
                CreditLineAllResponse Resp = await HttpService.Post<CreditLineAllResponse>("/Customer/GetCreditLine", payload);
                if (Resp.Status != 200)
                {
                    result = false;
                    toastService.ShowWarning("Not enough Credit Line !");
                }
            }
           
            return result;
        }
        private async Task<bool> ValidateDuplicate()
        {
            bool result = true;
            prompMsg = "";
            bool focus = true;
            string ID = "";
            string ID_BK = "";
            string SSN = "";
            string SSN_BK = "";
            ID = (model.ID == null ? "" : model.ID);
            ID_BK = (model.ID_BK == null ? "" : model.ID_BK);
            SSN = (model.SSN == null ? "" : model.SSN);
            SSN_BK = (model.SSN_BK == null ? "" : model.SSN_BK);
            string SDOB = "";
            string SISSUEDATE = "";
            string SEXPIREDATE = "";
            if (!string.IsNullOrEmpty(ID) && ID != ID_BK)
            {
                if (ID.ToUpper().Contains("XX") && !string.IsNullOrEmpty(ID_BK))
                {
                    ID = ID_BK;
                }
                if(!string.IsNullOrEmpty(ID))
                {
                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "CheckDuplicateID",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        CUST_ID = model.CustID,
                        DRIVER_ID = ID
                    };
                    duplicateAllResponse Resp = await HttpService.Post<duplicateAllResponse>("/Customer/CheckDuplicateID", payload);
                    if (Resp.Status == 200)
                    {
                        result = false;
                        toastService.ShowWarning("Please check Driver ID that is the same of the other ones.");
                    }
                }
                
            }
            if (!string.IsNullOrEmpty(SSN) && SSN != SSN_BK)
            {
                if(SSN.ToUpper().Contains("XX") && !string.IsNullOrEmpty(SSN_BK))
                {
                    SSN = SSN_BK;
                }
                if (!string.IsNullOrEmpty(SSN))
                {
                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "CheckDuplicateSSN",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        CUST_ID = model.CustID,
                        SSN = SSN
                    };
                    duplicateAllResponse Resp = await HttpService.Post<duplicateAllResponse>("/Customer/CheckDuplicateSSN", payload);
                    if (Resp.Status == 200)
                    {
                        result = false;
                        toastService.ShowWarning("Please check SSN that is the same of the other ones.");
                    }
                }
            }
            if (isNewCustomer)
            {
                if (!string.IsNullOrEmpty(model.SPhone) && !string.IsNullOrEmpty(model.SAddress)
                    && !string.IsNullOrEmpty(model.SLastName) && !string.IsNullOrEmpty(model.SFirstName)
                    && !string.IsNullOrEmpty(model.SZipcode))
                {
                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New CheckDuplicateProfile",
                        Action = "CheckDuplicatePhone",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        CUST_ID = model.CustID,
                        LASTNAME = model.SLastName,
                        FIRSTNAME = model.SFirstName,
                        MIDDLENAME = model.SMiddleName,
                        ADDRESS = model.SAddress.Trim(),
                        ZIP_CODE = model.SZipcode,
                        PHONE1 = model.SPhone.Replace("-", ""),
                        DOB = model.DOB,
                        DOB_BK = model.DOB_BK,
                    };
                    duplicateAllResponse Resp = await HttpService.Post<duplicateAllResponse>("/Customer/CheckDuplicateProfile", payload);
                    if (Resp.Status == 200)
                    {
                        result = false;
                        toastService.ShowWarning("Duplicate profile. ");
                    }
                }

                if (!string.IsNullOrEmpty(model.SPhone))
                {
                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "CheckDuplicatePhone",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        CUST_ID = model.CustID,
                        LASTNAME = model.SLastName,
                        FIRSTNAME = model.SFirstName,
                        MIDDLENAME = model.SMiddleName,
                        ADDRESS = model.SAddress.Trim(),
                        ZIP_CODE = model.SZipcode,
                        PHONE1 = model.SPhone.Replace("-","")
                    };
                    duplicateAllResponse Resp = await HttpService.Post<duplicateAllResponse>("/Customer/CheckDuplicatePhone", payload);
                    if (Resp.Status == 200)
                    {
                        result = false;
                        toastService.ShowWarning("Please check the sender phone that is the same of the other ones.");
                    }
                    else
                    {
                        if (Resp.Status == 12)
                        {
                            result = false;
                            toastService.ShowWarning(Resp.Message==null?"Customer Profile is blocked": Resp.Message);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(model.SAddress))
                {
                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Customer/CheckAddress",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        CUST_ID = model.CustID,
                        LASTNAME = model.SLastName,
                        FIRSTNAME = model.SFirstName,
                        ADDRESS = model.SAddress.Trim(),
                        ZIP_CODE = model.SZipcode,
                        PHONE1 = model.SPhone.Replace("-", "")
                    };
                    duplicateAllResponse Resp = await HttpService.Post<duplicateAllResponse>("/Customer/CheckAddress", payload);
                    if (Resp.Status == 200)
                    {
                        result = false;
                        toastService.ShowWarning("Please check the sender Address that is the same of the other ones.");
                    }
                }

            }
            
            if (model.DOB != null)
            {
                SDOB =Convert.ToDateTime(model.DOB).ToString("MM/dd/yyyy");
                if (SDOB.Length > 10)
                {
                    SDOB = SDOB.Substring(0, 10);
                }
                if (clsFunction.ValidStringDate(SDOB))
                {
                    System.DateTime DOB = System.DateTime.Parse(model.DOB.ToString());
                    if (DOB > System.DateTime.UtcNow.AddHours(-7).AddYears(-15) || DOB <= System.DateTime.UtcNow.AddHours(-7).AddYears(-100))
                    {
                        C_DOB = backerror;
                        result = false;
                        toastService.ShowWarning("Check DOB. DOB is wrong");
                    }
                    else
                    {
                        C_DOB = back;
                    }
                }
                else
                {
                    C_DOB = backerror;
                    result = false;
                    toastService.ShowWarning("DOB is wrong");
                }
            }
            if (model.IssueDate != null)
            {
                SISSUEDATE =  Convert.ToDateTime(model.IssueDate).ToString("MM/dd/yyyy");
                if (SISSUEDATE.Length > 10)
                {
                    SISSUEDATE = SISSUEDATE.Substring(0, 10);
                }
                if (clsFunction.ValidStringDate(SISSUEDATE))
                {
                    C_IssueDate = backerror;
                    System.DateTime IssueDate = System.DateTime.Parse(model.IssueDate.ToString());
                    if (IssueDate > System.DateTime.UtcNow.AddHours(-7))
                    {
                        result = false;
                        toastService.ShowWarning("Check Issue Date. Issue Date is wrong");
                    }
                    else
                    {
                        C_IssueDate = back;
                    }
                }
                else
                {
                    C_IssueDate = backerror;
                    result = false;
                    toastService.ShowWarning("Issue Date is wrong");
                }
            }
            if (model.ExpireDate != null)
            {

                SEXPIREDATE =  Convert.ToDateTime(model.ExpireDate).ToString("MM/dd/yyyy");
                if (SEXPIREDATE.Length > 10)
                {
                    SEXPIREDATE = SEXPIREDATE.Substring(0, 10);
                }
                if (clsFunction.ValidStringDate(SEXPIREDATE))
                {
                    System.DateTime ExpireDate = System.DateTime.Parse(model.ExpireDate.ToString());
                    if (ExpireDate < System.DateTime.UtcNow.AddHours(-7))
                    {
                        C_ExpireDate = backerror;
                        result = false;
                        toastService.ShowWarning("Check Expire Date. Expire Date is wrong");
                    }
                    else
                    {
                        C_ExpireDate = back;
                    }
                }
                else
                {
                    C_ExpireDate = backerror;
                    result = false;
                    toastService.ShowWarning("Expire Date is wrong");
                }
            }
            if (model.Duplicate==false)
            {
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Transaction/CheckDuplicateTransaction",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    B_CUST_ID = model.BCustID,
                    AGENT_ID = model.AgentID,
                    UserID = model.UserID,
                    CUST_ID = model.CustID,
                    LASTNAME = model.SLastName,
                    FIRSTNAME = model.SFirstName,
                    ADDRESS = model.SAddress.Trim(),
                    ZIP_CODE = model.SZipcode,
                    PHONE1 = model.SPhone.Replace("-", ""),
                    B_LASTNAME = model.RLastName,
                    B_FIRSTNAME = model.RFirstName,
                    B_ADDRESS = model.RAddress.Trim(),
                    B_PHONE1 = model.RPhone.Replace("-", ""),
                    AMOUNT = model.SendAmount
                };
                duplicateResponse Resp = await HttpService.Post<duplicateResponse>("/Transaction/CheckDuplicateTransaction", payload);
                if (Resp.Status == 200 && Resp.Content.duplicateList.Count>0)
                {
                    duptransaction = Resp.Content.duplicateList;
                    result = false;
                    ViewDuplicate = true;
                    toastService.ShowWarning("Please check the transaction that is the same of the other ones.");
                }
                else
                {
                    duptransaction = new List<dupTransaction>();
                    ViewDuplicate = false;
                }

            }
            return result;
        }
        private async void AggregationList()
        {
            SenderAddressList = new List<ReportDetail>();
            SenderPhoneList = new List<ReportDetail>();
            ReceiverLocalNameList = new List<ReportDetail>();
            ReceiverAddressList = new List<ReportDetail>();
            ReceiverPhoneList = new List<ReportDetail>();
            ReceiverBankAccountList = new List<ReportDetail>();
            ReceiverIDList = new List<ReportDetail>();
            SenderNameList = new List<ReportDetail>();
            SenderCustIDList = new List<ReportDetail>();
            StateHasChanged();
            dynamic payload = new
            {
                UserID = model.UserID,
                TRANS_ID = model.TransID,
                CUST_ID = model.CustID,
                LASTNAME = model.SLastName,
                FIRSTNAME = model.SFirstName,
                DOB = model.DOB,
                DOB_BK = model.DOB_BK,
                PASSPORT_NO = model.RID,
                STATE_ISSUE = model.StateIssue,
                ADDRESS = model.SAddress,
                CITY = model.SCity,
                STATE = model.SState,
                ZIP_CODE = model.SZipcode,
                COUNTRY = model.FromCountry,
                FROMCOUNTRY = model.FromCountry,
                TOCOUNTRY = model.ToCountry,
                PHONE1 = model.SPhone,
                SSN_BK = model.SSN_BK,
                SSN = model.SSN,
                DRIVER_ID = model.ID,
                DRIVER_ID_BK = model.ID_BK,
                TOTAL_AMT_USD = model.TotalAmount,
                LOCALNAME = model.RLocalName,
                B_ADDRESS = model.RAddress,
                DISTRICT = model.RCity,
                PROVINCE_ID = model.RState,
                B_PHONE1 = model.RPhone,
                B_PHONE2 = model.RPhone2,
                ACCOUNT_NO = model.AccountNo,
                AGG_CHECK0 = model.AGG_CHECK0,
                AGG_DATE0 = model.AGG_DATE0,
                AGG_CHECK1 = model.AGG_CHECK1,
                AGG_DATE1 = model.AGG_DATE1,
                AGG_CHECK2 = model.AGG_CHECK2,
                AGG_DATE2 = model.AGG_DATE2,
                AGG_CHECK3 = model.AGG_CHECK3,
                AGG_DATE3 = model.AGG_DATE3,
                AGG_CHECK4 = model.AGG_CHECK4,
                AGG_DATE4 = model.AGG_DATE4,
                AGG_CHECK5 = model.AGG_CHECK5,
                AGG_DATE5 = model.AGG_DATE5,
                AGG_CHECK6 = model.AGG_CHECK6,
                AGG_DATE6 = model.AGG_DATE6,
                AGG_CHECK7 = model.AGG_CHECK7,
                AGG_DATE7 = model.AGG_DATE7,
                AGG_CHECK8 = model.AGG_CHECK8,
                AGG_DATE8 = model.AGG_DATE8,
                AGG_CHECK9 = model.AGG_CHECK9,
                AGG_DATE9 = model.AGG_DATE9,
                AGG_CHECK10 = model.AGG_CHECK10,
                AGG_DATE10 = model.AGG_DATE10,
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Transaction/getAggregationList",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
            };
            aggregationListResponse Resp = await HttpService.Post<aggregationListResponse>("/Transaction/getAggregationList", payload);
            if (Resp.Status == 200)
            {
                if (Resp.Content != null)
                {
                    ViewAggList = true;
                    SenderAddressList = Resp.Content.SenderAddressList;
                    SenderPhoneList = Resp.Content.SenderPhoneList;
                    ReceiverAddressList = Resp.Content.ReceiverAddressList;
                    ReceiverPhoneList = Resp.Content.ReceiverPhoneList;
                    ReceiverBankAccountList = Resp.Content.ReceiverBankAccountList;
                    ReceiverLocalNameList = Resp.Content.ReceiverLocalNameList;
                    ReceiverIDList = Resp.Content.ReceiverIDList;
                    SenderNameList = Resp.Content.SenderNameList;
                    SenderCustIDList = Resp.Content.SenderCustIDList;
                   
                }
               
            }
            StateHasChanged();
        }
        private async Task<bool> ValidateCN()
        {
            bool result = true;
            prompMsg = "";
            bool focus = true;
            string RID = model.RID == null ? "" : model.RID.Trim();
            string RPhone = model.RPhone == null ? "" : model.RPhone.Trim();
            if (model.BankID == "0" || model.BankID.ToUpper() == "SELECT BANK")
            {
                result = false;
                C_SelectAccount = backerror;
                toastService.ShowWarning("Select Bank");
                if (focus)
                {
                    await E_SelectAccount.FocusAsync();
                    focus = false;
                }

            }
            else
            {
                C_SelectAccount = back;
            }
            if (string.IsNullOrEmpty(model.ReasonforSending))
            {
                result = false;
                C_ReasonforSending = backerror;
                toastService.ShowWarning("Enter Reason for Sending");
                if (focus)
                {
                    await E_ReasonforSending.FocusAsync();
                    focus = false;
                }
            }
            else
            {
                C_ReasonforSending = back;
            }
            if (string.IsNullOrEmpty(model.RLocalName))
            {
                result = false;
                C_RLocalName = backerror;
                toastService.ShowWarning("Enter Local Name");
                if (focus)
                {
                    await E_RLocalName.FocusAsync();
                    focus = false;
                }
            }

            if (string.IsNullOrEmpty(RID))
            {
                result = false;
                C_RID = backerror;
                toastService.ShowWarning("Enter Receiver ID");
                if (focus)
                {
                    await E_RID.FocusAsync();
                    focus = false;
                }
            }
            else
            {
                if (RID.ToString().Length != 22)
                {
                    result = false;
                    C_RID = backerror;
                    toastService.ShowWarning("Check Receiver ID");
                    if (focus)
                    {
                        await E_RID.FocusAsync();
                        focus = false;
                    }
                }
            }
            if (model.DOB == null)
            {
                DOBBackground = "did-floating-inputError";
                result = false;
                toastService.ShowWarning("Enter DOB");
            }
            else
            {
                DOBBackground = "did-floating-input";
            }
            if (string.IsNullOrEmpty(RPhone))
            {
                result = false;
                C_RPhone = backerror;
                toastService.ShowWarning("Enter Receiver Phone");
                if (focus)
                {
                    await E_RPhone.FocusAsync();
                    focus = false;
                }
            }
            else
            {
                if (RPhone.Length != 11)
                {
                    result = false;
                    C_RPhone = backerror;
                    toastService.ShowWarning("Check Receiver Phone. Receiver Phone is 11 numbers");
                    if (focus)
                    {
                        await E_RPhone.FocusAsync();
                        focus = false;
                    }
                }
            }
            return result;
        }
        private async Task<bool> ValidatePH()
        {
            bool result = true;
            prompMsg = "";
            bool focus = true;
            if (model.PaymentAgent == "PH1-FILREMIT" && model.PaymentMode == "05")
            {
                List<SendStateList> SendStateListFilter = SendStateList.Where(x => x.PaymentAgent.Contains("PH1-FILREMIT") && x.StateCode == model.RState).ToList();
                if (SendStateListFilter.Count() == 0)
                {
                    result = false;
                    toastService.ShowWarning("Door to Door payment mode not available for this Province/State. Please select another payment mode.");
                    C_RState = backerror;
                    await E_RState.FocusAsync();
                }
                else
                {
                    C_RState = back;
                }
                List<CityModel> CityListFilter = CityList.Where(x => x.PaymentAgent.Contains("PH1-FILREMIT") && x.StateId == model.RState && x.City == model.RCity).ToList();
                if (CityListFilter.Count() == 0)
                {
                    result = false;
                    toastService.ShowWarning("Door to Door payment mode not available for this City/District. Please select another payment mode.");
                    C_RCity = backerror;
                    await E_RCity.FocusAsync();
                }
                else
                {
                    C_RCity = back;
                }
            }
            if (model.PaymentAgent == "PH2-METRO" && model.PaymentMode == "CHD" && result)
            {
                List<SendStateList> SendStateListFilter = SendStateList.Where(x => x.PaymentAgent.Contains("PH2-METRO") && x.StateCode == model.RState).ToList();
                if (SendStateListFilter.Count() == 0)
                {
                    result = false;
                    toastService.ShowWarning("Door to Door payment mode not available for this Province/State. Please select another payment mode.");
                    C_RState = backerror;
                    await E_RState.FocusAsync();
                }
                else
                {
                    C_RState = back;
                }
            }
            if (AuthService.userMTRedSun.methodBankList.Contains(model.PaymentMode))
            {
                List<BankList> BankListFilter = BankList.Where(x => x.BANK_CODE == model.BankCode && x.BANK_ADDRESS.Contains(model.PaymentAgent)).ToList();
                if (BankListFilter.Count() == 0)
                {
                    result = false;
                    toastService.ShowWarning("Bank name does not exist, out of services. Please choose bank name on the list.");
                    C_BankCode = backerror;
                    await E_BankCode.FocusAsync();
                }
                else
                {
                    C_BankCode = back;
                }
            }

            //if (ddlDestinationCountry.SelectedValue.ToString() == "PH" && (ddlPaymentAgent.SelectedValue.ToString() == "PH1-FILREMIT" || ddlPaymentAgent.SelectedValue.ToString() == "PH2-METRO"))
            //{
            //    var sc = from s in db.tblTranTypes
            //             where s.TRAN_TYPE == ddlTypeDeliver.SelectedValue.ToString()
            //             && s.BANK == true
            //             select s;
            //    if (sc.Count() > 0)
            //    {
            //        var bk = from b in db.tblBANKs
            //                 where b.SWIFTCODE == txtSwiftCode.Text
            //                 && b.BANK_ADDRESS.Contains(ddlPaymentAgent.SelectedValue.ToString())
            //                 select b;
            //        if (bk.Count() == 0)
            //        {
            //            error++;
            //            prompMsg += "Bank name does not exist, out of services. Please choose bank name on the list.";
            //            this.ddlBank.BackColor = Color.Yellow;
            //        }

            //    }
            //}

            return result;
        }
        private async Task<bool> Validate()
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"['~`!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            var AhasSymbols = new Regex(@"['~`#!@$%^&*()_+=\[{\]};:<>|./?,-]");
            var hasPhone = new Regex(@"^\(?([2-9][0-8][0-9])\)?[-.●]?([2-9][0-9]{2})[-.●]?([0-9]{4})$");
           
            StateHasChanged();
            bool result = true;
            bool resultS = true;
            bool resultR = true;
            bool resultB = true;
            bool focus = true;
            KYCAmountNew = 0;
            i = 0;
            reason = "";
            travesof = true;
            travessn = true;
            trave = true;
            prompMsg = "";
            erragg = 0;
            errorint = 0;
            model.CheckID = false;
            model.CheckSSN = false;
            model.checkmaxamount = false;
            StateHasChanged();
            model.AGG_TYPE = "";
            string DOB = "";
          
            try
            {
                if (!string.IsNullOrEmpty(model.ID))
                {
                    model.ID = model.ID.Replace(".", "").Replace("-", "");
                }
                StateHasChanged();
                resultS = await ValidateSender();
                resultR = await ValidateRecipient();
                resultB = await ValidateBank();
                if(!resultS)
                {
                    result = resultS;
                }
                if (!resultR)
                {
                    result = resultR;
                }
                if (!resultB)
                {
                    result = resultB;
                }
                //if (model.AgentState == "NY" && model.CheckAgentState == false)
                //{
                //    result = false;
                //    toastService.ShowWarning("Check ID Verification");
                //}
                if (model.ToCountry.ToUpper() == "US")
                {
                    if (string.IsNullOrEmpty(model.SecurityAnswer))
                    {
                        result = false;
                        C_SecurityAnswer = backerror;
                        toastService.ShowWarning("Enter security answer");
                        if (focus)
                        {
                            await E_SecurityAnswer.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_SecurityAnswer = back;
                    }
                }

                if (result && model.ToCountry.ToUpper() == "CN")
                {
                    result = await ValidateCN();
                }
                if (result && model.ToCountry.ToUpper() == "PH")
                {
                    result = await ValidatePH();
                }
                if (result && model.IS_BH == 1)
                {
                    result = await ValidateBehalf();
                }
                if (result)
                {
                    result = await ValidateDuplicate();
                }
                if (result)
                {
                    result = await ValidateCreditLine();
                }
                if (result)
                {
                    result = await ValidateVerify();
                }
               
                double sendamount = 0;
                double servicefee = 0;
                double totalamount = 0;
                double exchangerate = 0;
                double landamount = 0;

                double.TryParse(model.SendAmount.ToString(), out sendamount);
                if (sendamount == 0)
                {
                    result = false;
                    //D_SendAmount = true;
                    cssbackAmount = cssBackError;
                    toastService.ShowWarning("Enter Send Amount");
                    //if (focus)
                    //{
                    //    await E_SendAmount.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    //D_SendAmount = false;
                    cssbackAmount = cssBack;
                }

                double.TryParse(model.TransferFee.ToString(), out servicefee);
                if (servicefee == 0)
                {
                    result = false;
                    cssbackServiceFee = cssBackError;
                    toastService.ShowWarning("Enter Service Fee");
                    //if (focus)
                    //{
                    //    await E_TransferFee.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    cssbackServiceFee = cssBack;
                }
                
                double.TryParse(model.LandedAmount.ToString(), out landamount);
                if (landamount == 0)
                {
                    result = false;
                    cssbackAmount = cssBackError;
                    toastService.ShowWarning("Enter Landed Amount");
                    //if (focus)
                    //{
                    //    await E_LandedAmount.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    cssbackAmount = cssBack;
                }
                double.TryParse(model.ExchangeRate.ToString(), out exchangerate);
                if (exchangerate == 0)
                {
                    result = false;
                    //C_ExchangeRate = backerror;
                    toastService.ShowWarning("Enter Exchange Rate");
                    //if (focus)
                    //{
                    //    await E_ExchangeRate.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    //C_ExchangeRate = back;
                }
                double.TryParse(model.TotalAmount.ToString(), out totalamount);
                if (totalamount == 0)
                {
                    result = false;
                    //C_TotalAmount = backerror;
                    toastService.ShowWarning("Enter Total Amount");
                    //if (focus)
                    //{
                    //    await E_TotalAmount.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    //C_TotalAmount = back;
                }
                StateHasChanged();


                if (result)
                {
                    dynamic payload = new
                    {
                        UserID = model.UserID,
                        TRANS_ID = model.TransID,
                        AGENT_ID = model.AgentID,
                        AgentID = model.AgentID,
                        CUST_ID = model.CustID,
                        PASSPORT_NO = model.RID,
                        STATE_ISSUE = model.StateIssue,
                        ADDRESS = model.SAddress.Trim(),
                        CITY = model.SCity,
                        STATE = model.SState,
                        ZIP_CODE = model.SZipcode,
                        COUNTRY = model.FromCountry,
                        FROMCOUNTRY = model.FromCountry,
                        TOCOUNTRY = model.ToCountry,
                        PHONE1 = model.SPhone,
                        SSN_BK = model.SSN_BK,
                        SSN = model.SSN,
                        DRIVER_ID = model.ID,
                        DRIVER_ID_BK = model.ID_BK,
                        TOTAL_AMT_USD = model.TotalAmount,
                        LOCALNAME = model.RLocalName,
                        B_ADDRESS = model.RAddress.Trim(),
                        DISTRICT = model.RCity,
                        PROVINCE_ID = model.RState,
                        B_PHONE1 = model.RPhone,
                        B_PHONE2 = model.RPhone2,
                        ACCOUNT_NO = model.AccountNo,
                        FIRSTNAME = model.SFirstName,
                        LASTNAME = model.SLastName,
                        DOB = model.DOB,
                        COUNTRY_ISSUE=model.CountryIssue,
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Transaction/getCheckAggregation",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    };
                    //tam khoa
                    aggregationResponse Resp = await HttpService.Post<aggregationResponse>("/Transaction/getCheckAggregation", payload);
                    if (Resp.Status == 200)
                    {
                        if (Resp.Content != null)
                        {
                            if (Resp.Content.aggregationList.Count > 0)
                            {
                                model.KYC = true;
                                model.Agg = true;
                                List<aggregationModel> aggregationListNOID = new List<aggregationModel>();
                                List<aggregationModel> aggregationListID = new List<aggregationModel>();
                                List<aggregationModel> aggregationListSOF = new List<aggregationModel>();
                                List<aggregationModel> aggregationListNOSSN = new List<aggregationModel>();
                                aggregationListNOSSN = Resp.Content.aggregationList.Where(x => x.LOAI.ToUpper().Contains("AGG") && x.LOAI.ToUpper().Contains("_NOSSN")).ToList();
                                aggregationListNOID = Resp.Content.aggregationList.Where(x => x.LOAI.ToUpper().Contains("AGG") && x.LOAI.ToUpper().Contains("_NOID")).ToList();
                                aggregationListID = Resp.Content.aggregationList.Where(x => x.LOAI.ToUpper().Contains("AGG") && !x.LOAI.ToUpper().Contains("_NO")).ToList();
                                aggregationListSOF = Resp.Content.aggregationList.Where(x => x.LOAI.ToUpper().Contains("SOF")).ToList();
                                i = 0;
                                if (aggregationListID.Count > 0)
                                {
                                    foreach (var item in aggregationListID)
                                    {
                                        reason = "";
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.MaxAmount))
                                        {
                                            model.checkmaxamount = true;
                                            result = false;
                                        }
                                        //if (i == 0)
                                        //{
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                        {
                                            KYCAmountNew = Convert.ToDouble(item.Amount);
                                        }
                                        else
                                        {
                                            KYCAmountNew = Convert.ToDouble(item.KYCFolder);
                                        }
                                        //}
                                        //if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                        //{
                                        //    trave = false;
                                        //}
                                        //if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.SSNAmount))
                                        //{
                                        //    travessn = false;
                                        //}
                                        if (reason == "")
                                        {
                                            

                                            if (Convert.ToInt32(item.OptionDate == null ? "0" : item.OptionDate) == 1)
                                            {
                                                reason += item.TYPE + " in " + item.OptionDate + " day ";
                                            }
                                            else
                                            {
                                                reason += item.TYPE + " in " + item.OptionDate + " days ";
                                            }

                                            if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                            {
                                                switch (item.TYPE.ToUpper())
                                                {
                                                    case "SENDERNAME":
                                                        model.AGG_CHECK0 = true;                                                        
                                                        if(Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate)> model.AGG_DATE0)
                                                        {
                                                            model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "CUST_ID":
                                                        model.AGG_CHECK10 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE10)
                                                        {
                                                            model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                       // model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        break;
                                                    case "SENDERADDRESS":
                                                        model.AGG_CHECK1 = true;
                                                        //model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE1)
                                                        {
                                                            model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERPHONE":
                                                        model.AGG_CHECK2 = true;
                                                        //model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE2)
                                                        {
                                                            model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERID":
                                                        model.AGG_CHECK3 = true;
                                                        //model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE3)
                                                        {
                                                            model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERSSN":
                                                        model.AGG_CHECK4 = true;
                                                        //model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE4)
                                                        {
                                                            model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "RECEIVERLOCALNAME":
                                                        model.AGG_CHECK8 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE8)
                                                        {
                                                            model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERADDRESS":
                                                        model.AGG_CHECK5 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE5)
                                                        {
                                                            model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERPHONE":
                                                        model.AGG_CHECK6 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE6)
                                                        {
                                                            model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERBANKACCOUNT":
                                                        model.AGG_CHECK7 = true;
                                                       // model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE7)
                                                        {
                                                            model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    default:
                                                        model.AGG_CHECK9 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE9)
                                                        {
                                                            model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            if (!reason.Contains(item.TYPE))
                                            {

                                                if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) == 1)
                                                {
                                                    reason += " + " + item.TYPE + " in " + Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) + " day ";
                                                }
                                                else
                                                {
                                                    reason += " + " + item.TYPE + " in " + Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) + " days ";
                                                }

                                                if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                                {
                                                    switch (item.TYPE.ToUpper())
                                                    {
                                                        case "SENDERNAME":
                                                            model.AGG_CHECK0 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE0)
                                                            {
                                                                model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "CUST_ID":
                                                            model.AGG_CHECK10 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE10)
                                                            {
                                                                model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            // model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            break;
                                                        case "SENDERADDRESS":
                                                            model.AGG_CHECK1 = true;
                                                            //model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE1)
                                                            {
                                                                model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERPHONE":
                                                            model.AGG_CHECK2 = true;
                                                            //model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE2)
                                                            {
                                                                model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERID":
                                                            model.AGG_CHECK3 = true;
                                                            //model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE3)
                                                            {
                                                                model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERSSN":
                                                            model.AGG_CHECK4 = true;
                                                            //model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE4)
                                                            {
                                                                model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "RECEIVERLOCALNAME":
                                                            model.AGG_CHECK8 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE8)
                                                            {
                                                                model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERADDRESS":
                                                            model.AGG_CHECK5 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE5)
                                                            {
                                                                model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERPHONE":
                                                            model.AGG_CHECK6 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE6)
                                                            {
                                                                model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERBANKACCOUNT":
                                                            model.AGG_CHECK7 = true;
                                                            // model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE7)
                                                            {
                                                                model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        default:
                                                            model.AGG_CHECK9 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE9)
                                                            {
                                                                model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                    }
                                                    //switch (item.TYPE.ToUpper())
                                                    //{
                                                    //    case "SENDERNAME":
                                                    //        model.AGG_CHECK0 = true;
                                                    //        model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERADDRESS":
                                                    //        model.AGG_CHECK1 = true;
                                                    //        model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERPHONE":
                                                    //        model.AGG_CHECK2 = true;

                                                    //        model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERID":
                                                    //        model.AGG_CHECK3 = true;
                                                    //        model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERSSN":
                                                    //        model.AGG_CHECK4 = true;

                                                    //        model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "RECEIVERLOCALNAME":
                                                    //        model.AGG_CHECK8 = true;
                                                    //        model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "RECEIVERADDRESS":
                                                    //        model.AGG_CHECK5 = true;

                                                    //        model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "RECEIVERPHONE":
                                                    //        model.AGG_CHECK6 = true;

                                                    //        model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "RECEIVERBANKACCOUNT":
                                                    //        model.AGG_CHECK7 = true;
                                                    //        model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "CUST_ID":
                                                    //        model.AGG_CHECK10 = true;
                                                    //        model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    default:
                                                    //        model.AGG_CHECK9 = true;
                                                    //        model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //}
                                                }
                                            }
                                        }
                                        model.KYC = true;
                                        i += 1;
                                        reason = "Aggregation over " + KYCAmountNew + " $ by " + reason + ". ";
                                       
                                        model.reasonKyc += reason;
                                    }
                                }
                                i = 0;
                                reasonView = "";
                                if (aggregationListNOID.Count > 0)
                                {
                                    reason = "";
                                    trave = false;
                                    foreach (var item in aggregationListNOID)
                                    {
                                        reason = "";
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.MaxAmount))
                                        {
                                            model.checkmaxamount = true;
                                        }
                                        //if (i == 0)
                                        //{
                                            if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                            {
                                                KYCAmountNew = Convert.ToDouble(item.Amount);
                                            }
                                            else
                                            {
                                                KYCAmountNew = Convert.ToDouble(item.KYCFolder);
                                            }
                                        //}
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                        {
                                            trave = false;
                                        }
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.SSNAmount))
                                        {
                                            travessn = false;
                                        }
                                        if (reason == "")
                                        {
                                            //if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.SSNAmount))
                                            //{
                                            //    travessn = false;
                                            //}

                                            if (Convert.ToInt32(item.OptionDate == null ? "0" : item.OptionDate) == 1)
                                            {
                                                reason += item.TYPE + " in " + item.OptionDate + " day ";
                                            }
                                            else
                                            {
                                                reason += item.TYPE + " in " + item.OptionDate + " days ";
                                            }

                                            if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                            {
                                                switch (item.TYPE.ToUpper())
                                                {
                                                    case "SENDERNAME":
                                                        model.AGG_CHECK0 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE0)
                                                        {
                                                            model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "CUST_ID":
                                                        model.AGG_CHECK10 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE10)
                                                        {
                                                            model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        // model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        break;
                                                    case "SENDERADDRESS":
                                                        model.AGG_CHECK1 = true;
                                                        //model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE1)
                                                        {
                                                            model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERPHONE":
                                                        model.AGG_CHECK2 = true;
                                                        //model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE2)
                                                        {
                                                            model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERID":
                                                        model.AGG_CHECK3 = true;
                                                        //model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE3)
                                                        {
                                                            model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERSSN":
                                                        model.AGG_CHECK4 = true;
                                                        //model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE4)
                                                        {
                                                            model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "RECEIVERLOCALNAME":
                                                        model.AGG_CHECK8 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE8)
                                                        {
                                                            model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERADDRESS":
                                                        model.AGG_CHECK5 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE5)
                                                        {
                                                            model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERPHONE":
                                                        model.AGG_CHECK6 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE6)
                                                        {
                                                            model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERBANKACCOUNT":
                                                        model.AGG_CHECK7 = true;
                                                        // model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE7)
                                                        {
                                                            model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    default:
                                                        model.AGG_CHECK9 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE9)
                                                        {
                                                            model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                }
                                                //switch (item.TYPE.ToUpper())
                                                //{
                                                //    case "SENDERNAME":
                                                //        model.AGG_CHECK0 = true;
                                                //        model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                //        break;
                                                //    case "CUST_ID":
                                                //        model.AGG_CHECK10 = true;
                                                //        model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                //        break;
                                                //    case "SENDERADDRESS":
                                                //        model.AGG_CHECK1 = true;
                                                //        model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                //        break;
                                                //    case "SENDERPHONE":
                                                //        model.AGG_CHECK2 = true;
                                                //        model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                //        break;
                                                //    case "SENDERID":
                                                //        model.AGG_CHECK3 = true;
                                                //        model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                //        break;
                                                //    case "SENDERSSN":
                                                //        model.AGG_CHECK4 = true;
                                                //        model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                //        break;
                                                //    case "RECEIVERLOCALNAME":
                                                //        model.AGG_CHECK8 = true;
                                                //        model.AGG_TYPE += "";
                                                //        model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                //        break;
                                                //    case "RECEIVERADDRESS":
                                                //        model.AGG_CHECK5 = true;
                                                //        model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                //        break;
                                                //    case "RECEIVERPHONE":
                                                //        model.AGG_CHECK6 = true;
                                                //        model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                //        break;
                                                //    case "RECEIVERBANKACCOUNT":
                                                //        model.AGG_CHECK7 = true;
                                                //        model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                //        break;
                                                //    default:
                                                //        model.AGG_CHECK9 = true;
                                                //        model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                //        break;
                                                //}
                                            }

                                        }
                                        else
                                        {
                                            if (!reason.Contains(item.TYPE))
                                            {

                                                if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) == 1)
                                                {
                                                    reason += " + " + item.TYPE + " in " + Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) + " day ";
                                                }
                                                else
                                                {
                                                    reason += " + " + item.TYPE + " in " + Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) + " days ";
                                                }

                                                if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                                {
                                                    switch (item.TYPE.ToUpper())
                                                    {
                                                        case "SENDERNAME":
                                                            model.AGG_CHECK0 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE0)
                                                            {
                                                                model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "CUST_ID":
                                                            model.AGG_CHECK10 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE10)
                                                            {
                                                                model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            // model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            break;
                                                        case "SENDERADDRESS":
                                                            model.AGG_CHECK1 = true;
                                                            //model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE1)
                                                            {
                                                                model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERPHONE":
                                                            model.AGG_CHECK2 = true;
                                                            //model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE2)
                                                            {
                                                                model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERID":
                                                            model.AGG_CHECK3 = true;
                                                            //model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE3)
                                                            {
                                                                model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERSSN":
                                                            model.AGG_CHECK4 = true;
                                                            //model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE4)
                                                            {
                                                                model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "RECEIVERLOCALNAME":
                                                            model.AGG_CHECK8 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE8)
                                                            {
                                                                model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERADDRESS":
                                                            model.AGG_CHECK5 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE5)
                                                            {
                                                                model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERPHONE":
                                                            model.AGG_CHECK6 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE6)
                                                            {
                                                                model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERBANKACCOUNT":
                                                            model.AGG_CHECK7 = true;
                                                            // model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE7)
                                                            {
                                                                model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        default:
                                                            model.AGG_CHECK9 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE9)
                                                            {
                                                                model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                    }
                                                    //switch (item.TYPE.ToUpper())
                                                    //{
                                                    //    case "SENDERNAME":
                                                    //        model.AGG_CHECK0 = true;
                                                    //        model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "CUST_ID":
                                                    //        model.AGG_CHECK10 = true;
                                                    //        model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERADDRESS":
                                                    //        model.AGG_CHECK1 = true;
                                                    //        model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERPHONE":
                                                    //        model.AGG_CHECK2 = true;
                                                    //        model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERID":
                                                    //        model.AGG_CHECK3 = true;
                                                    //        model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "SENDERSSN":
                                                    //        model.AGG_CHECK4 = true;
                                                    //        model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                    //        break;
                                                    //    case "RECEIVERLOCALNAME":
                                                    //        model.AGG_CHECK8 = true;
                                                    //        model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "RECEIVERADDRESS":
                                                    //        model.AGG_CHECK5 = true;
                                                    //        model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "RECEIVERPHONE":
                                                    //        model.AGG_CHECK6 = true;
                                                    //        model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    case "RECEIVERBANKACCOUNT":
                                                    //        model.AGG_CHECK7 = true;
                                                    //        model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //    default:
                                                    //        model.AGG_CHECK9 = true;
                                                    //        model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                    //        break;
                                                    //}
                                                }
                                            }
                                        }
                                        i += 1;
                                        reason = "Aggregation over " + KYCAmountNew + " $ by " + reason + " with No ID or the same Cust ID. ";
                                        model.reasonKyc += reason;
                                        reasonView += reason;
                                    }
                                    model.Agg = true;
                                    model.KYC = true;
                                    trave = false;
                                    
                                }
                                if (aggregationListNOSSN.Count > 0)
                                {
                                    reason = "";
                                    trave = false;
                                    foreach (var item in aggregationListNOSSN)
                                    {
                                        reason = "";
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.MaxAmount))
                                        {
                                            model.checkmaxamount = true;
                                        }
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                        {
                                            KYCAmountNew = Convert.ToDouble(item.Amount);
                                        }
                                        else
                                        {
                                            KYCAmountNew = Convert.ToDouble(item.KYCFolder);
                                        }
                                        
                                        if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.SSNAmount))
                                        {
                                            travessn = false;
                                        }
                                        if (reason == "")
                                        {
                                            if (Convert.ToInt32(item.OptionDate == null ? "0" : item.OptionDate) == 1)
                                            {
                                                reason += item.TYPE + " in " + item.OptionDate + " day ";
                                            }
                                            else
                                            {
                                                reason += item.TYPE + " in " + item.OptionDate + " days ";
                                            }

                                            if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                            {
                                                switch (item.TYPE.ToUpper())
                                                {
                                                    case "SENDERNAME":
                                                        model.AGG_CHECK0 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE0)
                                                        {
                                                            model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "CUST_ID":
                                                        model.AGG_CHECK10 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE10)
                                                        {
                                                            model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        // model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        break;
                                                    case "SENDERADDRESS":
                                                        model.AGG_CHECK1 = true;
                                                        //model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE1)
                                                        {
                                                            model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERPHONE":
                                                        model.AGG_CHECK2 = true;
                                                        //model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE2)
                                                        {
                                                            model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERID":
                                                        model.AGG_CHECK3 = true;
                                                        //model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE3)
                                                        {
                                                            model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "SENDERSSN":
                                                        model.AGG_CHECK4 = true;
                                                        //model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE4)
                                                        {
                                                            model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    case "RECEIVERLOCALNAME":
                                                        model.AGG_CHECK8 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE8)
                                                        {
                                                            model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERADDRESS":
                                                        model.AGG_CHECK5 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE5)
                                                        {
                                                            model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERPHONE":
                                                        model.AGG_CHECK6 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE6)
                                                        {
                                                            model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                    case "RECEIVERBANKACCOUNT":
                                                        model.AGG_CHECK7 = true;
                                                        // model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE7)
                                                        {
                                                            model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        break;
                                                    default:
                                                        model.AGG_CHECK9 = true;
                                                        if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE9)
                                                        {
                                                            model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                        }
                                                        //model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                        break;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            if (!reason.Contains(item.TYPE))
                                            {

                                                if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) == 1)
                                                {
                                                    reason += " + " + item.TYPE + " in " + Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) + " day ";
                                                }
                                                else
                                                {
                                                    reason += " + " + item.TYPE + " in " + Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) + " days ";
                                                }

                                                if (Convert.ToDouble(item.TOTAL_AMT_USD) > Convert.ToDouble(item.Amount))
                                                {
                                                    switch (item.TYPE.ToUpper())
                                                    {
                                                        case "SENDERNAME":
                                                            model.AGG_CHECK0 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE0)
                                                            {
                                                                model.AGG_DATE0 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "CUST_ID":
                                                            model.AGG_CHECK10 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE10)
                                                            {
                                                                model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            // model.AGG_DATE10 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            break;
                                                        case "SENDERADDRESS":
                                                            model.AGG_CHECK1 = true;
                                                            //model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE1)
                                                            {
                                                                model.AGG_DATE1 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERPHONE":
                                                            model.AGG_CHECK2 = true;
                                                            //model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE2)
                                                            {
                                                                model.AGG_DATE2 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERID":
                                                            model.AGG_CHECK3 = true;
                                                            //model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE3)
                                                            {
                                                                model.AGG_DATE3 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "SENDERSSN":
                                                            model.AGG_CHECK4 = true;
                                                            //model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE4)
                                                            {
                                                                model.AGG_DATE4 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        case "RECEIVERLOCALNAME":
                                                            model.AGG_CHECK8 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE8)
                                                            {
                                                                model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE8 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERADDRESS":
                                                            model.AGG_CHECK5 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE5)
                                                            {
                                                                model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE5 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERPHONE":
                                                            model.AGG_CHECK6 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE6)
                                                            {
                                                                model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE6 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                        case "RECEIVERBANKACCOUNT":
                                                            model.AGG_CHECK7 = true;
                                                            // model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE7)
                                                            {
                                                                model.AGG_DATE7 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            break;
                                                        default:
                                                            model.AGG_CHECK9 = true;
                                                            if (Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate) > model.AGG_DATE9)
                                                            {
                                                                model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate);
                                                            }
                                                            //model.AGG_DATE9 = Convert.ToInt16(item.OptionDate == null ? "0" : item.OptionDate); ;
                                                            break;
                                                    }
                                                }
                                            }
                                        }
                                        i += 1;
                                        reason = "Aggregation over " + KYCAmountNew + " $ by " + reason + " with ID, No SSN or the same Cust ID. ";
                                        model.reasonKyc += reason;
                                       
                                    }
                                    model.Agg = true;
                                    model.KYC = true;
                                    trave = false;

                                }
                                if (!string.IsNullOrEmpty(model.reasonKyc))
                                {
                                    model.reasonKyc += " Request ID check.";
                                }
                                else
                                {
                                    model.reasonKyc += "ID check";
                                }
                                i = 0;
                                if (aggregationListSOF.Count > 0)
                                {
                                    reason = "";
                                    foreach (var item in aggregationListSOF)
                                    {
                                        if (i == 0)
                                        {
                                            KYCAmountNew = Convert.ToDouble(item.Amount);
                                        }
                                        i += 1;
                                    }
                                    model.Agg = true;

                                    model.KYC = true;
                                    trave = false;
                                    travessn = false;
                                    travesof = false;
                                    reason = "Aggregation over " + KYCAmountNew + " $ by " + reason + ". Request SOF check.";
                                    model.reasonKyc += reason;
                                    if (loadedFileSOFs.Count == 0)
                                    {
                                        erragg++;
                                        errorint++;
                                        if (!prompMsg.Contains("Provide all of these below documents:"))
                                        {
                                            prompMsg += "Provide all of these below documents: \r\n\r \n ";
                                            prompMsg += " Bank statement/ Pay check/ Tax return";
                                            //prompMsg += "* Pay check ";
                                            //prompMsg += "* Tax return ";
                                        }
                                        toastService.ShowWarning(prompMsg);
                                        if (string.IsNullOrEmpty(model.SSN))
                                        {
                                            travessn = false;
                                        }

                                    }
                                }
                            }
                        }
                        //else
                        //{toastService.ShowWarning("khong du lieu");}
                    }
                    else
                    {
                        result = false;
                        toastService.ShowWarning(Resp.Message);
                    }
                    
                        
                }
                if (string.IsNullOrEmpty(model.reasonKyc) && (model.KYC || model.Agg))
                {
                    model.reasonKyc += "ID check";
                }
                if (model.checkmaxamount)
                {
                    result = false;
                    toastService.ShowWarning("Check Max Amount!");
                }
                if (trave == false || travessn == false)
                {
                    if (AuthService.userMTRedSun.AgentID.ToString().ToUpper() == "CA01"
                        && ((string.IsNullOrEmpty(model.ID) || (string.IsNullOrEmpty(model.SSN) && travessn == false))))
                    {
                        AggregationList();                        
                        result = false;
                    }
                    if (travesof == false)
                    {
                        if (loadedFileSOFs.Count == 0)
                        {
                            result = false;
                            if (AuthService.userMTRedSun.AgentID.ToString().ToUpper() == "CA01" && ((!string.IsNullOrEmpty(model.ID) || !string.IsNullOrEmpty(model.SSN))
                          && (result == false || travessn == false)))
                            {
                                AggregationList();
                                ViewAggList = true;
                            }
                           
                            toastService.ShowWarning("Uploas SOF files");
                        }
                    }
                    if (travessn == false)
                    {
                        if (string.IsNullOrEmpty(model.SSN))
                        {
                            SSNBackground = "BackgroundError NumberOnly";
                            result = false;
                            toastService.ShowWarning("Enter SSN");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(model.SSN_BK) && model.SSN.Contains("XXX"))
                            {
                                SSNBackground = "BackgroundError NumberOnly";
                                result = false;
                                toastService.ShowWarning("SSN is wrong");
                            }
                            else
                            {
                                SSNBackground = "BackgroundWhite NumberOnly";
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(model.ID))
                    {
                        IdBackground = "BackgroundError";
                        result = false;
                        toastService.ShowWarning("Enter ID");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(model.ID_BK) && model.ID.Contains("XXX"))
                        {
                            IdBackground = "BackgroundError";
                            result = false;
                            toastService.ShowWarning("ID is wrong");
                        }
                        else
                        {
                            IdBackground = "BackgroundWhite";
                        }
                    }
                    if (model.DOB == null)
                    {
                        C_DOB = backerror;
                        result = false;
                        toastService.ShowWarning("Enter DOB");
                    }
                    else
                    {
                        C_DOB = back;
                    }
                    if (string.IsNullOrEmpty(model.ReasonforSending))
                    {
                        result = false;
                        C_ReasonforSending = backerror;
                        toastService.ShowWarning("Enter Reason for Sending");
                        if (focus)
                        {
                            await E_ReasonforSending.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_ReasonforSending = back;
                    }
                    //if (model.IssueDate == null)
                    //{
                    //    C_IssueDate = backerror;
                    //    result = false;
                    //    toastService.ShowWarning("Enter Issue Date");
                    //}
                    //else
                    //{
                    //    C_IssueDate = back;
                    //}
                    if (model.ExpireDate == null)
                    {
                        C_ExpireDate = backerror;
                        result = false;
                        toastService.ShowWarning("Enter Expire Date");
                    }
                    else
                    {
                        C_ExpireDate = back;
                    }
                    

                    if (model.CountryIssue.ToUpper().Contains("SELECT ONE") || string.IsNullOrEmpty(model.CountryIssue))
                    {
                        result = false;
                        C_CountryIssue = backerror;
                        toastService.ShowWarning("Enter State Issue");
                    }
                    else
                    {
                        C_CountryIssue = back;
                    }

                    if (model.IDType != "PP" && model.IDType != "OT")
                    {
                        if (model.StateIssue.ToUpper().Contains("SELECT ONE") || string.IsNullOrEmpty(model.StateIssue))
                        {
                            result = false;
                            C_StateIssue = backerror;
                            toastService.ShowWarning("Enter State Issue");
                        }
                        else
                        {
                            C_StateIssue = back;
                        }
                    }

                    if (result && model.IDCheck == false)
                    {
                        result = await ValidateIdology();
                    }

                }


                //if (!string.IsNullOrEmpty(model.ID) && (model.ExpireDate!=model.ExpireDateBK))
                //{
                //    model.KYC = true;
                //    if (!string.IsNullOrEmpty(model.reasonKyc))
                //    {
                //        model.reasonKyc += "; Change Expire Date";
                //    }
                //    else
                //    {
                //        model.reasonKyc = "Change Expire Date";
                //    }

                //}
                if (model.ExpireDate != null && model.ExpireDateBK != null)
                {
                    if (model.ExpireDate != model.ExpireDateBK)
                    {                       
                        model.KYC = true;
                        if (!string.IsNullOrEmpty(model.reasonKyc))
                        {
                            model.reasonKyc.Replace("Request ID check.", "");
                            model.reasonKyc.Replace("Change Expire date.", "");
                        }
                        
                        model.reasonKyc += " Change Expire date. Request ID check.";
                    }
                }
                StateHasChanged();
                return result;
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
                return result;

            }
        }
        private async Task<bool> ValidateVerify()
        {
            bool resultValidate = true;
            bool focus = true;
            string errorstring = "";
            StateHasChanged();
            try
            {
                if (model.AgentState == "NY" && model.ToCountry.ToUpper() == "CN")
                {
                    if (!model.CheckAgentState)
                    {
                        resultValidate = false;
                        toastService.ShowWarning("ID Verification Checked");
                    }
                    //if (string.IsNullOrEmpty(model.VerifyIDCheck))
                    //{
                    //    resultValidate = false;
                    //    C_VerifyIDCheck = backerror;
                    //    toastService.ShowWarning("Sender ID last 4 digits");
                    //    if (focus)
                    //    {
                    //        await E_VerifyIDCheck.FocusAsync();
                    //        focus = false;
                    //    }
                    //}
                    //else
                    //{
                    //    if (string.IsNullOrEmpty(model.ID))
                    //    {
                    //        IdBackground = "BackgroundError";
                    //        resultValidate = false;
                    //        toastService.ShowWarning("Enter ID");
                    //    }
                    //    else
                    //    {
                    //        if (string.IsNullOrEmpty(model.ID_BK) && model.ID.Contains("XXX"))
                    //        {
                    //            IdBackground = "BackgroundError";
                    //            resultValidate = false;
                    //            toastService.ShowWarning("ID is wrong");
                    //        }
                    //        else
                    //        {
                    //            IdBackground = "BackgroundWhite";
                    //        }
                    //    }

                    //    if (model.ID.Length >= 4)
                    //    {
                    //        string idd = model.ID.Substring(model.ID.Length - 4, 4);
                    //        if (model.VerifyIDCheck.Trim() == idd)
                    //        {
                    //            C_VerifyIDCheck = back;
                    //        }
                    //        else
                    //        {
                    //            resultValidate = false;
                    //            C_VerifyIDCheck = backerror;
                    //            toastService.ShowWarning("Sender ID last 4 digits is wrong!");
                    //            if (focus)
                    //            {
                    //                await E_VerifyIDCheck.FocusAsync();
                    //                focus = false;
                    //            }
                    //        }
                    //    }
                    //    else
                    //    {
                    //        IdBackground = "BackgroundError";
                    //        resultValidate = false;
                    //        toastService.ShowWarning("ID is wrong");
                    //    }

                    //}
                }
            }
            catch(Exception ex)
            {

            }
            return resultValidate;
        }
        private async Task<bool> ValidateBehalf()
        {
            StateHasChanged();
            bool result = true;
            bool focus = true;
            string errorstring = "";
            StateHasChanged();
            try
            {

                if (string.IsNullOrEmpty(model.SBHFirstName))
                {
                    result = false;
                    C_SBHFirstName = backerror;
                    //toastService.ShowWarning("Enter Sender First Name behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender First Name behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender First Name behalf";
                    }
                    await E_SBHFirstName.FocusAsync();
                    focus = false;
                }
                else
                {
                    C_SBHFirstName = back;
                }
                if (string.IsNullOrEmpty(model.SBHLastName))
                {
                    result = false;
                    C_SBHLastName = backerror;
                    //toastService.ShowWarning("Enter Sender Last Name behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Last Name behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Last Name behalf";
                    }
                    if (focus)
                    {
                        await E_SBHLastName.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    C_SBHLastName = back;
                }
                if (string.IsNullOrEmpty(model.SBHAddress))
                {
                    result = false;
                    C_SBHAddress = backerror;
                    //toastService.ShowWarning("Enter Sender Address behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Address behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Address behalf";
                    }
                    if (focus)
                    {
                        await E_SBHAddress.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    C_SBHAddress = back;
                }
                if (string.IsNullOrEmpty(model.SBHCity))
                {
                    result = false;
                    C_SBHCity = backerror;
                    //toastService.ShowWarning("Enter Sender City behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender City behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender City behalf";
                    }
                    if (focus)
                    {
                        await E_SBHCity.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    C_SBHCity = back;
                }
                if (string.IsNullOrEmpty(model.SBHState))
                {
                    result = false;
                    C_SBHState = backerror;
                    //toastService.ShowWarning("Enter Sender State behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender State behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender State behalf";
                    }
                    if (focus)
                    {
                        await E_SBHState.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    C_SBHState = back;
                }
                if (string.IsNullOrEmpty(model.SBHZipcode))
                {
                    result = false;
                    C_SBHZipcode = backerror;
                    //toastService.ShowWarning("Enter Sender Zipcode behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Zipcode behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Zipcode behalf";
                    }
                    //if (focus)
                    //{
                    //    await E_SBHZipcode.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    C_SBHZipcode = back;
                }
                if (string.IsNullOrEmpty(model.SBHPhone))
                {
                    result = false;
                    C_SBHPhone = backerror;
                    //toastService.ShowWarning("Enter Sender Phone behalf");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Phone behalf";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Phone behalf";
                    }
                    //if (focus)
                    //{
                    //    await E_SBHPhone.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    C_SBHPhone = back;
                }
                if (!result)
                {
                    toastService.ShowWarning(errorstring);
                }
                return result;
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
                return result;

            }
        }
        private async Task<bool> ValidateSender()
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"['~`!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            var AhasSymbols = new Regex(@"['~`#!@$%^&*()_+=\[{\]};:<>|./?,-]");
            var hasPhone = new Regex(@"^\(?([2-9][0-8][0-9])\)?[-.●]?([2-9][0-9]{2})[-.●]?([0-9]{4})$");
            var AhasAddressSymbols = new Regex(@"['~`!@$%^&*()_+=\[{\]};:<>|./?,]");
            Regex regexAddress = new Regex(@"\\");
            var hasCharacter = new Regex(@"^[a-zA-Z]+$");
            //var hasSSN = new Regex(@"((?:\d{3})-(?:\d{2})-(?\d{4}))");
            bool result = true;
            bool focus = true;
            string errorstring = "";
            StateHasChanged();
            try
            {
                if (!string.IsNullOrEmpty((model.SSN_BK == null ? "" : model.SSN_BK)))
                {                   
                    double SSNNum = 0;
                    double.TryParse((model.SSN_BK == null ? "" : model.SSN_BK).ToString().Replace("-",""), out SSNNum);
                    if (SSNNum == 0)
                    {
                        result = false;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "SSN is wrong";
                        }
                        else
                        {
                            errorstring += ";  SSN is wrong";
                        }
                        C_SSN = backerror;
                        //toastService.ShowWarning("Sender Phone is wrong");
                    }
                    else
                    {
                        C_SSN = back;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty((model.SSN == null ? "" : model.SSN)))
                    {                      
                        double SSNNum = 0;
                        double.TryParse((model.SSN == null ? "" : model.SSN).ToString().Replace("-", ""), out SSNNum);                    
                        if (SSNNum == 0)
                        {
                            result = false;
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "SSN is wrong";
                            }
                            else
                            {
                                errorstring += ";  SSN is wrong";
                            }
                            C_SSN = backerror;
                            //toastService.ShowWarning("Sender Phone is wrong");
                        }
                        else
                        {
                            C_SSN = back;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(model.SMiddleName))
                {
                    if (!hasCharacter.IsMatch(model.SMiddleName.Replace(" ", "")))
                    {
                        result = false;
                        C_SMiddleName = backerror;
                        errorstring += ";  Sender MiddleName only character";
                    }
                }

                if (string.IsNullOrEmpty(model.SFirstName))
                {
                    result = false;
                    C_SFirstName = backerror;
                    //toastService.ShowWarning("Enter Sender First Name");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender First Name";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender First Name";
                    }
                    await E_SFirstName.FocusAsync();
                    focus = false;
                }
                else
                {
                    if (!hasCharacter.IsMatch(model.SFirstName.Replace(" ", "")))
                    {
                        result = false;
                        C_SFirstName = backerror;
                        errorstring += ";  Sender Firstname only character";
                    }
                    if (hasNumber.IsMatch(model.SFirstName) || hasSymbols.IsMatch(model.SFirstName) || model.SFirstName.Contains("  "))
                    {
                        result = false;
                        C_SFirstName = backerror;
                        //toastService.ShowWarning("Sender Firstname without number, double Space or special character ");
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Sender Firstname without number, double Space or special character";
                        }
                        else
                        {
                            errorstring += ";  Sender Firstname without number, double Space or special character";
                        }
                        await E_SFirstName.FocusAsync();
                        focus = false;
                    }
                    else
                    {
                        
                        string[] strArr = model.SFirstName.Trim().Split(' ');
                        if (strArr.Length > 1)
                        {
                            result = false;
                            C_SFirstName = backerror;
                            //toastService.ShowWarning("Enter to Sender Middle name. Sender First Name only one ");
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "Enter to Sender Middle name. Sender First Name only one";
                            }
                            else
                            {
                                errorstring += ";  Enter to Sender Middle name. Sender First Name only one";
                            }
                            await E_SFirstName.FocusAsync();
                            focus = false;
                        }
                        else
                        {
                            C_SFirstName = back;
                        }
                    }
                }
                if (string.IsNullOrEmpty(model.SLastName))
                {
                    result = false;
                    C_SLastName = backerror;
                    //toastService.ShowWarning("Enter Sender Last Name");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Last Name";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Last Name";
                    }
                    if (focus)
                    {
                        await E_SLastName.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (!hasCharacter.IsMatch(model.SLastName.Replace(" ", "")))
                    {
                        result = false;
                        C_SLastName = backerror;
                        errorstring += ";  Sender Lastname only character";
                    }
                    if (hasNumber.IsMatch(model.SLastName) || hasSymbols.IsMatch(model.SLastName) || model.SLastName.Contains("  "))
                    {
                        result = false;
                        C_SLastName = backerror;
                        toastService.ShowWarning(" ");
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Sender Lastname without number, double Space or special character";
                        }
                        else
                        {
                            errorstring += ";  Sender Lastname without number, double Space or special character";
                        }
                        await E_SLastName.FocusAsync();
                        focus = false;
                    }
                    else
                    {

                        string[] strArr = model.SLastName.Trim().Split(' ');
                        if (strArr.Length > 1)
                        {
                            result = false;
                            C_SLastName = backerror;
                           // toastService.ShowWarning("Enter to Sender Last Name. Sender Last Name only one ");
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "Enter to Sender Last Name. Sender Last Name only one";
                            }
                            else
                            {
                                errorstring += ";  Enter to Sender Last Name. Sender Last Name only one";
                            }
                            await E_SLastName.FocusAsync();
                            focus = false;
                        }
                        else
                        {
                            C_SLastName = back;
                        }
                    }

                }
                if (string.IsNullOrEmpty(model.SAddress))
                {
                    result = false;
                    C_SAddress = backerror;
                    if(string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Address";
                    }
                    else
                    {
                        errorstring += "; Enter Sender Address";
                    }
                    
                    if (focus)
                    {
                        await E_SAddress.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    bool erroraddress = false;
                    double Num;
                    string Str = "";
                    model.SAddress = model.SAddress.Trim();
                    StateHasChanged();
                    string saddress = model.SAddress.Trim().ToUpper();
                    if (ExceptionSAList.Count > 0)
                    {
                        foreach (var item in ExceptionSAList)
                        {
                            if (saddress.Contains(item.Exception_string.ToUpper()))
                            {
                                erroraddress = true;
                                C_SAddress = backerror;
                                result = false;
                                if (string.IsNullOrEmpty(errorstring))
                                {
                                    errorstring = "Sender Address is without " + item.Exception_string.ToUpper();
                                }
                                else
                                {
                                    errorstring += "; Sender Address is without " + item.Exception_string.ToUpper();
                                }
                                if (focus)
                                {
                                    await E_SAddress.FocusAsync();
                                    focus = false;
                                }
                            }
                        }
                    }
                    if (AuthService.userMTRedSun.SplitList.Count > 0)
                    {
                        foreach(var item in AuthService.userMTRedSun.SplitList)
                        {
                            saddress = saddress.Replace(item.Daucau, "");
                        }
                    }
                    saddress = saddress.Replace("  ", " ").Trim();
                    if (saddress.Substring(0, 1) == "0")
                    {
                        result = false;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Sender Address is wrong";
                        }
                        else
                        {
                            errorstring += "; Sender Address is wrong";
                        }
                    }
                    //string[] strArr1 = saddress.Split('\'\);


                    string[] strArr = saddress.Split(' ');
                    if (strArr.Length > 1)
                    {
                        Str = strArr[0];
                    }
                    strArr = Str.Split('/');
                    if (strArr.Length > 1)
                    {
                        Str = strArr[0];
                    }
                    strArr = Str.Split('.');
                    if (strArr.Length > 1)
                    {
                        Str = strArr[0];
                    }
                   
                    if (AhasAddressSymbols.IsMatch(saddress) || saddress.Contains("  "))
                    {
                        erroraddress = true;
                        result = false;
                        C_SAddress = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Sender address without speacial character or double Space";
                        }
                        else
                        {
                            errorstring += ";  Sender address without speacial character or double Space";
                        }
                        //toastService.ShowWarning("Sender address without speacial character or double Space");
                    }
                    else
                    {
                        if (saddress.Contains("\""))
                        {
                            result = false;
                            errorstring = "Sender address without speacial character or double Space";
                        }
                        if (regexAddress.IsMatch(saddress))
                        {
                            result = false;
                            errorstring = "Sender address without speacial character or double Space";
                        }
                    }
                    bool isNum = double.TryParse(Str, out Num);
                    if (!isNum)
                    {
                        erroraddress = true;
                        result = false;
                        C_SAddress = backerror;
                        
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Please edit Address";
                        }
                        else
                        {
                            errorstring += ";  Please edit Address";
                        }
                    }
                    strArr = saddress.Split(' ');
                    if (strArr.Length > 1)
                    {
                        Str = strArr[1];
                    }
                    isNum = double.TryParse(Str, out Num);
                    if (isNum)
                    {
                        erroraddress = true;
                        result = false;
                        C_SAddress = backerror;
                       
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Please edit Address";
                        }
                        else
                        {
                            errorstring += ";  Please edit Address";
                        }
                    }
                    if (erroraddress == false)
                    {
                        C_SAddress = back;
                    }
                }
                if (string.IsNullOrEmpty(model.SCity))
                {
                    result = false;
                    C_SCity = backerror;
                    //toastService.ShowWarning("Select Sender State");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender City";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender City";
                    }
                    if (focus)
                    {
                        await E_SCity.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    C_SCity = back;
                }
                if (string.IsNullOrEmpty(model.SState))
                {
                    result = false;
                    C_SState = backerror;
                    //toastService.ShowWarning("Select Sender State");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Select Sender State";
                    }
                    else
                    {
                        errorstring += ";  Select Sender State";
                    }
                    if (focus)
                    {
                        await E_SState.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (model.SState.Contains("Select One"))
                    {
                        result = false;
                        C_SState = backerror;
                        //toastService.ShowWarning("Select Sender State");
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Select Sender State";
                        }
                        else
                        {
                            errorstring += ";  Select Sender State";
                        }
                        if (focus)
                        {
                            await E_SState.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_SState = back;
                    }
                    
                }
                if (string.IsNullOrEmpty(model.SZipcode))
                {
                    result = false;
                    cssbackSZipCode = cssBackError;
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Zipcode";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Zipcode";
                    }
                    //toastService.ShowWarning("Enter Sender Zipcode");
                }
                else
                {
                    cssbackSZipCode = cssBack;
                }
                if (string.IsNullOrEmpty(model.SPhone))
                {
                    result = false;
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Sender Phone";
                    }
                    else
                    {
                        errorstring += ";  Enter Sender Phone";
                    }
                    cssbackSPhone = cssBackError;
                    //toastService.ShowWarning("Enter Sender Phone");
                    //if (focus)
                    //{
                    //    await E_SPhone.FocusAsync();
                    //    focus = false;
                    //}
                }
                else
                {
                    if (model.SPhone.Replace("-", "").Length != 10)
                    {
                        result = false;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Sender Phone is wrong";
                        }
                        else
                        {
                            errorstring += ";  Sender Phone is wrong";
                        }
                        cssbackSPhone = cssBackError;
                        //toastService.ShowWarning("Sender Phone is wrong");
                    }
                    else
                    {
                        string phone = model.SPhone.Replace("-", "");
                        phone = phone.Substring(0, 3) + "-" + phone.Substring(3, 3) + "-" + phone.Substring(6, 4);
                        if (!hasPhone.IsMatch(phone))
                        {
                            result = false;
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "Sender Phone is wrong";
                            }
                            else
                            {
                                errorstring += "; Sender Phone is wrong";
                            }
                            cssbackSPhone = cssBackError;
                            //toastService.ShowWarning("Sender Phone is wrong");
                        }
                        else
                        {
                            cssbackAmount = cssBack;
                        }
                    }

                }
                if (string.IsNullOrEmpty(model.Occupation))
                {
                    result = false;
                    C_Occupation = backerror;
                    //toastService.ShowWarning("Enter Occupation");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Occupation";
                    }
                    else
                    {
                        errorstring += ";  Enter Occupation";
                    }
                    if (focus)
                    {
                        await E_Occupation.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (AuthService.userMTRedSun.Occupation.Contains(model.Occupation))
                    {
                        C_Occupation = backerror;
                        result = false;
                        toastService.ShowWarning("check Occupation");
                    }
                    else
                    {
                        C_Occupation = back;
                    }
                }
                if (!string.IsNullOrEmpty(model.ID))
                {
                    if (hasSymbols.IsMatch(model.ID))
                    {
                        result = false;
                        C_ID = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "ID without double Space or special character";
                        }                       
                        if (focus)
                        {
                            await E_ID.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_ID = back;
                    }
                }
                //if (model.DOB == null)
                //{
                //    result = false;
                //    C_DOB = backerror;
                //    if (string.IsNullOrEmpty(errorstring))
                //    {
                //        errorstring = "Enter DOB";
                //    }
                //    else
                //    {
                //        errorstring += ";  Enter DOB";
                //    }
                //    //toastService.ShowWarning("Enter DOB");
                //    if (focus)
                //    {
                //        await E_DOB.FocusAsync();
                //        focus = false;
                //    }
                //}
                //else
                //{
                //    C_DOB = back;
                //}
                if (!result)
                {
                    //RenderFragment re ;
                    //errorstring += "Your date of birth is in the future <br> Please enter a valid date of birth";
                    //re=(RenderFragment)errorstring; //((MarkupStringSanitized.)errorstring);
                    //RenderFragment toast = @<errorstring/> ;
                    // toastService.ShowToast("Mensagem de ERRON<br> Xuống dòng thêm dòng mới", ToastLevel.Error);
                    //toastServices.ShowToast(toast);
                    toastService.ShowWarning(errorstring);
                }
                return result;
            }
            catch (Exception ex)
            {
                result = false;
                toastService.ShowError(ex.Message);
            }
            StateHasChanged();
            return result;
        }
        private async Task<bool> ValidateBank()
        {
            StateHasChanged();
            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"['~`!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            var AhasSymbols = new Regex(@"['~`#!@$%^&*()_+=\[{\]};:<>|./?,-]");
            var hasPhone = new Regex(@"^\(?([2-9][0-8][0-9])\)?[-.●]?([2-9][0-9]{2})[-.●]?([0-9]{4})$");
            bool result = true;
            bool focus = true;
            string errorstring = "";
            try
            {
                if (AuthService.userMTRedSun.methodBankList.Contains(model.PaymentMode))
                {
                    if (string.IsNullOrEmpty(model.AccountNo))
                    {
                        result = false;
                        C_AccountNo = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Select Bank";
                        }
                       
                       //toastService.ShowWarning("Select Bank");
                        if (focus)
                        {
                            await E_AccountNo.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_AccountNo = back;
                    }
                    if (string.IsNullOrEmpty(model.BankName))
                    {
                        result = false;
                        C_BankName = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Select Bank";
                        }
                        if (focus)
                        {
                            await E_BankName.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_BankName = back;
                    }
                    if (string.IsNullOrEmpty(model.BankID))
                    {
                        result = false;
                        C_SelectAccount = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Select Bank";
                        }
                        if (focus)
                        {
                            await E_SelectAccount.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        if (model.BankID == "0" || model.BankID.ToLower() == "select bank")
                        {
                            result = false;
                            C_SelectAccount = backerror;
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "Select Bank";
                            }
                            if (focus)
                            {
                                await E_SelectAccount.FocusAsync();
                                focus = false;
                            }
                        }
                        else
                        {
                            C_SelectAccount = back;
                        }
                    }
                    if(model.ToCountry=="VN" && model.TotalAmount>500 && !model.ReceiverIDCheck)
                    {
                        ReceiverIDCheckBackground = cssBackError;
                        result = false;
                        errorstring = "Bank deposit > $500, select Collected Receiver ID to continue";
                    }
                    else
                    {
                        ReceiverIDCheckBackground = cssBack;
                    }
                }
                if (!result)
                {
                    toastService.ShowWarning(errorstring);
                }
            }
            catch (Exception ex)
            {
                result = false;
                toastService.ShowError(ex.Message);
            }
            StateHasChanged();
            return result;
        }
        private async Task<bool> ValidateRecipient()
        {
            StateHasChanged();
            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"['~`!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            var AhasSymbols = new Regex(@"['~`#!@$%^&*()_+=\[{\]};:<>|./?,-]");
            var hasPhone = new Regex(@"^\(?([2-9][0-8][0-9])\)?[-.●]?([2-9][0-9]{2})[-.●]?([0-9]{4})$");
            var hasCharacter = new Regex(@"^[a-zA-Z]+$");
            bool result = true;
            bool focus = true;
            string errorstring = "";
            try
            {
                if (!string.IsNullOrEmpty(model.RelationwithSenderNote))
                {
                   if(model.RelationwithSenderNote.ToUpper()=="OTHER" || model.RelationwithSenderNote.ToUpper() == "OTHERS")
                    {
                        result = false;
                        C_RelationwithSender = backerror;
                        // toastService.ShowWarning("Receiver LocalName without number, double Space or Special character");
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Enter relation with Sender";
                        }
                        else
                        {
                            errorstring += ";  Enter relation with Sender";
                        }
                        await E_RelationwithSender.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    result = false;
                    C_RelationwithSender = backerror;
                    // toastService.ShowWarning("Receiver LocalName without number, double Space or Special character");
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter relation with Sender";
                    }
                    else
                    {
                        errorstring += ";  Enter relation with Sender";
                    }
                    await E_RelationwithSender.FocusAsync();
                    focus = false;
                }
                if (!string.IsNullOrEmpty(model.RLocalName))
                {
                    if (hasNumber.IsMatch(model.RLocalName) || hasSymbols.IsMatch(model.RLocalName) || model.RLocalName.Contains("  "))
                    {
                        result = false;
                        C_RLocalName = backerror;
                       // toastService.ShowWarning("Receiver LocalName without number, double Space or Special character");
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Receiver LocalName without number, double Space or Special character";
                        }
                        else
                        {
                            errorstring += ";  Receiver LocalName without number, double Space or Special character";
                        }
                        await E_RLocalName.FocusAsync();
                        focus = false;
                    }
                }
                if (!string.IsNullOrEmpty(model.RFullName2))
                {
                    if (hasNumber.IsMatch(model.RFullName2) || hasSymbols.IsMatch(model.RFullName2) || model.RFullName2.Contains("  "))
                    {
                        result = false;
                        C_RFullName2 = backerror;
                        //toastService.ShowWarning("Receiver Name 2 without number, double Space or Special character");
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Receiver Name 2 without number, double Space or Special character";
                        }
                        else
                        {
                            errorstring += ";  Receiver Name 2 without number, double Space or Special character";
                        }
                        await E_RFullName2.FocusAsync();
                        focus = false;
                    }
                }
                if (string.IsNullOrEmpty(model.RFirstName))
                {
                    result = false;
                    C_RFirstName = backerror;
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Receiver First Name";
                    }
                    else
                    {
                        errorstring += ";  Enter Receiver First Name";
                    }
                    //toastService.ShowWarning("Enter Receiver First Name");
                    if (focus)
                    {
                        await E_RFirstName.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (!hasCharacter.IsMatch(model.RFirstName.Replace(" ", "")))
                    {
                        result = false;
                        C_RFirstName = backerror;
                        errorstring += ";  Receiver Firstname only character";
                    }
                    if (hasNumber.IsMatch(model.RFirstName) || hasSymbols.IsMatch(model.RFirstName) || model.RFirstName.Contains("  "))
                    {
                        result = false;
                        C_RFirstName = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Receiver Firstname without number, double Space or special character";
                        }
                        else
                        {
                            errorstring += ";  Receiver Firstname without number, double Space or special character";
                        }
                        //toastService.ShowWarning("Receiver Firstname without number, double Space or special character");
                        await E_RFirstName.FocusAsync();
                        focus = false;
                    }
                    else
                    {
                        C_RFirstName = back;
                    }
                }

                if (string.IsNullOrEmpty(model.RLastName))
                {
                    result = false;
                    C_RLastName = backerror;
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Receiver Last Name";
                    }
                    else
                    {
                        errorstring += ";  Enter Receiver Last Name";
                    }
                    //toastService.ShowWarning("Enter Receiver Last Name");
                    if (focus)
                    {
                        await E_RLastName.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (!hasCharacter.IsMatch(model.RLastName.Replace(" ", "")))
                    {
                        result = false;
                        C_RLastName = backerror;
                        errorstring += ";  Receiver LastName only character";
                    }
                    if (hasNumber.IsMatch(model.RLastName) || hasSymbols.IsMatch(model.RLastName) || model.RLastName.Contains("  "))
                    {
                        result = false;
                        C_RLastName = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Receiver Lastname without number, double Space or special character";
                        }
                        else
                        {
                            errorstring += ";  Receiver Lastname without number, double Space or special character";
                        }
                        //toastService.ShowWarning("Receiver Lastname without number, double Space or special character ");
                        await E_RLastName.FocusAsync();
                        focus = false;
                    }
                    else
                    {
                        C_RLastName = back;
                    }
                }
                if (!string.IsNullOrEmpty(model.RMiddleName))
                {
                    if (!hasCharacter.IsMatch(model.RMiddleName.Replace(" ", "")))
                    {
                        result = false;
                        C_RMiddleName = backerror;
                        errorstring += ";  Receiver MiddleName only character";
                    }
                }
                if (string.IsNullOrEmpty(model.RAddress))
                {
                    result = false;
                    C_RAddress = backerror;
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Receiver Address";
                    }
                    else
                    {
                        errorstring += ";  Enter Receiver Address";
                    }
                    //toastService.ShowWarning("Enter Receiver Address");
                    if (focus)
                    {
                        await E_RAddress.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    if (model.RAddress.Substring(0, 1) == "0" || (model.RAddress.ToUpper().Contains("NA") && model.RAddress.Length == 2) || model.RAddress.ToUpper().Contains("N/A"))
                    {
                        result = false;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Receiver Address is wrong";
                        }
                        else
                        {
                            errorstring += ";  Receiver Address is wrong";
                        }
                        //toastService.ShowWarning("Receiver Address is wrong");
                    }
                    else
                    {
                        C_RAddress = back;
                    }

                }

                if (string.IsNullOrEmpty(model.RPhone))
                {
                    result = false;
                    C_RPhone = backerror;
                    if (string.IsNullOrEmpty(errorstring))
                    {
                        errorstring = "Enter Receiver Phone";
                    }
                    else
                    {
                        errorstring += ";  Enter Receiver Phone";
                    }
                    //toastService.ShowWarning("Enter Receiver Phone");
                    if (focus)
                    {
                        await E_RPhone.FocusAsync();
                        focus = false;
                    }
                }
                else
                {
                    model.RPhone = model.RPhone.Replace(" ", "").Replace(" ", "").Trim();
                    double Num;
                    bool isNum = double.TryParse(model.RPhone, out Num);
                    if (!isNum)
                    {
                        result = false;
                        C_RPhone = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Check Receiver Phone";
                        }
                        else
                        {
                            errorstring += " \r\nCheck Receiver Phone";
                        }
                    }
                    else
                    {
                        if (model.RPhone.Length < 7)
                        {
                            result = false;
                            C_RPhone = backerror;
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "Check Receiver Phone";
                            }
                            else
                            {
                                errorstring += " \r\nCheck Receiver Phone";
                            }
                            //toastService.ShowWarning("Check Receiver Phone");
                            if (focus)
                            {
                                await E_RPhone.FocusAsync();
                                focus = false;
                            }
                        }
                        else
                        {
                            if (model.RPhone.Substring(0, 2) == "00")
                            {
                                result = false;
                                C_RPhone = backerror;
                                if (string.IsNullOrEmpty(errorstring))
                                {
                                    errorstring = "Check Receiver Phone";
                                }
                                else
                                {
                                    errorstring += ";  Check Receiver Phone";
                                }
                                //toastService.ShowWarning("Check Receiver Phone");
                                if (focus)
                                {
                                    await E_RPhone.FocusAsync();
                                    focus = false;
                                }
                            }
                            else
                            {
                                C_RPhone = back;
                            }
                        }
                    }

                      

                }
                if (string.IsNullOrEmpty(model.RPhone2))
                {
                   
                }
                else
                {
                    model.RPhone2 = model.RPhone2.Replace(" ", "").Replace(" ", "").Trim();
                    double Num;
                    bool isNum = double.TryParse(model.RPhone2, out Num);
                    if (!isNum)
                    {
                        result = false;
                        C_RPhone2 = backerror;
                        if (string.IsNullOrEmpty(errorstring))
                        {
                            errorstring = "Check Receiver Phone 2";
                        }
                        else
                        {
                            errorstring += " \r\nCheck Receiver Phone 2";
                        }
                    }
                    else
                    {
                        if (model.RPhone2.Length < 7)
                        {
                            result = false;
                            C_RPhone2 = backerror;
                            if (string.IsNullOrEmpty(errorstring))
                            {
                                errorstring = "Check Receiver Phone 2";
                            }
                            else
                            {
                                errorstring += " \r\nCheck Receiver Phone 2";
                            }
                            //toastService.ShowWarning("Check Receiver Phone");
                            if (focus)
                            {
                                await E_RPhone2.FocusAsync();
                                focus = false;
                            }
                        }
                        else
                        {
                            if (model.RPhone2.Substring(0, 2) == "00")
                            {
                                result = false;
                                C_RPhone2 = backerror;
                                if (string.IsNullOrEmpty(errorstring))
                                {
                                    errorstring = "Check Receiver Phone 2";
                                }
                                else
                                {
                                    errorstring += ";  Check Receiver Phone 2";
                                }
                                //toastService.ShowWarning("Check Receiver Phone");
                                if (focus)
                                {
                                    await E_RPhone2.FocusAsync();
                                    focus = false;
                                }
                            }
                            else
                            {
                                C_RPhone2 = back;
                            }
                        }
                    }                  

                }
                
                //if (model.ToCountry == "VN" || model.PaymentMode== "DD")
                //{

                //}

                    if (model.ToCountry != "VN")
                {
                    if (string.IsNullOrEmpty(model.RCity))
                    {
                        result = false;
                        C_RCity = backerror;
                        toastService.ShowWarning("Enter Receiver City");
                        if (focus)
                        {
                            await E_RCity.FocusAsync();
                            focus = false;
                        }
                    }
                    else
                    {
                        C_RCity = back;
                    }
                }
                else
                {
                    C_RCity = back;
                }
                if (!result)
                {
                    toastService.ShowWarning(errorstring);
                }
            }
            catch (Exception ex)
            {
                result = false;
                toastService.ShowError(ex.Message);
            }
            StateHasChanged();
            return result;
        }
        private async Task<bool> ValidateBlackList()
        {
            StateHasChanged();
            bool result = true;
            bool focus = true;
            try
            {

                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Transaction/getBlackList",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    CustID = CustID,
                    DriverID = model.ID,
                    Phone = model.SPhone,
                    RPhone = model.RPhone,
                    RPhone2 = model.RPhone2,
                    BankAccount = model.AccountNo,
                    RID = model.RID,
                    SZipcode = model.SZipcode
                };

                BlackiListResp Resp = await HttpService.Post<BlackiListResp>("/Transaction/getBlackList", payload);
                if (Resp.Status == 200)
                {
                    if (Resp.Content.blackList.Count > 0)
                    {
                        result = false;
                        foreach (var item in Resp.Content.blackList)
                        {
                            toastService.ShowWarning(item.ErrorMessage);
                        }
                    }
                }
                else
                {
                    if (Resp.Status != 0)
                    {
                        result = false;
                        toastService.ShowWarning(Resp.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                toastService.ShowError(ex.Message);
            }
            StateHasChanged();
            return result;
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (isNewReceiver == false && isNewCustomer == false)
                {
                    await E_RefNo.FocusAsync();
                }
                else
                {
                    if (isNewCustomer == true)
                    {
                        await E_SFirstName.FocusAsync();
                    }
                    else
                    {
                        await E_RFirstName.FocusAsync();
                    }
                }
            }
        }
        private Stream GetFileStream(byte[]? FileLoad)
        {
            try
            {
                var fileStream = new MemoryStream(FileLoad);
                return fileStream;
            }
            catch (Exception ex)
            {
                return null;
                error = ex.Message;
                toastService.ShowError(ex.Message);
            }
        }
        private async Task DownloadFileFromStreamRec(string B_CUST_ID)
        {
            try
            {
                SenderDocumentsListDownload = new List<CustomerProfileFile>();
                dynamic payload = new
                {
                    Form = "/TransactionManagement/ProcessKYC",
                    FormName = "Process KYC",
                    Action = "/Customer/CustomerProfileCustFileID - DownloadFileFromStreamCust",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    B_CustID = B_CUST_ID
                };
                //GetCustomerFileID
                CustomerProfileFileResp respdoc = await HttpService.Post<CustomerProfileFileResp>
            ("/Customer/RecipientProfileFileID", payload);
                if (respdoc.Status.ToString() == "200")
                {
                    SenderDocumentsListDownload = respdoc.Content;
                }
                else
                {
                    toastService.ShowWarning(respdoc.Message.ToString());
                    SenderDocumentsListDownload = new List<CustomerProfileFile>();
                }
                if (SenderDocumentsListDownload.Count > 0)
                {
                    foreach (var item in SenderDocumentsListDownload)
                    {
                        var fileStream = GetFileStream(item.FileLoad);
                        using var streamRef = new DotNetStreamReference(stream: fileStream);
                        await JS.InvokeVoidAsync("downloadFileFromStream", item.FileName, streamRef);
                    }

                }
                else
                {
                    toastService.ShowWarning("Nothing to download");
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                toastService.ShowError(ex.Message);
            }
        }
        protected override async Task OnInitializedAsync()
        {
            System.DateTime d;
            LoadingReport = true;
            try
            {
                //var dimension = await Service.GetDimensions();
                
                //HeightBody = dimension.Height - 63;
                //MaxHeightBody = HeightBody.ToString() + "px";

                if (AuthService.userMTRedSun==null)
                {
                    await AuthService.Logout();
                    
                }
                else
                {
                    var dimension = await Service.GetDimensions();
                    HeightBody = dimension.Height - 38;
                    MaxHeightBody = HeightBody.ToString() + "px";


                    menuChildLists = AuthService.userMTRedSun.MenuChildList.ToList();
                    if (menuChildLists.Count > 0)
                    {
                        List<MenuChildList> menuChildList = new List<MenuChildList>();
                        menuChildList = menuChildLists.Where(x => x.LinkPageColor == pagename).ToList();
                        if (menuChildList.Count == 0)
                        {
                            toastService.ShowWarning("This function is not authorized!", "Warning");
                            await AuthService.Logout();
                        }
                    }
                    CustID = NavManager.QueryString("Custid");
                    BCustID = NavManager.QueryString("BCustid");
                    fc = NavManager.QueryString("fc");
                    tc = NavManager.QueryString("tc");
                    model.ToCountry = tc;
                    switch (tc)
                    {
                        case "VN":
                            bgcolor = bgcolorVN;
                            break;
                        case "CN":
                            bgcolor = bgcolorCN;
                            break;
                        case "PH":
                            bgcolor = bgcolorPH;
                            break;
                        case "US":
                            bgcolor = bgcolorUS;
                            break;
                        default:
                            bgcolor = bgcolorVN;
                            break;
                    }
                    if (tc == "US")
                    {
                        displayUS = "initial";
                    }
                    else
                    {
                        displayUS = "None";
                    }


                    model.UserID = AuthService.userMTRedSun.Id == null ? "" : AuthService.userMTRedSun.Id.ToString();

                    model.UserName = AuthService.userMTRedSun.UserName.ToString();
                    model.AgentState = AuthService.userMTRedSun.AgentState;
                    model.CheckAgentState = false;
                    if (model.AgentState == "NY" && model.ToCountry.ToUpper()=="CN")
                    {
                        displayVerificationChecked = "initial";
                    }
                    else
                    {
                        displayVerificationChecked = "None";
                    }

                  
                    StateHasChanged();

                    var guidT = (System.Guid.NewGuid().ToString() + "-T" + System.DateTime.UtcNow.AddHours(-7).ToString("yyMMddHHmmss")).ToUpper();
                    if (string.IsNullOrEmpty(CustID))
                    {
                        CustID = (System.Guid.NewGuid().ToString() + "-C" + System.DateTime.UtcNow.AddHours(-7).ToString("yyMMddHHmmss")).ToUpper();
                        model.CustID = CustID;
                        isNewCustomer = true;
                        //await E_SFirstName.FocusAsync();
                    }
                    else
                    {
                        model.CustID = CustID;
                        isNewCustomer = false;
                    }
                    if (string.IsNullOrEmpty(BCustID))
                    {
                        BCustID = (System.Guid.NewGuid().ToString() + "-B" + System.DateTime.UtcNow.AddHours(-7).ToString("yyMMddHHmmss")).ToUpper();
                        model.BCustID = BCustID;
                        isNewReceiver = true;
                        //await E_RFirstName.FocusAsync();

                    }
                    else
                    {
                        model.BCustID = BCustID;
                        isNewReceiver = false;
                    }

                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Transaction/GetNewTransaction",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        CustID = CustID,
                        BCustID = BCustID,
                        FromCountry = fc,
                        ToCountry = tc
                    };
                    dynamic payloadIndex = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Transaction/getBlackList",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        FromCountry = fc,
                        ToCountry = tc
                    };
                    isViewingSender = "None";

                    model.SSN = "";
                    ControlPageList = AuthService.userMTRedSun.ControlPageList.ToList();

                    OccupationMList = AuthService.userMTRedSun.OccupationMList.ToList();
                    OccupationDAllList = AuthService.userMTRedSun.OccupationDList.ToList();
                    model.OccupationM = "OTHERS";
                    OccupationDList = OccupationDAllList.Where(x => x.OccupationM == model.OccupationM).ToList();
                    model.OccupationD = "OTHERS";


                    ExceptionList = AuthService.userMTRedSun.ExceptionList.ToList();
                    ExceptionSAList = ExceptionList.Where(x => x.Ex_type == "SA").ToList();

                    RelationwithSenderList = AuthService.userMTRedSun.RelationwithSenderList.ToList();
                    if (AuthService.userMTRedSun.RelationwithSenderList.Count() > 0)
                    {
                        //model.RelationwithSender = AuthService.userMTRedSun.RelationwithSenderList[0].Relation_ID.ToString();
                        //model.RelationwithSenderNote = AuthService.userMTRedSun.RelationwithSenderList[0].Relation_Name.ToString();
                        model.RelationwithSender = "Others";
                        model.RelationwithSenderNote = "";
                    }

                    AgentList = AuthService.userMTRedSun.AgentList.ToList();
                    AgentListAll = AuthService.userMTRedSun.AgentListAll.ToList();

                    model.AgentID = AuthService.userMTRedSun.AgentID.ToString();
                    model.AgentType = AuthService.userMTRedSun.AgentType.ToString(); ;
                    if(AuthService.userMTRedSun.AgentID.ToString()=="CA01")
                    {
                        if (AuthService.userMTRedSun.GroupID.ToString() == "4" || AuthService.userMTRedSun.GroupID.ToString() == "5")
                        {
                            var AgentIDN = sessionStorage.GetItem<string>("AgentIDN");
                            if (!string.IsNullOrEmpty(AgentIDN))
                            {
                                model.AgentID = AgentIDN;
                                model.AgentType = AgentList.Where(x => x.Agent_ID == model.AgentID).ToList()[0].TYPE_AGENT;
                            }
                        }
                    }
                    StateHasChanged();

                    PaymentMethodList = AuthService.userMTRedSun.PaymentMethodList.ToList();
                    //if (AuthService.userMTRedSun.PaymentMethodList.Count() > 0)
                    //{
                    //    model.paymentMethod = AuthService.userMTRedSun.PaymentMethodList[1].PayTypeID.ToString();
                    //}

                    typeofPaidAllList = AuthService.userMTRedSun.TypeofPaidList.ToList();
                    TypeofPaidList = typeofPaidAllList.Where(x => x.TypeAgent.Contains( model.AgentType)).ToList();

                    if (TypeofPaidList.Count() > 0)
                    {
                        model.paymentMethod = TypeofPaidList[0].TypeID.ToString();
                    }

                    IDTypeList = AuthService.userMTRedSun.IDTypeList.ToList();
                    if (AuthService.userMTRedSun.IDTypeList.Count() > 0)
                    {
                        model.IDType = AuthService.userMTRedSun.IDTypeList[0].IDType.ToString();
                        model.SBHIDType = AuthService.userMTRedSun.IDTypeList[0].IDType.ToString();
                    }

                    CountryList = AuthService.userMTRedSun.CountryList.ToList();
                    if (AuthService.userMTRedSun.CountryList.Count > 0)
                    {
                        model.CountryIssue = CountryList[0].CountryCode.ToString();
                        model.SBHCountryIssue = CountryList[0].CountryCode.ToString();
                    }

                    SOFList = AuthService.userMTRedSun.SOFList.ToList();
                    if (AuthService.userMTRedSun.SOFList.Count() > 0)
                    {
                        model.SelectSOF = AuthService.userMTRedSun.SOFList[0].SOURCE_NAME.ToString();
                    }
                    if (tc == "US")
                    {
                        StatePayoutAll = AuthService.userMTRedSun.StatePayoutList.ToList();
                        StatePayoutList = AuthService.userMTRedSun.StatePayoutList.ToList();
                        model.PayoutState = StatePayoutAll[0].StateCode.ToString();

                        CityPayoutAll = AuthService.userMTRedSun.CityPayoutList.ToList();
                        CityPayoutList = CityPayoutAll.Where(x => x.StateCode == model.PayoutState).ToList();
                        model.PayoutCity = CityPayoutAll[0].CITY.ToString();
                        PaymentAgentList = PaymentAgentListAll.Where(x => x.STATE == model.PayoutState && x.CITY == model.PayoutCity).OrderByDescending(x=>x.MATDINH).ToList();
                        AgentPayoutList = AgentListAll.Where(x => x.STATE == model.PayoutState && x.CITY == model.PayoutCity).ToList();
                        if (AgentPayoutList.Count > 0)
                        {
                            model.PaymentAgent = AgentPayoutList[0].Agent_ID;
                            model.PayoutAddress = AgentPayoutList[0].FULLADDRESS;
                        }
                    }
                    StateHasChanged();
                    TransactionResp Resp = await HttpService.Post<TransactionResp>("/Transaction/GetNewTransaction", payload);
                    if (Resp.Status == 200)
                    {
                        SendCountryList = Resp.Content.SendCountryList.ToList();
                        if (Resp.Content.SendCountryList.Count > 0)
                        {
                            model.FromCountry = SendCountryList[0].CountryCode.ToString();
                        }
                        ReceiveCountryList = Resp.Content.ReceiveCountryList.ToList();
                        if (Resp.Content.ReceiveCountryList.Count > 0)
                        {
                            model.ToCountry = ReceiveCountryList[0].CountryCode.ToString();
                            if (model.ToCountry == "PH" || model.ToCountry == "CN" || model.ToCountry == "VN")
                            {
                                displayCityPH = "Initial";
                                displayCityNoPH = "None";
                            }
                            else
                            {
                                displayCityPH = "None";
                                displayCityNoPH = "Initial";
                            }
                        }
                        SendCurrencyList = Resp.Content.SendCurrencyList.ToList();
                        if (Resp.Content.SendCurrencyList.Count > 0)
                        {
                            model.FromCurrency = SendCurrencyList[0].CurrencyCode.ToString();
                        }
                        ReceiveCurrencyList = Resp.Content.ReceiveCurrencyList.ToList();
                        if (Resp.Content.ReceiveCurrencyList.Count > 0)
                        {
                            model.ToCurrency = ReceiveCurrencyList[0].CurrencyCode.ToString();
                        }
                        SendStateListNew = Resp.Content.SendStateList.ToArray();
                        SendStateList = Resp.Content.SendStateList.ToList();
                        if (Resp.Content.SendStateList.Count > 0)
                        {
                            model.SBHState = SendStateList[0].StateCode.ToString();
                            model.SState = SendStateList[0].StateCode.ToString();
                        }
                        ReceiveStateList = Resp.Content.ReceiveStateList.ToList();
                        CityList = Resp.Content.CityList.ToList();
                        if (Resp.Content.ReceiveStateList.Count > 0)
                        {
                            model.RState = ReceiveStateList[0].StateCode.ToString();
                        }
                        ReasonforSendingList = Resp.Content.ReasonforSendingList.ToList();
                        model.SelectReason = "Others";

                        TransTypeList = Resp.Content.TransTypeList.ToList();
                        if (Resp.Content.TransTypeList.Count > 0)
                        {
                            model.PaymentMode = TransTypeList[0].PAYABLE_CODE.ToString();
                            StateHasChanged();
                            if (AuthService.userMTRedSun.methodBankList.Contains(model.PaymentMode))
                            {
                                displayBank = "initial";
                            }
                            else
                            {
                                displayBank = "None";
                            }
                            StateHasChanged();
                        }
                        PaymentAgentList = Resp.Content.PaymentAgentList.OrderByDescending(x => x.MATDINH).ToList();
                        PaymentAgentListAll = Resp.Content.PaymentAgentList.OrderByDescending(x => x.MATDINH).ToList();
                        if (PaymentAgentList.Count > 0)
                        {
                            model.PaymentAgent = PaymentAgentList[0].PAY_AG_ID.ToString();
                        }



                        BankList = Resp.Content.BankList.ToList();
                        CustomerList = Resp.Content.CustomerList.ToList();
                        if (CustomerList.Count > 0)
                        {
                            foreach (var c in CustomerList)
                            {
                                model.SFirstName = c.FIRSTNAME == null ? "" : c.FIRSTNAME;
                                model.SMiddleName = c.MIDDLENAME == null ? "" : c.MIDDLENAME;
                                model.SLastName = c.LASTNAME == null ? "" : c.LASTNAME;
                                model.SAddress = c.ADDRESS == null ? "" : c.ADDRESS;
                                model.SCity = c.CITY == null ? "" : c.CITY;

                                if (!string.IsNullOrEmpty(c.STATE == null ? "" : c.STATE))
                                {
                                    model.SState = c.STATE == null ? "" : c.STATE;
                                }
                                model.SPhone = c.PHONE1 == null ? "" : c.PHONE1;
                                model.SEmail = c.EMAIL == null ? "" : c.EMAIL;
                                model.SZipcode = c.ZIP_CODE == null ? "" : c.ZIP_CODE;
                                if (!string.IsNullOrEmpty(c.ID_TYPE == null ? "" : c.ID_TYPE))
                                {
                                    model.IDType = c.ID_TYPE == null ? "" : c.ID_TYPE;
                                }

                                model.ID = c.DRIVER_ID == null ? "" : c.DRIVER_ID;
                                if (!string.IsNullOrEmpty(model.ID))
                                {                                  
                                    labeID = "";
                                }
                                else
                                {
                                    labeID = "";
                                }
                                model.ID_BK = c.DRIVER_ID_BK == null ? "" : c.DRIVER_ID_BK;
                                if (!string.IsNullOrEmpty(c.COUNTRY_ISSUE == null ? "" : c.COUNTRY_ISSUE))
                                {
                                    model.CountryIssue = c.COUNTRY_ISSUE == null ? "" : c.COUNTRY_ISSUE;
                                }
                                if (!string.IsNullOrEmpty(model.CountryIssue))
                                {
                                    dynamic payloadIssue = new
                                    {
                                        Form = "/Transaction/NewTransaction",
                                        FormName = "New Transaction",
                                        Action = "/Index/GetState",
                                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                                        UserID = model.UserID,
                                        CountryCode = model.CountryIssue,
                                        pageIndex = 1,
                                        pageSize = 50
                                    };

                                    var respIssue = await HttpService.Request("post", "/Index/GetState", payloadIssue);
                                    if (respIssue.Status.ToString() == "200")
                                    {
                                        SendStateIssueList = respIssue.Content.StateList;
                                    }
                                    StateHasChanged();
                                }
                                if (!string.IsNullOrEmpty(c.STATE_ISSUE == null ? "" : c.STATE_ISSUE))
                                {
                                    model.StateIssue = c.STATE_ISSUE == null ? "" : c.STATE_ISSUE;
                                }
                                string SDOB = c.DOB_BK == null ? "" : c.DOB_BK;
                                if (string.IsNullOrEmpty(SDOB))
                                {
                                    SDOB = c.DOB == null ? "" : c.DOB;
                                }
                                string SISSUEDATE = c.ISSUE_DATE == null ? "" : c.ISSUE_DATE;
                                string SEXPIREDATE = c.EXPIRATION == null ? "" : c.EXPIRATION;
                                if (!string.IsNullOrEmpty(SISSUEDATE))
                                {
                                    model.IssueDate = c.ISSUE_DATE == null ? null : Convert.ToDateTime(Convert.ToDateTime(c.ISSUE_DATE).ToString("MM/dd/yyyy"));
                                }

                                if (!string.IsNullOrEmpty(SEXPIREDATE))
                                {
                                    model.ExpireDate = c.EXPIRATION == null ? null : Convert.ToDateTime(Convert.ToDateTime(c.EXPIRATION).ToString("MM/dd/yyyy"));
                                    model.ExpireDateBK = c.EXPIRATION == null ? null : Convert.ToDateTime(Convert.ToDateTime(c.EXPIRATION).ToString("MM/dd/yyyy"));
                                }
                                if (!string.IsNullOrEmpty(SDOB) && !SDOB.Contains("XX"))
                                {
                                    System.DateTime.TryParse((Convert.ToDateTime(SDOB).ToString("MM/dd/yyyy")),out d);
                                    model.DOB = d;
                                }

                                model.SSN = c.SSN == null ? "" : c.SSN;
                                model.SSN_BK = c.SSN_BK == null ? "" : c.SSN_BK;
                                model.OccupationM = c.OccupationM == null ? "OTHERS" : c.OccupationM;
                                OccupationDList = OccupationDAllList.Where(x => x.OccupationM == model.OccupationM).ToList();
                                model.OccupationD = c.OccupationD == null ? "OTHERS" : c.OccupationD;
                                model.Occupation = c.Occupation == null ? "" : c.Occupation;
                            }
                        }
                        else
                        {
                            model.SFirstName = "";
                            model.SMiddleName = "";
                            model.SLastName = "";
                            model.SAddress = "";
                            model.SCity = "";
                            model.SPhone = "";
                            model.SEmail = "";
                            model.SZipcode = "";
                            model.ID = "";
                            model.ID_BK = "";
                            model.SSN_BK = "";
                            model.SSN = "";
                            model.Occupation = "";
                        }
                        StateHasChanged();
                        B_CustomerList = Resp.Content.B_CustomerList.ToList();
                        if (B_CustomerList.Count > 0)
                        {
                            foreach (var c in B_CustomerList)
                            {
                                model.RFirstName = c.FIRSTNAME == null ? "" : c.FIRSTNAME;
                                model.RMiddleName = c.MIDDLENAME == null ? "" : c.MIDDLENAME;
                                model.RLastName = c.LASTNAME == null ? "" : c.LASTNAME;
                                model.RLocalName = c.LOCALNAME == null ? "" : c.LOCALNAME;
                                model.RID = c.PASSPORT_NO == null ? "" : c.PASSPORT_NO;
                                model.RFullName2 = c.CN_FIRSTNAME == null ? "" : c.CN_FIRSTNAME;
                                model.RAddress = c.ADDRESS == null ? "" : c.ADDRESS;


                                if (!string.IsNullOrEmpty(c.PROVINCE_ID == null ? "" : c.PROVINCE_ID))
                                {
                                    model.RState = c.PROVINCE_ID == null ? "" : c.PROVINCE_ID;
                                    CityStateList = CityList.Where(x => x.StateId == model.RState && x.CountryCode.Contains(model.ToCountry)).ToList();
                                    if (CityStateList.Count() > 0)
                                    {
                                        model.RCity = CityStateList[0].City.ToString();                                       
                                        
                                    }
                                }
                                if (!string.IsNullOrEmpty(c.CITY == null ? "" : c.CITY))
                                {
                                    model.RCity = c.CITY == null ? "" : c.CITY;
                                }
                                else
                                {
                                    model.RCity = "";
                                }
                                model.RZipcode = c.ZIP_CODE == null ? "" : c.ZIP_CODE;
                                model.RPhone = c.PHONE1 == null ? "" : c.PHONE1;
                                model.RPhone2 = c.PHONE2 == null ? "" : c.PHONE2;
                                model.REmail = c.EMAIL == null ? "" : c.EMAIL;
                                model.RelationwithSender = c.ReasonwithSenderID == null ? "Others" : c.ReasonwithSenderID;
                                model.RelationwithSenderNote = c.RelationwithSenderNote == null ? "" : c.RelationwithSenderNote;
                                if(c.IsAttachFile=="1")
                                {
                                    IsAttachFile = true;
                                }
                                else
                                {
                                    IsAttachFile = false;
                                }
                            }
                        }
                        else
                        {
                            model.RFirstName = "";
                            model.RMiddleName = "";
                            model.RLastName = "";
                            model.RLocalName = "";
                            model.RID = "";
                            model.RFullName2 = "";
                            model.RAddress = "";
                            model.RCity = "";
                            model.RZipcode = "";
                            model.RPhone = "";
                            model.RPhone2 = "";
                            model.REmail = "";
                        }
                    }
                    dynamic payload5 = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Customer/GetReceiverBank",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        B_CustID = BCustID,
                        Country = model.ToCountry,
                        PaymentAgent = model.PaymentAgent,
                        Currency = model.ToCurrency,
                        pageIndex = 1,
                        pageSize = 50
                    };
                    if (model.ToCountry == "CN")
                    {
                        displayBankCountry = "initial";
                    }
                    BankListIDResp respB = await HttpService.Post<BankListIDResp>("/Customer/GetReceiverBank", payload5);
                    if (respB.Status == 200)
                    {
                        BankIDAllList = respB.Content.BankList;
                        BankIDList = respB.Content.BankList.Where(x => x.CURRENCY == model.ToCurrency || x.CURRENCY == "").OrderByDescending(x => x.Hidedate).ToList();
                        ChangeBank0();
                        //modelAddBank.BankID = resp.Content.ListBank[0].BANK_CODE.ToString();
                    }

                    TransTypeListNew = new List<TransTypeList>();
                    switch (model.ToCountry)
                    {
                        case "CN":
                            //model.PaymentAgent = "CN4-CHINA-RMB";
                            if (TransTypeList.Count > 0)
                            {
                                foreach (var item in TransTypeList)
                                {
                                    if (!string.IsNullOrEmpty(item.PAYMENT_AGENT))
                                    {
                                        if (item.PAYMENT_AGENT.Contains(model.PaymentAgent))
                                        {
                                            TransTypeList TransTypeNew = new TransTypeList();
                                            TransTypeNew.PAYABLE_CODE = item.PAYABLE_CODE;
                                            TransTypeNew.DESCRIPTION = item.DESCRIPTION;
                                            TransTypeNew.PAYMENT_AGENT = item.PAYMENT_AGENT == null ? "" : item.PAYMENT_AGENT;
                                            TransTypeListNew.Add(TransTypeNew);
                                        }
                                    }

                                }
                                if (TransTypeListNew.Count > 0)
                                {
                                    model.PaymentMode = TransTypeListNew[0].PAYABLE_CODE.ToString();
                                }
                            }
                            break;
                        case "PH":
                            //model.PaymentAgent = "PH1-FILREMIT";
                            if (TransTypeList.Count > 0)
                            {
                                foreach (var item in TransTypeList)
                                {
                                    if (!string.IsNullOrEmpty(item.PAYMENT_AGENT))
                                    {
                                        if (item.PAYMENT_AGENT.Contains(model.PaymentAgent))
                                        {
                                            TransTypeList TransTypeNew = new TransTypeList();
                                            TransTypeNew.PAYABLE_CODE = item.PAYABLE_CODE;
                                            TransTypeNew.DESCRIPTION = item.DESCRIPTION;
                                            TransTypeNew.PAYMENT_AGENT = item.PAYMENT_AGENT == null ? "" : item.PAYMENT_AGENT;
                                            TransTypeListNew.Add(TransTypeNew);
                                        }
                                    }
                                }
                                if (TransTypeListNew.Count > 0)
                                {
                                    model.PaymentMode = TransTypeListNew[0].PAYABLE_CODE.ToString();
                                }
                            }
                            break;
                        case "VN":
                            //model.PaymentAgent = "VN1-HONGLAN LLC";
                            model.PaymentMode = "D2D";
                            if (TransTypeList.Count > 0)
                            {
                                foreach (var item in TransTypeList)
                                {
                                    TransTypeList TransTypeNew = new TransTypeList();
                                    TransTypeNew.PAYABLE_CODE = item.PAYABLE_CODE;
                                    TransTypeNew.DESCRIPTION = item.DESCRIPTION;
                                    TransTypeNew.PAYMENT_AGENT = item.PAYMENT_AGENT == null ? "" : item.PAYMENT_AGENT;
                                    TransTypeListNew.Add(TransTypeNew);
                                }

                            }
                            break;
                        default:
                            if (TransTypeList.Count > 0)
                            {
                                foreach (var item in TransTypeList)
                                {
                                    TransTypeList TransTypeNew = new TransTypeList();
                                    TransTypeNew.PAYABLE_CODE = item.PAYABLE_CODE;
                                    TransTypeNew.DESCRIPTION = item.DESCRIPTION;
                                    TransTypeNew.PAYMENT_AGENT = item.PAYMENT_AGENT==null?"": item.PAYMENT_AGENT ;
                                    TransTypeListNew.Add(TransTypeNew);
                                }
                                if (TransTypeListNew.Count > 0)
                                {
                                    model.PaymentMode = TransTypeListNew[0].PAYABLE_CODE.ToString();
                                }
                            }
                            break;
                    }
                    StateHasChanged();
                    await getDiscountList();
                    await getBank();
                    if (AuthService.userMTRedSun.methodBankList.Contains(model.PaymentMode))
                    {
                        displayBank = "initial";
                        if (model.ToCountry == "CN")
                        {
                            MinHeghtSAmount = "273px";
                        }
                        else
                        {
                            MinHeghtSAmount = "315px";
                        }

                    }
                    else
                    {
                        MinHeghtSAmount = "384px";
                    }
                    ControlPermission();
                }
                

            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            LoadingReport = false;
            StateHasChanged();
        }
        public async Task getDiscountList()
        {
            try
            {
                StateHasChanged();
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Index/GetDiscountAgent",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    FromDate = System.DateTime.UtcNow.AddHours(-7),
                    AgentID = model.AgentID,
                    FromCountry=model.FromCountry,
                    ToCountry = model.ToCountry
                };
                DiscountDetailListResps resp = await HttpService.Post<DiscountDetailListResps>("/Index/GetDiscountAgent", payload);
                if (resp.Status.ToString() == "200")
                {
                    DiscountList = resp.Content.DiscountList;
                }
                else
                {
                    DiscountList = new List<DiscountList>();
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            this.StateHasChanged();
        }
        private async void ControlPermission()
        {
            List<ControlPageList> ControlPageLists = ControlPageList.Where(x => x.PageName == "NewTransaction.aspx").ToList();
            if (ControlPageLists.Count() > 0)
            {
                foreach (var item in ControlPageLists)
                {
                    switch (item.ControlPageN)
                    {
                        case "D_AgentID":
                            if (isNewCustomer && isNewReceiver)
                            {
                                D_AgentID = item.chkEnable?false:true;
                            }
                            else
                            {
                                if (item.chkOfSender)
                                {
                                    if (!isNewCustomer)
                                    {
                                        D_AgentID = item.chkSender?false:true;
                                    }
                                    else
                                    {
                                        D_AgentID = item.chkEnable?false:true;
                                    }
                                }
                                else
                                {
                                    if (item.chkOfReceiver)
                                    {
                                        if (!isNewReceiver)
                                        {
                                            D_AgentID = item.chkReceiver?false:true;
                                        }
                                        else
                                        {
                                            D_AgentID = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        D_AgentID = item.chkEnable?false:true;
                                    }
                                }
                            }
                            if (D_AgentID)
                            {
                                C_AgentID = DisableColor;
                            }
                            else
                            {
                                C_AgentID = back;
                            }
                            break;
                        case "D_SFirstName":
                            if (string.IsNullOrEmpty(model.SFirstName))
                            {
                                D_SFirstName = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SFirstName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SFirstName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SFirstName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SFirstName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SFirstName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SFirstName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if(D_SFirstName)
                            {
                                C_SFirstName = DisableColor;
                            }
                            else
                            {
                                C_SFirstName = back;
                            }
                            break;
                        case "D_SMiddleName":
                            if (string.IsNullOrEmpty(model.SMiddleName))
                            {
                                D_SMiddleName = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SMiddleName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SMiddleName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SMiddleName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SMiddleName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SMiddleName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SMiddleName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SMiddleName)
                            {
                                C_SMiddleName = DisableColor;
                            }
                            else
                            {
                                C_SMiddleName = back;
                            }
                            break;
                        case "D_SLastName":
                            if (string.IsNullOrEmpty(model.SLastName))
                            {
                                D_SLastName = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SLastName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SLastName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SLastName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SLastName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SLastName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SLastName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SLastName)
                            {
                                C_SLastName = DisableColor;
                            }
                            else
                            {
                                C_SLastName = back;
                            }
                            break;
                        case "D_SAddress":
                        case "D_Saddress":
                            if (string.IsNullOrEmpty(model.SAddress))
                            {
                                D_SAddress = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SAddress = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SAddress = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SAddress = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SAddress = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SAddress = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SAddress = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SAddress)
                            {
                                C_SAddress = DisableColor;
                            }
                            else
                            {
                                C_SAddress = back;
                            }
                            break;
                        case "D_SCity":
                            if (string.IsNullOrEmpty(model.SCity))
                            {
                                D_SCity = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SCity = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SCity = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SCity = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SCity = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SCity = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SCity = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SCity)
                            {
                                C_SCity = DisableColor;
                            }
                            else
                            {
                                C_SCity = back;
                            }
                            break;
                        case "D_SState":
                            if (string.IsNullOrEmpty(model.SState))
                            {
                                D_SState = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SState = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SState = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SState = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SState = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SState = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SState = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SState)
                            {
                                C_SState = DisableColor;
                            }
                            else
                            {
                                C_SState = back;
                            }
                            break;
                        case "D_SZipcode":
                            if (string.IsNullOrEmpty(model.SZipcode))
                            {
                                D_SZipcode = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SZipcode = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SZipcode = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SZipcode = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SZipcode = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SZipcode = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SZipcode = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SZipcode)
                            {
                                C_SZipcode = DisableColor;
                            }
                            else
                            {
                                C_SZipcode = back;
                            }
                            break;
                        case "D_SPhone":
                            if (string.IsNullOrEmpty(model.SPhone))
                            {
                                D_SPhone = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SPhone = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SPhone = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SPhone = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SPhone = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SPhone = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SPhone = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SPhone)
                            {
                                C_SPhone = DisableColor;
                            }
                            else
                            {
                                C_SPhone = back;
                            }
                            break;
                        case "D_SEmail":
                            if (string.IsNullOrEmpty(model.SEmail))
                            {
                                D_SEmail = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SEmail = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SEmail = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SEmail = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SEmail = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SEmail = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SEmail = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SEmail)
                            {
                                C_SEmail = DisableColor;
                            }
                            else
                            {
                                C_SEmail = back;
                            }
                            break;
                        case "D_RFirstName":
                            if (string.IsNullOrEmpty(model.RFirstName))
                            {
                                D_RFirstName = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RFirstName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RFirstName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RFirstName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RFirstName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RFirstName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RFirstName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RFirstName)
                            {
                                C_RFirstName = DisableColor;
                            }
                            else
                            {
                                C_RFirstName = back;
                            }
                            break;
                        case "D_RMiddleName":
                            if (string.IsNullOrEmpty(model.RMiddleName))
                            {
                                D_RMiddleName = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RMiddleName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RMiddleName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RMiddleName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RMiddleName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RMiddleName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RMiddleName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RMiddleName)
                            {
                                C_RMiddleName = DisableColor;
                            }
                            else
                            {
                                C_RMiddleName = back;
                            }
                            break;
                        case "D_RLastName":
                            if (string.IsNullOrEmpty(model.RLastName))
                            {
                                D_RLastName = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RLastName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RLastName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RLastName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RLastName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RLastName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RLastName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RLastName)
                            {
                                C_RLastName = DisableColor;
                            }
                            else
                            {
                                C_RLastName = back;
                            }
                            break;
                        case "D_RLocalName":
                            if (string.IsNullOrEmpty(model.RLocalName))
                            {
                                D_RLocalName = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RLocalName = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RLocalName = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RLocalName = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RLocalName = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RLocalName = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RLocalName = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RLocalName)
                            {
                                C_RLocalName = DisableColor;
                            }
                            else
                            {
                                C_RLocalName = back;
                            }
                            break;
                        case "D_RID":
                            if (string.IsNullOrEmpty(model.RID))
                            {
                                D_RID = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RID = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RID = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RID = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RID = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RID = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RID = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RID)
                            {
                                C_RID = DisableColor;
                            }
                            else
                            {
                                C_RID = back;
                            }
                            break;
                        case "D_RFullName2":
                            if (string.IsNullOrEmpty(model.RFullName2))
                            {
                                D_RFullName2 = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RFullName2 = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RFullName2 = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RFullName2 = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RFullName2 = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RFullName2 = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RFullName2 = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RFullName2)
                            {
                                C_RFullName2 = DisableColor;
                            }
                            else
                            {
                                C_RFullName2 = back;
                            }
                            break;
                        case "D_RAddress":
                            if (string.IsNullOrEmpty(model.RAddress))
                            {
                                D_RAddress = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RAddress = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RAddress = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RAddress = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RAddress = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RAddress = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RAddress = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RAddress)
                            {
                                C_RAddress = DisableColor;
                            }
                            else
                            {
                                C_RAddress = back;
                            }
                            break;
                        case "D_RCity":
                            if (string.IsNullOrEmpty(model.RCity))
                            {
                                D_RCity = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RCity = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RCity = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RCity = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RCity = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RCity = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RCity = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RCity)
                            {
                                C_RCity = DisableColor;
                            }
                            else
                            {
                                C_RCity = back;
                            }
                            break;
                        case "D_RState":
                            if (string.IsNullOrEmpty(model.RState))
                            {
                                D_RState = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RState = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RState = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RState = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RState = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RState = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RState = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RState)
                            {
                                C_RState = DisableColor;
                            }
                            else
                            {
                                C_RState = back;
                            }
                            break;
                        case "D_RZipcode":
                            if (string.IsNullOrEmpty(model.RZipcode))
                            {
                                D_RZipcode = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RZipcode = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RZipcode = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RZipcode = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RZipcode = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RZipcode = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RZipcode = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RZipcode)
                            {
                                C_RZipcode = DisableColor;
                            }
                            else
                            {
                                C_RZipcode = back;
                            }
                            break;
                        case "D_RPhone":
                            if (string.IsNullOrEmpty(model.RPhone))
                            {
                                D_RPhone = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RPhone = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RPhone = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RPhone = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RPhone = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RPhone = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RPhone = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RPhone)
                            {
                                C_RPhone = DisableColor;
                            }
                            else
                            {
                                C_RPhone = back;
                            }
                            break;
                        case "D_RPhone2":
                            if (string.IsNullOrEmpty(model.RPhone2))
                            {
                                D_RPhone2 = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_RPhone2 = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_RPhone2 = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_RPhone2 = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_RPhone2 = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_RPhone2 = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_RPhone2 = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_RPhone2)
                            {
                                C_RPhone2 = DisableColor;
                            }
                            else
                            {
                                C_RPhone2 = back;
                            }
                            break;
                        case "D_REmail":
                            if (string.IsNullOrEmpty(model.REmail))
                            {
                                D_REmail = false;;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_REmail = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_REmail = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_REmail = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_REmail = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_REmail = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_REmail = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_REmail)
                            {
                                C_REmail = DisableColor;
                            }
                            else
                            {
                                C_REmail = back;
                            }
                            break;
                        case "D_ID":
                            if (string.IsNullOrEmpty(model.ID))
                            {
                                D_ID = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_ID = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_ID = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_ID = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_ID = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_ID = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_ID = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_ID)
                            {
                                IdBackground = "BackgroundDisable";
                            }
                            else
                            {
                                IdBackground = "BackgroundWhite";
                            }
                            break;
                        case "D_CountryIssue":
                            if (string.IsNullOrEmpty(model.CountryIssue))
                            {
                                D_CountryIssue = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_CountryIssue = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_CountryIssue = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_CountryIssue = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_CountryIssue = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_CountryIssue = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_CountryIssue = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_CountryIssue)
                            {
                                C_CountryIssue = DisableColor;
                            }
                            else
                            {
                                C_CountryIssue = back;
                            }
                            break;
                        case "D_StateIssue":
                            if (string.IsNullOrEmpty(model.StateIssue))
                            {
                                D_StateIssue = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_StateIssue = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_StateIssue = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_StateIssue = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_StateIssue = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_StateIssue = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_StateIssue = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_StateIssue)
                            {
                                C_StateIssue = DisableColor;
                            }
                            else
                            {
                                C_StateIssue = back;
                            }
                            break;
                        case "D_DOB":
                            if (model.DOB==null)
                            {
                                D_DOB = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_DOB = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_DOB = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_DOB = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_DOB = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_DOB = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_DOB = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_DOB)
                            {
                                C_DOB = DisableColor;
                            }
                            else
                            {
                                C_DOB = back;
                            }
                            break;
                        case "D_SSN":
                            if (string.IsNullOrEmpty(model.SSN))
                            {
                                D_SSN = false;
                            }
                            else
                            {
                                if (isNewCustomer && isNewReceiver)
                                {
                                    D_SSN = item.chkEnable?false:true;
                                }
                                else
                                {
                                    if (item.chkOfSender)
                                    {
                                        if (!isNewCustomer)
                                        {
                                            D_SSN = item.chkSender?false:true;
                                        }
                                        else
                                        {
                                            D_SSN = item.chkEnable?false:true;
                                        }
                                    }
                                    else
                                    {
                                        if (item.chkOfReceiver)
                                        {
                                            if (!isNewReceiver)
                                            {
                                                D_SSN = item.chkReceiver?false:true;
                                            }
                                            else
                                            {
                                                D_SSN = item.chkEnable?false:true;
                                            }
                                        }
                                        else
                                        {
                                            D_SSN = item.chkEnable?false:true;
                                        }
                                    }
                                }
                            }
                            if (D_SSN)
                            {
                                SSNBackground = "BackgroundDisable NumberOnly";
                            }
                            else
                            {
                                SSNBackground = "BackgroundWhite NumberOnly";
                            }
                            break;
                        case "D_Discount": 
                            D_Discount = item.chkEnable ? false : true;
                            break;
                        default:
                            // code block
                            break;

                    }
                }
            }
        }
        private async void UpdateServiceFee()
        {

            StateHasChanged();
            string TypeOther = "0";
            TypeofPaidListSelect = TypeofPaidList.Where(x => x.TypeID == model.paymentMethod).ToList();
            TypeOtherFee = TypeofPaidListSelect[0].OtherFee;
            if (TypeOtherFee)
                {
                    TypeOther = "1";
                }
                dynamic payload = new
                {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Transaction/GeTransactionServices",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                AgentID = model.AgentID,
                FromCountry = model.FromCountry,
                ToCountry = model.ToCountry,
                FromCurrency = model.FromCurrency,
                ToCurrency = model.ToCurrency,
                RStateID = model.RState,
                TransType = model.PaymentMode,
                paymentMethod = model.paymentMethod,
                SendAmount = model.SendAmount,
                LandedAmount = model.LandedAmount,
                ServicesFee = model.TransferFee,
                OtherFee = model.OtherFee,
                Type = TypeServices,
                DiscountID = model.DiscountID,
                DiscountAmount = model.Discount,
                ExchangeRate = model.ExchangeRate,
                    TypeOther= TypeOther

                };
            if (model.SendAmount == 0 && model.LandedAmount == 0)
            {
                model.AgentFee = 0;
                model.SendAmount = 0;
                model.OtherFee = 0;
                model.TaxFee = 0;
                model.Discount = 0;
                model.TransferFee = 0;
                model.LandedAmount = 0;
                model.TotalAmount = 0;
            }
            else
            {
                TransactionServiceResp resp = await HttpService.Post<TransactionServiceResp>("/Transaction/GeTransactionServices", payload);
                if (resp.Status == 200)
                {
                    model.SendAmount = resp.Content.SendAmount;
                    if(TypeOtherFee)
                    {
                        model.OtherFee = resp.Content.OtherFee;
                    }
                    
                    model.TaxFee = resp.Content.TaxFee;
                    model.Discount = resp.Content.DiscountAmount;
                    model.TransferFee = resp.Content.ServicesFee;
                    model.LandedAmount = resp.Content.LandedAmount;
                    model.AgentFee = resp.Content.AgentFee;

                    if (model.ToCountry == "VN")
                    {
                        model.ExchangeRate = Math.Round(resp.Content.ExchangeRate, 0); 
                    }
                    else
                    {
                        model.ExchangeRate = Math.Round(resp.Content.ExchangeRate, 4); ;
                    }

                    model.TotalAmount = resp.Content.TotalAmount;
                }
                else
                {
                    model.AgentFee = 0;
                    model.SendAmount = 0;
                    model.OtherFee = 0;
                    model.TaxFee = 0;
                    model.Discount = 0;
                    model.TransferFee = 0;
                    model.LandedAmount = 0;
                    model.TotalAmount = 0;
                }
            }


            StateHasChanged();
        }
        private async void getAgentState()
        {
            StateHasChanged();


            StateHasChanged();
        }
        protected async void ChangeAgentID(ChangeEventArgs e)
        {
            StateHasChanged();
            model.AgentID = e.Value.ToString();
            model.AgentType = AgentList.Where(x => x.Agent_ID == model.AgentID).ToList()[0].TYPE_AGENT;
            sessionStorage.SetItem("AgentIDN", (model.AgentID == null ? "" : model.AgentID));
            StateHasChanged();

           

            typeofPaidAllList = AuthService.userMTRedSun.TypeofPaidList.ToList();
            TypeofPaidList = typeofPaidAllList.Where(x => x.TypeAgent.Contains(model.AgentType)).ToList();

            if (TypeofPaidList.Count() > 0)
            {
                model.paymentMethod = TypeofPaidList[0].TypeID.ToString();
            }

            getAgentState();
            model.CheckAgentState = false;
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Transaction/getAgentState",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                USER_ID = model.UserID,
                AGENT_ID = model.AgentID

            };
            getAgentStateResp resp = await HttpService.Post<getAgentStateResp>("/Transaction/getAgentState", payload);
            if (resp.Status == 200)
            {
                model.AgentState = resp.Content.ToString();
            }
            StateHasChanged();
            if (model.AgentState.ToString() == "NY" && model.ToCountry.ToString() == "CN")
            {
                displayVerificationChecked = "initial";
            }
            else
            {
                displayVerificationChecked = "None";
            }
            await getDiscountList();
            UpdateServiceFee();

            StateHasChanged();
        }

        protected async void ChangeAgentIDN()
        {
            StateHasChanged();
           
            model.AgentType = AgentList.Where(x => x.Agent_ID == model.AgentID).ToList()[0].TYPE_AGENT;
            sessionStorage.SetItem("AgentIDN", (model.AgentID == null ? "" : model.AgentID));
            StateHasChanged();



            typeofPaidAllList = AuthService.userMTRedSun.TypeofPaidList.ToList();
            TypeofPaidList = typeofPaidAllList.Where(x => x.TypeAgent.Contains(model.AgentType)).ToList();

            if (TypeofPaidList.Count() > 0)
            {
                model.paymentMethod = TypeofPaidList[0].TypeID.ToString();
            }

            getAgentState();
            model.CheckAgentState = false;
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Transaction/getAgentState",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                USER_ID = model.UserID,
                AGENT_ID = model.AgentID

            };
            getAgentStateResp resp = await HttpService.Post<getAgentStateResp>("/Transaction/getAgentState", payload);
            if (resp.Status == 200)
            {
                model.AgentState = resp.Content.ToString();
            }
            StateHasChanged();
            if (model.AgentState.ToString() == "NY" && model.ToCountry.ToString() == "CN")
            {
                displayVerificationChecked = "initial";
            }
            else
            {
                displayVerificationChecked = "None";
            }
            await getDiscountList();
            UpdateServiceFee();

            StateHasChanged();
        }
        protected async void ChangDiscountID(ChangeEventArgs e)
        {
            StateHasChanged();
            model.DiscountID = e.Value.ToString();          
            UpdateServiceFee();
            StateHasChanged();
        }
        protected async void ChangeBank(ChangeEventArgs e)
        {
            StateHasChanged();
            model.BankID = e.Value.ToString();
            
            var bankList = BankIDList.Find(x => x.ID ==e.Value.ToString());
            if (bankList != null)
            {
                model.BankCode = bankList.SWIFTCODE;
                model.BankName = bankList.BANK_NAME;
                model.AccountNo = bankList.ACCOUNT_NO;
                //model.BankCode = bankList.SWIFTCODE;
                model.Swiftcode = bankList.SWIFTCODE;
                model.BankProvince = bankList.BankProvince==null?"": bankList.BankProvince;
                model.BankCity = bankList.BankCity == null ? "" : bankList.BankCity;
                dynamic payload2 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/GetBankProvince",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    Country = model.ToCountry
                };
                StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
                if (respProvince.Status == 200)
                {
                    ProvinceBankList = respProvince.Content.BankProvinceList;
                }
                else
                {
                    ProvinceBankList = new List<StateList>();
                }
                model.BankProvince = bankList.BankProvince == null ? "" : bankList.BankProvince;
              
                StateHasChanged();

                
            }
            if (!string.IsNullOrEmpty(model.BankID))
            {
                if (model.BankID.ToUpper().Contains("SELECT BANK") || model.BankID.ToUpper() == "0")
                {
                    IsEditBankButton = true;
                }
                else
                {
                    IsEditBankButton = false;
                }
            }
            else
            {
                IsEditBankButton = true;
            }
            StateHasChanged();
        }
        protected async void ChangeBankUpdate(string BankID)
        {
            StateHasChanged();
            model.BankID = BankID;

            var bankList = BankIDList.Find(x => x.ID == BankID);
            if (bankList != null)
            {
                model.BankCode = bankList.SWIFTCODE;
                model.BankName = bankList.BANK_NAME;
                model.AccountNo = bankList.ACCOUNT_NO;
                //model.BankCode = bankList.SWIFTCODE;
                model.Swiftcode = bankList.SWIFTCODE;
                model.BankProvince = bankList.BankProvince == null ? "" : bankList.BankProvince;
                model.BankCity = bankList.BankCity == null ? "" : bankList.BankCity;
                dynamic payload2 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/GetBankProvince",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    Country = model.ToCountry
                };
                StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
                if (respProvince.Status == 200)
                {
                    ProvinceBankList = respProvince.Content.BankProvinceList;
                }
                else
                {
                    ProvinceBankList = new List<StateList>();
                }
                model.BankProvince = bankList.BankProvince == null ? "" : bankList.BankProvince;

                StateHasChanged();


            }
            if (!string.IsNullOrEmpty(model.BankID))
            {
                if (model.BankID.ToUpper().Contains("SELECT BANK") || model.BankID.ToUpper() == "0")
                {
                    IsEditBankButton = true;
                }
                else
                {
                    IsEditBankButton = false;
                }
            }
            else
            {
                IsEditBankButton = true;
            }
            StateHasChanged();
        }
        protected async void ChangeBank0()
        {
            StateHasChanged();
            model.BankID = "0";

            if(BankIDList.Count>1)
            {
                model.BankID = BankIDList[0].ID.ToString();
                model.BankCode = BankIDList[0].SWIFTCODE;
                model.BankName = BankIDList[0].BANK_NAME;
                model.AccountNo = BankIDList[0].ACCOUNT_NO;
                model.BankCode = BankIDList[0].SWIFTCODE;
                model.Swiftcode = BankIDList[0].SWIFTCODE;
                dynamic payload2 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/GetBankProvince",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    Country = model.ToCountry
                };
                StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
                if (respProvince.Status == 200)
                {
                    ProvinceBankList = respProvince.Content.BankProvinceList;
                }
                else
                {
                    ProvinceBankList = new List<StateList>();
                }
                model.BankProvince = BankIDList[0].BankProvince == null ? "" : BankIDList[0].BankProvince;
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/GetBankDistrict",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    Country = model.ToCountry,
                    CountryCode = model.ToCountry,
                    StateID = model.BankProvince,
                    PaymentAgent = "",
                    CurrencyCode = model.ToCurrency,
                    pageIndex = 1,
                    pageSize = 50
                };
                BankDistrictListResp resp = await HttpService.Post<BankDistrictListResp>("/Customer/GetBankDistrict", payload);
                if (resp.Status == 200)
                {
                    BankDistrictList = resp.Content.BankDistrictList;
                    model.BankCity = BankDistrictList[0].City;
                }
                StateHasChanged();

                model.BankCity = BankIDList[0].BankCity == null ? "" : BankIDList[0].BankCity;
               
                if (!string.IsNullOrEmpty(model.BankID))
                {
                    if (model.BankID.ToUpper().Contains("SELECT BANK") || model.BankID.ToUpper() == "0")
                    {
                        IsEditBankButton = true;
                    }
                    else
                    {
                        IsEditBankButton = false;
                    }
                }
                else
                {
                    IsEditBankButton = true;
                }
            }
            else
            {
                var bankList = BankIDList.Find(x => x.ID == "0");
                if (bankList != null)
                {
                    model.BankCode = bankList.SWIFTCODE;
                    model.BankName = bankList.BANK_NAME;
                    model.AccountNo = bankList.ACCOUNT_NO;
                    model.BankCode = bankList.SWIFTCODE;
                    model.Swiftcode = bankList.SWIFTCODE;
                    dynamic payload2 = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Customer/GetBankProvince",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        Country = model.ToCountry
                    };
                    StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
                    if (respProvince.Status == 200)
                    {
                        ProvinceBankList = respProvince.Content.BankProvinceList;
                    }
                    else
                    {
                        ProvinceBankList = new List<StateList>();
                    }
                    model.BankProvince = bankList.BankProvince == null ? "" : bankList.BankProvince;
                    dynamic payload = new
                    {
                        Form = "/Transaction/NewTransaction",
                        FormName = "New Transaction",
                        Action = "/Customer/GetBankDistrict",
                        UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                        UserID = model.UserID,
                        Country = model.ToCountry,
                        CountryCode = model.ToCountry,
                        StateID = model.BankProvince,
                        PaymentAgent = "",
                        CurrencyCode = model.ToCurrency,
                        pageIndex = 1,
                        pageSize = 50
                    };
                    BankDistrictListResp resp = await HttpService.Post<BankDistrictListResp>("/Customer/GetBankDistrict", payload);
                    if (resp.Status == 200)
                    {
                        BankDistrictList = resp.Content.BankDistrictList;
                        model.BankCity = BankDistrictList[0].City;
                    }
                    StateHasChanged();

                    model.BankCity = bankList.BankCity == null ? "" : bankList.BankCity;
                }
                if (!string.IsNullOrEmpty(model.BankID))
                {
                    if (model.BankID.ToUpper().Contains("SELECT BANK") || model.BankID.ToUpper() == "0")
                    {
                        IsEditBankButton = true;
                    }
                    else
                    {
                        IsEditBankButton = false;
                    }
                }
                else
                {
                    IsEditBankButton = true;
                }
            }
           
            StateHasChanged();
        }
        protected async void ChangMainBankAdd(ChangeEventArgs e)
        {
            StateHasChanged();
            modelAddBank.MainBank = e.Value.ToString();
            if(modelAddBank.MainBank=="OTHER")
            {
                isBankOther = false;
            }
            else
            {
                isBankOther = true;
            }
            StateHasChanged();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Customer/getBankCity",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelAddBank.Province,
                MainBank = modelAddBank.MainBank,
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankCityListResp resp = await HttpService.Post<BankCityListResp>("/Customer/getBankCity", payload);
            if (resp.Status == 200)
            {
                BankCityList = resp.Content.BankCityList;
                BankCityLists = BankCityList.FirstOrDefault();
                modelAddBank.bankCity = BankCityLists.City;
            }
            dynamic payload1 = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/GetBankList",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelAddBank.Province,
                MainBank = modelAddBank.MainBank,
                City = modelAddBank.bankCity,
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankListResp resp1 = await HttpService.Post<BankListResp>("/Index/GetBankList", payload1);
            if (resp1.Status == 200)
            {

                BankList = resp1.Content.ListBank;
                modelAddBank.BankID = resp1.Content.ListBank[0].BANK_CODE.ToString();
            }
            else
            {
                if (resp.Status == 99)
                {
                    toastService.ShowWarning("User is not Exist or Expire");
                    await AuthService.Logout();
                }
                BankList = new List<BankList>();
            }
            this.StateHasChanged();
            StateHasChanged();
        }
        protected async void ChangMainCityAdd(ChangeEventArgs e)
        {
            StateHasChanged();
            modelAddBank.bankCity = e.Value.ToString();
           
            //dynamic payload1 = new
            //{
            //    Form = "/Transaction/NewTransaction",
            //    FormName = "New Transaction",
            //    Action = "/Index/GetBankList",
            //    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
            //    UserID = model.UserID,
            //    Country = model.ToCountry,
            //    CountryCode = model.ToCountry,
            //    StateID = modelAddBank.Province,
            //    MainBank = modelAddBank.MainBank,
            //    City = modelAddBank.bankCity,
            //    CurrencyCode = model.ToCurrency,
            //    pageIndex = 1,
            //    pageSize = 50
            //};
            //BankListResp resp1 = await HttpService.Post<BankListResp>("/Index/GetBankList", payload1);
            //if (resp1.Status == 200)
            //{

            //    BankList = resp1.Content.ListBank;
            //    modelAddBank.BankID = resp1.Content.ListBank[0].BANK_CODE.ToString();
            //}
            //else
            //{
            //    if (resp1.Status == 99)
            //    {
            //        toastService.ShowWarning("User is not Exist or Expire");
            //        await AuthService.Logout();
            //    }
            //    BankList = new List<BankList>();
            //}
            this.StateHasChanged();
            StateHasChanged();
        }

        public async Task getBank()
        {
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "GetBankList",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankListResp resp = await HttpService.Post<BankListResp>("/Index/GetBankList", payload);
            if (resp.Status == 200)
            {
                BankList = resp.Content.ListBank;
                if(BankList.Count>0)
                {
                    modelAddBank.BankID = resp.Content.ListBank[0].BANK_CODE.ToString();
                    modelAddBank.BANK_NAME = resp.Content.ListBank[0].BANK_NAME.ToString();
                    modelAddBank.Swiftcode = resp.Content.ListBank[0].BANK_CODE.ToString();
                }
                
            }
            StateHasChanged();
        }
        public async Task getBankCity(string BankCode,string TypeBank)
        {
            dynamic payload3 = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "getBankCity",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                //StateID = modelEditBank.Province,
                BankCode = BankCode,
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankCityListResp resp2 = await HttpService.Post<BankCityListResp>("/Customer/getBankCity", payload3);
            if (resp2.Status == 200)
            {
                BankCityList = resp2.Content.BankCityList;
                BankCityLists = BankCityList.FirstOrDefault();
                if(TypeBank=="Add")
                {
                    modelAddBank.bankCity = BankCityLists.City;
                }
                else
                {
                    modelEditBank.bankCity = BankCityLists.City;
                }
            }
            StateHasChanged();
        }
        protected async void ChangMainCityEdit(ChangeEventArgs e)
        {
            StateHasChanged();
            modelEditBank.bankCity = e.Value.ToString();
            
            //dynamic payload1 = new
            //{
            //    Form = "/Transaction/NewTransaction",
            //    FormName = "New Transaction",
            //    Action = "/Index/GetBankList",
            //    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
            //    UserID = model.UserID,
            //    Country = model.ToCountry,
            //    CountryCode = model.ToCountry,
            //    StateID = modelEditBank.Province,
            //    MainBank = modelEditBank.MainBank,
            //    City = modelEditBank.bankCity,
            //    CurrencyCode = model.ToCurrency,
            //    pageIndex = 1,
            //    pageSize = 50
            //};
            //BankListResp resp1 = await HttpService.Post<BankListResp>("/Index/GetBankList", payload1);
            //if (resp1.Status == 200)
            //{

            //    BankList = resp1.Content.ListBank;
            //    modelEditBank.BankID = resp1.Content.ListBank[0].BANK_CODE.ToString();
            //}
            //else
            //{
            //    if (resp1.Status == 99)
            //    {
            //        toastService.ShowWarning("User is not Exist or Expire");
            //        await AuthService.Logout();
            //    }
            //    BankList = new List<BankList>();
            //}
            StateHasChanged();
        }
        protected async void ChangMainBankEdit(ChangeEventArgs e)
        {
            StateHasChanged();
            modelEditBank.MainBank = e.Value.ToString();
            if (modelEditBank.MainBank == "OTHER")
            {
                isBankOther = false;
            }
            else
            {
                isBankOther = true;
            }
            StateHasChanged();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/getBankCity",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelEditBank.Province,
                MainBank = modelEditBank.MainBank,
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankCityListResp resp = await HttpService.Post<BankCityListResp>("/Customer/getBankCity", payload);
            if (resp.Status == 200)
            {
                BankCityList = resp.Content.BankCityList;
                BankCityLists = BankCityList.FirstOrDefault();
                modelEditBank.bankCity = BankCityLists.City;
            }
            dynamic payload1 = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/GetBankList",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelEditBank.Province,
                MainBank = modelEditBank.MainBank,
                City = modelEditBank.bankCity,
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            //BankListResp resp1 = await HttpService.Post<BankListResp>("/Index/GetBankList", payload1);
            //if (resp1.Status == 200)
            //{

            //    BankList = resp1.Content.ListBank;
            //    modelAddBank.BankID = resp1.Content.ListBank[0].BANK_CODE.ToString();
            //}
            //else
            //{
            //    if (resp.Status == 99)
            //    {
            //        toastService.ShowWarning("User is not Exist or Expire");
            //        await AuthService.Logout();
            //    }
            //    BankList = new List<BankList>();
            //}
            StateHasChanged();
        }
        protected async void ChangBankProvinceAdd(ChangeEventArgs e)
        {
            StateHasChanged();
            modelAddBank.Province = e.Value.ToString();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Customer/GetBankDistrict",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelAddBank.Province,
                PaymentAgent = "",
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankDistrictListResp resp = await HttpService.Post<BankDistrictListResp>("/Customer/GetBankDistrict", payload);
            if (resp.Status == 200)
            {
                BankDistrictList = resp.Content.BankDistrictList;
                modelAddBank.City = BankDistrictList[0].City;
            }
            StateHasChanged();
        }
        protected async void ChangBankCityAdd(ChangeEventArgs e)
        {
            StateHasChanged();
            modelAddBank.City = e.Value.ToString();           
            StateHasChanged();
        }
        protected async void ChangBankCityEdit(ChangeEventArgs e)
        {
            StateHasChanged();
            modelEditBank.City = e.Value.ToString();
            StateHasChanged();
        }
        protected async void ChangBankProvince(ChangeEventArgs e)
        {
            StateHasChanged();
            model.BankProvince = e.Value.ToString();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Customer/GetBankDistrict",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelEditBank.Province,
                PaymentAgent = "",
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankDistrictListResp resp = await HttpService.Post<BankDistrictListResp>("/Customer/GetBankDistrict", payload);
            if (resp.Status == 200)
            {
                BankDistrictList = resp.Content.BankDistrictList;
                model.BankCity = BankDistrictList[0].City;
            }
            StateHasChanged();
        }
        protected async void ChangBankProvinceEdit(ChangeEventArgs e)
        {
            StateHasChanged();
            modelEditBank.Province = e.Value.ToString();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Customer/GetBankDistrict",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                Country = model.ToCountry,
                CountryCode = model.ToCountry,
                StateID = modelEditBank.Province,
                PaymentAgent = "",
                CurrencyCode = model.ToCurrency,
                pageIndex = 1,
                pageSize = 50
            };
            BankDistrictListResp resp = await HttpService.Post<BankDistrictListResp>("/Customer/GetBankDistrict", payload);
            if (resp.Status == 200)
            {
                BankDistrictList = resp.Content.BankDistrictList;
                modelEditBank.City = BankDistrictList[0].City;
            }
            StateHasChanged();
        }
        protected async void ChangBankAdd(ChangeEventArgs e)
        {
            StateHasChanged();
            modelAddBank.BankID = e.Value.ToString();
            string BANK_NAME = BankList.Where(x => x.BANK_CODE == e.Value.ToString()).ToList()[0].BANK_NAME;
          
            if (BANK_NAME != "OTHER")
            {
                modelAddBank.BANK_NAME = BANK_NAME;
                isBankOther = true;
            }
            else
            {
                modelAddBank.BANK_NAME = "";
                isBankOther = false;
            }

            modelAddBank.Swiftcode = e.Value.ToString();
             await  getBankCity(modelAddBank.BankID, "Add");
            StateHasChanged();
        }
        protected async void ChangeOccupationM(ChangeEventArgs e)
        {
            StateHasChanged();
            model.OccupationM = e.Value.ToString();
            OccupationDList = OccupationDAllList.Where(x => x.OccupationM == model.OccupationM).ToList();
            model.OccupationD = OccupationDList[0].OccupationD.ToString();
            if(model.OccupationM== "OTHERS")
            {
                model.Occupation = "";
            }
            else
            {
                model.Occupation = model.OccupationM + " " + model.OccupationD;
            }
            
            StateHasChanged();
        }
        protected async void ChangeOccupationD(ChangeEventArgs e)
        {
            StateHasChanged();
            model.OccupationD = e.Value.ToString();
            if (model.OccupationD == "OTHERS")
            {
                model.Occupation = "";
            }
            else
            {
                model.Occupation = model.OccupationM + " " + model.OccupationD;
            }
            StateHasChanged();
        }
        protected async void ChangBankUpdate(ChangeEventArgs e)
        {
            StateHasChanged();
            modelEditBank.BankID = e.Value.ToString();
            string BANK_NAME = BankList.Where(x => x.BANK_CODE == e.Value.ToString()).ToList()[0].BANK_NAME;
            if (BANK_NAME != "OTHER")
            {
                modelEditBank.BANK_NAME = BANK_NAME;
                isBankOther = true;
            }
            else
            {
                modelEditBank.BANK_NAME = "";
                isBankOther = false;
            }

            modelEditBank.Swiftcode = e.Value.ToString();
            await getBankCity(modelEditBank.BankID, "Edit");
            StateHasChanged();
        }
        protected async void ChangePaymentAgent(ChangeEventArgs e)
        {
            StateHasChanged();
            model.PaymentAgent = e.Value.ToString();


            switch (model.ToCountry)
            {
                case "CN":
                    TransTypeListNew = new List<TransTypeList>();
                    if (TransTypeList.Count > 0)
                    {
                        foreach (var item in TransTypeList)
                        {
                            if (!string.IsNullOrEmpty(item.PAYMENT_AGENT))
                            {
                                if (item.PAYMENT_AGENT.Contains(e.Value.ToString()))
                                {
                                    TransTypeList TransTypeNew = new TransTypeList();
                                    TransTypeNew.PAYABLE_CODE = item.PAYABLE_CODE;
                                    TransTypeNew.DESCRIPTION = item.DESCRIPTION;
                                    TransTypeNew.PAYMENT_AGENT = item.PAYMENT_AGENT;
                                    TransTypeListNew.Add(TransTypeNew);
                                }
                            }
                        }
                        model.PaymentMode = TransTypeListNew[0].PAYABLE_CODE.ToString();
                    }
                   
                    break;
                case "PH":
                    TransTypeListNew = new List<TransTypeList>();
                    if (TransTypeList.Count > 0)
                    {
                        foreach (var item in TransTypeList)
                        {
                            if (!string.IsNullOrEmpty(item.PAYMENT_AGENT))
                            {
                                if (item.PAYMENT_AGENT.Contains(e.Value.ToString()))
                                {
                                    TransTypeList TransTypeNew = new TransTypeList();
                                    TransTypeNew.PAYABLE_CODE = item.PAYABLE_CODE;
                                    TransTypeNew.DESCRIPTION = item.DESCRIPTION;
                                    TransTypeNew.PAYMENT_AGENT = item.PAYMENT_AGENT;
                                    TransTypeListNew.Add(TransTypeNew);
                                }
                            }
                        }
                        model.PaymentMode = TransTypeListNew[0].PAYABLE_CODE.ToString();
                    }
                    break;
                case "US":
                    AgentPayoutList = AgentListAll.Where(x => x.Agent_ID == e.Value.ToString()).ToList();
                    if (AgentPayoutList.Count > 0)
                    {
                        model.PayoutAddress = AgentPayoutList[0].FULLADDRESS;
                    }
                    break;
                default:
                    //foreach(var item in TransTypeList)
                    //{
                    //     TransTypeList TransTypeNew = new TransTypeList();
                    //     TransTypeNew.PAYABLE_CODE=item.PAYABLE_CODE;
                    //     TransTypeNew.DESCRIPTION=item.DESCRIPTION;
                    //     TransTypeNew.PAYMENT_AGENT=item.PAYMENT_AGENT;
                    //     TransTypeListNew.Add(TransTypeNew);
                    //}
                    break;
            }

            StateHasChanged();
            UpdateServiceFee();
            StateHasChanged();
        }
        protected async void ChangePaymentMode(ChangeEventArgs e)
        {

            TypeServices = "1";
            StateHasChanged();
            model.PaymentMode = e.Value.ToString();
            UpdateServiceFee();

            if (AuthService.userMTRedSun.methodBankList.Contains(model.PaymentMode))
            {
                displayBank = "initial";
                BankIDList = BankIDAllList.Where(x => x.CURRENCY == model.ToCurrency || x.CURRENCY == "").OrderByDescending(x => x.Hidedate).ToList();
                if (model.ToCountry == "CN")
                {
                    MinHeghtSAmount = "273px";
                }
                else
                {
                    MinHeghtSAmount = "315px";
                }
                ChangeBank0();
            }
            else
            {
                MinHeghtSAmount = "384px";
                displayBank = "None";
                model.AccountNo = "";
                model.BankID = "0";
                model.BankName = "SELECT BANK";
                model.BankCode = "";
            }

            StateHasChanged();
        }
        protected async void ChangePaymentMethod(ChangeEventArgs e)
        {

            TypeServices = "1";
            StateHasChanged();
            model.paymentMethod = e.Value.ToString();
            TypeofPaidListSelect = TypeofPaidList.Where(x => x.TypeID == e.Value.ToString()).ToList();
            TypeOtherFee = TypeofPaidListSelect[0].OtherFee;
            UpdateServiceFee();

            //if (AuthService.userMTRedSun.methodBankList.Contains(model.PaymentMode))
            //{
            //    displayBank = "initial";
            //}
            //else
            //{
            //    displayBank = "None";
            //    model.AccountNo = "";
            //    model.BankID = "0";
            //    model.BankName = "SELECT BANK";
            //    model.BankCode = "";
            //}

            StateHasChanged();
        }
        protected async void ChangetoAddBank(ChangeEventArgs e)
        {
            
            StateHasChanged();
            modelAddBank.Currency = e.Value.ToString();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/GetBankList",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                CountryCode = model.ToCountry,
                Country = model.ToCountry,
                PaymentAgent = "",
                CurrencyCode = modelAddBank.Currency,
                pageIndex = 1,
                pageSize = 50
            };
            if (model.ToCountry == "CN")
            {
                dynamic payload1 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/getMainBank",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    CountryCode = model.ToCountry,
                    Country = model.ToCountry,
                    PaymentAgent = model.PaymentAgent,
                    Currency = modelAddBank.Currency
                };
                displayBankCountry = "initial";
                MainBanksListResp respMain = await HttpService.Post<MainBanksListResp>("/Customer/getMainBank", payload1);
                if (respMain.Status == 200)
                {
                    MainBanksList = respMain.Content.MainBankList;
                }
                else
                {
                    MainBanksList = new List<MainBanks>();
                }
                dynamic payload2 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/GetBankProvince",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    Country = model.ToCountry
                };
                StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
                if (respProvince.Status == 200)
                {
                    ProvinceBankList = respProvince.Content.BankProvinceList;
                }
                else
                {
                    ProvinceBankList = new List<StateList>();
                }
            }
            else
            {
                displayBankCountry = "none";
            }

            BankListResp resp = await HttpService.Post<BankListResp>("/Index/GetBankList", payload);
            if (resp.Status == 200)
            {

                BankList = resp.Content.ListBank;
                modelAddBank.BankID = resp.Content.ListBank[0].BANK_CODE.ToString();
                modelAddBank.BANK_NAME = resp.Content.ListBank[0].BANK_NAME.ToString();
            }
            else
            {
                if (resp.Status == 99)
                {
                    toastService.ShowWarning("User is not Exist or Expire");
                    await AuthService.Logout();
                }
                BankList = new List<BankList>();
            }
            this.StateHasChanged();
            StateHasChanged();
        }
        protected async void ChangetoEditBank(ChangeEventArgs e)
        {

            StateHasChanged();
            modelEditBank.Currency = e.Value.ToString();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/GetBankList",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                CountryCode = model.ToCountry,
                Country = model.ToCountry,
                PaymentAgent = "",
                CurrencyCode = modelEditBank.Currency,
                pageIndex = 1,
                pageSize = 50
            };
            if (model.ToCountry == "CN")
            {
                dynamic payload1 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/getMainBank",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    CountryCode = model.ToCountry,
                    Country = model.ToCountry,
                    PaymentAgent = modelEditBank.Currency,
                    Currency = model.ToCurrency
                };
                displayBankCountry = "initial";
                MainBanksListResp respMain = await HttpService.Post<MainBanksListResp>("/Customer/getMainBank", payload1);
                if (respMain.Status == 200)
                {
                    MainBanksList = respMain.Content.MainBankList;
                }
                else
                {
                    MainBanksList = new List<MainBanks>();
                }
                dynamic payload2 = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Customer/GetBankProvince",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    UserID = model.UserID,
                    Country = model.ToCountry
                };
                StateBankListResp respProvince = await HttpService.Post<StateBankListResp>("/Customer/GetBankProvince", payload2);
                if (respProvince.Status == 200)
                {
                    ProvinceBankList = respProvince.Content.BankProvinceList;
                }
                else
                {
                    ProvinceBankList = new List<StateList>();
                }
            }
            else
            {
                displayBankCountry = "none";
            }

            BankListResp resp = await HttpService.Post<BankListResp>("/Index/GetBankList", payload);
            if (resp.Status == 200)
            {

                BankList = resp.Content.ListBank;
                modelAddBank.BankID = resp.Content.ListBank[0].BANK_CODE.ToString();
            }
            else
            {
                if (resp.Status == 99)
                {
                    toastService.ShowWarning("User is not Exist or Expire");
                    await AuthService.Logout();
                }
                BankList = new List<BankList>();
            }
            this.StateHasChanged();
            StateHasChanged();
        }
        public async Task SendAmountChange(double? newValue)
        {
            TypeServices = "1";
            model.SendAmount = Convert.ToDouble(newValue == null ? "0" : newValue.ToString());
            UpdateServiceFee();
            StateHasChanged();
        }
        protected async void ZipcodeChange(string NewValue)
        {
            StateHasChanged();
           
            if(!string.IsNullOrEmpty(NewValue) && NewValue.Length == 5)
            {
               
                   // model.SZipcode = NewValue;
                StateHasChanged();
                dynamic payload = new
                    {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Index/getZipcodeSearch",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    Zipcode = NewValue,
                        CountryCode = "US"
                    };
                    List<CityModel> CityListFilter = new List<CityModel>();
                    CityListResp Resp = await HttpService.Post<CityListResp>("/Index/getZipcodeSearch", payload);
                    if(Resp.Status==200)
                    {
                        if (Resp.Content.CityList.Count() >0)
                        {
                            model.SCity = Resp.Content.CityList[0].City == null ? "" : Resp.Content.CityList[0].City.ToString();
                            model.SState = Resp.Content.CityList[0].StateId == null ? "" : Resp.Content.CityList[0].StateId.ToString();
                        }
                        else
                        {
                            model.SCity = "";
                            model.SState = "";
                        }
                    }

                
            }
           
            StateHasChanged();
           
        }

       
        protected async void ZipcodeBHChange(string NewValue)
        {
            StateHasChanged();
            if (!string.IsNullOrEmpty(NewValue) && NewValue.Length == 5)
            {
                StateHasChanged();
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Index/getZipcodeSearch",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    Zipcode = NewValue,
                    CountryCode = "US"
                };
                List<CityModel> CityListFilter = new List<CityModel>();
                CityListResp Resp = await HttpService.Post<CityListResp>("/Index/getZipcodeSearch", payload);
                if (Resp.Status == 200)
                {
                    if (Resp.Content.CityList.Count() > 0)
                    {
                        model.SBHCity = Resp.Content.CityList[0].City == null ? "" : Resp.Content.CityList[0].City.ToString();
                        model.SBHState = Resp.Content.CityList[0].StateId == null ? "" : Resp.Content.CityList[0].StateId.ToString();
                    }
                    else
                    {
                        model.SBHCity = "";
                        model.SBHState = "";
                    }
                }
            }

            StateHasChanged();

        }
        protected async void ZipcodeReciverChange(ChangeEventArgs e)
        {
            StateHasChanged();
            if (!string.IsNullOrEmpty(e.Value==null?"":e.Value.ToString()) && e.Value.ToString().Length >=4)
            {
                StateHasChanged();
                dynamic payload = new
                {
                    Form = "/Transaction/NewTransaction",
                    FormName = "New Transaction",
                    Action = "/Index/getZipcodeSearch",
                    UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                    Zipcode = e.Value.ToString(),
                    CountryCode = model.ToCountry
                };
                List<CityModel> CityListFilter = new List<CityModel>();
                CityListResp Resp = await HttpService.Post<CityListResp>("/Index/getZipcodeSearch", payload);
                if (Resp.Status == 200)
                {
                    if (Resp.Content.CityList.Count() > 0)
                    {
                        model.RCity = Resp.Content.CityList[0].City == null ? "" : Resp.Content.CityList[0].City.ToString();
                        model.RState = Resp.Content.CityList[0].StateId == null ? "" : Resp.Content.CityList[0].StateId.ToString();
                    }
                    else
                    {
                        model.RCity = "";
                        model.RState = "";
                    }
                }
            }

            StateHasChanged();
        }
        public async Task ServicesFeeChange(double? newValue)
        {
            TypeServices = "1";
            model.TransferFee = Convert.ToDouble(newValue == null ? "0" : newValue.ToString());
            UpdateServiceFee();
            StateHasChanged();
        }
        public async Task OtherFeeChange(double? newValue)
        {
            TypeServices = "1";
            model.OtherFee = Convert.ToDouble(newValue == null ? "0" : newValue.ToString());
            UpdateServiceFee();
            StateHasChanged();
        }
        public async Task DiscountFeeChange(double? newValue)
        {
            TypeServices = "1";
            model.Discount = Convert.ToDouble(newValue == null ? "0" : newValue.ToString());
            if (model.Discount > model.TransferFee)
            {
                //C_Discount = backerror;
                toastService.ShowWarning("The amount of the discount cannot be greater than the service fee");
                //await E_Discount.FocusAsync();
                model.Discount = 0;
            }
            else
            {
                UpdateServiceFee();
            }
            StateHasChanged();
        }
        public async Task LandedAmountChange(double? newValue)
        {
            TypeServices = "2";
            model.LandedAmount = Convert.ToDouble(newValue == null ? "0" : newValue.ToString());
            UpdateServiceFee();
            StateHasChanged();
        }
        protected async void ChangeRelation(ChangeEventArgs e)
        {
            StateHasChanged();
            model.RelationwithSender = e.Value.ToString();
            if (e.Value.ToString() != "Others")
            {
                model.RelationwithSenderNote = e.Value.ToString();
            }
            else
            {
                model.RelationwithSenderNote = "";
            }

            StateHasChanged();
        }
        protected async void ChangeRState(ChangeEventArgs e)
        {
            TypeServices = "1";
            StateHasChanged();
            model.RState = e.Value.ToString();
            if (model.ToCountry == "PH" || model.ToCountry == "CN" || model.ToCountry == "VN")
            {
                CityStateList = CityList.Where(x => x.StateId == model.RState && x.CountryCode.Contains(model.ToCountry)).ToList();
                if (CityStateList.Count() > 0)
                {
                    model.RCity = CityStateList[0].City.ToString();
                }
            }

            UpdateServiceFee();
            StateHasChanged();
        }

        protected async void ChangePayoutState(ChangeEventArgs e)
        {
           
            StateHasChanged();
            model.PayoutState = e.Value.ToString();           
            CityPayoutList = CityPayoutAll.Where(x => x.StateCode == e.Value.ToString()).ToList();
            if (CityPayoutList.Count() > 0)
            {
                model.PayoutCity = CityPayoutList[0].CITY.ToString();
            }
            else
            {
                model.PayoutCity = "";
            }
            StateHasChanged();
            PaymentAgentList = PaymentAgentListAll.Where(x => x.STATE == e.Value.ToString() && x.CITY == model.PayoutCity).OrderByDescending(x => x.MATDINH).ToList();
            AgentPayoutList = AgentListAll.Where(x => x.STATE == e.Value.ToString() && x.CITY== model.PayoutCity).ToList();
            if(AgentPayoutList.Count>0)
            {
                model.PaymentAgent = AgentPayoutList[0].Agent_ID;
                model.PayoutAddress = AgentPayoutList[0].FULLADDRESS    ;
            }
            
            StateHasChanged();
        }
        protected async void ChangePayoutCity(ChangeEventArgs e)
        {

            StateHasChanged();
            model.PayoutCity = e.Value.ToString();            
            StateHasChanged();
            PaymentAgentList = PaymentAgentListAll.Where(x => x.STATE == model.PayoutState && x.CITY == model.PayoutCity).ToList();
            AgentPayoutList = AgentListAll.Where(x => x.STATE == model.PayoutState && x.CITY == model.PayoutCity).ToList();
            if (AgentPayoutList.Count > 0)
            {
                model.PaymentAgent = AgentPayoutList[0].Agent_ID;
                model.PayoutAddress = AgentPayoutList[0].FULLADDRESS;
            }
            
            StateHasChanged();
        }
       
        protected async void ChangeRCity(ChangeEventArgs e)
        {
            StateHasChanged();
            model.RCity = e.Value.ToString();
          
            StateHasChanged();
        }
        protected async void ChangeBankAdd(ChangeEventArgs e)
        {
            StateHasChanged();
            modelAddBank.AccountNo = e.Value.ToString();
            StateHasChanged();
            if (!string.IsNullOrEmpty(modelAddBank.AccountNo))
            {
                string newaccount = "";
                string account = modelAddBank.AccountNo.Replace("-", "").Replace(" ", "");
                if (account.Length > 4)
                {
                    for (int i = 0; i < account.Length; i++)
                    {
                        if ((i) % 4 == 0)
                        {
                            newaccount += " ";
                        }
                        newaccount += account.Substring(i, 1);
                    }
                }
                modelAddBank.AccountNo = newaccount.Trim();
            }
            StateHasChanged();
        }
        protected async void ChangeBankEdit(ChangeEventArgs e)
        {
            StateHasChanged();
            modelEditBank.AccountNo = e.Value.ToString();
            StateHasChanged();
            if (!string.IsNullOrEmpty(modelEditBank.AccountNo))
            {
                string newaccount = "";
                string account = modelEditBank.AccountNo.Replace("-", "").Replace(" ", "");
                if (account.Length > 4)
                {
                    for (int i = 0; i < account.Length; i++)
                    {
                        if ((i) % 4 == 0)
                        {
                            newaccount += " ";
                        }
                        newaccount += account.Substring(i, 1);
                    }
                }
                modelEditBank.AccountNo = newaccount.Trim();
            }
            StateHasChanged();
        }
        protected async void ChangeRID(ChangeEventArgs e)
        {
            StateHasChanged();
            model.RID = e.Value.ToString();
            StateHasChanged();

            if (!string.IsNullOrEmpty(model.RID))
            {
                string newaccount = "";
                string account = model.RID.Replace("-", "").Replace(" ", "");
                if (account.Length > 4)
                {
                    for (int i = 0; i < account.Length; i++)
                    {
                        if ((i) % 4 == 0)
                        {
                            newaccount += " ";
                        }
                        newaccount += account.Substring(i, 1);
                    }
                }
                StateHasChanged();
                model.RID = newaccount.Trim();
                if (model.ToCountry == "CN")
                {
                    if (model.RID.ToString().Length != 22)
                    {
                        C_RID = backerror;
                        await E_RID.FocusAsync();
                    }
                }
            }
            StateHasChanged();
        }
        protected async void ChangeSBHCountryIssue(ChangeEventArgs e)
        {
            StateHasChanged();
            model.SBHCountryIssue = e.Value.ToString();
            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/GetState",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                CountryCode = model.SBHCountryIssue,
                pageIndex = 1,
                pageSize = 50
            };

            var resp = await HttpService.Request("post", "/Index/GetState", payload);
            if (resp.Status == 200)
            {
                SendBHStateIssueList = resp.Content.StateList;
                if (resp.Content.StateList.Count > 0)
                {
                    model.SBHStateIssue = SendBHStateIssueList[0].StateCode.ToString();
                }
            }
            StateHasChanged();
        }
        protected async void ChangeCountryIssue(ChangeEventArgs e)
        {
            StateHasChanged();
            model.CountryIssue = e.Value.ToString();


            dynamic payload = new
            {
                Form = "/Transaction/NewTransaction",
                FormName = "New Transaction",
                Action = "/Index/GetState",
                UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString(),
                UserID = model.UserID,
                CountryCode = model.CountryIssue,
                pageIndex = 1,
                pageSize = 50
            };

            var resp = await HttpService.Request("post", "/Index/GetState", payload);
            if (resp.Status.ToString() == "200")
            {
                SendStateIssueList = resp.Content.StateList;
            }

            StateHasChanged();
        }
        protected async void ChangeReasonforSending(ChangeEventArgs e)
        {
            StateHasChanged();
            model.SelectReason = e.Value.ToString();
            if (model.SelectReason.ToUpper().Contains("OTHER"))
            {
                model.ReasonforSending = "";
            }
            else
            {
                model.ReasonforSending = model.SelectReason;
            }
            await E_SelectReason.FocusAsync();
            StateHasChanged();
        }
        protected async void ChangeSOF(ChangeEventArgs e)
        {
            StateHasChanged();
            model.SelectSOF = e.Value.ToString();
            if (model.SelectSOF.ToUpper().Contains("OTHER"))
            {
                model.SOF = "";
            }
            else
            {
                model.SOF = model.SelectSOF;
            }
            await E_SelectSOF.FocusAsync();
            StateHasChanged();
        }
        private void onClickRadioBehaflYes(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
        {
            //if (!IsShowStatus)
            //{
            //checkedValue = "Yes";
            IsShowStatus = true;
            IsShow = false;
            IsBehalf = true;
            model.IS_BH = 1;
            StateHasChanged();
            //}
            //else
            //{
            //    IsShowStatus = false;
            //    IsBehalf = false;
            //    IsShow = true;
            //    //checkedValue = "No";
            //}
        }
        private void onClickRadioBehaflNo(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
        {
            //if (!IsShowStatus)
            //{
            //    //checkedValue = "Yes";
            //    IsShowStatus = true;
            //    IsShow = false;
            //    IsBehalf = true;
            //}
            //else
            //{
            IsShowStatus = false;
            IsBehalf = false;
            IsShow = true;
            model.IS_BH = 0;
            StateHasChanged();
            //checkedValue = "No";
            //}
        }
        protected async void ExitTransaction()
        {
            try
            {
                string url = "/Customer/SearchCustomer";
                NavManager.NavigateTo(url);
            }
            catch (Exception ex)
            {

            }
        }
        protected async void AddNewTransaction()
        {
            try
            {
                isViewingReport = true;
                Table1 = new Array[] { };
                error = "";

                StateHasChanged();
                if (await Validate())
                {
                    if (await ValidateBlackList())
                    {
                        List<CustomerProfileFile> IdFiles = new List<CustomerProfileFile>();
                        List<CustomerProfileFile> SOFFiles = new List<CustomerProfileFile>();
                        List<CustomerProfileFile> SignFiles = new List<CustomerProfileFile>();
                        List<CustomerProfileFile> ReIdFiles = new List<CustomerProfileFile>();
                        if (loadedSigns.Count > 0)
                        {
                            foreach (var file in loadedSigns)
                            {
                                CustomerProfileFile SenderDocumentsfile = new CustomerProfileFile();
                                SenderDocumentsfile.FileName1 = "Sign Transaction ID";
                                SenderDocumentsfile.FileName = file.Name.ToString();
                                var buffers = new byte[file.Size];
                                await file.OpenReadStream(maxFileSize).ReadAsync(buffers);
                                SenderDocumentsfile.FileLoad = buffers;
                                SignFiles.Add(SenderDocumentsfile);
                            }
                        }
                        if (loadedFileIDs.Count > 0)
                        {
                            foreach (var file in loadedFileIDs)
                            {
                                CustomerProfileFile SenderDocumentsfile = new CustomerProfileFile();
                                SenderDocumentsfile.FileName1 = "ID File";
                                SenderDocumentsfile.FileName = file.Name.ToString();
                                var buffers = new byte[file.Size];
                                await file.OpenReadStream(maxFileSize).ReadAsync(buffers);
                                SenderDocumentsfile.FileLoad = buffers;
                                IdFiles.Add(SenderDocumentsfile);
                            }
                        }
                        if (loadedFileSOFs.Count > 0)
                        {
                            foreach (var file in loadedFileSOFs)
                            {
                                CustomerProfileFile SenderDocumentsfile = new CustomerProfileFile();
                                SenderDocumentsfile.FileName1 = "SOF File";
                                SenderDocumentsfile.FileName = file.Name.ToString();
                                var buffers = new byte[file.Size];
                                await file.OpenReadStream(maxFileSize).ReadAsync(buffers);
                                SenderDocumentsfile.FileLoad = buffers;
                                SOFFiles.Add(SenderDocumentsfile);
                            }
                        }

                        if (loadedReFileIDs.Count > 0)
                        {
                            foreach (var file in loadedReFileIDs)
                            {
                                CustomerProfileFile SenderDocumentsfile = new CustomerProfileFile();
                                SenderDocumentsfile.FileName1 = "ID File";
                                SenderDocumentsfile.FileName = file.Name.ToString();
                                var buffers = new byte[file.Size];
                                await file.OpenReadStream(maxFileSize).ReadAsync(buffers);
                                SenderDocumentsfile.FileLoad = buffers;
                                ReIdFiles.Add(SenderDocumentsfile);
                            }
                        }
                        dynamic payload = new
                        {
                            AGENT_ID = model.AgentID,
                            UserID = model.UserID,
                            TRANS_ID = model.TransID,
                            CUST_ID = model.CustID,
                            B_CUST_ID = model.BCustID,
                            FIRSTNAME = model.SFirstName,
                            MIDDLENAME = model.SMiddleName,
                            LASTNAME = model.SLastName,
                            ADDRESS = model.SAddress,
                            STATE = model.SState,
                            CITY = model.SCity,
                            ZIP_CODE = model.SZipcode,
                            PHONE1 = model.SPhone,
                            EMAIL = model.SEmail,

                            FIRSTNAME_BH = model.SBHFirstName,
                            MIDDLENAME_BH = model.SBHMiddleName,
                            LASTNAME_BH = model.SBHLastName,
                            ADDRESS_BH = model.SBHAddress,
                            STATE_BH = model.SBHState,
                            CITY_BH = model.SBHCity,
                            ZIPCODE_BH = model.SBHZipcode,
                            PHONE_BH = model.SBHPhone,
                            BH_EMAIL = model.SBHEmail,
                            BH_IDType = model.SBHIDType,
                            BH_Driver = model.SBHID,
                            COUNTRY_BH = model.SBHCountryIssue,
                            BH_State = model.SBHStateIssue,
                            BH_IssueDate = model.SBHIssueDate,
                            BH_Expire = model.SBHExpireDate,
                            DOB_BH = model.SBHDOB,
                            BH_SSN = model.SBHSSN,
                            BH_OCCUPATION = model.SBHOccupation,

                            B_FIRSTNAME = model.RFirstName,
                            B_MIDDLENAME = model.RMiddleName,
                            B_LASTNAME = model.RLastName,
                            LOCALNAME = model.RLocalName,
                            B_CMND = model.RID,
                            PASSPORT = model.RID,
                            B_RECIPIENT2 = model.RFullName2,
                            B_ADDRESS = model.RAddress,
                            B_STATE = model.RState,
                            B_PROVINCE_ID = model.RState,
                            B_CITY = model.RCity,
                            DISTRICT = model.RCity,
                            B_ZIPCODE = model.RZipcode,
                            B_EMAIL = model.REmail,
                            B_PHONE1 = model.RPhone,
                            B_PHONE2 = model.RPhone2,
                            ReasonwithSenderID = model.RelationwithSender,
                            RelationwithSenderNote = model.RelationwithSenderNote,
                            REF_NO = model.RefNo,
                            FROMCOUNTRY = model.FromCountry,
                            FROMCURRENCY = model.FromCurrency,
                            TOCOUNTRY = model.ToCountry,
                            TOCURRENCY = model.ToCurrency,
                            AMOUNT = model.SendAmount,
                            SERVICE_FEE = model.TransferFee,
                            AG_COMM_AMT = model.AgentFee,
                            OTHERFEE = model.OtherFee,
                            TAXFEE = model.TaxFee,
                            DISCOUNTID = model.DiscountID,
                            DISCOUNT_FEE = model.Discount,
                            TOTAL_AMT_USD = model.TotalAmount,
                            EXCHANGE_RATE = model.ExchangeRate,
                            LAND_AMT = model.LandedAmount,
                            PAY_BY = model.Paidby,
                            PaymentMethod = model.paymentMethod,
                            PAY_TYPE = model.paymentMethod,
                            TYPE_DELIVER = model.PaymentMode,
                            PAYMENT_AGENT = model.PaymentAgent,
                            BANK_NAME = model.BankName,
                            BANK_CODE = model.BankCode,
                            SWIFTCODE = model.Swiftcode,
                            ACCOUNT_NO = model.AccountNo,
                            ACCOUNT_TYPE = model.Accountype,
                            ID_TYPE = model.IDType,
                            DRIVER_ID = model.ID,
                            DRIVER_ID_BK = model.ID_BK,
                            ID = model.ID,
                            ID_BK = model.ID_BK,
                            COUNTRY_ISSUE = model.CountryIssue,
                            STATE_ISSUE = model.StateIssue,
                            ISSUE_DATE = model.IssueDate,
                            EXPIRATION = model.ExpireDate,
                            DOB = model.DOB,
                            DOB_BK = model.DOB,
                            SSN = model.SSN,
                            SSN_BK = model.SSN_BK,
                            OCCUPATION = model.Occupation,
                            OccupationM = model.OccupationM,
                            OccupationD = model.OccupationD,
                            Message = model.Message,
                            B_NOTE = model.Message,
                            REASON_SENDING_ID = model.SelectReason,
                            REASON_SENDING = model.ReasonforSending,
                            SecurityAnswer = model.SecurityAnswer,
                            CompanyNote = model.CompanyNote,
                            SelectSOF = model.SelectSOF,
                            SOF = model.SOF,
                            TypeSourceOfFund = model.SelectSOF,
                            SourceOfFund = model.SOF,
                            BankProvince = model.BankProvince,
                            BankCity = model.BankCity,
                            BANK_ID = model.BankID,
                            PASSPORT_NO = model.RID,
                            IdFiles = IdFiles,
                            SOFFiles = SOFFiles,
                            SignFiles = SignFiles,
                            ReIdFiles = ReIdFiles,
                            IS_BH = model.IS_BH,
                            KYCCheck = model.KYC,
                            KYC_REASON = model.reasonKyc,
                            AGG_CHECK0 = model.AGG_CHECK0,
                            AGG_CHECK1 = model.AGG_CHECK1,
                            AGG_CHECK2 = model.AGG_CHECK2,
                            AGG_CHECK3 = model.AGG_CHECK3,
                            AGG_CHECK4 = model.AGG_CHECK4,
                            AGG_CHECK5 = model.AGG_CHECK5,
                            AGG_CHECK6 = model.AGG_CHECK6,
                            AGG_CHECK7 = model.AGG_CHECK7,
                            AGG_CHECK8 = model.AGG_CHECK8,
                            AGG_CHECK9 = model.AGG_CHECK9,
                            AGG_CHECK10 = model.AGG_CHECK10,
                            AGG_DATE0 = model.AGG_DATE0,
                            AGG_DATE1 = model.AGG_DATE1,
                            AGG_DATE2 = model.AGG_DATE2,
                            AGG_DATE3 = model.AGG_DATE3,
                            AGG_DATE4 = model.AGG_DATE4,
                            AGG_DATE5 = model.AGG_DATE5,
                            AGG_DATE6 = model.AGG_DATE6,
                            AGG_DATE7 = model.AGG_DATE7,
                            AGG_DATE8 = model.AGG_DATE8,
                            AGG_DATE9 = model.AGG_DATE9,
                            AGG_DATE10 = model.AGG_DATE10,
                            Form = "/Transaction/NewTransaction",
                            FormName = "New Transaction",
                            Action = "/Transaction/AddNewTransaction",
                            UserName = AuthService.userMTRedSun.UserName == null ? "" : AuthService.userMTRedSun.UserName.ToString()
                        };

                        AddnewTransactionResponse Resp = await HttpService.Post<AddnewTransactionResponse>("/Transaction/AddNewTransaction", payload);
                        if (Resp.Status == 200)
                        {
                            string url = "/Transaction/Receipt?tid=" + Resp.Content.TransID
                            + "&Custid=" + Resp.Content.CustID + "&BCustid=" + Resp.Content.BCustID + "&fc=" + Resp.Content.fc + "&tc=" + Resp.Content.tc;
                            NavManager.NavigateTo(url);
                        }
                        else
                        {
                            toastService.ShowWarning(Resp.Message.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                toastService.ShowWarning(ex.Message);
            }
            isViewingReport = false;
            StateHasChanged();
        }
        protected async void ChangeStateIssue(ChangeEventArgs e)
        {
            StateHasChanged();
            model.StateIssue = e.Value.ToString();
            StateHasChanged();
        }
        protected async void ChangeIDType(ChangeEventArgs e)
        {
            StateHasChanged();
            model.IDType = e.Value.ToString();
            StateHasChanged();
        }
        protected async Task ChangeID(string newValue)
        {
            StateHasChanged();
            model.ID = newValue;
            if (!string.IsNullOrEmpty(model.ID))
            {
                model.ID = model.ID.Replace(".", "").Replace("-", "");
                labeID = "";
            }
            else
            {
                labeID = "";
            }
            StateHasChanged();
        }
      
        public async Task ChangeSSN(string newValue)
        {
            StateHasChanged();
            string SSN = "";
            SSN = newValue;
            model.SSN = newValue;
            if (!string.IsNullOrEmpty(SSN))
            {
                if (!SSN.ToUpper().Contains("XX") )
                {
                    model.SSN_BK = newValue;                  
                }
            }
            StateHasChanged();
        }

        //protected async void ChangeSSN(ChangeEventArgs e)
        //{
        //    StateHasChanged();
        //    string SSN = "";
        //    SSN = e.Value.ToString();
        //    if (!string.IsNullOrEmpty(SSN))
        //    {
        //        if(!SSN.ToUpper().Contains("XX") && SSN.Length==9)
        //        {
        //            model.SSN_BK = e.Value.ToString();
        //            model.SSN ="XXXXX" + e.Value.ToString().Substring(5,4);
        //        }
        //    }
        //    StateHasChanged();
        //}
        protected async void OnKeyPressSSN(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {

               
            }
        }
        protected async void ChangeSBHIDType(ChangeEventArgs e)
        {
            StateHasChanged();
            model.SBHIDType = e.Value.ToString();
            StateHasChanged();
        }
    }
}
