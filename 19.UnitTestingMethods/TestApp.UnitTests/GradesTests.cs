using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase (2.50, "Fail")]
    [TestCase (3.20, "Average")]
    [TestCase (3.60, "Good")]
    [TestCase (4.40, "Very Good")]
    [TestCase (4.80, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestCase (1.00, "Invalid!")]
    [TestCase (0.00, "Invalid!")]
    [TestCase (-0.00, "Invalid!")]
    [TestCase (15.00, "Invalid!")]
    [TestCase (126, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
