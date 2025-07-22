using AppMoneyTransferRS;
using Blazored.Toast;
using AppMoneyTransferRS.Services;
using Blazored.SessionStorage;
using MudBlazor.Services;
using System.Globalization;
using AppMoneyTransferRS.Class;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

// Add authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/auth/login";
        options.LogoutPath = "/auth/logout";
        options.ExpireTimeSpan = TimeSpan.FromHours(8);
        options.SlidingExpiration = true;
        options.Cookie.SameSite = SameSiteMode.Lax;
        options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
    });

// Add session support
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(8);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
});

builder.Services.AddLocalization();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredToast();
builder.Services.AddMudServices();

// Add HTTP context accessor for session management
builder.Services.AddHttpContextAccessor();

builder.Services
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<IHttpService, HttpService>()
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<ISessionStateService, SessionStateService>()
                .AddScoped<BrowserService>()
                .AddScoped<HttpClient>();

// Configure culture
var culture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;
DateTimeFormatInfo formatInfo = culture.DateTimeFormat;
formatInfo.ShortDatePattern = "MM/dd/yyyy";
formatInfo.LongDatePattern = "MM/dd/yyyy HH:mm:ss";
formatInfo.FullDateTimePattern = "MM/dd/yyyy HH:mm:ss";

// Configure SignalR for Blazor Server
builder.Services.AddServerSideBlazor().AddHubOptions(options => {
    options.MaximumReceiveMessageSize = 1024 * 1024; // 1MB
});

//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(policy =>
//        policy.WithOrigins(new[] { "https://transfer.honglanservices.co",
//                                "https://testapi.honglanservices.co",
//                                "https://api.honglanservices.co"
//                                , "https://sandbox.dongphuongmoneytransfer.com"
//                            , "http://localhost:62149"})
//        .AllowAnyHeader()
//        .AllowAnyMethod()
//        .AllowCredentials());
//});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins(new[] { "https://transfer.honglanservices.co",
                                "https://testapi.honglanservices.co",
                                "https://api.honglanservices.co",
                                "https://sandbox.dongphuongmoneytransfer.com",
                                "http://localhost:62149"})
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
        });
});

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors();

// Add session middleware
app.UseSession();

// Add authentication middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


