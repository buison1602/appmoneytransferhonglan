using System.ComponentModel.DataAnnotations;

namespace AppMoneyTransferRS.Models
{
    public class TransactionModel
    {
        [Required]
        public string?  AgentID { get; set; } = "";
        public string?  AgentState { get; set; } = "";
        public string?  AgentType { get; set; } = "";
        public bool CheckAgentState { get; set; } = false;

        public string?  UserID { get; set; } = "";
        public string?  UserName { get; set; } = "";
        public string?  TransID { get; set; } = "";

        public DateTime TransDate { get; set; } = DateTime.UtcNow.AddHours(-7);

        [Required]
        public string?  CustID { get; set; } = "";
        [Required]
        public string?  BCustID { get; set; } = "";
        [Required]
        public string?  SFirstName { get; set; } = "";
        public string?  SMiddleName { get; set; } = "";
        [Required]
        public string?  SLastName { get; set; } = "";
        [Required]
        public string?  SAddress { get; set; } = "";
        [Required]
        public string?  SState { get; set; } = "";
        [Required]
        public string?  SCity { get; set; } = "";
        [Required]
        [RegularExpression(@"^[0][1-9]([0-9][0-9]){4}", ErrorMessage = "Incorrect Zipcode !")]
        public string?  SZipcode { get; set; } = "";
        [Required]
        [RegularExpression(@"^[0][1-9]([0-9][0-9]){4}", ErrorMessage = "Incorrect Zipcode !")]
        public string?  SPhone { get; set; } = "";
        public string?  SEmail { get; set; } = "";

        public string?  SBHFirstName { get; set; } = "";
        public string?  SBHMiddleName { get; set; } = "";
        public string?  SBHLastName { get; set; } = "";
        public string?  SBHAddress { get; set; } = "";
        public string?  SBHState { get; set; } = "";
        public string?  SBHCity { get; set; } = "";
        public string?  SBHZipcode { get; set; } = "";
        public string?  SBHPhone { get; set; } = "";
        public string?  SBHEmail { get; set; } = "";
        public string?  SBHIDType { get; set; } = "";
        public string?  SBHID { get; set; } = "";
        public string?  SBHCountryIssue { get; set; } = "";
        public string?  SBHStateIssue { get; set; } = "";
        public DateTime? SBHIssueDate { get; set; }
        public DateTime? SBHExpireDate { get; set; }
        public DateTime? SBHDOB { get; set; }
        public string?  SBHSSN { get; set; } = "";
        public string?  SBHOccupation { get; set; } = "";

        public string?  RFirstName { get; set; } = "";
        public string?  RMiddleName { get; set; } = "";
        public string?  RLastName { get; set; } = "";
        public string?  RLocalName { get; set; } = "";
        public string?  RID { get; set; } = "";
        public string?  RFullName2 { get; set; } = "";
        public string?  RAddress { get; set; } = "";
        public string?  RState { get; set; } = "";
        public string?  RStateName { get; set; } = "";
        public string?  RCity { get; set; } = "";
        public string?  RZipcode { get; set; } = "";
        public string?  REmail { get; set; } = "";
        public string?  RPhone { get; set; } = "";
        public string?  RPhone2 { get; set; } = "";
        public string?  RelationwithSender { get; set; } = "";
        public string?  RelationwithSenderNote { get; set; } = "";
        public string?  RefNo { get; set; } = "";
        public string?  FromCountry { get; set; } = "";
        public string?  FromCurrency { get; set; } = "";
        public string?  ToCountry { get; set; } = "";
        public string?  ToCurrency { get; set; } = "";
        public double? SendAmount { get; set; } = 0;
        public double? TransferFee { get; set; } = 0;
        public double? AgentFee { get; set; } = 0;
        public double? OtherFee { get; set; } = 0;
        public double? TaxFee { get; set; } = 0;
        public string?  DiscountID { get; set; } = "";
        public double? Discount { get; set; } = 0;
        public double? TotalAmount { get; set; } = 0;
        public double? TotalAmountOld { get; set; } = 0;
        public double? ExchangeRate { get; set; } = 0;
        public double? LandedAmount { get; set; } = 0;
        public string?  ReadMoney { get; set; } = "";
        public string?  Paidby { get; set; } = "";
        public string?  PaymentMode { get; set; } = "";
        public string?  PaymentAgent { get; set; } = "";
        public string?  paymentMethod { get; set; } = "";
        public string?  SelectAccount { get; set; } = "";
        public string?  BankID { get; set; } = "";
        public string?  BankName { get; set; } = "";
        public string?  BankCode { get; set; } = "";
        public string?  AccountNo { get; set; } = "";
        public string?  Accountype { get; set; } = "";

