using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        var input = 0;
        string output = String.Empty;

        var result = Triangle.PrintTriangle(input);

        Assert.AreEqual(output, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        int input = 3;
        string output = 
            "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine + 
            "1";
        string result = Triangle.PrintTriangle(input);

        Assert.AreEqual(output, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int input = 5;
        string output =
            "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        string result = Triangle.PrintTriangle(input);

        Assert.AreEqual(output, result);
    }
}
