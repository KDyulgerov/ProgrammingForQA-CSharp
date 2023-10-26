using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        int[] emptyArray = Array.Empty<int>();

        string result = Reverse.ReverseArray(emptyArray);

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        int[] oneElement = { 42 };

        string result = Reverse.ReverseArray(oneElement);

        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        int[] multipleElementsArray = { 42, 54, -1, 8, 6 };

        string result = Reverse.ReverseArray(multipleElementsArray);

        Assert.That(result, Is.EqualTo("6 8 -1 54 42"));
    }
}
