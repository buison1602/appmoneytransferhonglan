using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    
    public class splitList
    {
        public string?  Daucau { get; set; }
    }
    public class MenuParentList
    {
        public string?  MenuNameParent { get; set; }
        public string? Icon { get; set; }
        public bool GroupP { get; set; }
        

    }
    public class MenuParentListResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public MenuParentList[] Content { get; set; }
    }
}