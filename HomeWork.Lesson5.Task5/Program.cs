/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;
using System.Collections.Generic;

namespace HomeWork.Lesson5.Task5
{
    internal class Program
    {
        private static void Main()
        {
            var que = new Queue<string>();

            Console.WriteLine("Queue demo\n");

            que.Enqueue("first");
            que.Enqueue("second");
            que.Enqueue("third");

            Console.WriteLine($"Start queue {string.Join('|', que.ToArray())}\n");

            var del = que.Dequeue();

            Console.WriteLine($"Delete from queue: {del}\n");

            Console.WriteLine($"Edited queue {string.Join('|', que.ToArray())}");

            Console.ReadKey();
        }
    }
}
