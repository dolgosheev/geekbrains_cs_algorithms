/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 3
 */

using System;

namespace HomeWork.Lesson1.Task3
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Program for exchanging values of two variables\n\tEnter variable A : ");
            var varA = Console.ReadLine();
            Console.Write("\tEnter variable B : ");
            var varB = Console.ReadLine();

            Console.WriteLine($"\nVariable \n\tvarA={varA}\n\tvarB={varB} ");

            // variant via 3th value
            var varC = varB;
            varB = varA;
            varA = varC;

            Console.WriteLine($"\nSwap variables (through 3d) \n\tvarA={varA}\n\tvarB={varB} ");

            // 2 variable variant
            varA += varB;
            varB = varA.Replace(varB ?? string.Empty, "");
            varA = varA.Replace(varB, "");

            Console.WriteLine($"\nSwap variables (through two) \n\tvarA={varA}\n\tvarB={varB} ");

            // 2 variable variant (for numbers only)
            ReverseInt(varA, varB);

            Console.ReadKey();
        }

        private static void ReverseInt(string x, string y)
        {
            int varA;
            int varB;
            try
            {
                varA = Convert.ToInt32(x);
                varB = Convert.ToInt32(y);

                varA ^= varB;
                varB ^= varA;
                varA ^= varB;
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nThe entered variables are not numbers\nError - {e.Message}");
                return;
            }
            Console.WriteLine($"\nSwap integer variables \n\tvarA={varA}\n\tvarB={varB} ");
        }
    }
}
