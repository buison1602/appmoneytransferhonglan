using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class ControlPageList
    {
        public Int64 RowNumber { get; set; }
        public int GroupID { get; set; }
        public string?  PageName { get; set; }
        public string?  GroupName { get; set; }
        public string?  SubjectPage { get; set; }
        public string?  ControlName { get; set; }
        public string?  ControlPage { get; set; }
        public string?  ControlPageN { get; set; }
        public string?  ControlType { get; set; }
        public bool chkEnable { get; set; }
        public bool chkApprove { get; set; }
        public bool chkSender { get; set; }
        public bool chkReceiver { get; set; }
        public bool chkOfSender { get; set; }
        public bool chkOfReceiver { get; set; }
        public bool chkNewSenderBefore { get; set; }
        public bool chkOldSenderBefore { get; set; }
        public bool chkNewSenderAfter { get; set; }
        public bool chkOldSenderAfter { get; set; }
        public bool chkNewReceiverBefore { get; set; }
        public bool chkOldReceiverBefore { get; set; }
        public bool chkNewReceiverAfter { get; set; }
        public bool chkOldReceiverAfter { get; set; }
    }
    public class ControlPageModelList
    {
        public ControlPageList[] ControlPageList { get; set; }
    }
    public class ControlPageListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public ControlPageModelList Content { get; set; }
    }
}