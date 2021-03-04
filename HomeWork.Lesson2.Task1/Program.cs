/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 1
 */

using System;

namespace HomeWork.Lesson2.Task1
{
    internal class Program
    {
        private static void Main()
        {
            var digit = 1;
            Console.WriteLine($" Digit {digit} to binary - {DecToBin(digit)}");
            Console.ReadKey();
        }

        private static string DecToBin(int dec)
        {
            if(dec == 0)
                return dec.ToString();

            return (dec > 0) ? DecToBin(dec / 2) + (dec % 2) : "";
        }
    }
}
