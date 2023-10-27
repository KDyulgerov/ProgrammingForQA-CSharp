using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        long number = 1;

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(number), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long number = 3;

        long result = PrimeFactor.FindLargestPrimeFactor(number);

        Assert.That(result, Is.EqualTo(number));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long number = 123456789;

        long result = PrimeFactor.FindLargestPrimeFactor(number);

        long expected = 3803;
        Assert.That(result, Is.EqualTo(expected));
    }
}
