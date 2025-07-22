using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
   
    public class ResponseResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }
       
    }
    public class PartnerFile
    {
        public Int64 RowNumber { get; set; }
        public Int64 ID { get; set; }
        public string?  IP_ID { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  UserID { get; set; }
        public Int64 No { get; set; }
        public string?  CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string?  EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string?  FileName { get; set; }
        public byte[]? FileImage { get; set; }
        public bool? IsView { get; set; }
        public bool AgentShow { get; set; }

        public string?  FileName1 { get; set; }
        public string?  FileLoadBase64 { get; set; }
        public string?  NOIDUNG { get; set; }
        public string?  Comment { get; set; }
        public string?  CPI_NAME { get; set; }


    }
    public class PartnerFileList
    {
        public List<PartnerFile> PartnerFileLists { get; set; }
    }
    public class PartnerFileResps
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public PartnerFileList Content { get; set; }
    }

}