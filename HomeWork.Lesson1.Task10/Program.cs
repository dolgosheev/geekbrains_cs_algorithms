/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 10
 */

using System;

namespace HomeWork.Lesson1.Task10
{
    internal class Program
    {
        private static void Main()
        {
            var n = 23;
            int counter = default;

            while (n > 0)
            {
                if ((n % 10) == 2)
                    counter++;
                n /= 10;
            }

            Console.WriteLine(counter != 0);
            Console.ReadKey();
        }
    }
}
