using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using AppMoneyTransferRS.Models;
using System;
using System.Collections.Generic;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace AppMoneyTransferRS.Services
{
   
    public interface IAuthService
    {
        User userMTRedSun { get; }
        Task Initialize();
        Task<ResponseResp> Login(Login model);
        Task Logout();
        Task Reset();
    }

    public class AuthService : IAuthService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private ISessionStateService _sessionStateService;
        private readonly string _userKey = "userHongLan";
        private Blazored.SessionStorage.ISessionStorageService sessionStorage;
        public User userMTRedSun { get;  set; }
        public User userMTRedSunTest { get; set; }

        public AuthService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService,
            ISessionStateService sessionStateService
        )
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            _sessionStateService = sessionStateService;
        }

        public async Task Initialize()
        {
            // Try to get user from session state first (for cross-tab support)
            userMTRedSun = await _sessionStateService.GetCurrentUserAsync();

            // If not found, try local storage as fallback
            if (userMTRedSun == null)
            {
                userMTRedSun = await _localStorageService.GetItem<User>(_userKey);

                // If found in local storage, migrate to session state
                if (userMTRedSun != null)
                {
                    await _sessionStateService.SetCurrentUserAsync(userMTRedSun);
                }
            }
        }

        public async Task<ResponseResp> Login(Login model)
        {
            ResponseResp responseResp = new ResponseResp();
            try
            {
                LoginResp Resp = await _httpService.Post<LoginResp>("/api/Login", model);
                if(Resp.Status==200)
                {
                    userMTRedSun = new User {};
                    if (Resp.Content.Users.Count > 0)
                    {
                        foreach (var user in Resp.Content.Users)
                        {
                            userMTRedSun.Id = user.UserID.ToString();
                            userMTRedSun.UserName = user.UserName.ToString();
                            userMTRedSun.AgentID = user.AgentID.ToString();
                            userMTRedSun.TranAgentID = user.AgentID.ToString();
                            userMTRedSun.AgentName = user.AgentName.ToString();
                            userMTRedSun.AgentState = user.AgentState.ToString();
                            userMTRedSun.TimeOut = user.TimeOut;
                            userMTRedSun.TimeWarning = user.TimeWarning;
                            userMTRedSun.FullName = user.FullName;
                            userMTRedSun.GroupID = user.GroupID;
                            userMTRedSun.GroupName = user.GroupName;
                            userMTRedSun.LegalName = user.LegalName;
                            userMTRedSun.OwnerName = user.OwnerName;
                            userMTRedSun.AgentType = user.AgentType;
                            if (user.ImageUrl != null)
                            {
                                userMTRedSun.ImageUrl = user.ImageUrl;
                            }
                            else
                            {
                                userMTRedSun.ImageUrl = "";
                            }
                               
                            userMTRedSun.methodBankList = user.methodBankList;
                            userMTRedSun.Occupation = user.Occupation;
                            userMTRedSun.FirstName = user.FirstName;
                            userMTRedSun.LastName = user.LastName;
                            userMTRedSun.Expire = user.Expire;
                            if (user.FileImage!=null)
                            {
                                userMTRedSun.FileImage = user.FileImage;
                            }
                            userMTRedSun.EditProfile = user.EditProfile;
                            userMTRedSun.Warning = user.Warning;
                            
                        }
                    }
                    userMTRedSun.AgentList = Resp.Content.AgentList;
                    userMTRedSun.AgentListAll = Resp.Content.AgentListAll;
                    userMTRedSun.Users = Resp.Content.Users;
                    userMTRedSun.SendCountryList = Resp.Content.SendCountryList;
                    userMTRedSun.ReceiveCountryList = Resp.Content.ReceiveCountryList;
                    userMTRedSun.SendCurrencyList = Resp.Content.SendCurrencyList;
                    userMTRedSun.ReceiveCurrencyList = Resp.Content.ReceiveCurrencyList;
                    userMTRedSun.SearchList = Resp.Content.SearchList;
                    userMTRedSun.MenuParentList = Resp.Content.MenuParentList;
                    userMTRedSun.MenuChildList = Resp.Content.MenuChildList;
                    userMTRedSun.TypeTranList = Resp.Content.TypeTranList;
                    userMTRedSun.StateList = Resp.Content.StateList;
                    userMTRedSun.PaymentAgentList = Resp.Content.PaymentAgentList;
                    userMTRedSun.CountryList = Resp.Content.CountryList;
                    userMTRedSun.PaymentMethodList = Resp.Content.PaymentMethodList;
                    userMTRedSun.PaymentMethodReportList = Resp.Content.PaymentMethodReportList;
                    userMTRedSun.IDTypeList = Resp.Content.IDTypeList;
                    userMTRedSun.UserTypeList = Resp.Content.UserTypeList;
                    userMTRedSun.TypeofStatusList = Resp.Content.TypeofStatusList;
                    userMTRedSun.AccessLevelList = Resp.Content.AccessLevelList;
                    userMTRedSun.TransStatusList = Resp.Content.TransStatusList;
                    userMTRedSun.SOFList = Resp.Content.SOFList;
                    userMTRedSun.AgentStatusList = Resp.Content.AgentStatusList;
                    userMTRedSun.TypeofApproveList = Resp.Content.TypeofApproveList;
                    userMTRedSun.RelationwithSenderList = Resp.Content.RelationwithSenderList;
                    userMTRedSun.ControlPageList = Resp.Content.ControlPageList;
                    userMTRedSun.TypeofBlackList = Resp.Content.TypeofBlackList;
                    userMTRedSun.PageNameList = Resp.Content.PageNameList;
                    userMTRedSun.AMLTypeList = Resp.Content.AMLTypeList;
                    userMTRedSun.YearList = Resp.Content.YearList;
                    userMTRedSun.QuartList = Resp.Content.QuartList;
                    userMTRedSun.StateAgentList = Resp.Content.StateAgentList;
                    userMTRedSun.MenuChildChildList = Resp.Content.MenuChildChildList;
                    userMTRedSun.NoteList = Resp.Content.NoteList;
                    userMTRedSun.StateListAll = Resp.Content.StateListAll;
                    userMTRedSun.OccupationDList = Resp.Content.OccupationDList;
                    userMTRedSun.OccupationMList = Resp.Content.OccupationMList;
                    userMTRedSun.StatePayoutList = Resp.Content.StatePayoutList;
                    userMTRedSun.CityPayoutList = Resp.Content.CityPayoutList;
                    userMTRedSun.SplitList = Resp.Content.SplitList;
                    userMTRedSun.TypeofPaidList = Resp.Content.TypeofPaidList;
                    userMTRedSun.ExceptionList = Resp.Content.ExceptionList;
                    userMTRedSun.BusinessList = Resp.Content.BusinessList;
                    userMTRedSun.PaymentMethodListAll = Resp.Content.PaymentMethodListAll;
                    userMTRedSun.TypeofUpdateList = Resp.Content.TypeofUpdateList;

                    try
                    {
                        // Store in both session state and local storage for cross-tab support
                        await _sessionStateService.SetCurrentUserAsync(userMTRedSun);
                        await _localStorageService.SetItem(_userKey, userMTRedSun);

                        // Verify session storage worked
                        userMTRedSunTest = await _sessionStateService.GetCurrentUserAsync();
                        if(userMTRedSunTest == null)
                        {
                            // Retry once if session storage failed
                            await _sessionStateService.SetCurrentUserAsync(userMTRedSun);
                        }

                        responseResp.Status = 200;
                        responseResp.Message = Resp.Message;
                    }
                    catch (Exception sessionEx)
                    {
                        // If session storage fails, still allow login but log the error
                        Console.WriteLine($"Session storage error: {sessionEx.Message}");
                        responseResp.Status = 200;
                        responseResp.Message = Resp.Message;
                    }
                }
                else
                {
                    responseResp.Status = Resp.Status;
                    responseResp.Message = Resp.Message;
                }
                return responseResp;
            }
            catch(Exception ex)
            {
             
                responseResp.Status = 1;
                responseResp.Message = ex.Message;
                return responseResp;
            }            
        }
        public async Task Reset()
        {
            try
            {
                // Clear user data without navigation (for login page initialization)
                await _sessionStateService.ClearUserSessionAsync();
                await _localStorageService.RemoveItem(_userKey);

                userMTRedSun = null;
                userMTRedSunTest = null;
            }
            catch (Exception)
            {
                // Silently handle errors during reset
                userMTRedSun = null;
                userMTRedSunTest = null;
            }
        }

        public async Task Logout()
        {
            try
            {
                // Clear both session state and local storage
                await _sessionStateService.ClearUserSessionAsync();
                await _localStorageService.RemoveItem(_userKey);

                userMTRedSun = null;
                userMTRedSunTest = null;

                _navigationManager.NavigateTo("auth/login");
            }
            catch (Exception ex)
            {
                // Handle error silently
            }
        }
    }
}
