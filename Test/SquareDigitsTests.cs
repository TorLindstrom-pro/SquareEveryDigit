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
    public void ZeroSquared_IsZero(int n, int expectedResult)
    {
        // Act
        var result = Kata.SquareDigits(0);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}