using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        List<int>? nullList = null;

        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        List<int> emptyList = new();

        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> oneElement = new() { 13 };

        int result = MaxNumber.FindMax(oneElement);

        Assert.That(result, Is.EqualTo(13));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> multiplePosiviteElements = new() { 13, 42, 24, 1, 5, 6 };

        int result = MaxNumber.FindMax(multiplePosiviteElements);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> multipleNegativeElements = new() { -1, -4, -124, -13, -6 };

        int result = MaxNumber.FindMax(multipleNegativeElements);

        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> mixedElements = new() { 1, 2, -14, 3, -2, 1 };

        int result = MaxNumber.FindMax(mixedElements);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> duplicateMaxValueElements = new() { 2, 5, 13, 13, -1, 1 };

        int result = MaxNumber.FindMax(duplicateMaxValueElements);

        Assert.That(result, Is.EqualTo(13));
    }
}
