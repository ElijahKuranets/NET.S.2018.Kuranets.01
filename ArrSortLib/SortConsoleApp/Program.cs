using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted array: ");
            int[] array = {1,34,56,76,34,65,86,98,76,43,24};
            print(array);
            Console.WriteLine();
            Console.WriteLine("Quick sort:");
            ArrSortLib.SortLib.QuickSort(array);
            print(array);
            Console.WriteLine();
            Console.WriteLine("Merge sort:");
            ArrSortLib.SortLib.MergeSort(array);
            print(array);
            Console.WriteLine();
        }
        public static void print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
