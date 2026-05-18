using DemoLibrary;

namespace DemoLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectValue()
    {
        var calc = new Calculator();

        Assert.Equal(5, calc.Add(2, 3));
    }
}