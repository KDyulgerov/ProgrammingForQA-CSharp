using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        string[] inputArray = Array.Empty<string>();

        string[] result = Reverser.ReverseStrings(inputArray);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        string[] singleStringArray = { "rdZ" };

        string[] result = Reverser.ReverseStrings(singleStringArray);

        string[] expected = { "Zdr" };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        string[] multipleStringsArray = { "olleH", "rdZ", "rpK" };

        string[] result = Reverser.ReverseStrings(multipleStringsArray);

        string[] expected = { "Hello", "Zdr", "Kpr" };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        string[] specialCharStringArray = { "!olleH$" };

        string[] result = Reverser.ReverseStrings(specialCharStringArray);

        string[] expected = { "$Hello!" };

        CollectionAssert.AreEqual(expected, result);
    }
}
