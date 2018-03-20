using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000000];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                array[i] = rand.Next(0, 200);
            }
            int digit = 7;
        
            Stopwatch stopwatchStr = Stopwatch.StartNew();
            int[] newarray = FilterDigitLib.FilterDigit.FilterDigitUsingString(array,digit);
            foreach (var item in newarray)
            {
                Console.Write(item + " ");
            }
            stopwatchStr.Stop();

            Console.WriteLine();
            Console.WriteLine(stopwatchStr.ElapsedMilliseconds + "ms");
            Console.WriteLine();

            Stopwatch stopwatchDiv = Stopwatch.StartNew();

         
            int[] newarr = FilterDigitLib.FilterDigit.FilterDigitByDiv(array, 7);
            foreach (var item in newarr)
            {
                Console.Write(item + " ");
            }
            stopwatchDiv.Stop();
            Console.WriteLine();
            Console.WriteLine(stopwatchDiv.ElapsedMilliseconds + "ms");
            Console.WriteLine("Hello");

        }
    }
}
