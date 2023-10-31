using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] {1, 2, 3, 4}, "3 7")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "7 7 7 19 19 19")]
    [TestCase(new int[] { -1, 2, -3, 4 }, "1 1")]
    [TestCase(new int[] { -1, -2, -3, -4 }, "-3 -7")]
    [TestCase(new int[] { }, "")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        string result = FoldSum.FoldArray(arr);

        Assert.AreEqual(expected, result);
    }
}
