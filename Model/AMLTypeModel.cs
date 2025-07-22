using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class AMLTypeModel
    {
        public int IdLoaiCauHoi { get; set; }
        public string?  LoaiCauHoi { get; set; }
    }
    public class AMLTypeModelListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public AMLTypeModel[] Content { get; set; }
    }
}