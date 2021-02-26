/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;
using System.Collections;

namespace HomeWork.Lesson5.Task3
{
    internal static class Program
    {
        private static void Main()
        {
            var stack = new Stack();
         
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Original Stack {string.Join(',', stack.ToArray())}");

            var stackNCopy = (Stack) stack.Clone();

            Console.WriteLine($"Stack Copy {string.Join(',', stackNCopy.ToArray())}");

            Console.WriteLine("\nAdd 10 to stack and 30 to stackcopy\n");
            stack.Pop();
            stack.Push(10);
            stackNCopy.Push(30);

            Console.WriteLine($"Original Stack {string.Join(',', stack.ToArray())}");
            Console.WriteLine($"Stack Copy {string.Join(',', stackNCopy.ToArray())}");

            Console.ReadKey();

        }

    }
}
