/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 2
 */

using System;
using System.Collections;

namespace HomeWork.Lesson8.Task2
{
    internal class Program
    {
        private static void Main()
        {
            var ellapledTicks = DateTime.Now.Millisecond;

            var count = 100; //10000 1000000 
            var help = new Help(count, 2, 30);

            Console.WriteLine($"Start  Array : {string.Join(" ", help.Array)}");
            Console.WriteLine($"Sorted Array : {string.Join(" ", help.QuickSort())}");

            ellapledTicks = DateTime.Now.Millisecond - ellapledTicks;

            Console.WriteLine($"\nTime for {count} elemetns is {ellapledTicks} ms");

            Console.ReadLine();
        }
    }

    internal class Help : IEnumerable
    {
        public int[] Array { get; }

        public Help(int size, int min = 0, int max = 100)
        {
            Array = new int[size];

            for (var i = 0; i < size; i++)
                Array[i] = new Random().Next(min, max);
        }

        private int[] QuickSort(int[] array, int min, int max)
        {
            if (min >= max)
                return array;

            var index = Helper(array, min, max);
            QuickSort(array, min, index-1);
            QuickSort(array, index+1, max);

            return array;
        }

        public int[] QuickSort()
        {
            return QuickSort(Array, 0, Array.Length - 1);
        }

        private void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        private int Helper(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        public IEnumerator GetEnumerator()
        {
            return Array.GetEnumerator();
        }
    }
}