/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 2
 */

using System;

namespace HomeWork.Lesson1.Task2
{
    internal class Program
    {
        private static void Main()
        {
            byte a = 7, b = 14, c = 3, d = 10;

            var tmpmax1 = a > b ? a : b;
            var tmpmax2 = c > d ? c : d;

            var max = tmpmax1 > tmpmax2 ? tmpmax1 : tmpmax2;

            Console.WriteLine($"Max from {string.Join(',',a,b,c,d)} is {max}");

            Console.ReadKey();
        }
    }
}
