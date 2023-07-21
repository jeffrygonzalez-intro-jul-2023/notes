
using FirstApp.Models;
using FirstApp.Services;
using Microsoft.AspNetCore.Mvc;

Console.WriteLine("Starting Up The Api");
var builder = WebApplication.CreateBuilder(args);
// Configuration for the API Will go here.

builder.Services.AddTransient<IProvideTheSystemStatus, RemoteStatusService>();
builder.Services.AddTransient<ISystemTime, SystemTime>();

Console.WriteLine("About to Start the Api");
var app = builder.Build();
// GET /sayhi
app.MapGet("/sayhi", () =>
{
    Console.WriteLine("Got a request!");
    return Results.Ok("Yep! Hello, Good To See You!");
});

app.MapGet("/status", ([FromServices]IProvideTheSystemStatus _statusGenerator) =>
{
    //var response = new StatusResponseModel(DateTime.Now, "Looks Good", "Operating Normally");
    StatusResponseModel response = _statusGenerator.GetCurrentStatus();
    return Results.Ok(response);
});

app.MapGet("/todo-list", () =>
{
    var response = new List<TodoItemModel>() {
        new TodoItemModel(Guid.NewGuid(), "Buy Beer", "Later"),
        new TodoItemModel(Guid.NewGuid(), "Mow Lawn", "Waiting")
    };
    return Results.Ok(response);
});

app.Run(); // Blocking call - this will start server and run FOREVER (or until we kill it)
Console.WriteLine("Api is going down. Goodbye..");