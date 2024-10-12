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
    
    [Test]
    public void EachDigitInNumber_IsSquared()
    {
        // Act
        var result = Kata.SquareDigits(123);

        // Assert
        Assert.That(result, Is.EqualTo(149));
    }
}