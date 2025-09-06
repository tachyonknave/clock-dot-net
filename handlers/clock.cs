namespace ClockDotNet.Handlers;
using ClockDotNet.Models;

public class ClockHandler
{
    public static List<ClockCommand> AddClockCommand(List<ClockCommand> clockProgram, string function)
    {
        var newProgram = new List<ClockCommand>(clockProgram);
        newProgram.Add(new ClockCommand(function, 0, "FFFFFF", 1000));
        return newProgram;
        
    }
}