using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorAppAPI.Services;

var builder = WebApplication.CreateBuilder(args);

//* Agregar servicios al contenedor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//builder.Services.AddScoped<EmpleadoService>(sp => new EmpleadoService(sp.GetRequiredService<IHttpClientFactory>().CreateClient("EmpleadoApi")));
builder.Services.AddScoped<EmpleadoService>(sp => new EmpleadoService(sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebAppApi")));


// Configurar HttpClient
builder.Services.AddHttpClient("EmpleadoApi", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]);
});

var app = builder.Build();

//*Configurar middleware
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
