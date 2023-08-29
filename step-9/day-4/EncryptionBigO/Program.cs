using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionBigO
{
    class Program
    {
        /////////// BIGO
        ///
        //O(1)
        private static void ConstantBigO(int index)
        {
            int[] array = new int[] { 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Console.WriteLine($"Constant: {array[index]}");
        }
        //O(n)
        private static void LinearBigO(int searchedNumber)
        {
            int[] array = new int[] { 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == searchedNumber)
                {
                    Console.WriteLine("Your number found at " + i);
                }
            }
        }
        //O(n^2)
        private static void QuadraticBigO()
        {
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.WriteLine(numbers[i] + ", " + numbers[j]);
                }
            }
        }
        //O(2^n)
        private static void ExponentialBigO(int n)
        {
            int total = 0;

            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                total++;
            }
        }
        //O(logn)
        private static int LogarithmBigO(int target)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        //////// ENCRYPTION
        ///

        static void Main(string[] args)
        {
            ConstantBigO(10);
            LinearBigO(6);
            QuadraticBigO();
            ExponentialBigO(5);
            LogarithmBigO(5);

            Console.ReadLine();
        }
    }
}
