/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 3
 */

using System;
using System.Collections;

namespace HomeWork.Lesson8.Task3
{
    internal class Program
    {
        private static void Main()
        {
            var ellapledTicks = DateTime.Now.Millisecond;

            var count = 100; //10000 1000000 
            var help = new Help(count, 2, 30);

            Console.WriteLine($"Start  Array : {string.Join(" ", help.Array)}");
            Console.WriteLine($"Sorted Array : {string.Join(" ", help.MergeSort())}");

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

        private void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        private int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        public int[] MergeSort()
        {
            return MergeSort(Array, 0, Array.Length - 1);
        }

        public IEnumerator GetEnumerator()
        {
            return Array.GetEnumerator();
        }
    }
}