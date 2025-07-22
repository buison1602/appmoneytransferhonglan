using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class pageSizeModel
    {
        public int PageID { get; set; }
        public string?  PageName { get; set; }
    }
    public class pageSizesModel
    {
        public List<pageSizeModel> pageSizeModels { get; set; }
     
    }
   
}