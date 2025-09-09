namespace ClockDotNet.Models;
public record ClockCommand(string function, int param, string color_RGB, int duration_ms);
