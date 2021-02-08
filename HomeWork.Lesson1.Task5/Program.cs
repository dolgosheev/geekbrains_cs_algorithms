/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;

namespace HomeWork.Lesson1.Task5
{
    internal class Program
    {
        private static void Main()
        {
            while(true)
            {
                Console.Write("Enter month number for the year time : ");

                var tmpmonth = Console.ReadLine();

                if (!int.TryParse(tmpmonth, out var month))
                {
                    Console.WriteLine("\n** this is not digit **\n");
                    continue;
                }

                Console.WriteLine($"\nMonth #{month} is - {GetSeasonByMonth(month)}\n");
            }
        }


        private static string GetSeasonByMonth(int month)
        {
            if (month > 12) return "Only 12 months per year";
            if (month < 3 || month == 12) return "Winter";
            if (month < 6) return "Spring";
            if (month < 9) return "Summer";
            return "Autumn";
        }
    }
}
