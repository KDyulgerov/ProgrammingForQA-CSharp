using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests1
{
    [TestCase (0, "")]
    [TestCase (3,
        "1\r\n" +
        "1 2\r\n" +
        "1 2 3\r\n" +
        "1 2\r\n" +
        "1")]

    [TestCase (5,
        "1\r\n" +
        "1 2\r\n" +
        "1 2 3\r\n" +
        "1 2 3 4\r\n" +
        "1 2 3 4 5\r\n" +
        "1 2 3 4\r\n" +
        "1 2 3\r\n" +
        "1 2\r\n" +
        "1")]
    public void Test_Triangle_OutputMatchesExpected_Size0(int input, string output)
    {
        var result = Triangle.PrintTriangle(input);

        Assert.AreEqual(output, result);
    }
}
