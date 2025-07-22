using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{      
    public class CustomerProfileFile
    {       
        public Int64 RowNumber { get; set; }        
        public string?  B_CUST_ID { get; set; }
        public string?  CUST_ID { get; set; }
        public string?  TRANS_ID { get; set; }
        public string?  AGENT_ID { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  TypeUpload { get; set; }
        public string?  UserID { get; set; }
        public Int64 No { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string?  EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string?  FileName { get; set; }
        public byte[]? FileLoad { get; set; }
        public bool? IsView { get; set; }
        public string?  FileName1 { get; set; }
        public string?  FileLoadBase64 { get; set; }
        
    }
    
    public class CustomerProfileFileResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public List<CustomerProfileFile>  Content { get; set; }
    }
}