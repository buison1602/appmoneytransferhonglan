using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace AppMoneyTransferRS.Class
{
    public class CryptoService
    {
        private readonly IJSRuntime _jsRuntime;

        public CryptoService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        public async Task<string> NewEncryptDataAsync(string data)
        {
            return await _jsRuntime.InvokeAsync<string>("NewEncryptData", clsFunction.publickey, data);
        }
        public async Task<string> NewDecryptDataAsync( string data)
        {
            return await _jsRuntime.InvokeAsync<string>("NewDecryptData", clsFunction.privatekey, data);
        }
        public async Task<string> ConvertNewUserID( string data)
        {
            string UserID= await _jsRuntime.InvokeAsync<string>("NewDecryptData", clsFunction.privatekey, data);
            return await _jsRuntime.InvokeAsync<string>("NewEncryptData", clsFunction.publickey, UserID.Replace("REDSUN",""));
        }
        public async Task<string>GetNewUserID( string data,string Key)
        {
            string UserID = await _jsRuntime.InvokeAsync<string>("NewDecryptData", clsFunction.privatekey, data);
            return await _jsRuntime.InvokeAsync<string>("NewEncryptData", clsFunction.publickey, UserID.Replace("REDSUN", "") + "-" + Key);
        }

    }
}
