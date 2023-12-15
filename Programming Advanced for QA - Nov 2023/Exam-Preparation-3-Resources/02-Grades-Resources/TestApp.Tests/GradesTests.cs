using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Ivan", 4 },
            { "Petar", 3 },
            { "Georgi", 2},
            { "Petya", 5 },
            { "Maria", 6 }
        };
        string expected = $"Maria with average grade 6.00{Environment.NewLine}Petya with average grade 5.00{Environment.NewLine}Ivan with average grade 4.00";

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();
        string expected = string.Empty;

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Petya", 5 },
            { "Maria", 6 }
        };
        string expected = $"Maria with average grade 6.00{Environment.NewLine}Petya with average grade 5.00";

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Ivan", 4 },
            { "Petar", 3 },
            { "Georgi", 2},
            { "Petya", 6 },
            { "Maria", 6 }
        };
        string expected = $"Maria with average grade 6.00{Environment.NewLine}Petya with average grade 6.00{Environment.NewLine}Ivan with average grade 4.00";

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
