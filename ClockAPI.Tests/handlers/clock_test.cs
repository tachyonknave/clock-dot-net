namespace ClockAPI.Tests;

using Xunit;
using ClockDotNet.Handlers;
using ClockDotNet.Models;
using System.Collections.Generic;

public class ClockHandlerTests
{
    [Fact]
    public void AddsNewCommandToEmptyList()
    {
        // Arrange
        var initialList = new List<ClockCommand>();
        string function = "TestFunction";
        string red_color = "FF0000";

        // Act
        var result = ClockHandler.AddClockCommand(initialList, function, color_RGB: red_color);

        // Assert
        Assert.Single(result);
        Assert.Equal(function, result[0].function);
        Assert.Equal(0, result[0].param); 
        Assert.Equal("FF0000", result[0].color_RGB);
        Assert.Equal(1000, result[0].duration_ms); 
    }

    [Fact]
    public void AddsNewCommandToNonEmptyList()
    {
        // Arrange
        var initialList = new List<ClockCommand>();
        string function = "TestFunction";

        // Act
        var result = ClockHandler.AddClockCommand(initialList, function);
        var second_result = ClockHandler.AddClockCommand(result, function, param: 20);

        // Assert
        Assert.Single(result);
        Assert.Equal(function, second_result[1].function);
        Assert.Equal(20, second_result[1].param); 
        Assert.Equal("FFFFFF", second_result[1].color_RGB); 
        Assert.Equal(1000, second_result[1].duration_ms);
    }

}