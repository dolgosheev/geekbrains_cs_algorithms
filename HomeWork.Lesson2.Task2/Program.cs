/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 2
 */

using System;

namespace HomeWork.Lesson2.Task2
{
    internal class Program
    {
        private static void Main()
        {
            var digitA = 12;
            var digitB = 4;

            Console.WriteLine($"Digit {digitA} in the degree of {digitB} is {Pow_norecursive(digitA, digitB)}");
            Console.WriteLine($"Digit {digitA} in the degree of {digitB} is {Pow_recursive(digitA, digitB)}");
            Console.WriteLine($"Digit {digitA} in the degree of {digitB} is {Pow_recursive_parity(digitA, digitB)}");

            Console.ReadKey();
        }

        private static long Pow_norecursive(long a,long b)
        {
            return unchecked( (long)Math.Pow(a, b) );
        }

        private static long Pow_recursive(long a, long b)
        {
            return (b == 0) ? 1 : a * (Pow_recursive(a, --b));
        }

        private static long Pow_recursive_parity(long a, long b)
        {
            if (b == 0)
                return 1;

            return (b % 2 == 1)
                ? Pow_recursive_parity(a, --b) * a
                : Pow_recursive_parity(a, b / 2) * Pow_recursive_parity(a, b / 2);

        }
    }
}
