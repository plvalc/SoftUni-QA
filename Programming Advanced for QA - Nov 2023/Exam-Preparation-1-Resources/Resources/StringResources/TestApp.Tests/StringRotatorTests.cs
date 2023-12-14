using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, 12);

        // Assert

        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Hello";

        // Act
        string result = StringRotator.RotateRight(input, 0);

        // Assert

        Assert.That(result, Is.EqualTo("Hello"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello";

        // Act
        string result = StringRotator.RotateRight(input, 2);

        // Assert

        Assert.That(result, Is.EqualTo("loHel"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello";

        // Act
        string result = StringRotator.RotateRight(input, -2);

        // Assert

        Assert.That(result, Is.EqualTo("loHel"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello";

        // Act
        string result = StringRotator.RotateRight(input, 6);

        // Assert

        Assert.That(result, Is.EqualTo("oHell"));
    }
}
