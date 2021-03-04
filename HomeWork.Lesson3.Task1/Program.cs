/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 1
 */

using System;

namespace HomeWork.Lesson3.Task1
{
    internal static class Program
    {
        private static void Main()
        {
            var arr = new int[100];

            long countBubbleSort = 0;

            arr.ArrFiller();

            var arrayForBubble = new int[arr.Length];
            Array.Copy(arr, arrayForBubble,arr.Length);

            countBubbleSort = ArrayBubbleSort(arrayForBubble, countBubbleSort);
            Console.WriteLine($"For array length {arr.Length} bubble sort count is {countBubbleSort}");
            
            // for check
            //Array.ForEach(arrayForBubble,Console.WriteLine);

        }

        private static void ArrFiller(this int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1,100);
            }
        }

        private static void ReverseInt(int x, int y,ref int[] arr)
        {
            var varA = arr[x];
            var varB = arr[y];

            varA ^= varB;
            varB ^= varA;
            varA ^= varB;

            arr[x] = varA;
            arr[y] = varB;

        }

        private static long ArrayBubbleSort(int[] arr, long bubbleCount)
        {
            for (var i = 0; i < arr.Length - 1; i++)
                for (var j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        ReverseInt(i,j,ref arr); 
                        bubbleCount++;
                    }

            return bubbleCount;
        }
    }
}
