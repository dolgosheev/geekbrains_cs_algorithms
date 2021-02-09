/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 2
 */

using System;

namespace HomeWork.Lesson3.Task2
{
    internal static class Program
    {
        private static void Main()
        {
            var arr = new int[100];

            long countShakerSort = 0;

            arr.ArrFiller();

            var arrayForShaker = new int[arr.Length];
            Array.Copy(arr, arrayForShaker, arr.Length);

            countShakerSort = ArrayBubbleSort(arrayForShaker, countShakerSort);
            Console.WriteLine($"For array length {arr.Length} shaker sort count is {countShakerSort}");

            // for check
            //Array.ForEach(arrayForShaker, Console.WriteLine);

        }

        private static void ArrFiller(this int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 100);
            }
        }

        private static void ReverseInt(int x, int y, ref int[] arr)
        {
            var varA = arr[x];
            var varB = arr[y];

            varA ^= varB;
            varB ^= varA;
            varA ^= varB;

            arr[x] = varA;
            arr[y] = varB;

        }

        private static long ArrayBubbleSort(int[] arr, long shakerCount)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            for (var j = i + 1; j < arr.Length; j++)
                if (arr[i] > arr[j])
                {
                    ReverseInt(i, j, ref arr);
                    shakerCount++;
                }


            for (var i = 0; i < arr.Length / 2; i++)
            {
                bool flag = false;
                // ->
                for (var j = i; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[++j])
                    {
                        ReverseInt(j, ++j, ref arr);
                        flag = true;
                        shakerCount++;
                    }
                }

                // <-
                for (var j = arr.Length - 2 - i; j > i; j--)
                {
                    if (arr[--j] > arr[j])
                    {
                        ReverseInt(--j, j, ref arr);
                        flag = true;
                        shakerCount++;
                    }
                }

                if(!flag)
                    break;
            }

            return shakerCount;
        }
    }
}