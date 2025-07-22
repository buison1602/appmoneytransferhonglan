using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using AppMoneyTransferRS.Models;
using System.Text.Json;

namespace AppMoneyTransferRS.Services
{
    public interface ISessionStateService
    {
        Task<T> GetAsync<T>(string key);
        Task SetAsync<T>(string key, T value);
        Task RemoveAsync(string key);
        Task<User> GetCurrentUserAsync();
        Task SetCurrentUserAsync(User user);
        Task ClearUserSessionAsync();
    }

    public class SessionStateService : ISessionStateService
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userKey = "userHongLan";

        public SessionStateService(ProtectedSessionStorage sessionStorage, IHttpContextAccessor httpContextAccessor)
        {
            _sessionStorage = sessionStorage;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<T> GetAsync<T>(string key)
        {
            try
            {
                var result = await _sessionStorage.GetAsync<T>(key);
                return result.Success ? result.Value : default(T);
            }
            catch
            {
                return default(T);
            }
        }

        public async Task SetAsync<T>(string key, T value)
        {
            try
            {
                await _sessionStorage.SetAsync(key, value);
            }
            catch
            {
                // Handle error silently
            }
        }

        public async Task RemoveAsync(string key)
        {
            try
            {
                await _sessionStorage.DeleteAsync(key);
            }
            catch
            {
                // Handle error silently
            }
        }

        public async Task<User> GetCurrentUserAsync()
        {
            return await GetAsync<User>(_userKey);
        }

        public async Task SetCurrentUserAsync(User user)
        {
            await SetAsync(_userKey, user);

            // Try to store in HTTP session for cross-tab support, but don't fail if it's not available
            try
            {
                var httpContext = _httpContextAccessor.HttpContext;
                if (httpContext?.Session != null && httpContext.Response != null && !httpContext.Response.HasStarted)
                {
                    var userJson = JsonSerializer.Serialize(user);
                    httpContext.Session.SetString(_userKey, userJson);
                }
            }
            catch (InvalidOperationException)
            {
                // Session cannot be established after response has started - ignore this error
                // The user data is still stored in ProtectedSessionStorage which is sufficient
            }
            catch (Exception)
            {
                // Handle any other session-related errors silently
            }
        }

        public async Task ClearUserSessionAsync()
        {
            await RemoveAsync(_userKey);

            // Try to clear HTTP session, but don't fail if it's not available
            try
            {
                var httpContext = _httpContextAccessor.HttpContext;
                if (httpContext?.Session != null && httpContext.Response != null && !httpContext.Response.HasStarted)
                {
                    httpContext.Session.Remove(_userKey);
                }
            }
            catch (InvalidOperationException)
            {
                // Session cannot be established after response has started - ignore this error
            }
            catch (Exception)
            {
                // Handle any other session-related errors silently
            }
        }
    }
}
