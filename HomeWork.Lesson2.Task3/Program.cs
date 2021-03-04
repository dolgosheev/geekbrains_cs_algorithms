/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 3
 */

using System;

namespace HomeWork.Lesson2.Task3
{
    internal static class Program
    {
        private static int[] _array;
        private static readonly int operations = 1;

        private static void Main()
        {
            // set variant by enum
            _array.FillArray(ArrayFiller.Random,20);
            // start digit
            var StartDigit = 3;
            // show result by array
            Console.WriteLine( $"Result used array (3 to 20) is {_array.Variant_Array(StartDigit, operations)}" );
            // clear garbage
            GC.Collect();
            // show result by recourse
            Console.WriteLine($"Result used recourse (3 to 20) is {Variant_Recoursive(StartDigit, operations) }");

            Console.ReadKey();
        }

        private enum ArrayFiller
        {
            Enumerate,
            Random
        }

        private static void FillArray(this int[] array,ArrayFiller filler, int count)
        {
            array = new int[count];
            var rnd = new Random();

            for (var i = 0; i < array.Length; i++)
            {
                if(filler == ArrayFiller.Enumerate)
                    array[i] = ++i;

                if (filler == ArrayFiller.Random)
                    array[i] = rnd.Next(1,1000);
            }

            _array = array;
        }

        private static int Variant_Array(this int[] array, int digit, int ops)
        {
            for (var i = digit ; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    ++ops;
            return ops;
        }

        private static int Variant_Recoursive(int digit, int ops)
        {
            if (digit == _array.Length)
                return ops;

            if ((digit + 1) % 2 == 0) ops++;
                return Variant_Recoursive(digit + 1, ops);
        }
    }
}
