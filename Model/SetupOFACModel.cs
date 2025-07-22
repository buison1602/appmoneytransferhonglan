using System.Collections.Generic;
using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.Models
{
    public class SetupOFACModel
    {
        public Int64 RowNumber { get; set; }
        public Int64 STT { get; set; }
        public string?  OFAC { get; set; }
        public int Percent { get; set; }
      
        public double Total { get; set; }
        
        public string?  CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string?  EditedBy { get; set; }
        public DateTime? EditDate { get; set; }
        public Boolean chkCheckOfacOnline { get; set; }

    }
    public class SetupOFACRespContent
    {        
        public List<SetupOFACModel> ReportDetail { get; set; }
    }
    public class SetupOFACResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public SetupOFACRespContent Content { get; set; }
    }

}