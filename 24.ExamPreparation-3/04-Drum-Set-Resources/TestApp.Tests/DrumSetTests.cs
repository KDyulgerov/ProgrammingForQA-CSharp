using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        decimal money = 100;
        List<int> initialValues = new() { 1, 2, 10 };
        List<string> commands = new() { "2", "2", "" };

        Assert.That(() => DrumSet.Drum(money, initialValues, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        decimal money = 100;
        List<int> initialValues = new() { 1, 1 };
        List<string> commands = new() { "stringTest" };

        Assert.That(() => DrumSet.Drum(money, initialValues, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 100;
        List<int> initialValues = new() { 3, 3 };
        List<string> commands = new() { "1", "1", "Hit it again, Gabsy!" };
        string expected = "1 1\nGabsy has 100.00lv.";

        string result = DrumSet.Drum(money, initialValues, commands);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 100;
        List<int> initialValues = new() { 3, 3 };
        List<string> commands = new() { "3", "3", "Hit it again, Gabsy!" };
        string expected = "3 3\nGabsy has 64.00lv.";

        string result = DrumSet.Drum(money, initialValues, commands);

        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 10;
        List<int> initialValues = new() { 9, 9 };
        List<string> commands = new() { "10", "10", "Hit it again, Gabsy!" };
        string expected = "\nGabsy has 10.00lv.";

        string result = DrumSet.Drum(money, initialValues, commands);

        Assert.That(result, Is.EqualTo(expected));
    }

}
