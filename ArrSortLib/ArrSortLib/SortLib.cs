using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSortLib
{
    /// <summary>
    /// This сlass contains two variants of sorting an array of type int 
    /// </summary>
    public class SortLib
    {
        #region QuickSort
        /// <summary>
        /// Sort two elements using third temporary element (swap)
        /// </summary>
        static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
        /// <summary>
        /// Sorts elements in a one-dimensional array using random element as pivot
        /// </summary>
        public static void QuickSort(int[] items)
        {
            CheckInputArray(items);
            quicksort(items, 0, items.Length - 1);

        }
        /// <summary>
        /// Sorts elements in a one-dimensional array using random element as pivot
        /// </summary>
        /// <param name="items">
        /// The one-dimentional array to sort
        /// </param>
        /// <param name="left">
        /// Left bound index of the selected part of the array.
        /// </param>
        /// <param name="right">
        /// Right bound index of the selected part of the array.
        /// </param>
        private static void quicksort(int[] items, int left, int right)
        {
            CheckInputArray(items);
            CheckArrayBounds(items, left, right);

            Random _pivotRng = new Random();

            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);
                int newPivot = partition(items, left, right, pivotIndex);
                quicksort(items, left, newPivot - 1);
                quicksort(items, newPivot + 1, right);
            }
        }

        private static int partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];
            Swap(items, pivotIndex, right);
            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }

        #endregion

        #region MergeSort 
        /// <summary>
        /// Sorts elements in a one-dimensional array by merge.
        /// </summary>
        /// <param name="items">
        /// The one-dimensional array to sort.
        /// </param>
        public static void MergeSort(int[] items)
        {
            CheckInputArray(items);

            if (items.Length <= 1)
            {
                return;
            }
            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            MergeSort(left);
            MergeSort(right);

            Merge(items, left, right);
        }
        private static void Merge(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;
            int remaining = left.Length + right.Length;
            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else
                {
                    items[targetIndex] = right[rightIndex++];
                }
                targetIndex++;
                remaining--;
            }
        }
        #endregion

        #region CheckSortMethods
        private static void CheckArrayBounds(int[] array, int left, int right)
        {
            bool Flag;

            if (Flag = (left < 0 || right >= array.Length))
            {
                throw new ArgumentException();
            }
        }

        private static void CheckInputArray(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException();
            if (array == null)
                throw new ArgumentNullException(nameof(array));
        }
        #endregion
    }
}
