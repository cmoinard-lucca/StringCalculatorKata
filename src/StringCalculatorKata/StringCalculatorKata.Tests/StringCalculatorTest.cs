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
}