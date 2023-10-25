using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 1;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(1, result);

    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 3;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(6, result);
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        int input = -1;

        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
