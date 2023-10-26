using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        int[] emptyArray = Array.Empty<int>();

        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
    }

    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        int[] array = { 42 };

        double result = Average.CalculateAverage(array);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        int[] positiveNumArray = { 1, 2, 3, 4, 5, 6};

        double result = Average.CalculateAverage(positiveNumArray);

        Assert.That(result, Is.EqualTo(3.5));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        int[] negativeNumArray = { -1, -2, -3, -4, -5, -6 };

        double result = Average.CalculateAverage(negativeNumArray);

        Assert.That(result, Is.EqualTo(-3.5));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        int[] mixetNumArray = { 1, 15, -2, 3, -1 };

        double result = Average.CalculateAverage(mixetNumArray);

        Assert.That(result, Is.EqualTo(3.2));
    }
}
