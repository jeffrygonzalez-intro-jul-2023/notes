
namespace CSharpSyntax;

public class Immutability
{
    [Fact]
    public void Watermelon()
    {

        var formatters = new Formatters();

        var response = formatters.FormatName("Han", "Solo");

        Assert.Equal("Solo, Han", response.FullName);
        Assert.Equal(9, response.NumberOfLetters);




        var anotherResult = new FormattedNameResult("Solo, Han", 9);
        

        Assert.Equal(response.FullName, anotherResult.FullName);
        Assert.Equal(response.NumberOfLetters, anotherResult.NumberOfLetters);

        Assert.Equal(response, anotherResult);

        var updated = anotherResult with { NumberOfLetters = 22 };

        Assert.Equal(22, updated.NumberOfLetters);
        Assert.Equal("Solo, Han", updated.FullName);

        Assert.Equal(9, anotherResult.NumberOfLetters);
    }
}
