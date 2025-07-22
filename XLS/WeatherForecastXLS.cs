using ClosedXML.Excel;
using AppMoneyTransferRS.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.EMMA;
using System.Text.RegularExpressions;
using AppMoneyTransferRS.Class;

namespace AppMoneyTransferRS.XLS;

public class WeatherForecastXLS
{
    public byte[] ExportExcelUserList(List<UserListModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        int row = 1;
    
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
     
        int i = 1;
        ws.Cell(row, i).Value = "No";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "User Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "User Type";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Full Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Agent ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Agent Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Last Login";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Last Logout";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Last Update";
        ws.Cell(row, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(row, i).Value = "Status";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "IP";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;

        row += 1;
       

        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row, i).Value = row-1;
            i += 1;
            ws.Cell(row, i).Value =  item.USERNAME;
            i += 1;
            ws.Cell(row, i).Value =  item.LEVEL_DESC;
            i += 1;
            ws.Cell(row, i).Value =@item.FIRSTNAME +" "+ item.MIDDLENAME + " " +  item.LASTNAME;
            i += 1;
            ws.Cell(row, i).Value = item.PHONE;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_ID;         
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.LAST_LOGINConvert;
            i += 1;
            ws.Cell(row, i).Value = item.LAST_LOGOUTConvert;
            i += 1;
            ws.Cell(row, i).Value = item.ChangeDateConvert;
            i += 1;
            ws.Cell(row, i).Value = item.StatusName;
            i += 1;
            ws.Cell(row, i).Value = item.ALLOW_IP;
            i += 1;
            row += 1;
           
        }
    
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportSOF(List<AggregationModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;

        i += 1;

        ws.Cell(1, i).Value = "From Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "To Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        ws.Cell(1, i).Value = "Option Date 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 2";
        ws.Cell(1, i).Style.Font.Bold = true;
     
        i += 1;
        ws.Cell(1, i).Value = "Option Date 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 3";
        ws.Cell(1, i).Style.Font.Bold = true;
    
        i += 1;


        ws.Cell(1, i).Value = "Option Date 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 4";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        ws.Cell(1, i).Value = "Option Date 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 5";
        ws.Cell(1, i).Style.Font.Bold = true;
      
        i += 1;
        ws.Cell(1, i).Value = "Option Date 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 6";
        ws.Cell(1, i).Style.Font.Bold = true;
      
        i += 1;


        ws.Cell(1, i).Value = "Option Date 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 7";
        ws.Cell(1, i).Style.Font.Bold = true;
      
        i += 1;
        ws.Cell(1, i).Value = "Option Date 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 8";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        ws.Cell(1, i).Value = "Option Date 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender SSN";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Bank Account";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust ID / Email";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FromCountry;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToCountry;
          
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount1;
         
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount2;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount3;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount4;
          
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount5;
          
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount6;
          
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount7;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount8;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount9;           
            i += 1;

            if (item.SenderName)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderAddress)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderPhone)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderSSN)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverLocalName)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverAddress)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverPhone)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverBankAccount)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.Email)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreatedBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreatedDate;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportAggregation(List<AggregationModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "From Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "To Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Has Receiver ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

      
        ws.Cell(1, i).Value = "Option Date 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Option Date 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender SSN";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Bank Account";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FromCountry;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToCountry;
            i += 1;
            ws.Cell(row + 1, i).Value = item.State;
            i += 1;
            if (item.ID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }           
            i += 1;
            ws.Cell(row + 1, i).Value = item.CountryIssue;
            i += 1;
            if (item.RequestReceiverID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount9;
            i += 1;
            if (item.SenderName)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderAddress)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderPhone)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderSSN)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverLocalName)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverAddress)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverPhone)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverBankAccount)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.Email)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreatedBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreatedDate;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportAggregationOnline(List<AggregationModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "From Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "To Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Has Receiver ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 1";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 3";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Option Date 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 4";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 5";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 6";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Option Date 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 7";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 8";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Date 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Amount 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option KYC Folder 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Option SSN 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Option Max Amount 9";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender SSN";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Bank Account";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Email";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FromCountry;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToCountry;
            i += 1;
            ws.Cell(row + 1, i).Value = item.State;
            i += 1;
            if (item.ID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.CountryIssue;
            i += 1;
            if (item.RequestReceiverID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount3;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount4;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount5;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount6;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount7;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount8;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionDate9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionAmount9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYCFolder9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OptionSSN9;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MaxAmount9;
            i += 1;
            if (item.SenderName)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderAddress)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderPhone)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.SenderSSN)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverLocalName)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverAddress)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverPhone)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverBankAccount)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.ReceiverID)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            if (item.Email)
            {
                ws.Cell(row + 1, i).Value = "1";
            }
            else
            {
                ws.Cell(row + 1, i).Value = "0";
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreatedBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreatedDate;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
  
    public byte[] ExportExcelSetUpRiskAssetmentList(List<SetRiskAssetmentDetail> reportDetails,
        List<SetRiskAssetmentSum> reportSummarys , string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 1;
       
    
        i = 1;
        ws.Cell(row, i).Value = "No";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Risk";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Type Year/Quarter";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Year";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "From";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "To";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Prepare By";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Prepare Date";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Approved By<";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Approved Date";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        
        row += 1;
        foreach (var item in reportSummarys)
        {
            i = 1;
            ws.Cell(row, i).Value = item.RowNumber;
            i += 1;
            ws.Cell(row, i).Value = item.RiskRateID;
            i += 1;
            ws.Cell(row, i).Value = item.Type;
            i += 1;
            ws.Cell(row, i).Value = item.Year;
            i += 1;
            ws.Cell(row, i).Value = item.FromScore;
            i += 1;
            ws.Cell(row, i).Value = item.ToScore;
            i += 1;
            ws.Cell(row, i).Value = item.PrepareBy;
            i += 1;
            ws.Cell(row, i).Value = item.PrepareDate;
            i += 1;
            ws.Cell(row, i).Value = item.ApproveBy;
            i += 1;
            ws.Cell(row, i).Value = item.ApproveDate;
            row += 1;
        }
        row += 3;
        i = 1;
        ws.Cell(row, i).Value = "No";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Risk";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Type Year/Quarter";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Year";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "From";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "To";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Risk Detail";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Comment";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
       

        row += 1;
        foreach (var item in reportDetails)
        {
            i = 1;
            ws.Cell(row, i).Value = item.RowNumber;
            i += 1;
            ws.Cell(row, i).Value = item.RiskRateID;
            i += 1;
            ws.Cell(row, i).Value = item.Type;
            i += 1;
            ws.Cell(row, i).Value = item.Year;
            i += 1;
            ws.Cell(row, i).Value = item.FromScore;
            i += 1;
            ws.Cell(row, i).Value = item.ToScore;
            i += 1;
            ws.Cell(row, i).Value = item.RiskRateIDDetail;
            i += 1;
            ws.Cell(row, i).Value = item.RiskRateContent;
            i += 1;
           
            row += 1;
        }
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelRiskAssetmentList(List<RiskAssessmentModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 1;
        ws.Cell(row, i).Value = "No.";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Range("A1:A2").Row(1).Merge();
        i += 1;
        ws.Cell(row, i).Value = "Agent Info";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("B1:N1").Row(1).Merge();
        i += 13;
        ws.Cell(row, i).Value = "Transactions Number";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("O1:Z1").Row(1).Merge();
        i += 12;
        ws.Cell(row, i).Value = "Total Volumn";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("AA1:AL1").Row(1).Merge();
        i += 12;
        ws.Cell(row, i).Value = "Volumn is over 100k/month";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("AM1:AX1").Row(1).Merge();
        i += 12;
        ws.Cell(row, i).Value = "Summary";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("AY1:BC1").Row(1).Merge();
        i += 5;
        ws.Cell(row, i).Value = "SARs";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("BD1:BO1").Row(1).Merge();
        i += 12;
        ws.Cell(row, i).Value = "CTRs";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("BP1:CA1").Row(1).Merge();
        i += 12;
        ws.Cell(row, i).Value = "Risk Assessment";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range("CB1:CQ1").Row(1).Merge();
        i += 16;

        row += 1;
        i = 2;
        ws.Cell(row, i).Value = "Legal Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Alternate name, e.g., DBA";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Code";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent name base on system";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Last Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Middle Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "First Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "City";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "State";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Zipcode";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Country";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jan";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Feb";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Mar";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Apr";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "May";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jun";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jul";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Aug";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Sep";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Oct";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Nov";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Dec";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

        //total
        i += 1;
        ws.Cell(row, i).Value = "Jan";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Feb";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Mar";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Apr";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "May";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jun";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jul";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Aug";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Sep";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Oct";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Nov";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Dec";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        //over
        i += 1;
        ws.Cell(row, i).Value = "Jan";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Feb";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Mar";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Apr";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "May";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jun";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jul";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Aug";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Sep";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Oct";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Nov";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Dec";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        //Amount tran
        ws.Cell(row, i).Value = "Total Volumn ($)";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Total Trans";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Avg. ($/pc)";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Total CTRs";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Total SARs";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

        //SARs
        i += 1;
        ws.Cell(row, i).Value = "Jan";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Feb";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Mar";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Apr";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "May";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jun";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jul";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Aug";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Sep";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Oct";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Nov";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Dec";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        //CTRs
        i += 1;
        ws.Cell(row, i).Value = "Jan";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Feb";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Mar";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Apr";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "May";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jun";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Jul";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Aug";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Sep";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Oct";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Nov";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Dec";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;

        ws.Cell(row, i).Value = "8. SAR/Total Trans of HL";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "9. SAR/Total SAR of HL";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "1. High Risk Exposures";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "2. Destination";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "3. HIFCA";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "4. HIDTA";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "5. Volume";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "6. Average Transaction";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "7. Number of SARs filed";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "8. SARs/Total Trans";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "9. SAR/Total SARs of HL";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "10. Number of CTR filed";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Total";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Grade";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Grade Detail";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Comment";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        row += 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row , i).Value = row-2;
            i += 1;
            ws.Cell(row , i).Value = item.LEGAL_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.DBA;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.LASTNAME;
            i += 1;
            ws.Cell(row, i).Value = item.MIDDLENAME;
            i += 1;
            ws.Cell(row, i).Value = item.FIRSTNAME;
            i += 1;
            ws.Cell(row, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row, i).Value = item.CITY;
            i += 1;
            ws.Cell(row, i).Value = item.STATE;
            i += 1;
            ws.Cell(row, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row, i).Value = item.COUNTRY;
            i += 1;
            ws.Cell(row, i).Value = item.PHONE;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_01;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_02;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_03;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_04;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_05;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_06;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_07;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_08;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_09;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_10;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_11;
            i += 1;
            ws.Cell(row, i).Value = item.TranNo_12;
            i += 1;

            ws.Cell(row, i).Value = item.TranAmount_01;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_02;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_03;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_04;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_05;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_06;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_07;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_08;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_09;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_10;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_11;
            i += 1;
            ws.Cell(row, i).Value = item.TranAmount_12;
            i += 1;


            ws.Cell(row, i).Value = item.OverAmount_01;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_02;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_03;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_04;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_05;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_06;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_07;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_08;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_09;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_10;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_11;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.OverAmount_12;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;

            ws.Cell(row, i).Value = item.Amount;
            i += 1;
            ws.Cell(row, i).Value = item.CountOfTran;
            i += 1;
            ws.Cell(row, i).Value = item.AvgTran;
            i += 1;
            ws.Cell(row, i).Value = item.NoofCtrs;
            i += 1;
            ws.Cell(row, i).Value = item.NoofSars;
            i += 1;

            ws.Cell(row, i).Value = item.SarsNo_01;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_02;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_03;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_04;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_05;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_06;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_07;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_08;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_09;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_10;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_11;
            i += 1;
            ws.Cell(row, i).Value = item.SarsNo_12;
            i += 1;

            ws.Cell(row, i).Value = item.CtrsNo_01;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_02;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_03;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_04;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_05;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_06;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_07;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_08;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_09;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_10;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_11;
            i += 1;
            ws.Cell(row, i).Value = item.CtrsNo_12;
            i += 1;


            ws.Cell(row, i).Value = item.SarsofTrans;
            i += 1;
            ws.Cell(row, i).Value = item.SarsofTotal;
            i += 1;
            ws.Cell(row, i).Value = item.HighRisk;
            i += 1;
            ws.Cell(row, i).Value = item.Destination;
            i += 1;
            ws.Cell(row, i).Value = item.HIFCA;
            i += 1;
            ws.Cell(row, i).Value = item.HIDTA;
            i += 1;
            ws.Cell(row, i).Value = item.Volumn;
            i += 1;
            ws.Cell(row, i).Value = item.AverageTransaction;
            i += 1;
            ws.Cell(row, i).Value = item.NumberofSAR;
            i += 1;
            ws.Cell(row, i).Value = item.SARsTotalTrans;
            i += 1;
            ws.Cell(row, i).Value = item.SARsTotalofHL;
            i += 1;
            ws.Cell(row, i).Value = item.NumberofCTRs;
            i += 1;
            ws.Cell(row, i).Value = item.Total;
            i += 1;
            ws.Cell(row, i).Value = item.Grade;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.GradeDetail;
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = item.Comment;
            i += 1;

            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAgentListforFinCENList(List<AgentModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 1;
      
        ws.Cell(row, i).Value = "No";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Id";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Legal Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "DBA";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Fax";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Email";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Location";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Type of Business";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Business Structure";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Secrectary of State File #";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Expire";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "City Business License #";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Expire";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "EIN#";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Type";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Start Date";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent End Date";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner First Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Middle Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Last Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

        //total
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "SS";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Expire";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner First Name 2";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Middle Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Last Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "SS";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Expire";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner First Name 3";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Middle Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Last Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "SS";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Expire";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        //over
        i += 1;
        ws.Cell(row, i).Value = "Compliance Officer";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
       
        i += 1;
        ws.Cell(row, i).Value = "ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "SS";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Expire";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Payment Method";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Bank Type";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Bank Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Bank Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Sending Country";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Receiving Country";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Status";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Reason for Ending Agreement";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Bond";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Credit Line";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Max Credit Line";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
      
        row += 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row, i).Value = item.RowNumber;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.LEGAL_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.DBA;
            i += 1;
            ws.Cell(row, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row, i).Value = item.FULLADDRESS;
            i += 1;
            ws.Cell(row, i).Value = item.PHONE;
            i += 1;
            ws.Cell(row, i).Value = item.FAX;
            i += 1;
            ws.Cell(row, i).Value = item.EMAIL;
            i += 1;
            ws.Cell(row, i).Value = item.LOCATION;
            i += 1;
            ws.Cell(row, i).Value = item.BUSINESS_TYPE;
            i += 1;
            ws.Cell(row, i).Value = item.BUSINESS_STRUCT_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.STATEFILE;
            i += 1;
            ws.Cell(row, i).Value = item.EXPIRE;
            i += 1;
            ws.Cell(row, i).Value = item.LICENSE_NO;
            i += 1;
            ws.Cell(row, i).Value = item.EXPIRE1;
            i += 1;
            ws.Cell(row, i).Value = item.EIN;
            i += 1;
         
            ws.Cell(row, i).Value = item.AGENT_TYPE;
            i += 1;
            ws.Cell(row, i).Value = item.DATE_CREATE;
            i += 1;
            ws.Cell(row, i).Value = item.DATE_STOP;
            i += 1;
            ws.Cell(row, i).Value = item.FIRSTNAME;
            i += 1;
            ws.Cell(row, i).Value = item.MIDDLENAME;
            i += 1;
            ws.Cell(row, i).Value = item.LASTNAME;
            i += 1;
            ws.Cell(row, i).Value = item.OWNERFULLADDRESS;
            i += 1;

            ws.Cell(row, i).Value = item.OwnerPhone;
            i += 1;
            ws.Cell(row, i).Value = item.ID;
            i += 1;
            ws.Cell(row, i).Value = item.SS;
            i += 1;
            ws.Cell(row, i).Value = item.OWNEREXPIRE;
            i += 1;
            ws.Cell(row, i).Value = item.FIRSTNAME2;
            i += 1;
            ws.Cell(row, i).Value = item.MIDDLENAME2;
            i += 1;
            ws.Cell(row, i).Value = item.LASTNAME2;
            i += 1;
            ws.Cell(row, i).Value = item.OWNERFULLADDRESS2;
            i += 1;
            ws.Cell(row, i).Value = item.OwnerPhone1;
            i += 1;
            ws.Cell(row, i).Value = item.ID1;
            i += 1;
            ws.Cell(row, i).Value = item.SS1;
            i += 1;
            ws.Cell(row, i).Value = item.OWNEREXPIRE1;
            i += 1;
            ws.Cell(row, i).Value = item.FIRSTNAME3;
            i += 1;
            ws.Cell(row, i).Value = item.MIDDLENAME3;
            i += 1;
            ws.Cell(row, i).Value = item.LASTNAME3;
            i += 1;
            ws.Cell(row, i).Value = item.OWNERFULLADDRESS3;
            i += 1;
            ws.Cell(row, i).Value = item.OwnerPhone3;
            i += 1;
            ws.Cell(row, i).Value = item.ID3;
            i += 1;
            ws.Cell(row, i).Value = item.SS3;
            i += 1;
            ws.Cell(row, i).Value = item.OWNEREXPIRE3;
            i += 1;
            ws.Cell(row, i).Value = item.COMPLIANCE_OFFICER;
            i += 1;
            ws.Cell(row, i).Value = item.CID;
            i += 1;
            ws.Cell(row, i).Value = item.CSS;
            i += 1;
            ws.Cell(row, i).Value = item.CEXPIREDATECon;
            i += 1;
            ws.Cell(row, i).Value = item.PAYMENT_METHOD;
            i += 1;
            ws.Cell(row, i).Value = item.BANK_TYPE;
            i += 1;
            ws.Cell(row, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.BANK_ADDRESS;
            i += 1;

            ws.Cell(row, i).Value = item.SENDCOUNTRYFULL;
            i += 1;
            ws.Cell(row, i).Value = item.RECEIVECOUNTRYFULL;
            i += 1;
            ws.Cell(row, i).Value = item.StatusName;
            i += 1;
            ws.Cell(row, i).Value = item.REASONFORBLOCK;
            i += 1;
            ws.Cell(row, i).Value = @String.Format("{0:n2}", item.BondAmount);
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = @String.Format("{0:n2}", item.CREDIT_LINE);
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = @String.Format("{0:n2}", item.CREDIT_LINEAPP);            
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
         
            i += 1;

            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAgentListList(List<AgentModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 1;

        ws.Cell(row, i).Value = "No";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Id";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Legal Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "DBA";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner Name";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Address";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Phone";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Fax";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Email";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
      
        ws.Cell(row, i).Value = "Type of Business";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Business Structure";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Secretary of state file #";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "City Business license";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner 1 ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Owner 2 ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Compliance Officer";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
      
        ws.Cell(row, i).Value = "Sending Country";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Receiving Country";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Type";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent Start Date";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Agent End Date";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Status";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Reason for Ending Agreement";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Bond";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Credit Line";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        i += 1;
        ws.Cell(row, i).Value = "Max Credit Line";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

        row += 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row, i).Value = item.RowNumber;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.LEGAL_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.DBA;
            i += 1;
            ws.Cell(row, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row, i).Value = item.FULLADDRESS;
            i += 1;
            ws.Cell(row, i).Value = item.PHONE;
            i += 1;
            ws.Cell(row, i).Value = item.FAX;
            i += 1;
            ws.Cell(row, i).Value = item.EMAIL;
            i += 1;          
            ws.Cell(row, i).Value = item.BUSINESS_TYPE;
            i += 1;
            ws.Cell(row, i).Value = item.BUSINESS_STRUCT_NAME;
            i += 1;
            ws.Cell(row, i).Value = item.STATEFILE;
            i += 1;
            ws.Cell(row, i).Value = item.LICENSE_NO;
            i += 1;
            ws.Cell(row, i).Value = item.ID;
            i += 1;
            ws.Cell(row, i).Value = item.ID1;
            i += 1;

            ws.Cell(row, i).Value = item.COMPLIANCE_OFFICER;
            i += 1;
           
            ws.Cell(row, i).Value = item.SENDCOUNTRYFULL;
            i += 1;
            ws.Cell(row, i).Value = item.RECEIVECOUNTRYFULL;
            i += 1;
            ws.Cell(row, i).Value = item.AGENT_TYPE;
            i += 1;
            ws.Cell(row, i).Value = item.DATE_CREATE;
            i += 1;
            ws.Cell(row, i).Value = item.DATE_STOP;
            i += 1;
            ws.Cell(row, i).Value = item.StatusName;
            i += 1;
            ws.Cell(row, i).Value = item.REASONFORBLOCK;
            i += 1;
            ws.Cell(row, i).Value = @String.Format("{0:n2}", item.BondAmount);
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = @String.Format("{0:n2}", item.CREDIT_LINE);
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            i += 1;
            ws.Cell(row, i).Value = @String.Format("{0:n2}", item.CREDIT_LINEAPP);
            ws.Cell(row, i).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            i += 1;

            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAMLTrainingDetailLogList(List<AMLTrainingLogModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Compliance Officer";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trainer name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trainee name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Testing Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Module";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Score";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Greade";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Result";
        ws.Cell(1, i).Style.Font.Bold = true;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Agent_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Agent_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COMPLIANCE_OFFICER;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Trainer_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Trainee_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss");
            i += 1;
            ws.Cell(row + 1, i).Value = item.LoaiCauHoi;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NoiDung;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Answer;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Grade;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Result;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAMLTrainingLogList(List<AMLTrainingLogModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Module";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Test Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Effective Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expire Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created By";
        ws.Cell(1, i).Style.Font.Bold = true;
       

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;          
            ws.Cell(row + 1, i).Value = item.LoaiCauHoi;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NoiDung;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FromDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss");
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelIndependentReviewList(List<IndependentReviewModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "File Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Effective Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expire Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Status";
        ws.Cell(1, i).Style.Font.Bold = true;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss");
            i += 1;
            ws.Cell(row + 1, i).Value = item.AML_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NOIDUNG;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.FromDate.ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToDate.ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = item.SHOW;

            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelComplianceList(List<ComplianceModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "File Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Comment";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Effective Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expire Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Status";
        ws.Cell(1, i).Style.Font.Bold = true;
        
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss");
            i += 1;
            ws.Cell(row + 1, i).Value = item.CPI_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NOIDUNG;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Comment;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FromDate.ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToDate.ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = item.SHOW;
            
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelComplianceSubmitList(List<ComplianceSubmitModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Submit Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Comment";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SubmitDate.ToString("MM/dd/yyyy HH:mm:ss");
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UserName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FullName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NOIDUNG;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Comment;
            i += 1;

            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAmlMaterialList(List<AMLMaterialModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "File Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Effective Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expire Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Status";
        ws.Cell(1, i).Style.Font.Bold = true;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss");
            i += 1;
            ws.Cell(row + 1, i).Value = item.NOIDUNG;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AML_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FromDate.ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = item.ToDate.ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = item.SHOW;

            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAMLTestList(List<AMLTestModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Module";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Test Subject";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        ws.Cell(1, i).Value = "Effective Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expire Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Show";
        ws.Cell(1, i).Style.Font.Bold = true;
        ws.Cell(1, i).Value = "Created Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Edited Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Edited By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Module;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NoiDung;
            i += 1;         
            ws.Cell(row + 1, i).Value =Convert.ToDateTime( item.FromDate==null?DateTime.UtcNow.AddHours(-7): item.FromDate).ToString("MM/dd/yyyy");
            i += 1;
            ws.Cell(row + 1, i).Value = Convert.ToDateTime(item.ToDate == null ? DateTime.UtcNow.AddHours(-7) : item.ToDate).ToString("MM/dd/yyyy");
            i += 1;
            if (item.show)
            {
                ws.Cell(row + 1, i).Value = true;
            }
            else
            {
                ws.Cell(row + 1, i).Value = false;
            }
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EditDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EditBy;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelOFACList(List<OfacModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Aka First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Aka Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Aka Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Title";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "SDN_TYPE";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "REMARK";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "TYPE";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FIRST_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LAST_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AKA_FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AKA_LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AKA_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS_1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Country;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TITLE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SDN_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REMARK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TYPESDN;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelHongLanBlackList(List<HongLanBlackListModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Type Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Error Message";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TypeName;
            i += 1;
            ws.Cell(row + 1, i).Value = "'" + item.BlackListName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ErrorMessage;
           
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelCollectList(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Account";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Note";
        ws.Cell(1, i).Style.Font.Bold = true;

        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SenderFullName;
            i += 1;
            ws.Cell(row + 1, i).Value = "'" + item.SenderPhone;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receivername;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReceiverPhone;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReceiverID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BankAccount;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Note;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelAgentRate(List<AgentRateModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Type Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Mode Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "From Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Min Amt";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Max Amt";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Comm Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Add Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Add Fee Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_ID;
            i += 1;          
            ws.Cell(row + 1, i).Value = item.TRANS_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRAN_TYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Payment_Mode;

            i += 1;
            ws.Cell(row + 1, i).Value = item.Payment_Mode_Name;

            i += 1;
            ws.Cell(row + 1, i).Value = item.VN_ZONE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.A_MIN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.A_MAX;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CUST_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.HQ_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TYPE_FEE;
            i += 1;
            row += 1;
        }
        i += 1;
      
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelSampleRateOnline(List<AgentRateModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Type Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(1, i).Value = "Payment Mode Name";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        ws.Cell(1, i).Value = "Zone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "From Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Min Amt";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Max Amt";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Comm Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Add Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Add Fee Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRAN_TYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Payment_Mode;
            i += 1;
            //ws.Cell(row + 1, i).Value = item.Payment_Mode_Name;
            //i += 1;
            ws.Cell(row + 1, i).Value = item.VN_ZONE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.A_MIN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.A_MAX;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CUST_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.HQ_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TYPE_FEE;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelSampleRate(List<AgentRateModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Type Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Mode Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "From Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Min Amt";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Max Amt";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Comm Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Add Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Add Fee Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;          
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRAN_TYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Payment_Mode;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Payment_Mode_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.VN_ZONE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.A_MIN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.A_MAX;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CUST_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.HQ_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TYPE_FEE;
            i += 1;
            row += 1;
        }
        i += 1;

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelTransactionCN9(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        int row = 3;
        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        int noftran = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        ws.Cell(1, 1).Value = SheetName.Replace(".xlsx", "");
        int i = 1;
        ws.Cell(row, i).Value = "收款人姓名*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "身份证号*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行卡号*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行卡预留电话*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款金额（CNY）*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行名称*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "开户支行名称*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "客户订单号*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "客户账号*";
        ws.Cell(row, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(row, i).Value = "备注*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人姓名*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(row, i).Value = "汇款人地址*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = " 汇款人电话*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人所属国籍*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人职业*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人行业";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人与收款人关系";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人证件类型";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人证件号码";
        ws.Cell(row, i).Style.Font.Bold = true;


        i = 1;
        row += 1;
        ws.Cell(row, i).Value = "Recipient Name*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Receiver ID number*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Bank card number*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Receiver Phone Number*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Payout Amount in RMB*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Bank Name*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sub Branch*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Transaction ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Merchant Id*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Notes";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender Name*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(row, i).Value = "Sender Address*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender Phone*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "The nationality of the sender*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender Occupation*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender work on Industry";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Relationship";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "ID type";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "ID number";
        ws.Cell(row, i).Style.Font.Bold = true;
        row += 1;
        //String[] strlist = dr[5].ToString().Split('-');
        //if (strlist.Length > 0)
        //{
        //    BankName = strlist[0];
        //}
        //else
        //{
        //    BankName = dr[5].ToString();

        //}
        //cells["F" + i].PutValue(BankName);//MST
        //String[] strlist2 = dr[6].ToString().Split(' ');
        //if (strlist2.Length > 1)
        //    if (strlist2.Length > 1)
        //    {
        //        cells["G" + i].PutValue(strlist2[1] + "-" + dr[7].ToString());//MST
        //    }
        //    else
        //    {
        //        cells["G" + i].PutValue(dr[6] + "-" + dr[7].ToString());//MST
        //    }


        foreach (var item in reportDetailsAll)
        {
            i = 1;
          
            ws.Cell(row, i).Value =clsFunction.ReplaceSpaceChinese( (item.LOCALNAME==null?"":item.LOCALNAME.Replace(" ", "")));
           
            i += 1;
            ws.Cell(row, i).Value ="'" + item.R_PASSPORT_NO;
            i += 1;
            ws.Cell(row, i).Value = "'" + item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row, i).Value = "'" + item.B_PHONE1;
            i += 1;
            ws.Cell(row, i).Value = item.B_AMT_PAY;
            i += 1;
            string BankName = "";
            String[] strlist = (item.R_BANK_NAME==null?"": item.R_BANK_NAME).ToString().Split('-');
            if (strlist.Length > 0)
            {
                BankName = strlist[0];
            }
            else
            {
                BankName = item.R_BANK_NAME == null ? "" : item.R_BANK_NAME;

            }
            //cells["F" + i].PutValue(BankName);//MST
            ws.Cell(row, i).Value = BankName;
            i += 1;
            String[] strlist2 = (item.StateName == null ? "" : item.StateName).ToString().Split(' ');
            if (strlist2.Length > 1)
            {
                ws.Cell(row, i).Value = strlist2[1] + "-" + (item.CN_CITY == null ? "" : item.CN_CITY);
               
            }
            else
            {
                ws.Cell(row, i).Value = (item.StateName == null ? "" : item.StateName).ToString() + "-" + (item.CN_CITY == null ? "" : item.CN_CITY);
            }


           
            i += 1;
            ws.Cell(row, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row, i).Value = "jackhungtruong@honglanservices.com";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row, i).Value = item.FULLADDRESS;
            i += 1;
            ws.Cell(row, i).Value = item.PHONE;
            i += 1;
            ws.Cell(row, i).Value = item.Nat;
            i += 1;
            ws.Cell(row, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row, i).Value = item.OCCUPATIONM;
            i += 1;
            ws.Cell(row, i).Value = item.RelationwithSenderNote;
            i += 1;
            totalAmountUSD += item.AMOUNT;
            totalAmountCNY += item.B_AMT_PAY;
            row += 1;
            noftran += 1;
        }
        ws.Cell(2, 1).Value = "Total Tran: " + noftran;
        ws.Cell(2, 2).Value = "Total Amount RMB: " + totalAmountCNY.ToString("###00.00");
        i += 1;
        //ws.Cell(row + 1, 15).Value = totalAmountUSD;
        //ws.Cell(row + 1, 15).Style.Font.Bold = true;
        //ws.Cell(row + 1, 16).Value = totalAmountCNY;
        //ws.Cell(row + 1, 16).Style.Font.Bold = true;
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelTransactionCN10(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        int row = 3;
        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        int noftran = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        ws.Cell(1, 1).Value = SheetName.Replace(".xlsx", "");
        int i = 1;
        ws.Cell(row, i).Value = "收款人姓名*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "身份证号*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行卡号*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行卡预留电话*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款金额（CNY）*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行名称*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "开户支行名称*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "客户订单号*";
        ws.Cell(row, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(row, i).Value = "备注*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人姓名*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(row, i).Value = "汇款人地址*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = " 汇款人电话*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人所属国籍*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人职业*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人行业*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人与收款人关系*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i = 1;
        row += 1;
        ws.Cell(row, i).Value = "Recipient Name*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Receiver ID number*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Bank card number*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Receiver Phone Number*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Payout Amount in RMB*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Bank Name*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sub Branch*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Transaction ID";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Merchant Id*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Notes";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender Name*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(row, i).Value = "Sender Address*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender Phone*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "The nationality of the sender*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender Occupation*";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Sender work on Industry";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Relationship";
        ws.Cell(row, i).Style.Font.Bold = true;
        row += 1;
        //String[] strlist = dr[5].ToString().Split('-');
        //if (strlist.Length > 0)
        //{
        //    BankName = strlist[0];
        //}
        //else
        //{
        //    BankName = dr[5].ToString();

        //}
        //cells["F" + i].PutValue(BankName);//MST
        //String[] strlist2 = dr[6].ToString().Split(' ');
        //if (strlist2.Length > 1)
        //    if (strlist2.Length > 1)
        //    {
        //        cells["G" + i].PutValue(strlist2[1] + "-" + dr[7].ToString());//MST
        //    }
        //    else
        //    {
        //        cells["G" + i].PutValue(dr[6] + "-" + dr[7].ToString());//MST
        //    }


        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row, i).Value = (item.LOCALNAME == null ? "" : item.LOCALNAME.Replace(" ", ""));
            i += 1;
            ws.Cell(row, i).Value = "'" + item.R_PASSPORT_NO;
            i += 1;
            ws.Cell(row, i).Value = "'" + item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row, i).Value = "'" + item.B_PHONE1;
            i += 1;
            ws.Cell(row, i).Value = item.B_AMT_PAY;
            i += 1;
            string BankName = "";
            String[] strlist = (item.R_BANK_NAME == null ? "" : item.R_BANK_NAME).ToString().Split('-');
            if (strlist.Length > 0)
            {
                BankName = strlist[0];
            }
            else
            {
                BankName = item.R_BANK_NAME == null ? "" : item.R_BANK_NAME;

            }
            //cells["F" + i].PutValue(BankName);//MST
            ws.Cell(row, i).Value = BankName;
            i += 1;
            String[] strlist2 = (item.StateName == null ? "" : item.StateName).ToString().Split(' ');
            if (strlist2.Length > 1)
            {
                ws.Cell(row, i).Value = strlist2[1] + "-" + (item.CN_CITY == null ? "" : item.CN_CITY);

            }
            else
            {
                ws.Cell(row, i).Value = (item.StateName == null ? "" : item.StateName).ToString() + "-" + (item.CN_CITY == null ? "" : item.CN_CITY);
            }



            i += 1;
            ws.Cell(row, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row, i).Value = "nguyetngo@honglanservices.com";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row, i).Value = item.FULLADDRESS;
            i += 1;
            ws.Cell(row, i).Value = item.PHONE;
            i += 1;
            ws.Cell(row, i).Value = item.Nat;
            i += 1;
            ws.Cell(row, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row, i).Value = item.OCCUPATIONM;
            i += 1;
            ws.Cell(row, i).Value = item.RelationwithSenderNote;
            i += 1;
            totalAmountUSD += item.AMOUNT;
            totalAmountCNY += item.B_AMT_PAY;
            row += 1;
            noftran += 1;
        }
        ws.Cell(2, 1).Value = "Total Tran: " + noftran;
        ws.Cell(2, 2).Value = "Total Amount RMB: " + totalAmountCNY.ToString("###00.00");
        i += 1;
        //ws.Cell(row + 1, 15).Value = totalAmountUSD;
        //ws.Cell(row + 1, 15).Style.Font.Bold = true;
        //ws.Cell(row + 1, 16).Value = totalAmountCNY;
        //ws.Cell(row + 1, 16).Style.Font.Bold = true;
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelTransactionCN12(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        int row = 1;
        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        int noftran = 0;
        string transid = "";
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Cell(1, 1).Value = SheetName.Replace(".xlsx", "");
        int i = 1;
        //ws.Cell(row, i).Value = "* 汇款订单号";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Transaction ID(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 平台准入时间";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Transaction Date(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
      
        //ws.Cell(row, i).Value = "* 汇款币种";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Remit Currency CNY(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 汇款金额";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Remit Amount CNY(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
      
        i += 1;
        //ws.Cell(row, i).Value = "* 汇款人名称";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payer Name(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        
                ws.Cell(row, i).Value = "Payer Phone(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "Payer Address(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 汇款人所属国籍";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payer Nationality(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 汇款人与收款人关系";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Relationship between payer and payee(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 汇款国家地区";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Remit from Country(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 收款人姓名";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee Name(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 收款人证件类型";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee ID Type(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 收款人证件号码";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee ID No.(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 收款人联系电话";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee Phone(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee Account Type(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "* 收款人银行卡号";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee Account Number(*)";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "收款银行名称";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Payee Bank Code";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "银行归属省份";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Branch located Province";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "银行归属城市";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Branch located City";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "银行支行名称";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Branch information";
        ws.Cell(row, i).Style.Font.Bold = true;
        i += 1;
        //ws.Cell(row, i).Value = "";
        //ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row, i).Value = "Remark";
        ws.Cell(row, i).Style.Font.Bold = true;
      
        i += 1;
        row += 1;
       
        try
        {
            foreach (var item in reportDetailsAll)
            {
                i = 1;
                ws.Cell(row, i).Value = item.TRANS_ID;
                transid = item.TRANS_ID;
               
                i += 1;
                ws.Cell(row, i).Value = Convert.ToDateTime(item.TRANS_DATE).ToString("MM/dd/yyyy");
                i += 1;
                ws.Cell(row, i).Value = "CNY";
                i += 1;
                ws.Cell(row, i).Value = item.B_AMT_PAY;
                i += 1;

                ws.Cell(row, i).Value = item.FULLNAME;
                i += 1;
                //if (string.IsNullOrEmpty(item.DRIVER_ID_BK))
                //{
                //    ws.Cell(row, i).Value = "";
                //}
                //else
                //{
                //    ws.Cell(row, i).Value = item.ID_TYPE == null ? "" : item.ID_TYPE;
                //}

                //i += 1;
                ws.Cell(row, i).Value = item.PHONE == null ? "" : item.PHONE;
                i += 1;
                ws.Cell(row, i).Value = item.FULLADDRESS == null ? "" : item.FULLADDRESS.Replace(" US", "");
                i += 1;
                ws.Cell(row, i).Value = "USA";
                i += 1;
                string RelationwithSenderNote= item.RelationwithSenderNote == null ? "" : item.RelationwithSenderNote;
                if(!string.IsNullOrEmpty(RelationwithSenderNote))
                {
                    ws.Cell(row, i).Value = item.RelationwithSenderNote == null ? "" : char.ToUpper(item.RelationwithSenderNote[0]) + item.RelationwithSenderNote.Substring(1).ToLower();
                }
                else
                {
                    ws.Cell(row, i).Value = "";
                }
                
                i += 1;
                ws.Cell(row, i).Value = "USA";
                i += 1;
                ws.Cell(row, i).Value = clsFunction.ReplaceSpaceChinese((item.LOCALNAME == null ? "" : item.LOCALNAME.Replace(" ","")));
                i += 1;
                ws.Cell(row, i).Value = "IDENTIFICATION";
                i += 1;
                ws.Cell(row, i).Value = "'" + item.R_PASSPORT_NO;
                i += 1;
                ws.Cell(row, i).Value = item.B_PHONE1 == null ? "" : item.B_PHONE1;
                i += 1;
                ws.Cell(row, i).Value = "PRI";
                i += 1;
                ws.Cell(row, i).Value = "'" + item.ACCOUNT_NO;
                i += 1;

                string BankName = item.R_BANK_NAME == null ? "" : item.R_BANK_NAME.ToString();
                if(!string.IsNullOrEmpty(BankName))
                {
                    String[] strlist = (item.R_BANK_NAME == null ? "" : item.R_BANK_NAME).ToString().Split('-');
                    if (strlist.Length > 0)
                    {
                        BankName = strlist[0];
                    }
                    else
                    {
                        BankName = item.R_BANK_NAME == null ? "" : item.R_BANK_NAME;
                    }
                }
               
                ws.Cell(row, i).Value = BankName;
                i += 1;
                string StateBank = item.StateBank == null ? "" : item.StateBank.ToString();
                if (!string.IsNullOrEmpty(StateBank))
                {
                    String[] strlist1 = (item.StateBank == null ? "" : item.StateBank).ToString().Split(' ');
                    if (strlist1.Length > 0)
                    {
                        StateBank = strlist1[1];
                    }
                    else
                    {
                        StateBank = item.StateBank == null ? "" : item.StateBank.Trim();
                    }
                }
                   
                ws.Cell(row, i).Value = StateBank;
                i += 1;
                ws.Cell(row, i).Value = item.BankCity == null ? "" : item.BankCity;
                i += 1;
                ws.Cell(row, i).Value = "";
                i += 1;
                ws.Cell(row, i).Value = "";
                i += 1;

                totalAmountCNY += item.B_AMT_PAY;
                row += 1;
                noftran += 1;
            }

            i += 1;
            //ws.Cell(row, 15).Value = totalAmountUSD;
            //ws.Cell(row, 15).Style.Font.Bold = true;
            //ws.Cell(row, 16).Value = totalAmountCNY;
            //ws.Cell(row, 16).Style.Font.Bold = true;
            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
        catch(Exception ex)
        {
            string a = transid;
            return null;
        }
      
    }
    public byte[] ExportExcelTransactionCN12_Old(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        int row = 1;
        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        int noftran = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Cell(1, 1).Value = SheetName.Replace(".xlsx", "");
        int i = 1;
        ws.Cell(row, i).Value = "* 汇款订单号";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row+1, i).Value = "Transaction ID";
        ws.Cell(row+1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 平台准入时间";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Transaction Input time";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* KYC方式";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "FACE_IDENTIFICATION";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 交易类型";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "C2C";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款金额";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Remit amount";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款币种";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Currency";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇率";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款时间";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Transaction date";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款订单渠道";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Walking to store";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款国家地区";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender country";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 资金来源";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Income";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款用途";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Reason for sending";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "交易附言";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "首次汇款时间";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        
        ws.Cell(row, i).Value = "最近汇款时间";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "添加收款人时间";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人名称";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender name";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人所属国籍";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender country";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人职业";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender Occupation Detail";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人行业";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender Industry";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人地址";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender address";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人证件类型";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender ID Type";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人证件号码";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender ID no.";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人证件有效期";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人联系电话";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender phone";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人电子邮箱";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Sender email address";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人生日";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row, i).Value = "汇款人工资范围";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
            ws.Cell(row, i).Value = "汇款银行名称";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "汇款人银行卡号";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 汇款人与收款人关系";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Relationship";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "ip";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "ip";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "经度";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "纬度";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "设备id";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "设备型号";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "系统类型";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 收款人姓名";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver name";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 收款人证件类型";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver ID type";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 收款人证件号码";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver ID No";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "收款人证件有效期";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 收款人银行卡号";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver Bank account";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "收款银行名称";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver bank name";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行归属省份";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Bank Province";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行归属城市";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Bank City";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "银行支行名称";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Bank location";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "* 收款人联系电话";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver Phone";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row, i).Value = "*收款人地址";
        ws.Cell(row, i).Style.Font.Bold = true;
        ws.Cell(row + 1, i).Value = "Receiver address";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        row += 2;
       

        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row, i).Value =Convert.ToDateTime( item.TRANS_DATE).ToString("yyyy-MM-dd HH:mm:ss");
            i += 1;
            ws.Cell(row, i).Value = "FACE_IDENTIFICATION";
            i += 1;
            ws.Cell(row, i).Value = "C2C";
            i += 1;
            ws.Cell(row, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row, i).Value = "CNY";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = Convert.ToDateTime(item.TRANS_DATE).ToString("yyyy-MM-dd HH:mm:ss");
            i += 1;
            ws.Cell(row, i).Value = "OFFICIAL_WEBSITE";
            i += 1;
            ws.Cell(row, i).Value = "840";
            i += 1;
            ws.Cell(row, i).Value = "SALARY";
            i += 1;
            ws.Cell(row, i).Value = item.REASON_SENDING==null? "":item.REASON_SENDING;
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row, i).Value = "840";
            i += 1;
            ws.Cell(row, i).Value = item.OCCUPATION==null?"":item.OCCUPATION;
            i += 1;
            ws.Cell(row, i).Value = item.OCCUPATIONM == null ? "" : item.OCCUPATIONM;
            i += 1;
            ws.Cell(row, i).Value = item.FULLADDRESS == null ? "" : item.FULLADDRESS.Replace(" US","");
            i += 1;
            if(string.IsNullOrEmpty(item.DRIVER_ID_BK))
            {
                ws.Cell(row, i).Value = "";
            }
            else
            {
                ws.Cell(row, i).Value = item.ID_TYPE == null ? "" : item.ID_TYPE;
            }
            
            i += 1;
            ws.Cell(row, i).Value = item.DRIVER_ID_BK == null ? "" : item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = item.PHONE1 == null ? "" : item.PHONE1;
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = item.RelationwithSenderNote == null ? "" : item.RelationwithSenderNote;
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value =  (item.LOCALNAME == null ? "" : item.LOCALNAME);
            i += 1;
            ws.Cell(row, i).Value = "IDENTIFICATION";
            i += 1;
            ws.Cell(row, i).Value = "'" + item.R_PASSPORT_NO;
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = "'" + item.ACCOUNT_NO;
            i += 1;

            string BankName = "";
            String[] strlist = (item.R_BANK_NAME == null ? "" : item.R_BANK_NAME).ToString().Split('-');
            if (strlist.Length > 0)
            {
                BankName = strlist[0];
            }
            else
            {
                BankName = item.R_BANK_NAME == null ? "" : item.R_BANK_NAME;
            }
            ws.Cell(row, i).Value = BankName;
            i += 1;
            string StateBank = "";
            String[] strlist1 = (item.StateBank == null ? "" : item.StateBank).ToString().Split(' ');
            if (strlist1.Length > 0)
            {
                StateBank = strlist1[1];
            }
            else
            {
                StateBank = item.StateBank == null ? "" : item.StateBank.Trim();
            }
            ws.Cell(row, i).Value = StateBank;
            i += 1;
            ws.Cell(row, i).Value = item.BankCity == null ? "" : item.BankCity;
            i += 1;
            ws.Cell(row, i).Value = "";
            i += 1;
            ws.Cell(row, i).Value = item.B_PHONE1 == null ? "" : item.B_PHONE1;
            i += 1;

            string ProvinceName ="";
           
            String[] strlist2 = (item.StateName == null ? "" : item.StateName).ToString().Split(' ');
            if (strlist2.Length > 0)
            {
                ProvinceName = strlist2[1];
            }
            else
            {
                ProvinceName = item.StateName == null ? "" : item.StateName.Trim();
            }

            ws.Cell(row, i).Value = item.R_FULLADDRESS == null ? "" : item.R_FULLADDRESS.ToUpper().Replace((item.StateName == null ? "" : item.StateName.Trim().ToUpper()), ProvinceName.ToUpper()).Replace(" CN","").Replace("NONE ", "");
            i += 1;

            totalAmountCNY += item.B_AMT_PAY;
            row += 1;
            noftran += 1;
        }
      
        i += 1;
        //ws.Cell(row + 1, 15).Value = totalAmountUSD;
        //ws.Cell(row + 1, 15).Style.Font.Bold = true;
        //ws.Cell(row + 1, 16).Value = totalAmountCNY;
        //ws.Cell(row + 1, 16).Style.Font.Bold = true;
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelTransactionCN2(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Merchant Order No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Contact Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Send Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Contact Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Id Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Account Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount / US";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount / CNY";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            totalAmountUSD += item.AMOUNT;
            totalAmountCNY += item.B_AMT_PAY;
            row += 1;

        }
        i += 1;
        ws.Cell(row + 1, 15).Value = totalAmountUSD;
        ws.Cell(row + 1, 15).Style.Font.Bold = true;
        ws.Cell(row + 1, 16).Value = totalAmountCNY;
        ws.Cell(row + 1, 16).Style.Font.Bold = true;
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelTransactionCN4(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;

        ws.Cell(1, i).Value = "交易编号";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "汇款人ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "汇款人姓名";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "汇款人电话";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "汇款人常驻国家";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "汇款人地址";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "收款人姓名";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "收款人身份证号码";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "金额 RMB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "收款人银行卡号码";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "收款人银行卡绑定手机号";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "收款人联系手机号";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "开户行编号";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "开户行省";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "开户行市";
        ws.Cell(1, i).Style.Font.Bold = true;
        
        i += 1;
        ws.Cell(1, i).Value = "身份证照片";
        ws.Cell(1, i).Style.Font.Bold = true;
        


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value =item.CUST_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value =item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = "'" + item.RECEIVERID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = "'" + item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Rec_BankStateHoa;
            i += 1;
            ws.Cell(row + 1, i).Value = "'" + item.Rec_CityState;
            i += 1;
            ws.Cell(row + 1, i).Value = "";
            i += 1;
            //ws.Cell(row + 1, i).Value = item.TRANS_ID;
            //i += 1;
            totalAmountCNY += item.B_AMT_PAY;
            row += 1;

        }
        i += 1;
        //ws.Cell(row + 1, 15).Value = totalAmountUSD;
        //ws.Cell(row + 1, 15).Style.Font.Bold = true;
        //ws.Cell(row + 1, 16).Value = totalAmountCNY;
        //ws.Cell(row + 1, 16).Style.Font.Bold = true;
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelTransactionCN8(List<batchTransactionFileExportModel> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();

        double totalAmountUSD = 0;
        double totalAmountCNY = 0;
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;
       
        ws.Cell(1, i).Value = "No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Merchant Order No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Contact Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Send Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Receiver Contact Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Id Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Account Number";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount / US";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount / CNY";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
           

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = clsFunction.ReplaceSpaceChinese((item.LOCALNAME==null?"": item.LOCALNAME.Replace(" ", "")));
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            totalAmountUSD+= item.AMOUNT;
            totalAmountCNY += item.B_AMT_PAY;
            row += 1;

        }
        i += 1;
        ws.Cell(row + 1, 15).Value = totalAmountUSD;
        ws.Cell(row + 1, 15).Style.Font.Bold = true;
        ws.Cell(row + 1, 16).Value = totalAmountCNY;
        ws.Cell(row + 1, 16).Style.Font.Bold = true;
        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelQuickBookDomestic(List<QuickbookCounterData> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 0;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = item.A;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C;
            i += 1;
            ws.Cell(row + 1, i).Value = item.D;
            i += 1;
            ws.Cell(row + 1, i).Value = item.E;
            i += 1;
            ws.Cell(row + 1, i).Value = item.F;
            i += 1;
            ws.Cell(row + 1, i).Value = item.G;
            i += 1;
         

            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelQuickBookOnlineDebit(List<QuickbookCounterData> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 0;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = item.A;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C;
            i += 1;
            ws.Cell(row + 1, i).Value = item.D;
            i += 1;
            ws.Cell(row + 1, i).Value = item.E;
            i += 1;
            //ws.Cell(row + 1, i).Value = item.F;
            //i += 1;
            ws.Cell(row + 1, i).Value = item.G;
            i += 1;
            ws.Cell(row + 1, i).Value = item.H;
            i += 1;

            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelQuickBookHLDebit(List<QuickbookCounterData> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        int i = 1;
        int row = 0;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = item.A;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C;
            i += 1;
            ws.Cell(row + 1, i).Value = item.D;
            i += 1;
            ws.Cell(row + 1, i).Value = item.E;
            i += 1;
            ws.Cell(row + 1, i).Value = item.F;
            i += 1;
            ws.Cell(row + 1, i).Value = item.G;
            i += 1;


            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelQuickBookCounter(List<QuickbookCounterData> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        //ws.Cell(1, i).Value = "A";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "B";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "C";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "D";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "E";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "E1";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "F";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "G";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "H";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        ////ws.Cell(1, i).Value = "I";
        ////ws.Cell(1, i).Style.Font.Bold = true;
        ////i += 1;
        ////ws.Cell(1, i).Value = "J";
        ////ws.Cell(1, i).Style.Font.Bold = true;
        ////i += 1;
        ////ws.Cell(1, i).Value = "J1";
        ////ws.Cell(1, i).Style.Font.Bold = true;
        ////i += 1;
        //ws.Cell(1, i).Value = "K";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "L";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Cell(1, i).Value = "Trans ID";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Ref No";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Trans Date";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Agent Name";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Sender Name";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;
        //ws.Column(i).AdjustToContents();
        //ws.Cell(1, i).Value = "Sender Address";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Sender Phone";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;


        //ws.Cell(1, i).Value = "Receiver Name";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Receiver Address";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Receiver Phone";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Account No";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Country";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Amount";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Cust Fee";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Other Fee";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Tax Fee";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Discount";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Total Amount";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Agent Fee";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Total Due";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Currency";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Total Paid";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        //ws.Cell(1, i).Value = "Created by";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;


        int row = 0;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = item.A==null?"": item.A;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B == null ? "" : item.B;
            i += 1;
            ws.Cell(row + 1, i).Value = item.C == null ? "" : item.C;
            i += 1;
            ws.Cell(row + 1, i).Value = item.D == null ? "" : item.D;
            i += 1;
            ws.Cell(row + 1, i).Value = item.E == null ? "" : item.E;
            i += 1;
            ws.Cell(row + 1, i).Value = item.E1 == null ? "" : item.E1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.F == null ? "" : item.F;
            i += 1;

            ws.Cell(row + 1, i).Value = item.G == null ? "" : item.G;
            i += 1;
            ws.Cell(row + 1, i).Value = item.H == null ? "" : item.H;
            i += 1;
            //ws.Cell(row + 1, i).Value = item.I == null ? "" : item.I;
            //i += 1;
            //ws.Cell(row + 1, i).Value = item.J == null ? "" : item.J;
            //i += 1;
            //ws.Cell(row + 1, i).Value = item.J1 == null ? "" : item.J1;
            //i += 1;
           
            ws.Cell(row + 1, i).Value = item.K == null ? "" : item.K;
            i += 1;
            ws.Cell(row + 1, i).Value = item.L == null ? "" : item.L;
            i += 1;

            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportDatatoExcelReportVN(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       
        ws.Cell(1, i).Value = "First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Middle Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        

        ws.Cell(1, i).Value = "Recipient ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Middle Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
     
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Dilivery Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       

        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
      
        i += 1;
        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = " Transaction Type/Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Code";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Message";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Sending";
        ws.Cell(1, i).Style.Font.Bold = true;
      
        i += 1;
      
        ws.Cell(1, i).Value = "Source of Fund";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agg Check";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "HL Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MIDDLENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.B_CUST_ID_REF;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_MIDDLENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESSVN;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.R_StateName;
            i += 1;
            
            ws.Cell(row + 1, i).Value = item.B_PHONE1 + " - " +  item.B_PHONE2;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;

            i += 1;
          
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.BANKCODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_ACCOUNT_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REASON_SENDING;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MSG_TO_BENE_1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.securityanswer;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CompanyNote;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StatusName;
            i += 1;
          
         
         
            ws.Cell(row + 1, i).Value = item.PaidDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_PASSPORT_NO;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportDatatoExcelPayment(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        
        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       

        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Code";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        ws.Cell(1, i).Value = "Bank City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type / Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Message";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Pending";
        ws.Cell(1, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(1, i).Value = "Agent Feedback";
        ws.Cell(1, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(1, i).Value = "Status";
        ws.Cell(1, i).Style.Font.Bold = true;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;           
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaidDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESSVN;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_PHONE1 ;
            i += 1;
            ws.Cell(row + 1, i).Value =  item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANKCODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.BANK_ADDRESS;
            i += 1;          
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_NOTE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonForPending;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FeedBack;
            i += 1;
            
            ws.Cell(row + 1, i).Value = item.StatusName;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportReviewPaymentTransactiontoExcel(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type/ Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Exchange Rate";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User Review Payment Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cyber Review Payment Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cyber Refund Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Status";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User refund Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User refund by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User refund reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PROVINCE_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXCHANGE_RATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.VerifyDate == null ? "" : item.VerifyDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CyberPaymentPayment == null ? "" : item.CyberPaymentPayment;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CyberRefundDate == null ? "" : item.CyberRefundDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StatusName == null ? "" : item.StatusName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REVIEWREFUNDDATE==null?"": item.REVIEWREFUNDDATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REVIEWREFUNDBY == null ? "" : item.REVIEWREFUNDBY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REVIEWREFUNDREASON == null ? "" : item.REVIEWREFUNDREASON;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }

    public byte[] ExportReviewDMTransactiontoExcel(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx","").Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type/ Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Exchange Rate";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "DM Trigger";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Review by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User DM Review";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User DM Review Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "CyberSource DM Review";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PROVINCE_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXCHANGE_RATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonReview == null ? "" : item.ReasonReview;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReviewBy == null ? "" : item.ReviewBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReviewDate == null ? "" : item.ReviewDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonReviewApproved == null ? "" : item.ReasonReviewApproved;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CyberDMDate==null?"": item.CyberDMDate;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    
        public byte[] ExportOFACReporttoExcel(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;       
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;

            ws.Cell(row + 1, i).Value = item.AGENT_NAME;

            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.ACTION_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COMMENT_OFAC;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionDate;
           
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportReleaseHoldingtoExcel(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type/ Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Exchange Rate";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Action Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;

            ws.Cell(row + 1, i).Value = item.AGENT_NAME;

            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXCHANGE_RATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACTION_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COMMENTHOLD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionBy;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportHoldingtoExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type/ Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Exchange Rate";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Action Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;

            ws.Cell(row + 1, i).Value = item.AGENT_NAME;

            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXCHANGE_RATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACTION_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonHolding;
            i += 1;
            ws.Cell(row + 1, i).Value = item.HoldingDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.HoldingBy;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportApproveTransactiontoExcel(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Approved Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Approved by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type/ Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Exchange Rate";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;

            ws.Cell(row + 1, i).Value = item.DATE_VERIFY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.VERIFIED;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;

            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PROVINCE_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXCHANGE_RATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;

            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportPaymentAgentTransactiontoExcel(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       

        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Transaction Type/ Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        
        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Exchange Rate";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PROVINCE_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXCHANGE_RATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
           
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    
        public byte[] ExportKYCReporttoExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        
        ws.Cell(1, i).Value = "Cust Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
       
        i += 1;
        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Pay Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Kyc Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Compliance Comment";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Action by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;         
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CUST_ID;          
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAY_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACTION_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COMMENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMMENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionDate;
            
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportDataMTtoExcelReport(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Middle Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
     
        i += 1;
        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Issue Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Recipient ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Middle Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Bank Code";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Message";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Sending";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User Input";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Company Note";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans Status";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MIDDLENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ISSUE_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_CUST_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_MIDDLENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PROVINCE_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;

            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANKCODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_ACCOUNT_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MSG_TO_BENE_1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REASON_SENDING;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CompanyNote;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StatusName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaidDate;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportIdologytoExcelReport(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      

        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
      
        i += 1;
        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User Input";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
     
        ws.Cell(1, i).Value = "Idology SSN";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Idology ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
          
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;

            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;


            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
          ;
            ws.Cell(row + 1, i).Value = item.Idology_SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Idology_ID;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportDatatoExcelReport(List<ReportDetailExport> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Middle Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender First Name Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Middle Name Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Last Name Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Address Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "City Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "State Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Zipcode Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Phone Behafl";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Recipient ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Last Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Middle Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient First Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Full Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient District / City";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Province / State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient Phone 2";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Recipient No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Origin Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = " Destination Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Bank Code";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Message";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Sending";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "User Input";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Company Note";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans Status";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Delivery Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MIDDLENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StateName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIP_CODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID_BK;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FIRSTNAME_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MIDDLENAME_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LASTNAME_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CITY_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ZIPCODE_BH;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE_BH;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_CUST_ID_REF;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FIRSTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_MIDDLENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_LASTNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_RECIPIENT2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_CITY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PROVINCE_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE2;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FROMCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AG_COMM_AMT;
            
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
           
           
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANKCODE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.BANK_ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_ACCOUNT_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.MSG_TO_BENE_1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REASON_SENDING;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CompanyNote;
            i += 1;
            ws.Cell(row + 1, i).Value = item.StatusName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaidDate;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelReport(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
      

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;      

      
        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

     
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
      
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportExcelSenderHistoryReport(List<HistoryCustomerSendTran> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

    

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
    

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
    


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
         

            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
       
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            if(item.DisableAmount)
            {
                ws.Cell(row + 1, i).Value = item.AMOUNT;
            }
            
            i += 1;
        
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportRequestRefundReport(List<ReportRefundDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;

            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;

            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] CommissionTransListsExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Payment Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sub Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans Passcode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Paid Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Paid Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Commission Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Commission Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "payment Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaidDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSCODE;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.payment_servicefee;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaymentCurrency;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] CompletedTransactionReportExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Paid Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Approve";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaidDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ApproveTransaction(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / Green Card / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Account";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

     

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Holding";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Release Holding";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Verified";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Verified By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Verified Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
          
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonHolding;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReleaseHoldingReason;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Verify;
            i += 1;
            ws.Cell(row + 1, i).Value = item.VerifyBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.VerifyDate;
            i += 1;
          
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] FeedBackTransactionExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Reason for Pending";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Update Pending by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Update Pending Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Feedback";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Update Feedback by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Update Feedback Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonForPending;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UpdatePendingBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UpdatePendingDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FeedBack;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UpdateFeedbackBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UpdateFeedbackDate;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] PendingTransactionExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        //ws.Cell(1, i).Value = "Sender Phone";
        //ws.Cell(1, i).Style.Font.Bold = true;
        //i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Reason for Pending";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        
        ws.Cell(1, i).Value = "Update Pending by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Update Pending Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
         
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonForPending;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UpdatePendingBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.UpdatePendingDate;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] BlockCustomerReportExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Block By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACTION_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COMMENT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionBy;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ActionDate;
            i += 1;
           
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] PendingInstoreTransaction(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;           
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;            
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
           
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] CTRsReviewExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
      
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

      
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "No of Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.Case_No_Date;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.Sender_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Address;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Phone_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL;
            i += 1;
            ws.Cell(row + 1, i).Value = item.No;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] CTRsReportExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No CTRs";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "CTRs Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Comment CTRs";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
     
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

      

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Approve";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = item.RowNumber;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FileSarsName;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Comment_Ctrs;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NoTran;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Case_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Case_No_Date;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Address;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Phone_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receiver_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receiver_Phone;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.BankAccount;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL;
            i += 1;
           
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] GeneralDailyReportExcel(List<ReportDetail> reportDetailsAll,string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Approve";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] SARsReviewExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();


        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
     
        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;



        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Approve";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FileSarsName;
            i += 1;

            ws.Cell(row + 1, i).Value = item.NoTran;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Case_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Case_No_Date;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Address;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Phone_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receiver_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receiver_Phone;
            i += 1;

            ws.Cell(row + 1, i).Value = item.BankAccount;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[]SARsReportExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "SARs Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

     

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Approve";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FileSarsName;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.NoTran;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Case_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Case_No_Date;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Sender_Address;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Phone_No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receiver_Full_Name;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Receiver_Phone;
            i += 1;

            ws.Cell(row + 1, i).Value = item.BankAccount;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] SARsExcel(List<ReportDetail> reportDetailsAll, string SheetName,
        bool chkS_Name, bool chkS_Address, bool chkS_Phone, bool chkID, bool chkSS, bool chkRe_Name,
        bool chkRe_Address, bool chkRe_Phone, bool chkAccount, bool chkPassport)
    {
        var wb = new XLWorkbook();
      

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        if(chkS_Name)
        {
            ws.Cell(1, i).Value = "Sender Name";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkS_Address)
        {
            ws.Cell(1, i).Value = "Sender Address";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkS_Phone)
        {
            ws.Cell(1, i).Value = "Sender Phone";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkID)
        {
            ws.Cell(1, i).Value = "Sender ID";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkSS)
        {
            ws.Cell(1, i).Value = "Sender SSN";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkRe_Name)
        {
            ws.Cell(1, i).Value = "Receiver Name";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkRe_Name)
        {
            ws.Cell(1, i).Value = "Receiver Address";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkRe_Name)
        {
            ws.Cell(1, i).Value = "Receiver Phone";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkAccount)
        {
            ws.Cell(1, i).Value = "Receiver Account";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        if (chkPassport)
        {
            ws.Cell(1, i).Value = "Receiver ID";
            ws.Cell(1, i).Style.Font.Bold = true;
            i += 1;
        }
        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "No of Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "No of Days";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            if (chkS_Name)
            {
                ws.Cell(row + 1, i).Value = item.Sender_Full_Name;
                i += 1;
            }
            if (chkS_Address)
            {
                ws.Cell(row + 1, i).Value = item.Sender_Address;
                i += 1;
            }
            if (chkS_Phone)
            {
                ws.Cell(row + 1, i).Value = item.Phone_No;
                i += 1;
            }
            if (chkID)
            {
                ws.Cell(row + 1, i).Value = item.DRIVER_ID;
                i += 1;
            }
            if (chkSS)
            {
                ws.Cell(row + 1, i).Value = item.SS;
                i += 1;
            }
            if (chkRe_Name)
            {
                ws.Cell(row + 1, i).Value = item.Receiver_Full_Name;
                i += 1;
            }
            if (chkRe_Name)
            {
                ws.Cell(row + 1, i).Value = item.Receiver_Address;
                i += 1;
            }
            if (chkRe_Name)
            {
                ws.Cell(row + 1, i).Value = item.Receiver_Phone;
                i += 1;
            }
            if (chkAccount)
            {
                ws.Cell(row + 1, i).Value = item.BankAccount;
                i += 1;
            }
            if (chkPassport)
            {
                ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
                i += 1;
            }
          
            ws.Cell(row + 1, i).Value = item.TOTAL;
            i += 1;
            ws.Cell(row + 1, i).Value = item.No;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NoofDay;
            
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] KYCReportExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Currency";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Paid";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       

        ws.Cell(1, i).Value = "Kyc Reason";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Holding";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Release Holding";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Release By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Release Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.KYC_REASON==null?"": item.KYC_REASON;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonHolding == null ? "" : item.ReasonHolding;
            i += 1;
            ws.Cell(row + 1, i).Value = item.HoldingBy == null ? "" : item.HoldingBy; 
            i += 1;
            ws.Cell(row + 1, i).Value = item.HoldingDate==null?"": item.HoldingDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReleaseHoldingReason == null ? "" : item.ReleaseHoldingReason;
            if(!string.IsNullOrEmpty((item.ReleaseHoldingReason == null ? "" : item.ReleaseHoldingReason)))
            {
                i += 1;
                ws.Cell(row + 1, i).Value = item.ReleaseHoldingBy == null ? "" : item.ReleaseHoldingBy;
                i += 1;
                ws.Cell(row + 1, i).Value = item.ReleaseHolding == null ? "" : item.ReleaseHolding;
                i += 1;
            }
          
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] TransactionStatusExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Merchant Order No.";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

    

        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Local Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Rec ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bank Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       
        ws.Cell(1, i).Value = "";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount/US";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Amount/CNY";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
           
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.LOCALNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PASSPORT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_BANK_NAME;
            i += 1;
            if(!string.IsNullOrEmpty(item.ACCOUNT_NO))
            {
                ws.Cell(row + 1, i).Value = item.ACCOUNT_NO.Replace("-","");
            }
           
            i += 3;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
           
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] AdPhoneExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
       

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Description";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Create Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Create By";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Phone;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Description;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Date;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CreateBy;
            i += 1;
           
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] TransactionVolunmReportExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

     

        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
      
        ws.Cell(1, i).Value = "No. Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "No.Trans Refund";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;


        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
          
            ws.Cell(row + 1, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NumberRecord;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AGENTFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.NoofTranRefund;
            i += 1;
           
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] HistoryCancelExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cancel Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Cancel by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Cancel";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

       

        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

      

        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CANCELDATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.CANCELBY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonforCancel;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] HistoryRefundVoidExcel(List<ReportDetail> reportDetailsAll, string SheetName)
    {
        var wb = new XLWorkbook();
        //wb.Properties.Author = "the Author";
        //wb.Properties.Title = "the Title";
        //wb.Properties.Subject = "the Subject";
        //wb.Properties.Category = "the Category";
        //wb.Properties.Keywords = "the Keywords";
        //wb.Properties.Comments = "the Comments";
        //wb.Properties.Status = "the Status";
        //wb.Properties.LastModifiedBy = "the Last Modified By";
        //wb.Properties.Company = "the Company";
        //wb.Properties.Manager = "the Manager";

        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ref No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;



        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Void/Refund Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Void/Refund by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Reason for Void/Refund";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Sender Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Sender Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "SS#";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "DOB";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Expiration";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Id Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Driver ID / GC / PP";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "State Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country Issue";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Occupation";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Receiver Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Account No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;



        ws.Cell(1, i).Value = "Created by";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;



        int row = 1;
        foreach (var item in reportDetailsAll)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REF_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REVIEWREFUNDDATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.REVIEWREFUNDBY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ReasonforReviewRefund;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SSN;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DOB;
            i += 1;
            ws.Cell(row + 1, i).Value = item.EXPIRATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ID_TYPE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DRIVER_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.STATE_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.COUNTRY_ISSUE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OCCUPATION;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.ACCOUNT_NO;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_COUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AMOUNT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.SERVICE_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.OTHERFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TAXFEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.DISCOUNT_FEE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOTAL_AMT_USD;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_COMM;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Total_Due;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCURRENCY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_AMT_PAY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.USER_INPUT;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Approved;
            i += 1;
            //ws.Cell(row + 1, 1).Value = row;
            //ws.Cell(row + 1, 1).Value =item.TRANS_ID;
            //ws.Cell(row + 1, 2).Value = item.TRANS_DATE;
            //ws.Cell(row + 1, 3).Value = item.FULLNAME;
            //ws.Cell(row + 1, 4).Value = item.S_FULLADDRESS;
            row += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }

    public byte[] ExportBillingReport(List<ReportBillingSummary> reportSummarys, List<ReportDetail> reportDetails, List<ReportDetail> reportDetail1s, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "No.of Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Agent Comm";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportSummarys)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TranType;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n0}", item.Trans_No);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_AMOUNT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AAGENT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.OTHER_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_TAX);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_DISCOUNT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.GRANT_TOTAL);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTALAGENT_COMM);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.Total_Due);
            i += 1;
            row += 1;

        }
        row += 2;
        i = 1;
        ws.Cell(row + 1, i).Value = "DEBIT";
        row += 1;

        i = 1;
        ws.Cell(row + 1, i).Value = "No";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans ID";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans Date";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Sender";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Receiver";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Transaction Type/Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
       ws.Cell(row + 1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
         ws.Cell(row + 1, i).Value = "AGENT COMM";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
         ws.Cell(row + 1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int k = 1;
        row += 1;


        foreach (var item in reportDetails)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = k;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
          ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
          ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
          ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
          ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
          ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
          ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
          ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
          ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
          ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
         ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AMOUNT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.SERVICE_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.OTHERFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TAXFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.DISCOUNT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_AMT_USD);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AG_COMM_AMT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AGENT_COMM);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.Total_Due);
            i += 1;
            row += 1;
            k += 1;

        }


        row += 2;
        i = 1;
        ws.Cell(row + 1, i).Value = "CREDIT (REFUND)";
        row += 1;

        i = 1;
        ws.Cell(row + 1, i).Value = "No";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        
             i += 1;
        ws.Cell(row + 1, i).Value = "Type";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans ID";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans Date";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Sender";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Receiver";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Transaction Type/Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "AGENT COMM";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
         k = 1;
        row += 1;


        foreach (var item in reportDetail1s)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = k;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Type;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AMOUNT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.SERVICE_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.OTHERFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TAXFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.DISCOUNT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_AMT_USD);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AG_COMM_AMT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AGENT_COMM);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.Total_Due);
            i += 1;
            row += 1;
            k += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportViewBillingReport(List<ReportBillingSummary> reportSummarys, List<ReportDetail> reportDetails, List<ReportDetail> reportDetail1s, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "No.of Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Sender Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Tax";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Agent Comm";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportSummarys)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TransDate;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TranType;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n0}", item.Trans_No);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_AMOUNT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AAGENT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.OTHER_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_TAX);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_DISCOUNT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.GRANT_TOTAL);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTALAGENT_COMM);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.Total_Due);
            i += 1;
            row += 1;

        }
        row += 2;
        i = 1;
        ws.Cell(row + 1, i).Value = "DEBIT";
        row += 1;

        i = 1;
        ws.Cell(row + 1, i).Value = "No";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans ID";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans Date";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Sender";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Receiver";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Transaction Type/Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "AGENT COMM";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int k = 1;
        row += 1;


        foreach (var item in reportDetails)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = k;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AMOUNT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.SERVICE_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.OTHERFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TAXFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.DISCOUNT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_AMT_USD);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AG_COMM_AMT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AGENT_COMM);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.Total_Due);
            i += 1;
            row += 1;
            k += 1;

        }


        row += 2;
        i = 1;
        ws.Cell(row + 1, i).Value = "CREDIT (REFUND)";
        row += 1;

        i = 1;
        ws.Cell(row + 1, i).Value = "No";
        ws.Cell(row + 1, i).Style.Font.Bold = true;

        i += 1;
        ws.Cell(row + 1, i).Value = "Type";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans ID";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Trans Date";
        ws.Cell(row + 1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Sender";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Receiver";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Address";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Phone";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Country";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Transaction Type/Mode";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Payment Agent";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Cust Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Other Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Tax Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Discount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Total Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Agent Fee";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "AGENT COMM";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(row + 1, i).Value = "Total Due";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        k = 1;
        row += 1;


        foreach (var item in reportDetail1s)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = k;
            i += 1;
            ws.Cell(row + 1, i).Value = item.Type;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANS_DATE;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.S_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_FULLNAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.R_FULLADDRESS;
            i += 1;
            ws.Cell(row + 1, i).Value = item.B_PHONE1;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TOCOUNTRY;
            i += 1;
            ws.Cell(row + 1, i).Value = item.TRANTYPENAME;
            i += 1;
            ws.Cell(row + 1, i).Value = item.PAYMENT_AGENT;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AMOUNT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.SERVICE_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.OTHERFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TAXFEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.DISCOUNT_FEE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TOTAL_AMT_USD);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AG_COMM_AMT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AGENT_COMM);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.Total_Due);
            i += 1;
            row += 1;
            k += 1;

        }

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }

    public byte[] ExportReviewAgentPayment(List<AccountBalanceSummaryMocel> reportDetails, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx", ""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Average Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Beginning Balance";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Credit Line";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Bond";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Available Credit Line";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Max Credit Line";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Payment Credit";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Current Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Refund Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Void Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Domestic Payout";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ending Balance";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Ending Balance after Bond";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Payment Management";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetails)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRANS_AVE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.BEGIN_BALANCEDK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.CREDIT_LINE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.BondAmount);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.ACREDIT);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.CREDIT_LINEAPP);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.PAYMENTTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRAN_AMOUNTTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRAN_AMOUNTREFUNDTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRAN_AMOUNTCANCELTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.DOMESTICTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.END_BALANCEDK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.EndBold);
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaymentStatus;
            i += 1;
            row += 1;

        }


        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportAccountBalanceSummary( List<AccountBalanceSummaryMocel> reportDetails, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Beginning Balance";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Credit Line";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Max Credit Line";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Payment Credit";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Current Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Refund Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Void Trans";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Domestic Payout";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Ending Balance";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
          ws.Cell(1, i).Value = "Payment Management";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        int row = 1;
        foreach (var item in reportDetails)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            ws.Cell(row + 1, i).Value = item.AGENT_ID;
            i += 1;
            ws.Cell(row + 1, i).Value =  item.AGENT_NAME;
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.BEGIN_BALANCEDK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.CREDIT_LINE);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.CREDIT_LINEAPP);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.PAYMENTTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRAN_AMOUNTTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRAN_AMOUNTREFUNDTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.TRAN_AMOUNTCANCELTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.DOMESTICTK);
            i += 1;
            ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.END_BALANCEDK);
            i += 1;
            ws.Cell(row + 1, i).Value = item.PaymentStatus;
            i += 1;
            row += 1;

        }
      

        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
    public byte[] ExportAgentAccountBalance(List<AccountBalanceSummaryMocel> reportDetails, string SheetName)
    {
        var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add(SheetName.Replace(".xlsx",""));
        ws.Columns().AdjustToContents();
        //ws.Columns.AutoFit();
        int i = 1;
        ws.Cell(1, i).Value = "No";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent ID";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Agent Name";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Cell(1, i).Value = "Type";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Trans Date";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;
        ws.Column(i).AdjustToContents();
        ws.Cell(1, i).Value = "Num";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Amount";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        ws.Cell(1, i).Value = "Balance";
        ws.Cell(1, i).Style.Font.Bold = true;
        i += 1;

        int row = 1;
        foreach (var item in reportDetails)
        {
            i = 1;
            ws.Cell(row + 1, i).Value = row;
            i += 1;
            if(item.NUM.ToUpper().Contains("BALANCE"))
            {
                ws.Cell(row + 1, i).Value = item.AGENT_ID;
                ws.Cell(row + 1, i).Style.Font.Bold = true;
                i += 1;
                ws.Cell(row + 1, i).Value = item.AGENT_NAME;
                ws.Cell(row + 1, i).Style.Font.Bold = true;
                i += 1;
            }
            else
            {               
                i += 1;             
                i += 1;
            }
          
            ws.Cell(row + 1, i).Value = item.TYPEOPTION;
            i += 1;
            if (!item.NUM.ToUpper().Contains("BALANCE"))
            {
                ws.Cell(row + 1, i).Value = item.TranApprove;
                i += 1;
                ws.Cell(row + 1, i).Value = item.trandate;
                i += 1;
            }
            else
            {
                i += 1;
                i += 1;
            }

           
            ws.Cell(row + 1, i).Value =  item.NUM;
            i += 1;
            if (!item.NUM.ToUpper().Contains("BALANCE"))
            {
                ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.AMOUNT);
            }
          
               
            i += 1;
            if (item.NUM.ToUpper().Contains("BALANCE"))
            {
                ws.Cell(row + 1, i).Style.Font.Bold = true;
            }
                ws.Cell(row + 1, i).Value = String.Format("{0:n2}", item.BALANCE);

            i += 1;
         
            row += 1;

        }


        MemoryStream XLSStream = new();
        wb.SaveAs(XLSStream);

        return XLSStream.ToArray();
    }
}
