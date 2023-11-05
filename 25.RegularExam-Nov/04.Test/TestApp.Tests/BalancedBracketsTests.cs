using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] arrInput = { string.Empty };

        bool result = BalancedBrackets.IsBalanced(arrInput);

        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] arrInput = { "(", ")", "(", ")" };

        bool result = BalancedBrackets.IsBalanced(arrInput);

        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] arrInput = { "(", ":", "(", ")" };

        bool result = BalancedBrackets.IsBalanced(arrInput);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] arrInput = { "(", ")", ")", ")" };

        bool result = BalancedBrackets.IsBalanced(arrInput);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] arrInput = { "(", "(", "(" };

        bool result = BalancedBrackets.IsBalanced(arrInput);

        Assert.That(result, Is.False);
    }
}

