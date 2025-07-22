using System;

namespace AppMoneyTransferRS.Models
{
    public class ViewOfacModel
    {
        public int RowNumber { get; set; }
        
        public String Trans_ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Type { get; set; }
        public String Program { get; set; }
        public String List { get; set; }
        public String Score { get; set; }
        public String Loai { get; set; }
        public String TypeAPI { get; set; }
    }

    public class ViewOfacModelList
    {
        public List<ViewOfacModel> ViewOfacModelLists { get; set; }
    }

    public class ViewOfacModelResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public ViewOfacModelList Content { get; set; }
    }
}
