namespace ClockDotNet.Handlers;
using ClockDotNet.Models;

public class ClockHandler
{
    public static List<ClockCommand> AddClockCommand(
        List<ClockCommand> clockProgram,
        string function,
        int param = 0,
        string color_RGB = "FFFFFF",
        int duration_ms = 1000)
    {
        var newProgram = new List<ClockCommand>(clockProgram);
        newProgram.Add(new ClockCommand(function, param, color_RGB, duration_ms));
        return newProgram;
        
    }
}