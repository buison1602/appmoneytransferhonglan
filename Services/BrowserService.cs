
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace AppMoneyTransferRS.Services
{
    public class BrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }

    }
    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; } = 800; public int HeightBody { get; set; } = 800;
    }
}
