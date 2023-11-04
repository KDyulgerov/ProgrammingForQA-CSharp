using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        string input = null;

        Assert.That(() => ExtractFile.GetFile(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        string input = string.Empty;

        Assert.That(() => ExtractFile.GetFile(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string input = "D:\\KD\\SoftUni\\03-Extract-File-Resources.txt";
        string expected = "File name: 03-Extract-File-Resources\nFile extension: txt";

        string result = ExtractFile.GetFile(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string input = "D:\\KD\\SoftUni\\03-Extract-File-Resources";
        string expected = "File name: 03-Extract-File-Resources";

        string result = ExtractFile.GetFile(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string input = "D:\\K$D\\So_ft.Uni\\03-Extract-File-Resources.txt";
        string expected = "File name: 03-Extract-File-Resources\nFile extension: txt";

        string result = ExtractFile.GetFile(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
