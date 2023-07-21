
namespace StringCalculatorKata;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;
    public StringCalculatorTests()
    {
        _calculator = new StringCalculator();
    }

    [Fact]
    public void EmptyStringReturnsZero()
    {
       

        // When
        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1",1)]
    [InlineData("2",2)]
    [InlineData("308",308)]
    public void SingleDigit(string numbers, int expected)
    {
      
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2",3)]
    [InlineData("1,8",9)]
    [InlineData("10,2", 12)]
    [InlineData("4096,10", 4106)]
    public void TwoDigits(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void ArbitraryNumberOfDigits(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2\n3", 6)]
    [InlineData("1\n2,3", 6)]
    public void NewLineDelimeters(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n3;10", 13)]
    [InlineData("//*\n3*10", 13)]
    [InlineData("//###\n3###10", 13)]

    public void CustomDelimeters(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }


}
