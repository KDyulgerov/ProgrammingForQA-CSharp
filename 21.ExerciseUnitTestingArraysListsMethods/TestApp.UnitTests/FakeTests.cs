using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        char[]? input = null;

        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] digitsInput = { '0', '1', 'a', '2' };

        char[] result = Fake.RemoveStringNumbers(digitsInput);

        char[] expected = { 'a' };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] noDigitsInput = { 'a', 'b',  'c' };

        char[] result = Fake.RemoveStringNumbers(noDigitsInput);

        CollectionAssert.AreEqual(noDigitsInput, result);
    }
    
    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] emptyInput = Array.Empty<char>();

        char[] result = Fake.RemoveStringNumbers(emptyInput);

        CollectionAssert.AreEqual(emptyInput, result);
    }
}
