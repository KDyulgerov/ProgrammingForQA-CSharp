using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        List<string> validInput = new() { "Mom", "Aha" };

        bool result = Palindrome.IsPalindrome(validInput);

        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        List<string> emptyInput = new();
        
        bool result = Palindrome.IsPalindrome(emptyInput);

        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> validInput = new() { "Mom" };

        bool result = Palindrome.IsPalindrome(validInput);

        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> nonValidInput = new() { "nonvalid" };

        bool result = Palindrome.IsPalindrome(nonValidInput);

        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> mixedValidInput = new() { "Mom", "aha", "NON" };

        bool result = Palindrome.IsPalindrome(mixedValidInput);

        Assert.IsTrue(result);
    }
}
