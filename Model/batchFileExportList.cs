using System;

using System.Collections.Generic;
namespace AppMoneyTransferRS.Models
{

    public class batchFileExportModelSummary
    {

        public Int64 NoofTran { get; set; }
    }
    public class batchFileExportModelResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentbatchFileExportModelResponse Content { get; set; }
    }
    public class ContentbatchFileExportModelResponse
    {
        public List<batchFileExportModel> ReportDetail { get; set; }
        public List<batchFileExportModelSummary> ReportSummary { get; set; }
    }

    public class batchFileTransactionExportModelResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentbatchFileTransactionExportModelResponse Content { get; set; }
    }

    public class ContentbatchFileTransactionExportModelResponse
    {
        public List<batchTransactionFileExportModel> ReportDetail { get; set; }
    }

    public class tranExportCN4
    {
        public string?  A { get; set; }
        public string?  B { get; set; }
        public string?  C { get; set; }
        public string?  D { get; set; }
        public string?  E { get; set; }
        public string?  F { get; set; }
        public string?  G { get; set; }
        public string?  H { get; set; }
        public string?  I { get; set; }
        public string?  J { get; set; }

        public string?  K { get; set; }
        public string?  L { get; set; }
        public string?  M { get; set; }
        public string?  N { get; set; }
        public string?  O { get; set; }
        public string?  TRANS_ID { get; set; }
        public bool SelectTran { get; set; }
        public Int64 RowNumber { get; set; }

    }
    public class ContenttranExportCN4Response
    {
        public List<tranExportCN4> ReportDetail { get; set; }
    }
    public class tranExportCN4Response
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContenttranExportCN4Response Content { get; set; }
    }
    public class tranExportCN8
    {
        public Int64 RowNumber { get; set; }
        public String TRANS_ID { get; set; }
        public String AGENT_NAME { get; set; }
        public String FULLNAME { get; set; }
        public String DRIVER_ID_BK { get; set; }
        public String S_FULLADDRESS { get; set; }
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
        public bool SelectTran { get; set; }

    }
    public class tranExportCN9
    {
        public Int64 RowNumber { get; set; }
        public String A { get; set; }
        public String B { get; set; }
        public String C { get; set; }
        public String D { get; set; }
        public String E { get; set; }
        public String F { get; set; }
        public String G { get; set; }
        public String TRANS_ID { get; set; }
        public String AGENT_NAME { get; set; }
        public String FULLNAME { get; set; }
        public String DRIVER_ID_BK { get; set; }
        public String S_FULLADDRESS { get; set; }
        public String FULLADDRESS { get; set; }
        public String ADDRESS { get; set; }
        public String PHONE { get; set; }
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
        public String CN_CITY { get; set; }
        public String StateName { get; set; }

        public bool SelectTran { get; set; }

    }
    public class tranExportFilRemit
    {
        public Int64 RowNumber { get; set; }
        public String TRANS_ID { get; set; }
        public DateTime T_DATE { get; set; }
        public String TRANS_DATE { get; set; }
        public String S_LASTNAME { get; set; }
        public String S_FIRSTNAME { get; set; }
        public String SENDER_NAME { get; set; }
        public String S_ZIP_CODE { get; set; }
        public String S_ADDRESS { get; set; }
        public String S_CITY { get; set; }
        public String SENDER_ADDRESS1 { get; set; }
        public String SENDER_ADDRESS2 { get; set; }
        public String PHONE1 { get; set; }
        public String B_LASTNAME { get; set; }
        public String B_FIRSTNAME { get; set; }
        public String RECEIVER_NAME { get; set; }
        public String RECEIVER_ADDRESS1 { get; set; }
        public String RECEIVER_ADDRESS2 { get; set; }
        public String RECEIVER_PHONE { get; set; }
        public String GENDER { get; set; }
        public String DOB { get; set; }
        public String TRANS_TYPE { get; set; }
        public String PAYABLE_CODE { get; set; }
        public String BANK_CODE { get; set; }
        public String BRANCH_NAME { get; set; }
        public String ACCOUNT_NO { get; set; }
        public String LAND_CURR { get; set; }
        public double LAND_AMT { get; set; }
        public String MSG_TO_BENE_1 { get; set; }
        public String MSG_TO_BENE_2 { get; set; }
        public String StateName { get; set; }
        public String BANKNAME { get; set; }
        public String BANKCODE { get; set; }
        public String BANKADDRESS { get; set; }
        public double AMOUNT { get; set; }
        public double EXCHANGE_RATE { get; set; }
        public String AGENT_NAME { get; set; }
        public String PAYMENT_AGENT { get; set; }
        public bool SelectTran { get; set; }

    }
    public class ContenttranExportFilRemitResponse
    {
        public List<tranExportFilRemit> ReportDetail { get; set; }
    }
    public class tranExportFilRemitResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContenttranExportFilRemitResponse Content { get; set; }
    }
    public class ContenttranExportCN8Response
    {
        public List<tranExportCN8> ReportDetail { get; set; }
    }
    public class tranExportCN8Response
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContenttranExportCN8Response Content { get; set; }
    }

    public class ContenttranExportCN9Response
    {
        public List<tranExportCN9> ReportDetail { get; set; }
    }
    public class tranExportCN9Response
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContenttranExportCN9Response Content { get; set; }
    }
}
