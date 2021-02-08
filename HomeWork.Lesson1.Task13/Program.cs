/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 13
 */

using System;
using System.Threading;

namespace HomeWork.Lesson1.Task13
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine($" *standart* New random from 1 to 100 is {new Random().Next(1,101)}");
                Thread.Sleep(1000);

                var start = DateTime.Now;
                var time = DateTime.Now - start;

                Console.WriteLine($" *non standart* New random from 1 to 100 is {time.Ticks % 100}");
            }
        }

    }
}