        public string?  IDType { get; set; } = "";
        public string?  ID { get; set; } = "";
        public string?  ID_BK { get; set; } = "";
        public string?  CountryIssue { get; set; } = "";
        public string?  StateIssue { get; set; } = "";
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ExpireDateBK { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DOB_BK { get; set; }
        public string?  SSN { get; set; } = "";
        public string?  SSN_BK { get; set; } = "";
        public string?  Occupation { get; set; } = "";
        public string?  Message { get; set; } = "";
        public string?  SelectReason { get; set; } = "";
        public string?  ReasonforSending { get; set; } = "";
        public string?  SecurityAnswer { get; set; } = "";
        public string?  CompanyNote { get; set; } = "";
        public string?  SelectSOF { get; set; } = "";
        public string?  SOF { get; set; } = "";
        public string?  BankProvince { get; set; } = "";
        public string?  BankCity { get; set; } = "";
        public bool AGG_CHECK0 { get; set; } = false;
        public bool AGG_CHECK1 { get; set; } = false;
        public bool AGG_CHECK2 { get; set; } = false;
        public bool AGG_CHECK3 { get; set; } = false;
        public bool AGG_CHECK4 { get; set; } = false;
        public bool AGG_CHECK5 { get; set; } = false;
        public bool AGG_CHECK6 { get; set; } = false;
        public bool AGG_CHECK7 { get; set; } = false;
        public bool AGG_CHECK8 { get; set; } = false;
        public bool AGG_CHECK9 { get; set; } = false;
        public bool AGG_CHECK10 { get; set; } = false;
        public int AGG_DATE0 { get; set; } = 0;
        public int AGG_DATE1 { get; set; } = 0;
        public int AGG_DATE2 { get; set; } = 0;
        public int AGG_DATE3 { get; set; } = 0;
        public int AGG_DATE4 { get; set; } = 0;
        public int AGG_DATE5 { get; set; } = 0;
        public int AGG_DATE6 { get; set; } = 0;
        public int AGG_DATE7 { get; set; } = 0;
        public int AGG_DATE8 { get; set; } = 0;
        public int AGG_DATE9 { get; set; } = 0;
        public int AGG_DATE10 { get; set; } = 0;
        public bool Ofac { get; set; } = false;
        public bool Agg { get; set; } = false;
        public bool KYC { get; set; } = false;
        public bool ReceiverIDCheck { get; set; } = false;
        
        public bool Duplicate { get; set; } = false;
        public string?  reasonKyc { get; set; } = "";
        public bool checkmaxamount { get; set; } = false;
        public bool VerifyID { get; set; } = false;
        public int IS_BH { get; set; } = 0;
        public bool IDCheck { get; set; } = false;
        public string?  AGG_TYPE { get; set; } = "";
        public string?  CN_TRANS_NO { get; set; } = "";
        public string?  messageVerifyID { get; set; } = "";
        public string?  messageVerifySSN { get; set; } = "";
        public bool CheckID { get; set; } = false;
        public bool CheckSSN { get; set; } = false;
        public string?  Swiftcode { get; set; } = "";
        public string?  OccupationM { get; set; } = "";
        public string?  OccupationD { get; set; } = "";
        public string?  PayoutAddress { get; set; } = "";
        public string?  PayoutState { get; set; } = "";
        public string?  PayoutCity { get; set; } = "";
        public bool VerifyCheck { get; set; } = false;
        public string?  VerifyIDCheck { get; set; } = "";


    }
    public class TransactionKYCModel
    {
        public string?  UserID { get; set; } = "";
        public string?  UserName { get; set; } = "";
        public string?  TRANS_ID { get; set; } = "";
        public string?  CUST_ID { get; set; } = "";
        public string?  KYC { get; set; } = "0";
        public string?  Comment { get; set; } = "0";
      
    }
}