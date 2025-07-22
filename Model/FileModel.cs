using System.Collections.Generic;
namespace AppMoneyTransferRS.Models
{
   
    public class SaveFile
    {
        public SaveFile()
        {
            Files = new List<FileData>();
        }
        public List<FileData> Files { get; set; }
    }

    public class FileData
    {
        public byte[] ImageBytes { get; set; }
        public string?  FileName { get; set; }
        public string?  FileName1 { get; set; }
        public string?  FileType { get; set; }
        public long FileSize { get; set; }
        public string?  Cust_ID { get; set; }
        public string?  UserID { get; set; }
    }
    
}
