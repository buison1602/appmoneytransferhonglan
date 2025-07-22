using Microsoft.JSInterop;
using System.Threading.Tasks;
namespace AppMoneyTransferRS.Class
{
    public class getCaliTime
    {
        private readonly IJSRuntime _jsRuntime;

        public getCaliTime(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        public  async Task<string> getCaliTimes()
        {
            string dateTime = DateTime.UtcNow.AddHours(-7).ToString();
            try
            {
                dateTime = await _jsRuntime.InvokeAsync<string>("getCaliforniaTime");
            }
            catch (Exception ex)
            {
                return dateTime;
            }
            return dateTime;
        }
     
    }
}
