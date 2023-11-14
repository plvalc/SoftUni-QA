using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char firstChar = 'A';
        char secondChar = 'B';
        string expected = "";

        // Act
        string result = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char firstChar = 'B';
        char secondChar = 'A';
        string expected = "";

        // Act
        string result = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char firstChar = 'A';
        char secondChar = 'C';
        string expected = "B";

        // Act
        string result = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char firstChar = 'D';
        char secondChar = 'G';
        string expected = "E F";

        // Act
        string result = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char firstChar = 'X';
        char secondChar = 'Z';
        string expected = "Y";

        // Act
        string result = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
