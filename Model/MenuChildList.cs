using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class MenuChildList
    {
        public string?  MenuNameParent { get; set; }
        public string?  MenuNameChild { get; set; }
        public string?  LinkPage { get; set; }
        public string?  LinkPageColor { get; set; }
        public string? Icon { get; set; }
        public string? IconColor { get; set; }
        public  Int64 STT { get; set; }

    }
    public class MenuChildListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public MenuChildList[] Content { get; set; }
    }
}