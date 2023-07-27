using EmployeeDirectoryApi;
using EmployeeDirectoryApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// 198
builder.Services.AddTransient<IProvideTheBusinessClock, StandardBusinessClock>();
builder.Services.AddScoped<ILookupOnCallDevelopers, DeveloperLookup>();
builder.Services.AddSingleton<ISystemTime, SystemTime>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { } // this will add to the internal class Main so we can see it from out tests.