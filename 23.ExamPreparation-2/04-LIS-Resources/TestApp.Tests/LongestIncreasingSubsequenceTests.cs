using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[]? input = null;

        Assert.That(() => LongestIncreasingSubsequence.GetLis(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[]? input = Array.Empty<int>();

        string result = LongestIncreasingSubsequence.GetLis(input);

        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[]? input = { 1 };
        string expected = "1";

        string result = LongestIncreasingSubsequence.GetLis(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[]? input = { 1, 3, 1, 5, 1, 2, 1, 3, 4, 1 };
        string expected = "1 2 3 4";

        string result = LongestIncreasingSubsequence.GetLis(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[]? input = { 6, 7, 8, 10};
        string expected = "6 7 8 10";

        string result = LongestIncreasingSubsequence.GetLis(input);

        CollectionAssert.AreEqual(expected, result);
    }
}
