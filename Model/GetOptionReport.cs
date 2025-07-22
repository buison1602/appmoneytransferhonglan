using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class GetOptionReport
    {
        public OptionDate[] OptionDate { get; set; }
        public Partner[] Partner { get; set; }
        public Province[] Province { get; set; }
        public Branch[] Branch { get; set; }
        public Employee[]  Employee { get; set; }
        public PaymentModeList[] PaymentMethod { get; set; }
        public ImportBatch[] ImportBatch { get; set; }
        public Currency[] Currency { get; set; }
        public EmailStatus[] EmailStatus { get; set; }
        public TranStatus[] TranStatus { get; set; }
        public Search[] Search { get; set; }
        public ApproveOption[] ApproveOption { get; set; }
        public OptionCheckStatus[] OptionCheckStatus { get; set; }
        

    }

    public class GetOptionReportInput
    {
        public String UserID { get; set; }
    }

    public class GetOptionReportResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public GetOptionReport Content { get; set; }
    }
}
