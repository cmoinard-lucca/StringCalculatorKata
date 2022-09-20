using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StringCalculatorKata.Tests;

public class StringCalculatorTest
{
    private static Random Random { get; } = new();

    [Fact]
    public void EmptyString()
    {
        var actual = StringCalculator.Add("");

        Assert.Equal(0, actual);
    }

    public static TheoryData<string, int> OneNumberData =
        Enumerable.Range(1, 100)
            .Select(_ => Random.Next())
            .ToTheoryData(
                number => number.ToString(),
                number => number);

    [Theory]
    [MemberData(nameof(OneNumberData))]
    public void WhenOneNumber_ShouldReturnSameNumber(string input, int expected)
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

public static class TheoryDataExtensions
{
    public static TheoryData<T1, T2> ToTheoryData<T, T1, T2>(
        this IEnumerable<T> source,
        Func<T, T1> getT1,
        Func<T, T2> getT2
    )
    {
        var theoryData = new TheoryData<T1, T2>();
        foreach (var value in source)
        {
            theoryData.Add(
                getT1(value),
                getT2(value)
            );
        }

        return theoryData;
    }
}