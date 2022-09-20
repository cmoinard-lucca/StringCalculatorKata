using Xunit;

namespace StringCalculatorKata.Tests;

public class StringCalculatorTest
{
    [Fact]
    public void EmptyString()
    {
        var actual = StringCalculator.Add("");

        Assert.Equal(0, actual);
    }

    [Fact]
    public void OnlyOneNumberString()
    {
        var actual = StringCalculator.Add("3");

        Assert.Equal(3, actual);
    }
}