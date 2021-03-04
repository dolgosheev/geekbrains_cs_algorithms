/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;

namespace HomeWork.Lesson6.Task1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Please input string for get hash : ");
            var pref_hash = Console.ReadLine();
            Console.WriteLine($"\nYour hash is {GetHashFromString(pref_hash)}");
            Console.ReadKey();
        }

        private static double GetHashFromString(string str)
        {
            double sum = 0;
            foreach (var item in str) sum += item;
            return sum;
        }
    }
}
