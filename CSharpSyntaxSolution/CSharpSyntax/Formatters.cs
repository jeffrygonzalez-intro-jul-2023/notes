
namespace CSharpSyntax;

public class Formatters
{
    public FormattedNameResult FormatName(string firstName, string lastName)
    {
        var fullName = $"{lastName}, {firstName}";
        var result = new FormattedNameResult(fullName, fullName.Length);
        
        //result.FullName = fullName;
        //result.NumberOfLetters = fullName.Length;
        return result;
    }
}

//public class FormattedNameResult : IEquatable<FormattedNameResult>
//{
//    public string FullName { get; init; } = string.Empty;
//    public int NumberOfLetters { get; init; }

//    public bool Equals(FormattedNameResult? other)
//    {
//        if(other == null) return false;
//        if(other.FullName == this.FullName && other.NumberOfLetters == this.NumberOfLetters)
//        {
//            return true;
//        }
//        return false;
//    }
//}

//public record FormattedNameResult
//{
//    public string FullName { get; init; } = string.Empty;
//    public int NumberOfLetters { get; init; }
//}

public record FormattedNameResult(string FullName, int NumberOfLetters);