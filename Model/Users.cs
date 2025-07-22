using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    public class Users
    {
        public string?  UserID { get; set; }
        public string?  UserName { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  LegalName { get; set; }
        public string?  OwnerName { get; set; }
        public string?  AgentID { get; set; }
        public string?  TranAgentID { get; set; }        
        public string?  AgentName { get; set; }
        public string?  AgentState { get; set; }
        public string?  FullName { get; set; }
        public string?  GroupID { get; set; }
        public string?  GroupName { get; set; }
        public string?  ImageUrl { get; set; }
        public string?  Expire { get; set; }
        public int TimeOut { get; set; }
        public int TimeWarning { get; set; }
        public string?  methodBankList { get; set; }
        public string?  Occupation { get; set; }
        public string?  AgentType { get; set; }
        
        public byte[]? FileImage { get; set; }
        public int EditProfile { get; set; }
        public bool Warning { get; set; } = false;
    }
    public class UsersResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public Users[] Content { get; set; }
    }
}