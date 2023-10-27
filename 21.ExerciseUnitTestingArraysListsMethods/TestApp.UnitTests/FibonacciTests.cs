using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInputReturnException()
    {
        int n = -1;

        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int number = 0;

        int result = Fibonacci.CalculateFibonacci(number);

        Assert.That(result, Is.EqualTo(number));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int number = 1;

        int result = Fibonacci.CalculateFibonacci(number);

        Assert.That(result, Is.EqualTo(1));
    }
}