using System;

namespace StringCalculator;

public class StringCalc

{
    internal object Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers)) return 0;
        var result = numbers.Split(",")
            .Select(s => int.Parse(s))
            .Sum();

        return result;
    }    
}