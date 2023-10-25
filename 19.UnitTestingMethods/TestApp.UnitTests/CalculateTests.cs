using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new();
        int num1 = 5;
        int num2 = 4;

        // Act
        int result = calculator.Subtraction(num1, num2);

        // Assert
        Assert.AreEqual(1, result, "Error Message");
    }
}
