using Football.Models;
using Football.Services;
using Football.Services.Interfaces;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Bind FootballApi configuration
builder.Services.Configure<FootballApiSettings>(builder.Configuration.GetSection("FootballApi"));

// Add HttpClient with BaseAddress and DefaultRequestHeaders
builder.Services.AddHttpClient<IFootballService, FootballService>((provider, client) =>
{
    var settings = provider.GetRequiredService<IOptions<FootballApiSettings>>().Value;
    client.BaseAddress = new Uri(settings.BaseUrl);
    client.DefaultRequestHeaders.Add("X-Auth-Token", settings.ApiKey);
});

// Add controllers with views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
