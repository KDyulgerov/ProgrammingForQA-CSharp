using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        int[] emptyArray = Array.Empty<int>();

        int result = EvenOddSubtraction.FindDifference(emptyArray);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        int[] evenElements = { 2, 4, 6, 8 };

        int result = EvenOddSubtraction.FindDifference(evenElements);

        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnOddSum()
    {
        int[] oddElements = { 1, 3, 5, 7, 9 };

        int result = EvenOddSubtraction.FindDifference(oddElements);

        Assert.That(result, Is.EqualTo(25));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        int[] mixedElements = { 1, 2, 3, 4, 5, };

        int result = EvenOddSubtraction.FindDifference(mixedElements);

        Assert.That(result, Is.EqualTo(3));
    }
}
