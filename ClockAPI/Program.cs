using ClockDotNet.Models;
using ClockDotNet.Handlers;
using ClockDotNet.DB;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var clockProgram = new List<ClockCommand>();


app.MapGet("/health", () => Results.Ok("OK"));
app.MapPost("/clock", (ClockCommand command) =>
{
    clockProgram = ClockHandler.AddClockCommand(clockProgram, command.function);
    // print the updated clockProgram to the console for debugging
    Console.WriteLine("Updated clockProgram:");
    foreach (var cmd in clockProgram)
    {
        Console.WriteLine($"Function: {cmd.function}, Param: {cmd.param}, Color: {cmd.color_RGB}, Duration: {cmd.duration_ms}");
    }   
    return Results.Ok("Command added");
});

SqliteDatabase clockDb = new SqliteDatabase();
clockDb.ConnectToDatabase("data/clock.db");  

app.Run();


