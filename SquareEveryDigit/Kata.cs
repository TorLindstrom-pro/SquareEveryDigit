using System.Linq;

namespace SquareEveryDigit;

public class Kata
{
    public static int SquareDigits(int n)
    {
        var squareDigits = n.ToString().Select(char.GetNumericValue).Aggregate("", (result, c) => result + c * c);
        return int.Parse(squareDigits);
    }
}