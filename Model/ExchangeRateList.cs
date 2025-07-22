using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ExchangeRateDetailList
    {
        public string?  AGENT_ID { get; set; }
        public string?  AGENT_NAME { get; set; }
        public Int64 EX_ID { get; set; }
        public Int64 RowNumber { get; set; }
        public string?  FromCurrency { get; set; }
        public string?  ToCurrency { get; set; }
        public DateTime DateApply { get; set; }
        public double DealerExRate { get; set; }
        public double DiffRate { get; set; }
        public double AG_ExRate { get; set; }
        public string?  CreateBy { get; set; }

    }
    public class ExchangeRateDetailListResps
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentExrateDetailResponse Content { get; set; }
    }
    public class ContentExrateDetailResponse
    {
        public List<ExchangeRateDetailList> ExchangeRateDetailList { get; set; }
    }
    public class ExchangeRateList
    {
        public string?  Currency { get; set; }
        public Int64 EX_ID { get; set; }
        public Int64 RowNumber { get; set; }
        public string?  FromCurrency { get; set; }
        public string?  ToCurrency { get; set; }
        public DateTime DATE_POST { get; set; }
        public double EXCHANGE_RATE { get; set; }
        public string?  CreateBy { get; set; }

    }
    public class Tran
    {      
        public string?  NOOFTRANS { get; set; }        
        public string?  TOTALAMOUNT { get; set; }
        public string?  AvailableCredit { get; set; }
    }
    public class ExchangeRateListRe
    {
        public List<ExchangeRateList> ExchangeRateList { get; set; }
        public List<ExchangeRateList> ExchangeRateList1 { get; set; }
        //public List<Tran> TranList { get; set; }
    }
    public class tranListRe
    {
        //public List<ExchangeRateList> ExchangeRateList { get; set; }
        //public List<ExchangeRateList> ExchangeRateList1 { get; set; }
        public List<Tran> TranList { get; set; }
    }
    public class getTranListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public tranListRe Content { get; set; }
    }
    public class ExchangeRateListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ExchangeRateListRe Content { get; set; }
    }
    public class ExchangeRateListResps
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentExrateResponse Content { get; set; }
    }
    public class ContentExrateResponse
    {
        public List<ExchangeRateList> ExchangeRateList { get; set; }
    }
}