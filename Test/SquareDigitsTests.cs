using SquareEveryDigit;

namespace Test;

public class SquareDigitsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Theory]
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(4, 4)]
    [TestCase(81, 81)]
    public void SingleDigits_AreSquared(int n, int expectedResult)
    {
        // Act
        var result = Kata.SquareDigits(0);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Theory]
    [TestCase(123, 149)]
    [TestCase(765, 493625)]
    [TestCase(9119, 811181)]
    public void EachDigitInNumber_IsSquared(int n, int expectedResult)
    {
        // Act
        var result = Kata.SquareDigits(n);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}