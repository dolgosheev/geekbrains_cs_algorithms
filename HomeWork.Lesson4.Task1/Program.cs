/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 4
 */

using System;

namespace HomeWork.Lesson4.Task1
{
    internal static class Program
    {
        private static readonly int[][] Map = {
            new[] {1,1,1},
            new[] {0,1,0},
            new[] {0,1,0}
        };


        private static void Main()
        {
            Console.WriteLine($"Route counts is {Map.SearchRouteCounts()}");
        }

        private static int SearchRouteCounts(this int[][] map)
        {
            int routes = default;

            for (var i = 1; i <= map.GetUpperBound(0); i++)
            {
                for (var j = 1; j <= map[i].GetUpperBound(0); j++)
                {
                    if (map[i][j] == 0) continue;

                    map[i][j] = map[i][j - 1] + map[i - 1][j];
                    routes = map[i][j] > routes ? map[i][j] : routes;
                }
            }

            return routes;
        }

    }


}
