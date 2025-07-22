using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{

   
    public class BankCity
    {
     
        public string?  Zipcode { get; set; }
        public string?  City { get; set; }
        public string?  StateId { get; set; }
        public string?  Zip { get; set; }
        public string?  CountryCode { get; set; }
        public string?  CounPaymentAgenttryCode { get; set; }
    }
    public class BankDistristLists
    {
        public List<BankCity> BankDistrictList { get; set; }
    }
    public class BankDistrictListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public BankDistristLists Content { get; set; }
    }
    public class BankCityLists
    {
        public List<BankCity> BankCityList { get; set; }
    }
    public class BankCityListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public BankCityLists Content { get; set; }
    }
    public class MainBanks
    {
        public string?  MainBank { get; set; }
        public string?  COUNTRY_ID { get; set; }
        public string?  Currency { get; set; }
        public string?  BANK_ADDRESS { get; set; }
    }
    public class MainBanksList
    {
        public List<MainBanks> MainBankList { get; set; }
    }
    public class MainBanksListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public MainBanksList Content { get; set; }
    }
    public class BankList
    {
        public string?  BANK_CODE { get; set; }
        public string?  BANK_NAME { get; set; }
        public string?  BANK_ADDRESS { get; set; }
        public string?  SWIFTCODE { get; set; }
        public string?  Currency { get; set; }
        

    }
    public class BankIDList
    {
        public int RowNumber { get; set; }
        public string?  ID { get; set; }
        public string?  B_CUST_ID { get; set; }
        public string?  ACCOUNT_NO { get; set; }
        public string?  SWIFTCODE { get; set; }
        public string?  BANK_NAME_CN { get; set; }
        public string?  BANK_NAME { get; set; }
        public string?  BANK_ADDRESS { get; set; }        
        public string?  COUNTRY_ID { get; set; }
        public string?  MAINBANK { get; set; }
        public string?  CITY { get; set; }
        public string?  BANK_CODE { get; set; }
        public string?  CURRENCY { get; set; }
        public string?  BANKCODE2 { get; set; }
        public string?  BANKCODE3 { get; set; }
        public string?  FULLBANKNAME { get; set; }
        public string?  BankProvince { get; set; }
        public string?  BankCity { get; set; }
        public Int64 No { get; set; }
        public DateTime? CREATEDATE { get; set; }
        public string?  CREATEBY { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string?  EDITBY { get; set; }
        public DateTime? Hidedate { get; set; }

    }
    public class BankIDLists
    {
        public List<BankIDList> BankList { get; set; }
    }
    public class BankListIDResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public BankIDLists Content { get; set; }
    }
    public class BankLists
    {
        public List<BankList> ListBank { get; set; }
    }
    public class BankListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public BankLists Content { get; set; }
    }
}