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

    [Theory]
    [InlineData("3", 3)]
    [InlineData("14", 14)]
    public void OnlyOneNumberString(string input, int expected)
    {
        var actual = StringCalculator.Add(input);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("3,5", 8)]
    [InlineData("14,6", 20)]
    public void TwoNumbersString(string input, int expected)
    {
        var actual = StringCalculator.Add(input);

        Assert.Equal(expected, actual);
    }
}