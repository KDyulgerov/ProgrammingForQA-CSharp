using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = String.Empty;

        // Act
        StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(String.Empty, input);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = "T";

        string result = StringReverse.Reverse(input);

        Assert.AreEqual("T", result);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "ABC";

        string result = StringReverse.Reverse(input);

        Assert.AreEqual("CBA", result);
    }
}
