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

        return numbers
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Sum(n => int.Parse(n));
    }
}