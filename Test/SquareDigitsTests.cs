using SquareEveryDigit;

namespace Test;

public class SquareDigitsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ZeroSquared_IsZero()
    {
        // Act
        var result = Kata.SquareDigits(0);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}