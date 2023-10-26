using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        List<int> emptyList = new();

        List<int> result = GaussTrick.SumPairs(emptyList);

        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        List<int> singleElement = new() { 2 };

        List<int> result = GaussTrick.SumPairs(singleElement);

        List<int> expected = new() { 2 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> evenCountList = new() { 1, 2, 3, 4 };

        List<int> result = GaussTrick.SumPairs(evenCountList);

        List<int> expected = new() { 5, 5 };
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddCountList = new() { 1, 2, 3, 4, 5 };

        List<int> result = GaussTrick.SumPairs(oddCountList);

        List<int> expected = new() { 6, 6, 3 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> oddCountList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> result = GaussTrick.SumPairs(oddCountList);

        List<int> expected = new() { 11, 11, 11, 11, 11 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddCountList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        List<int> result = GaussTrick.SumPairs(oddCountList);

        List<int> expected = new() { 10, 10, 10, 10, 5 };
        CollectionAssert.AreEqual(expected, result);
    }
}
