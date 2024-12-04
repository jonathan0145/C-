using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorAppAPI.Services;
using Microsoft.AspNetCore.Routing;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//builder.Services.AddScoped<EmpleadoService>(sp => new EmpleadoService(sp.GetRequiredService<IHttpClientFactory>().CreateClient("EmpleadoApi")));
builder.Services.AddScoped<EmpleadoService>(sp =>
{
    var httpClient = sp.GetRequiredService<IHttpClientFactory>().CreateClient("EmpleadoApi");
    var configuration = sp.GetRequiredService<IConfiguration>(); // Obtén IConfiguration del proveedor de servicios
    return new EmpleadoService(httpClient, configuration);
});

// Configurar HttpClient
//builder.Services.AddHttpClient("EmpleadoApi", client =>
//{
//    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]);
//});
builder.Services.AddHttpClient("EmpleadoApi", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]);
});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
