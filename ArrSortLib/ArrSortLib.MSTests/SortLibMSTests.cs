using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrSortLib.MSTests
{
    [TestClass]
    public class SortLibMSTests
    {
        #region QuickSortTests
        [TestMethod]
        public void MSQuickSort_UnsortedArray_SortedArray()
        {
            int[] actual  = { 8, 5, 3, 2, 4, 1, 6, 7 };
            SortLib.QuickSort(actual);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.Equals(expected, actual);
        }
        #endregion

        #region MergeSortTests
        [TestMethod]
        public void MSMergeSort_UnsortedArray_SortedArray()
        {
            int[] actual = { 3, 5, 8, 2, 4, 1, 6, 7 };
            SortLib.QuickSort(actual);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.Equals(expected, actual);
        }
        #endregion
    }
}
