using Microsoft.EntityFrameworkCore;
using WebAppApi.Model;
using WebAppApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Configurar conexión MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); builder.Services.AddDbContext<ApplicationDbContext>(options =>

options.UseMySql(builder.Configuration.GetConnectionString("Defaul tConnection"),

ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));


builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAppApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
