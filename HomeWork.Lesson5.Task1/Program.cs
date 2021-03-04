/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Lesson5.Task1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Input decimal value (for getting binary equal) : ");
            if(!int.TryParse(Console.ReadLine(), out var decDigit))
                throw new Exception("Just numbers please");

            var digitsStack = new Stack<int>();

            while (decDigit >= 2)
            {
                digitsStack.Push(decDigit % 2);
                decDigit /= 2;
            }
            digitsStack.Push(decDigit);
            var result = digitsStack.Select(r => r).ToArray();

            Console.Write("Binary equal is : ");
            Array.ForEach(result, Console.Write);

            Console.ReadLine();
        }
    }
}
