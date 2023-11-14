using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int input = 0;

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int input = 3;

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("1" + Environment.NewLine + "1 2" + Environment.NewLine + "1 2 3" + Environment.NewLine + "1 2" + Environment.NewLine + "1", actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int input = 5;

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5\r\n1 2 3 4\r\n1 2 3\r\n1 2\r\n1", actual);

    }
}
