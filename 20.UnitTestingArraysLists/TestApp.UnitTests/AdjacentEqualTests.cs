using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        List<int>? nullList = null;

        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        List<int> emptyList = new();

        string result = AdjacentEqual.Sum(emptyList);

        List<int> expected = new();
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        List<int> noAdjacentNums = new() { 1, 2, 3, 4, 5 };

        string result = AdjacentEqual.Sum(noAdjacentNums);

        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        List<int> adjacentNums = new() { 1, 1, 2, 3, 4, 5 };

        string result = AdjacentEqual.Sum(adjacentNums);

        Assert.That(result, Is.EqualTo("4 3 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> allAdjacent = new() { 1, 1, 2, 4, 8 };

        string result = AdjacentEqual.Sum(allAdjacent);

        Assert.That(result, Is.EqualTo("16"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        List<int> beginningEqual = new() { 1, 1, 2, 4, 5, 3, 2, 3 };

        string result = AdjacentEqual.Sum(beginningEqual);

        Assert.That(result, Is.EqualTo("8 5 3 2 3"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        List<int> endEqual = new() { 1, 3, 4, 1, 1, 2 };

        string result = AdjacentEqual.Sum(endEqual);

        Assert.That(result, Is.EqualTo("1 3 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> middleEqual = new() { 1, 3, 4, 4, 5 };

        string result = AdjacentEqual.Sum(middleEqual);

        Assert.That(result, Is.EqualTo("1 3 8 5"));
    }
}
