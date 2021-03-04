/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 6
 */

using System;

namespace HomeWork.Lesson1.Task6
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Enter age (1 to 150 years) : ");

                var tmpAge = Console.ReadLine();

                if (!int.TryParse(tmpAge, out var age))
                {
                    Console.WriteLine("\n** this is not digit **\n");
                    continue;
                }

                if (age <1 || age > 150)
                {
                    Console.WriteLine("\n** only 1 to 150 years **\n");
                    continue;
                }

                Console.WriteLine($"\nCorrect age of #{age} sounds as - {age} {GetCorrectEnd(age)}\n");
            }
        }

        private static string GetCorrectEnd(int age)
        {
            var ends = new[] { "год","года","лет"};
            var cases = new[] {2, 0, 1, 1, 1, 2};
            return ends[(age % 100 > 4 && age % 100 < 20) ? 2 : cases[Math.Min(age % 10,5)]];
        }
    }
}
