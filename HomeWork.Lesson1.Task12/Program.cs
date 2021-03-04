/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 12
 */

using System;

namespace HomeWork.Lesson1.Task12
{
    internal class Program
    {
        private static void Main()
        {
            var a = 10;
            var b = 1;
            var c = 61;

            var max = a > b ? a > c ? a: c : b > c ? b : c;

            Console.WriteLine($"Max from {a},{b} and {c} is {max} ");
            Console.ReadKey();
        }
    }
}
