using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMoneyTransferRS.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Enter Agent Name")]
        public string?  AgentName { get; set; }

        [Required(ErrorMessage = "Enter Agent ID")]
        public string?  AgentID { get; set; }

        [Required(ErrorMessage = "Enter User Name")]
        public string?  Username { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string?  Password { get; set; }
        public string?  Ip { get; set; }
    }
}
