using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class DiscountDetailList
    {
        public string?  DISCOUNT_TYPE { get; set; }
        public string?  DISCOUNT_NAME { get; set; }
        public Int64 DISCOUNT_ID { get; set; }
        public Int64 RowNumber { get; set; }
        public string?  FROMCOUNTRY { get; set; }
        public string?  TOCOUNTRY { get; set; }
        public bool HIDDEN { get; set; }
        public DateTime F_DATE { get; set; }
        public DateTime T_DATE { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public string?  CreateBy { get; set; }
        public DateTime EIDT_DATE { get; set; }

        public string?  EditBy { get; set; }
        public int NO { get; set; }
        public string?  CTYPE { get; set; }
        public double F_AMOUNT { get; set; }
        public double T_AMOUNT { get; set; }
        public double AMOUNT { get; set; }

    }
    public class DiscountDetailListResps
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentDiscountDetailResponse Content { get; set; }
    }
    public class ContentDiscountDetailResponse
    {
        public List<DiscountList> DiscountList { get; set; }
    }
    public class DiscountAgentRequest
    {       
        public Int64 DiscountID { get; set; }
        public string?  AgentID { get; set; }
        public string?  STATE { get; set; }
        public bool AgentShow { get; set; }

    }

    public class DiscountList
    {
        public string?  DISCOUNT_TYPE { get; set; }
        public string?  DISCOUNT_NAME { get; set; }
        public string?  DISCOUNT_CODE { get; set; }
        public Int64 DISCOUNT_ID { get; set; }
        public Int64 ID { get; set; }
        public bool DisplaySum { get; set; }
        
        public Int64 RowNumber { get; set; }
        public string?  FROMCOUNTRY { get; set; }
        public string?  TOCOUNTRY { get; set; }
        public bool HIDDEN { get; set; }
        public DateTime F_DATE { get; set; }
        public DateTime T_DATE { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public string?  CreateBy { get; set; }
        public DateTime EIDT_DATE { get; set; }

        public string?  EditBy { get; set; }
        public int NO { get; set; }
        public string?  CTYPE { get; set; }
        public double F_AMOUNT { get; set; }
        public double T_AMOUNT { get; set; }
        public double AMOUNT { get; set; }
        public string?  Search { get; set; }
        public string?  StateID { get; set; }
        public string?  AgentID { get; set; }
        public string?  STATE { get; set; }
        public string?  AGENT_NAME { get; set; }
        public bool AgentShow { get; set; }
    }
    
    public class DiscountListRe
    {
        public List<DiscountList> DiscountList { get; set; }
        public List<DiscountList> DiscountList1 { get; set; }
        public List<Tran> TranList { get; set; }
    }
    public class DiscountListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public DiscountListRe Content { get; set; }
    }
    public class DiscountListResps
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentDiscountResponse Content { get; set; }
    }
    public class ContentDiscountResponse
    {
        public List<DiscountList> DiscountList { get; set; }
    }
}