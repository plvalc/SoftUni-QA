using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "abcd ww.dir.bg http://aaa";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "https://dir.bg";
        List<string> expected = new() {"https://dir.bg"};

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "https://dir.bg http://www.abv.bg https://google.com";
        List<string> expected = new() { "https://dir.bg", "http://www.abv.bg", "https://google.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "https://dir.bg \"http://www.abv.bg\" https://google.com";
        List<string> expected = new() { "https://dir.bg", "http://www.abv.bg", "https://google.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
