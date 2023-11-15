using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("abcd", 3, "aBcDaBcDaBcD")]
    [TestCase("AbCd", 5, "aBcDaBcDaBcDaBcDaBcD")]
    [TestCase("xy22ab", 6, "xY22aBxY22aBxY22aBxY22aBxY22aBxY22aB")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repeat = 2;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repeat), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abdc";
        int repeat = -2;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repeat), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcd";
        int repeat = 0;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repeat), Throws.ArgumentException);
    }
}
