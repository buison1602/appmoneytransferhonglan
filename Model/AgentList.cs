using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class AgentHistory
    {
        public Int64 RowNumber { get; set; }
        public string?  Agent_ID { get; set; }
        public string?  ACTION_TYPE { get; set; }
        public string?  AG_COMMENT { get; set; }
        public string?  COMMENT { get; set; }
        public string?  ActionBy { get; set; }
        public DateTime? ActionDate { get; set; }

    }
    public class AgentHistoryList
    {
        public List<AgentHistory> AgentHistoryLists { get; set; }
    }
    public class AgentHistoryListResps
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AgentHistoryList Content { get; set; }
    }
    public class AgentFile
    {
        public Int64 RowNumber { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  UserID { get; set; }
        public Int64 No { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string?  EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string?  FileName { get; set; }
        public byte[]? FileLoad { get; set; }
        public bool? IsView { get; set; }
        public bool AgentShow { get; set; }

        public string?  FileName1 { get; set; }
        public string?  FileLoadBase64 { get; set; }
        public string?  NOIDUNG { get; set; }
        public string?  Comment { get; set; }
        public string?  Comment2 { get; set; }
        public string?  Comment3 { get; set; }
        public string?  CPI_NAME { get; set; }


    }
    public class AgentFileList
    {
        public List<AgentFile> AgentFileLists { get; set; }
    }
    public class AgentFileResps
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AgentFileList Content { get; set; }
    }
    public class AgentList
    {
        public string?  Agent_ID { get; set; }
        public string?  Agent_Name { get; set; }
        public bool PAYMENT { get; set; }
        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  PHONE { get; set; }
        public string?  EMAIL { get; set; }
        public string?  FULLADDRESS { get; set; }
        public string?  TYPE_AGENT { get; set; }

    }
    public partial class AgentRateModel
    {
        public Int64 C_ID { get; set; }
        public Int64 RowNumber { get; set; }

        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }

        public string?  FROMCURRENCY { get; set; }

        public string?  TOCURRENCY { get; set; }

        public string?  FROMCOUNTRY { get; set; }

        public string?  TOCOUNTRY { get; set; }

        public int VN_ZONE { get; set; }

        public double A_MIN { get; set; }

        public double A_MAX { get; set; }

        public string?  TRANS_TYPE { get; set; }

        public double CUST_FEE { get; set; }

        public double AGENT_FEE { get; set; }

        public double HQ_FEE { get; set; }

        public double FEE1 { get; set; }

        public double FEE2 { get; set; }

        public double FEE3 { get; set; }

        public double FEE4 { get; set; }

        public string?  C_TYPE { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public string?  UPDATE_BY { get; set; }

        public string?  TRAN_TYPENAME { get; set; }
        public string?  Payment_Mode { get; set; }
        public string?  TYPE_FEE { get; set; }
        public string?  Payment_Mode_Name { get; set; }

    }
    public class AgentRateListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AgentRateList Content { get; set; }
    }
    public class AgentRateList
    {
        public List<AgentRateModel> AgentRates { get; set; }
    }
    public partial class AgentModel
    {
        public Int64 P_ID { get; set; }
        public Int64 RowNumber { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }
        public string?  OWNER_NAME { get; set; }
        public string?  LEGAL_NAME { get; set; }
        public string?  DBA { get; set; }
        public string?  FIRSTNAME { get; set; }
        public string?  LASTNAME { get; set; }
        public string?  MIDDLENAME { get; set; }
        public string?  FULLNAME { get; set; }
        public string?  FULLADDRESS { get; set; }

        public string?  ADDRESS { get; set; }
        public string?  CITY { get; set; }
        public string?  STATE { get; set; }
        public string?  ZIP_CODE { get; set; }
        public string?  COUNTRY { get; set; }
        public string?  PHONE { get; set; }
        public string?  EMAIL { get; set; }
        public string?  FAX { get; set; }
        public string?  LICENSE_NO { get; set; }
        public string?  COMMENT { get; set; }
        public double? CREDIT_LINE { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public string?  UPDATE_BY { get; set; }
        public string?  COMMENT_UPDATE { get; set; }
        public int? STATUS { get; set; }
        public string?  LOGO { get; set; }
        public int? LEVEL_ACCESS { get; set; }
        public string?  DATE_CREATE { get; set; }
        public string?  DATE_STOP { get; set; }
        public DateTime? DATE_CREATECon { get; set; }
        public DateTime? DATE_STOPCon { get; set; }
        public string?  StatusName { get; set; }
        public string?  AGENT_TYPE { get; set; }
        public string?  EIN { get; set; }
        public int? TYPE_AGENT { get; set; }
        public string?  BUSINESS_TYPE { get; set; }
        public string?  BUSINESS_STRUCT { get; set; } = "5";
        public string?  SENDING_COUNTRY { get; set; }
        public string?  TO_COUNTRY { get; set; }
        public string?  PAYMENTAGENT { get; set; }
        public string?  COMPLIANCE_OFFICER { get; set; }
        public string?  BANK_NAME { get; set; }
        public string?  BANK_ADDRESS { get; set; }
        public string?  BANK_TYPE { get; set; }
        public string?  REASONFORBLOCK { get; set; }
        public int? STT { get; set; }
        public string?  TIN { get; set; }
        public string?  OWNER_NAME2 { get; set; }
        public string?  FIRSTNAME2 { get; set; }
        public string?  LASTNAME2 { get; set; }
        public string?  MIDDLENAME2 { get; set; }
        public string?  ID { get; set; }
        public string?  SS { get; set; }
        public string?  BUSINESS_LICENSE_TYPE { get; set; }
        public string?  OWNERADDRESS { get; set; }
        public string?  OWNERFULLADDRESS { get; set; }
        public string?  OWNERCITY { get; set; }
        public string?  OWNERSTATE { get; set; }
        public string?  OWNERZIP_CODE { get; set; }
        public string?  OWNERFULLADDRESS2 { get; set; }
        public string?  OWNERADDRESS1 { get; set; }
        public string?  OWNERCITY1 { get; set; }
        public string?  OWNERSTATE1 { get; set; }
        public string?  OWNERZIP_CODE1 { get; set; }
        public string?  ID1 { get; set; }
        public string?  SS1 { get; set; }
        public DateTime? EXPIREDATE { get; set; }
        public string?  OwnerCountry { get; set; }
        public string?  OwnerCountry1 { get; set; }
        public int? LOCATION { get; set; }
        public string?  OwnerPhone { get; set; }
        public string?  OwnerPhone1 { get; set; }
        public string?  STATEFILE { get; set; }
        public string?  OWNEREXPIRE { get; set; }
        public string?  OWNEREXPIRE1 { get; set; }
        public string?  EXPIRE { get; set; }
        public string?  EXPIRE1 { get; set; }
        public string?  PAYMENT_METHOD { get; set; }
        public double? CREDIT_LINEAPP { get; set; }
        public double? BEGIN_BALANCE { get; set; }
        public bool? payment { get; set; }
        public int? HighRiskExposures { get; set; }
        public int? Destination { get; set; }
        public int? HIFCA { get; set; }
        public int? HIDTA { get; set; }
        public bool? Bond { get; set; }
        public double? BondAmount { get; set; }
        public bool? chkCheckOfac { get; set; }
        public bool? MATDINH { get; set; } = false;
        public string?  datalatitude { get; set; }
        public string?  datalongitude { get; set; }
        public string?  UserName { get; set; }
        public string?  Password { get; set; }
        public string?  Repassword { get; set; }
        public string?  BUSINESS_STRUCT_NAME { get; set; }
        public string?  SENDCOUNTRYFULL { get; set; }
        public string?  RECEIVECOUNTRYFULL { get; set; }
        public DateTime? OWNEREXPIRECon { get; set; }
        public DateTime? OWNEREXPIRE1Con { get; set; }
        public DateTime? EXPIRECon { get; set; }
        public DateTime? EXPIRE1Con { get; set; }
        public DateTime? EXPIREDATECon { get; set; }

        public string?  CID { get; set; }
        public string?  CSS { get; set; }
        public DateTime? CEXPIREDATE { get; set; }
        public DateTime? CEXPIREDATECon { get; set; }
        public string?  OWNER_NAME3 { get; set; }
        public string?  FIRSTNAME3 { get; set; }
        public string?  LASTNAME3 { get; set; }
        public string?  MIDDLENAME3 { get; set; }
        public string?  OWNERADDRESS3 { get; set; }
        public string?  OWNERCITY3 { get; set; }
        public string?  OWNERSTATE3 { get; set; }
        public string?  OWNERZIP_CODE3 { get; set; }
        public string?  OwnerCountry3 { get; set; }
        public string?  OwnerPhone3 { get; set; }
        
        public string?  ID3 { get; set; }
        public string?  SS3 { get; set; }
        public string?  OWNEREXPIRE3 { get; set; }
        public DateTime? OWNEREXPIRE3Con { get; set; }
        public string?  OWNERFULLADDRESS3 { get; set; }

    }
    public class AgentListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AgentList[] Content { get; set; }
    }
    public class AgentResps
    {
        public AgentModel[] AgentModelList { get; set; }
    }
    public class AgentResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AgentResps Content { get; set; }
    }

    public class CountryAgent
    {
        public int RowNumber { get; set; }
        public Int64 No { get; set; }

        public string?  Agent_ID { get; set; }
        public string?  CountryCode { get; set; }
        public string?  CountryName { get; set; }
        public bool hidden { get; set; }
        public bool MatDinh { get; set; }
    }
    public class CountryAgents
    {
        public CountryAgent[] CountryAgentSend { get; set; }
        public CountryAgent[] CountryAgentReceive { get; set; }
    }
    public class CountryAgentResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CountryAgents Content { get; set; }
    }
}