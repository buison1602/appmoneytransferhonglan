using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class NoteModel
    {
        public string?  NCode { get; set; }
        public string?  NName { get; set; }
        public string?  Warning { get; set; }
        public string?  Warning2 { get; set; }
        public string?  Warning3 { get; set; }
        public bool Show { get; set; }
    }
  
    public class NoteModelListResp
    {
        public int Status { get; set; }
        public string?  Message { get; set; }
        public NoteModel[] Content { get; set; }
    }
}