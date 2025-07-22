using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Specialized;
using System.Web;

namespace AppMoneyTransferRS.Helpers
{
    public static class ExtensionMethods
    {
        public static NameValueCollection QueryString(this NavigationManager navigationManager)
        {
            return HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
        }

        public static string QueryString(this NavigationManager navigationManager, string key)
        {
            return navigationManager.QueryString()[key];
        }
        public static byte[] GetBinaryFile(string filename)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }
        //public static SaveOptions GetSaveOptions(string format)
        //{
        //    switch (format.ToUpper())
        //    {
        //        case "XLSX":
        //            return SaveOptions.XlsxDefault;
        //        case "XLS":
        //            return SaveOptions.XlsDefault;
        //        case "ODS":
        //            return SaveOptions.OdsDefault;
        //        case "CSV":
        //            return SaveOptions.CsvDefault;
        //        case "HTML":
        //            return SaveOptions.HtmlDefault;
        //        case "PDF":
        //            return SaveOptions.PdfDefault;
        //        case "XPS":
        //        case "PNG":
        //        case "JPG":
        //        case "GIF":
        //        case "TIF":
        //        case "BMP":
        //        case "WMP":
        //            throw new InvalidOperationException("To enable saving to XPS or image format, add 'Microsoft.WindowsDesktop.App' framework reference.");
        //        default:
        //            throw new NotSupportedException();
        //    }
        //}
    }
}