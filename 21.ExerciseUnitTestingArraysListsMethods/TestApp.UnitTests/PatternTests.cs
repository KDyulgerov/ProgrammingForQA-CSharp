using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        int[]? inputNullArray = null;

        Assert.That(() => Pattern.SortInPattern(inputNullArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] input = { 1, 2, 3, 3, 4 };

        int[] result = Pattern.SortInPattern(input);

        int[] expected = { 1, 4, 2, 3, };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] emptyArrayInput = Array.Empty<int>();

        int[] result = Pattern.SortInPattern(emptyArrayInput);

        CollectionAssert.AreEqual(emptyArrayInput, result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] singleArrayInput = { 1 };

        int[] result = Pattern.SortInPattern(singleArrayInput);

        CollectionAssert.AreEqual(singleArrayInput, result);
    }
}
