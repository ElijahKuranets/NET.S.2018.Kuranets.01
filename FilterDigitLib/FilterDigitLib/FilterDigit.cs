using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigitLib
{
    public class FilterDigit
    {
        #region FilterDigitUsingString

        public static int[] FilterDigitUsingString(int[] numbers, int digit)
        {

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentException($"Enter a {nameof(digit)} from 0 to 9!");
            }

            if (numbers.Length == 0)
            {
                return null;
            }

            if (numbers == null)
            {
                throw new ArgumentException(nameof(numbers));
            }

            int[] sortedArray = new int[0];
            string stringDigit = digit.ToString();
            for (int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i].ToString();
                if (number.Contains(stringDigit))
                {
                    Array.Resize(ref sortedArray, sortedArray.Length + 1);
                    sortedArray[sortedArray.Length - 1] = numbers[i];
                }
            }

            return sortedArray;

        }

        #endregion

        #region FilterDigitUsingDivisions
        public static int[] FilterDigitByDiv(int[] array, int digit)
        {
            int[] newarray = new int[0];
            foreach (var number in array)
            {
                Filter(number, digit);
            }
            foreach (var number in array)
            {
                var result = Filter(number, digit);
                if (result != 0)
                {
                    Array.Resize(ref newarray, newarray.Length + 1);
                    newarray[newarray.Length - 1] = result;
                }
            }

            return newarray;
        }

        public static int Filter(int number, int digt)
        {
            int tmp = number;
            while (tmp != 0)
            {
                if (tmp % 10 == digt)
                { return number; }
                tmp /= 10;
            }

            return 0;
        }
    }
    #endregion
}


