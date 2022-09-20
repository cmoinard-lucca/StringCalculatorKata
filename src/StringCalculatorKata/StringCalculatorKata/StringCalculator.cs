namespace StringCalculatorKata;

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        if (!numbers.Contains(","))
        {
            return int.Parse(numbers);
        }

        var indexOfComma = numbers.IndexOf(",", StringComparison.Ordinal);
        var firstNumber = int.Parse(numbers[.. indexOfComma]);
        var secondNumber = int.Parse(numbers[(indexOfComma + 1) ..]);
        return firstNumber + secondNumber;
    }
}