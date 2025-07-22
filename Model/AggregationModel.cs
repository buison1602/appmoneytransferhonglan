using System;

namespace AppMoneyTransferRS.Models
{
    public class AggregationModel
    {
        public int RowNumber { get; set; }
        
        public String FromCountry { get; set; }
        public String ToCountry { get; set; }
        public String State { get; set; }
        public String CountryIssue { get; set; }
        public bool ID { get; set; }
        public bool SSN { get; set; }
        public bool RequestReceiverID { get; set; }
        public bool NewSender { get; set; }
        public bool VerifyAddress { get; set; }
        public bool RequestSSN { get; set; }
        public int OptionDate1 { get; set; }
        public double OptionAmount1 { get; set; }
        public double KYCFolder1 { get; set; }
        public double MaxAmount1 { get; set; }
        public double OptionSSN1 { get; set; }

        public int OptionDate2 { get; set; }
        public double OptionAmount2 { get; set; }
        public double KYCFolder2 { get; set; }
        public double MaxAmount2 { get; set; }
        public double OptionSSN2 { get; set; }

        public int OptionDate3 { get; set; }
        public double OptionAmount3 { get; set; }
        public double KYCFolder3 { get; set; }
        public double MaxAmount3 { get; set; }
        public double OptionSSN3 { get; set; }

        public int OptionDate4 { get; set; }
        public double OptionAmount4 { get; set; }
        public double KYCFolder4 { get; set; }
        public double MaxAmount4 { get; set; }
        public double OptionSSN4 { get; set; }

        public int OptionDate5 { get; set; }
        public double OptionAmount5 { get; set; }
        public double KYCFolder5 { get; set; }
        public double MaxAmount5 { get; set; }
        public double OptionSSN5 { get; set; }

        public int OptionDate6 { get; set; }
        public double OptionAmount6 { get; set; }
        public double KYCFolder6 { get; set; }
        public double MaxAmount6 { get; set; } 
        public double OptionSSN6 { get; set; }

        public int OptionDate7 { get; set; }
        public double OptionAmount7 { get; set; }
        public double KYCFolder7 { get; set; }
        public double MaxAmount7 { get; set; }
        public double OptionSSN7 { get; set; }

        public int OptionDate8 { get; set; }
        public double OptionAmount8 { get; set; }
        public double KYCFolder8 { get; set; }
        public double MaxAmount8 { get; set; }
        public double OptionSSN8 { get; set; }

        public int OptionDate9 { get; set; }
        public double OptionAmount9 { get; set; }
        public double KYCFolder9 { get; set; }
        public double MaxAmount9 { get; set; }
        public double OptionSSN9 { get; set; }
        
            public bool SenderName { get; set; }
        public bool SenderAddress { get; set; }
        public bool SenderPhone { get; set; }
        public bool SenderID { get; set; }
        public bool SenderSSN { get; set; }
        public bool ReceiverLocalName { get; set; }
        public bool ReceiverAddress { get; set; }
        public bool ReceiverPhone { get; set; }
        public bool ReceiverBankAccount { get; set; }
        public bool ReceiverID { get; set; }
        public bool Email { get; set; }
        public string?  CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

    }

    public class AggregationModelList
    {
        public List<AggregationModel> AggregationModels { get; set; }
    }

    public class AggregationModelResp
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public AggregationModelList Content { get; set; }
    }
}
