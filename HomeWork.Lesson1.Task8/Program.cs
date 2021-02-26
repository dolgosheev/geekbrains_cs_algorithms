/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 8
 */

using System;

namespace HomeWork.Lesson1.Task8
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Enter a digit : ");
                var a = Console.ReadLine();

                if (!int.TryParse(a, out var aI))
                {
                    Console.WriteLine("\n** this is not digit **\n");
                    continue;
                }

                Console.Write("Enter b digit ( b more than a ) : ");
                var b = Console.ReadLine();

                if (!int.TryParse(b, out var bI))
                {
                    Console.WriteLine("\n** this is not digit **\n");
                    continue;
                }

                if (bI <= aI || bI == 0 || aI ==0)
                {
                    Console.WriteLine("b should be less than a & not equal & is not null");
                    continue;
                }

                var difference = bI - aI;
                Console.WriteLine($"a is {aI} | b is {bI} | interval is {++difference}");

                for (var i = 0; i < difference; i++)
                {
                    Console.WriteLine($"Operation for digit {aI + i} | ^2 = {Math.Pow((aI + i),2)} | ^3 = {Math.Pow((aI + i), 3)}");
                }
            }
        }
    }
}
