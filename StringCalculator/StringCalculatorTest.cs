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
}