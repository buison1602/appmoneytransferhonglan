namespace AppMoneyTransferRS.Models
{
    public class batchFileExportModel
    {
        public Int64 RowNumber { get; set; }
        public DateTime batchDate { get; set; }
        public String batchName { get; set; }
        public double? TotalTrans { get; set; }
        public double? TotalAmount { get; set; }

    }
    public class batchTransactionFileExportModel
    {
        public Int64 RowNumber { get; set; }
        public String TRANS_ID { get; set; }
        public String AGENT_NAME { get; set; }
        public String FULLNAME { get; set; }
        public String DRIVER_ID_BK { get; set; }
        public String S_FULLADDRESS { get; set; }
        public String FULLADDRESS { get; set; }
        public String PHONE1 { get; set; }
        public String FROMCOUNTRY { get; set; }
        public String B_FULLNAME { get; set; }
        public String LOCALNAME { get; set; }
        public String B_PHONE1 { get; set; }
        public String PASSPORT_NO { get; set; }
        public String R_BANK_NAME { get; set; }        
        public String ACCOUNT_NO { get; set; }
        public double AMOUNT { get; set; }
        public double B_AMT_PAY { get; set; }
        public String TOCURRENCY { get; set; }
        public String R_PASSPORT_NO { get; set; }
        public String BANK_NAME_CN { get; set; }
        public String SWIFTCODE { get; set; }
        public String Rec_BankStateHoa { get; set; }
        public String Rec_CityState { get; set; }
        public String StateName { get; set; }
        public String PHONE { get; set; }
        public String CN_CITY { get; set; }
        public String CUST_ID { get; set; }
        public String COUNTRY { get; set; }
        public String RECEIVERID { get; set; }
        public String B_PHONE { get; set; }
        public String B_PHONE2 { get; set; }
        public String BANK_CODE { get; set; }
        public String Nat { get; set; }
        public String OCCUPATION { get; set; }
        public String OCCUPATIONM { get; set; }
        public String RelationwithSenderNote { get; set; }
        public String CN_EXP_ID { get; set; }
        public DateTime? TRANS_DATE { get; set; }
        public bool?  SelectTran { get; set; }
        public String REASON_SENDING { get; set; }
        public String ID_TYPE { get; set; }
        public String StateBank { get; set; }
        public String BankCity { get; set; }
        public String R_FULLADDRESS { get; set; }
        
    }
}
