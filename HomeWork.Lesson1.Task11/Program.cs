/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 11
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Lesson1.Task11
{
    internal class Program
    {
        private static void Main()
        {
            string inpS;
            var inputDigits = new List<int>();

            do
            {

                Console.WriteLine("* Press 0 for exit");
                Console.Write("Please input digit : ");
                inpS = Console.ReadLine();

                if (!int.TryParse(inpS, out var inpI))
                {
                    Console.WriteLine("\n** this is not digit **\n");
                    continue;
                }

                if(inpI != 0)
                    inputDigits.Add(inpI);

            } while (inpS != "0");

            Console.WriteLine($"Getted digits is {string.Join(',',inputDigits)}");

            inputDigits = inputDigits.Where(r=> ( ( r % 10) == 8) && r > 0).ToList();

            Console.WriteLine($"Average from {string.Join(',', inputDigits)} is {(inputDigits.Aggregate((a,b)=>a+b)/inputDigits.Count)}");

            Console.ReadKey();
        }
    }
}
