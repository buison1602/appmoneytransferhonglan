using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using AppMoneyTransferRS.Helpers;

namespace AppMoneyTransferRS.Services
{
    public interface IHttpService
    {
        Task<T> Get<T>(string uri);
        Task Post(string uri, object value);
        Task<T> Post<T>(string uri, object value);
        Task Put(string uri, object value);
        Task<T> Put<T>(string uri, object value);
        Task Delete(string uri);
        Task<T> Delete<T>(string uri);
        Task<dynamic> Request(string method, string uri, object data=null);
    }

    public class HttpService : IHttpService
    {
        private HttpClient _httpClient;
        private HttpClient _httpClientCore;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private IConfiguration _configuration;
        public string?  apiURL;
        //public string?  apiURLCore;
        public HttpService(
            HttpClient httpClient,
             //HttpClient httpClientCore,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService,
            IConfiguration configuration
        )
        {
            httpClient.Timeout = TimeSpan.FromMinutes(15);
          
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            _configuration = configuration;
            _httpClient = httpClient;
            string ApiURL = configuration.GetValue<string>("ApiURL");
            _httpClient.BaseAddress = new Uri(ApiURL);
            apiURL = ApiURL;

            //_httpClientCore = httpClientCore;
            //string ApiURLCore = configuration.GetValue<string>("ApiURLCore");
            //_httpClientCore.BaseAddress = new Uri(ApiURLCore);
            //apiURLCore = ApiURLCore;
        }

        public async Task<T> Get<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            return await sendRequest<T>(request);
        }

        public async Task Post(string uri, object value)
        {
            var request = createRequest(HttpMethod.Post, uri, value);
            await sendRequest(request);
        }

        public async Task<T> Post<T>(string uri, object value)
        {
            var request = createRequest(HttpMethod.Post, uri, value);
            return await sendRequest<T>(request);
        }

        public async Task Put(string uri, object value)
        {
            var request = createRequest(HttpMethod.Put, uri, value);
            await sendRequest(request);
        }

        public async Task<T> Put<T>(string uri, object value)
        {
            var request = createRequest(HttpMethod.Put, uri, value);
            return await sendRequest<T>(request);
        }

        public async Task Delete(string uri)
        {
            var request = createRequest(HttpMethod.Delete, uri);
            await sendRequest(request);
        }

        public async Task<T> Delete<T>(string uri)
        {
            var request = createRequest(HttpMethod.Delete, uri);
            return await sendRequest<T>(request);
        }

        // helper methods
        private HttpRequestMessage createRequest(HttpMethod method, string uri, object value = null)
        {
            var request = new HttpRequestMessage(method, uri);
            if (value != null)
                request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return request;
        }

        private async Task sendRequest(HttpRequestMessage request)
        {
            await addJwtHeader(request);

            // send request
            using var response = await _httpClient.SendAsync(request);

            // auto logout on 401 response
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                _navigationManager.NavigateTo("account/logout");
                return;
            }

            await handleErrors(response);
        }

        private async Task<T> sendRequest<T>(HttpRequestMessage request)
        {
            try
            {
                await addJwtHeader(request);

                // send request
                using var response = await _httpClient.SendAsync(request);

                // auto logout on 401 response
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    _navigationManager.NavigateTo("account/logout");
                    return default;
                }

                await handleErrors(response);

                var options = new JsonSerializerOptions();
                options.PropertyNameCaseInsensitive = true;
                options.Converters.Add(new StringConverter());
                return await response.Content.ReadFromJsonAsync<T>(options);
            }
            catch(Exception ex)
            {
                return default;
            }
            

            
        }
        
        private async Task<string> _sendRequest(HttpRequestMessage request)
        {
            await addJwtHeader(request);

            // send request
            using var response = await _httpClient.SendAsync(request);

            // auto logout on 401 response
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception(response.StatusCode.ToString());
            }

            await handleErrors(response);

            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.Converters.Add(new StringConverter());

            return (await response.Content.ReadFromJsonAsync<object>(options)).ToString();
        }

        

        private async Task addJwtHeader(HttpRequestMessage request)
        {
            //// add jwt auth header if user is logged in and request is to the api url
            //var user = await _localStorageService.GetItem<User>("user");
            //var isApiUrl = !request.RequestUri.IsAbsoluteUri;
            //if (user != null && isApiUrl)
            //    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
        }

        private async Task handleErrors(HttpResponseMessage response)
        {
            // throw exception on error response
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["message"]);
            }
        }

        public async Task<dynamic> Request(string method, string uri, object data)
        {
            var request = createRequest(HttpMethod.Get, uri);

            if (method == "get")
            {
                 request = createRequest(HttpMethod.Get, uri);
            } else if (method == "post")
            {
                 request = createRequest(HttpMethod.Post, uri, data);
            }
            else if (method == "put")
            {
                request = createRequest(HttpMethod.Put, uri, data);
            }
            else
            {
                throw new NotImplementedException();
            }

            object resp = await sendRequest<object>(request);

            return Newtonsoft.Json.JsonConvert.DeserializeObject(resp.ToString());
        }
    }
}