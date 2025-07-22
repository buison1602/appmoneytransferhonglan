using System;

using System.Collections.Generic;
namespace AppMoneyTransferRS.Models
{
    public class QuickbookCounterData
    {
        //A,B,C,D,E ,E1, F,G,H,I,J,J1,K,L
        public String A { get; set; }
        public String B { get; set; }
        public String C { get; set; }
        public String D { get; set; }
        public String E { get; set; }
        public String E1 { get; set; }
        public String F { get; set; }
        public String G { get; set; }
        public String H { get; set; }
        public String I { get; set; }
        public String J { get; set; }
        public String J1 { get; set; }     
        public String K { get; set; }
        public String L { get; set; }
    }
    public class QuickbookCounterSummary
    {

        public Int64 Trans_No { get; set; }

        public Int64 NoofTran { get; set; }
    }
        public class QuickbookCounterDataResponse
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ContentQuickbookCounterResponse Content { get; set; }
    }
    public class ContentQuickbookCounterResponse
    {
        public List<QuickbookCounterData> ReportDetail { get; set; }
        public List<QuickbookCounterSummary> ReportSummary { get; set; }
    }
}
