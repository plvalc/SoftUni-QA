using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = string.Empty;
        string[] expected = Array.Empty<string>();

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "Hello";
        string[] expected = { "Hello" };

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "Hello,I,am,Pesho";
        string[] expected = { "Hello", "I", "am", "Pesho" };

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "Hello ,I, am,   Pesho";
        string[] expected = { "Hello", "I", "am", "Pesho" };

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
