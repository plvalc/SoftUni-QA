using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;

        // Act
        int actual = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(1, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 7;

        // Act
        int actual = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(5040, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int input = -1;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
