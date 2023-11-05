using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char startInput = 'A';
        char endInput = 'B';
        string expected = string.Empty;

        string result = CharacterRange.GetRange(startInput, endInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char startInput = 'B';
        char endInput = 'A';
        string expected = string.Empty;

        string result = CharacterRange.GetRange(startInput, endInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char startInput = 'A';
        char endInput = 'C';
        string expected = "B";

        string result = CharacterRange.GetRange(startInput, endInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char startInput = 'D';
        char endInput = 'G';
        string expected = "E F";

        string result = CharacterRange.GetRange(startInput, endInput);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char startInput = 'X';
        char endInput = 'Z';
        string expected = "Y";

        string result = CharacterRange.GetRange(startInput, endInput);

        Assert.That(result, Is.EqualTo(expected));
    }
}
