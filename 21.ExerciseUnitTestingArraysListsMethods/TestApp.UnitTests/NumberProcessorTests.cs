using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        List<double> actual = NumberProcessor.ProcessNumbers(input);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        List<int> oddInput = new() { 9, 25, 25};
        List<double> expected = new() { 3, 5, 5 };

        List<double> result = NumberProcessor.ProcessNumbers(oddInput);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        List<double> result = NumberProcessor.ProcessNumbers(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        List<int> negativeInput = new() { -1, -2 };

        Assert.That(() => NumberProcessor.ProcessNumbers(negativeInput), Throws.ArgumentException);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        List<int> emptyInput = new();

        List<double> result = NumberProcessor.ProcessNumbers(emptyInput);

        CollectionAssert.AreEqual(emptyInput, result);
    }
}
