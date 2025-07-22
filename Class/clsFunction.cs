using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace AppMoneyTransferRS.Class
{
    public class clsFunction
    {
        public static string publickey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApA2wXCorWyHvkbLyIiQJJTeogkGpuUGp1p2zecJRuQ9sE5n5A5mxJ7OmZRsmP4J7vmsULDupssNqtJ5V0Mwac/4+8E1bXz9yqOlBJNeQRrZHYJSgvL+qTATcPkTabuVoZYupBynu5QzZcRibH6KdNl/uJ93Cyw7B8IooSGxxAQ+gOJjBLardatP6p4qvt36jk/copMddtHNsVUfJeCrsA72gvSk7s/6KCDXzwkmA8jfSjSq/GlQLE88iHbWzE1ZylYWV7+oXIznH1gpgwmljcGSKjPktxnzqU+hxIdiBQm9fF3KGz9/gbED9guPQdZhMeClP9WB+cGdSsMW0WXxWtQIDAQAB";


        public static string privatekey = @"MIIEpAIBAAKCAQEApA2wXCorWyHvkbLyIiQJJTeogkGpuUGp1p2zecJRuQ9sE5n5A5mxJ7OmZRsmP4J7vmsULDupssNqtJ5V0Mwac/4+8E1bXz9yqOlBJNeQRrZHYJSgvL+qTATcPkTabuVoZYupBynu5QzZcRibH6KdNl/uJ93Cyw7B8IooSGxxAQ+gOJjBLardatP6p4qvt36jk/copMddtHNsVUfJeCrsA72gvSk7s/6KCDXzwkmA8jfSjSq/GlQLE88iHbWzE1ZylYWV7+oXIznH1gpgwmljcGSKjPktxnzqU+hxIdiBQm9fF3KGz9/gbED9guPQdZhMeClP9WB+cGdSsMW0WXxWtQIDAQABAoIBAG/L2FRmdFdNYAolLTaw4f6X2GCzyKqzob7chzNBhhmb9eXBtt2KPhy1I36hKsZ68EMKi5u9KN7mpu/hOs/oV1qWd2OhA9R703JiSn+F2w8lJq0dfBBEeRQG9+QDXevWr/cLXqvAGsnCoOeegg/j7EjixNQsHpPsQaPfMqZwJ+41FNkr4pMXJB4VFNIi+nLl8FiODTo264z0Hb4p/ys7hhCCOP4VdHMD3ZUCJIsa4YzfRw0pqdZz4ZHQ4CroocOOukr1QDyfFHdOCBEtCkzi8Zlq2neaObEt3x5gFpxyfMcduTt+sfATfr7E3Qu6JCK/Btc1MfLsqUOkKkAESuhT04ECgYEA26mkmau0PkFe5sCv8VtTd13Q0soFyJQA5oKoBo8CC8XeKaoqnuFpjjS2bBUf7f7AbKcL9FD5WkHgPGJWGX0LEhJutap0Dg79FOoeFC4LCxci7qeVjNCUollmghrcw3xR9n9w6DGJalmqhhYU31ZyNcULQ1rHAv6Ku1YPVj3hcVUCgYEAvzEWPRm7p5wXhPoh8DN67WWLw/6mSaot8LUCCSreP5gxBh3DODRxnQen5dXxktxZlgLqAt/Ki9O2m8oZq6o6TsjZ7QOzcVCGMAo+vaOr+MUhmgw22R7/UQ/9e5ptyQiwo/oNxlw6L5ncc05XYhWQVzfw0oI5KM88Eim0rszkz+ECgYEAgtoLs38VYACRB+TA6oX8sp6wRuERkOqZnrc2YLHQBjNYpHk56mtc9dlw0fHDk4KuHgtkk6Wo5JtZeJ8bqxNSBPH2AUII4FcNa+gLAvpqmbCunnw2GiwmXo/jAJ3/5HOqX6yLFcZslW3UpwuAY4qbfmxiyTzKUH5RJked20IBigECgYEAp/DXRv52nqj24+DPtO2TejorhhMGQEjTJ8/npOPZ62SlE2lLVPCEJ9pUugeutkEGFEYlBjdL9H0Yt0nUOL1DkHbPLmmE0vFXnZUyPWQqqE+Iz4cRGrEmti7kixFAhEk02CTKusXCepOdWE+lZEvqySIjUNYAnX9DlfS6eJ0UFCECgYBKwaI4Xhc3XR9simPRjaplw7MZK2L2Pc9Wbbm+D88kJxWLgd1z3ZY7tPkP0/9a6wmUNq5JUPgiKpsj+EvF0Jw5AOxwcCCdyVad1g8/rrFSXr22/10G0PUaOyAMrzY2TKk58VYET7ofaKaPqIhiQ2/KIouhIkZ4LpBSxzaOTjNpnw==";
        public static Stream GetFileStream(byte[]? FileLoad)
        {
            try
            {
                var fileStream = new MemoryStream(FileLoad);
                return fileStream;
            }
            catch (Exception ex)
            {
                return null;
               
            }
        }
        public static string RandomFileName(int len)
        {
            Random rd = new Random();
            String rdString = "";
            int ranNo;

            for (int i = 0; i < len; i++)
            {
                if (rd.Next(1, 3) == 1)
                {
                    ranNo = rd.Next(97, 123);
                }
                else
                {
                    ranNo = rd.Next(48, 58);
                }
                rdString = rdString + (char)ranNo;
            }

            return rdString;
        }
        public static bool ValidStringDate(String date)
        {
            try
            {
                if(date.Length>10)
                {
                    date = date.Substring(0, 10);
                }
                string[] dateArray = date.Split(new Char[] { '/' });
                if(dateArray.Length==1)
                {
                    dateArray = date.Split(new Char[] { '-' });
                }
                DateTime date1 = new DateTime(Convert.ToInt16(dateArray[2]), Convert.ToInt16(dateArray[0]), Convert.ToInt16(dateArray[1]));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static string ReplaceSpaceChinese(string Cha)
        {           
            String rdString  = Regex.Replace(Cha, @"(?<=[\p{IsCJKUnifiedIdeographs}]) (?=[\p{IsCJKUnifiedIdeographs}])", "");
            rdString=Regex.Replace(rdString, @"(?<=[\p{IsCJKUnifiedIdeographs}])\s+(?=[\p{IsCJKUnifiedIdeographs}])", "");
            rdString = Regex.Replace(rdString, @"\s+", "");
            rdString= Regex.Replace(rdString, @"(?<=[\u4E00-\u9FFF])\s+(?=[\u4E00-\u9FFF])", "");
            return rdString;
        }
    }
}
