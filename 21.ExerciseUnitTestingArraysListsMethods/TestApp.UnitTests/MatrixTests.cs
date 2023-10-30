using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        List<List<int>> expected = new() { new() { 6, 8 }, new() { 10, 12 } };

        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        List<List<int>> matrixA = new();
        List<List<int>> matrixB = new();
        List<List<int>> expected = new();

        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5 }, new() { 7 } };

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException1()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new();

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException2()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 1 }, new() { 3, 4 } };

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException3()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 1, 2 }, new() { 4 } };

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException4()
    {
        List<List<int>> matrixA = new() { new() { 1 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 1, 2 }, new() { 4 } };

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException5()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 4 } };
        List<List<int>> matrixB = new() { new() { 1 }, new() { 4, 5 } };

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException6()
    {
        List<List<int>> matrixA = new();
        List<List<int>> matrixB = new() { new() { 1, 2 }, new() { 4, 5 } };

        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
    }

    [Test]
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        List<List<int>> matrixA = new() { new() { -1, -2 }, new() { -3, -4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        List<List<int>> expected = new() { new() { 4, 4 }, new() { 4, 4 } };

        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 2, 4 } };
        List<List<int>> matrix0 = new() { new() { 0, 0 }, new() { 0, 0 } };
        List<List<int>> expected = new() { new() { 1, 2 }, new() { 2, 4 } };

        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrix0);

        CollectionAssert.AreEqual(expected, result);
    }
}
