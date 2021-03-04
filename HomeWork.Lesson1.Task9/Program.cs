﻿/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 9
 */

using System;

namespace HomeWork.Lesson1.Task9
{
    internal class Program
    {
        private static void Main()
        {
            var n = 23;
            var k = 12;

            int balance = default;

            while (n>=k)
            {
                balance++;
                n--;
            }

            Console.WriteLine(balance);
            Console.ReadKey();
        }
    }
}
