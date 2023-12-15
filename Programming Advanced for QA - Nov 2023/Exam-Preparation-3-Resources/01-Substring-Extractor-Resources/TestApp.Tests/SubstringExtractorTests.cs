using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "Hello!";
        string start = "e";
        string end = "o";
        string expected = "ll";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello!";
        string start = "b";
        string end = "o";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello!";
        string start = "e";
        string end = "j";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello!";
        string start = "b";
        string end = "j";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string start = "b";
        string end = "o";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello!";
        string start = "o";
        string end = "e";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
