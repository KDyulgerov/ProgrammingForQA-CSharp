using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        int[] emptyInput = Array.Empty<int>();

        int[] result = Duplicates.RemoveDuplicates(emptyInput);

        CollectionAssert.IsEmpty(result);

    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        int[] noDuplicatesInput = { 1, 2, 3 };

        int[] result = Duplicates.RemoveDuplicates(noDuplicatesInput);

        int[] expected = { 1, 2, 3 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] duplicatesInput = { 1, 2, 2, 2, 3 };

        int[] result = Duplicates.RemoveDuplicates(duplicatesInput);

        int[] expected = { 1, 2, 3 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] allDuplicatesInput = { 1, 1, 1 };

        int[] result = Duplicates.RemoveDuplicates(allDuplicatesInput);

        int[] expected = { 1 };
        CollectionAssert.AreEqual(expected, result);
    }
}
