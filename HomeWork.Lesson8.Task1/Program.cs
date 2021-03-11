/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 1
 */

using System;
using System.Collections;

namespace HomeWork.Lesson8.Task1
{
    internal class Program
    {
        private static void Main()
        {
            var ellapledTicks = DateTime.Now.Millisecond;

            var count = 100; //10000 1000000 
            var help = new Help(count, 2, 30);

            Console.WriteLine($"Start  Array : {string.Join(" ",help.Array)}");
            Console.WriteLine($"Sorted Array : {string.Join(" ",help.BasicCountingSort())}");

            ellapledTicks = DateTime.Now.Millisecond - ellapledTicks;

            Console.WriteLine($"\nTime for {count} elemetns is {ellapledTicks} ms");

            Console.ReadLine();
        }
    }

    internal class Help : IEnumerable
    {
        public int[] Array { get; }
        private int _max;

        public Help(int size,int min = 0,int max = 100)
        {
            _max = max;
            Array = new int[size];

            for (var i = 0; i < size; i++)
                Array[i] = new Random().Next(min, _max);
        }

        public int[] BasicCountingSort()
        {
            var count = new int[_max];
            for (var i = 0; i < Array.Length; i++)
            {
                count[Array[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    Array[index] = i;
                    index++;
                }
            }

            return Array;
        }

        public IEnumerator GetEnumerator()
        {
            return Array.GetEnumerator();
        }
    }
}
