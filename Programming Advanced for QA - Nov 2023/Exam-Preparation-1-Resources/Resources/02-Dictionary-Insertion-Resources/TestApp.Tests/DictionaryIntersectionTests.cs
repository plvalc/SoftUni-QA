using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();
        Dictionary<string, int> expected = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "one" , 1 },
            { "two",  2 },
            { "three", 3 }
        };
        Dictionary<string, int> dict2 = new();
        Dictionary<string, int> expected = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "one" , 1 },
            { "two",  2 },
            { "three", 3 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "four", 4 },
            { "five", 5 },
            { "six", 6 }
        };
        Dictionary<string, int> expected = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "one" , 1 },
            { "two",  2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "four", 4 },
            { "five", 5 },
            { "six", 6 }
        };
        Dictionary<string, int> expected = new()
        {
            { "four", 4 },
            { "five", 5 }
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {

        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "one" , 1 },
            { "two",  2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "four", 40 },
            { "five", 50 },
            { "six", 60 }
        };
        Dictionary<string, int> expected = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Has.Count.EqualTo(0));
    }
}
