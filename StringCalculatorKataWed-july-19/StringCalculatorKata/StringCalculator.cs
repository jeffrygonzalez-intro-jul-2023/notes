
namespace StringCalculatorKata;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        

        return numbers.Split(',') // ["108"]
                .Select(int.Parse) // [ 108 ]
                .Sum(); // Sum them up!
    }
}
