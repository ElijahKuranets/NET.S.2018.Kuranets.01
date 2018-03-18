using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSortLib.Tests

{
    [TestFixture]

    public class SortLibTests
    {
        #region QuickSortTests

        [TestCase(new int[] { 8, 3, 5, 7, 2, 1, 6, 4 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [Category("QuickSortTests")]
        public void NUNITQuickSort_UnsortedArray_SortedArray(int[] array, int[] expected)
        {
            SortLib.QuickSort(array);
            bool result = array.SequenceEqual<int>(expected);
            Assert.True(result);
        }

        #endregion

        #region MergeSortTests

        [TestCase(new int[] { 5, 8, 6, 3, 1, 7, 9, 2, 4 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [Category("MergeSortTests")]
        public void NUNITMergeSort_UnsortedArray_SortedArray(int[] array, int[] expected)
        {
            SortLib.MergeSort(array);
            bool result = array.SequenceEqual<int>(expected);
            Assert.True(result);
        }
        #endregion
    }

}
