using System;
using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
      
    public class TransImageModel
    {
        public string?  TenFile  { get; set; }
        public byte[]? FileImage { get; set; } 

    }
    public class TransImageList
    {
        public TransImageModel[] TransImagelist { get; set; }
    }
    public class TransImageModelResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public TransImageList Content { get; set; }
    }
    public class TransReceiptPDFResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }
        public byte[]? Content { get; set; } 
    }
    public class TransFileDownloadResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }
        public FileDownload Content { get; set; } 
    }
    public class FileDownload
    {
        public string?  LinkFile { get; set; }
        public string?  FileName { get; set; }
        public byte[]? FileLoad { get; set; }
    }
    public class TransReceiptbase64Resp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }
        public resReceipt Content { get; set; }
    }
    public class TransReceiptAllbase64Resp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }
        public List<resReceipt> Content { get; set; }
    }
    public class resReceipt
    {
        public string?  FileName { get; set; }
        public string?  FilePath { get; set; }
        public byte[] ReceiptByte { get; set; }
    }
}