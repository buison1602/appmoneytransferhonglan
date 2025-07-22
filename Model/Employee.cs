using System;

namespace AppMoneyTransferRS.Models
{
    public class Employee
    {
        public String MANV { get; set; }
        
        public String TenNV { get; set; }
    }

    public class EmployeeInput
    {
        public String UserID { get; set; }
    }

    public class EmployeeResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public Employee[] Content { get; set; }
    }
}
