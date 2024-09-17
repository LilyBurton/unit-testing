namespace StringCalculator;

public class StringCalculatorTest

{
    private StringCalc _calculator = new StringCalc();
    [Fact]
    public void Returns0GivenEmptyString()
    {
        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    public void ReturnsANumberGivenANumber(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 2", 3)]
    [InlineData("5, 5", 10)]

    public void AddTwoNumbersTogether(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

      [Theory]
    [InlineData("1, 2, 3", 6)]
    [InlineData("5, 5, 5", 15)]

    public void AddThreeNumbersTogether(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

      [Theory]
    [InlineData("1\n2, 3", 6)]
    [InlineData("1\n2\n3", 6)]
    [InlineData("1,2\n3", 6)]

    public void AddThreeNumbersTogetherWithNewLinesAndCommas(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
      
      [Theory]
    [InlineData("//;\n1;2;3", 6)]

    public void AddThreeNumbersTogetherWithNewDelimiters(string numbers, int expected)
    {
        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("-1, 2", "Negatives Not Allowed: -1")]
    [InlineData("-1,-2", "Negatives Not Allowed: -1,-2")]

    public void ThrowsNegativeGiven(string numbers, string expectedMessage)
    {
        Action action = () => _calculator.Add(numbers);

        var err = Assert.Throws<Exception>(action);

        Assert.Equal(expectedMessage, err.Message);
    }
}