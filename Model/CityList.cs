using System.Collections.Generic;

namespace AppMoneyTransferRS.Models
{
    

    public class CityModel
    {
        public string?  City { get; set; }
        public string?  StateId { get; set; }
        public string?  PaymentAgent { get; set; }
        public string?  Zipcode { get; set; }
        public string?  CountryCode { get; set; }
    }
    public class CitysList
    {
        public List<CityModel> CityList { get; set; }
    }
    public class CityListResp
    {
        public int Status { get; set; }

        public string?  Message { get; set; }

        public CitysList Content { get; set; }
    }
   
}