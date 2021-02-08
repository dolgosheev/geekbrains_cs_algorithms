/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 1
 */

using System;
using System.Globalization;

namespace HomeWork.Lesson1.Task1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("BMI calculation (body mass index)\n\tEnter human height ( height in metres ) : ");
            var sGrowth = Console.ReadLine();
            Console.Write("\tEnter the weight of the person ( body weight in kilograms ) : ");
            var sWeight = Console.ReadLine();

            byte.TryParse(sGrowth, out var iGrowth);
            byte.TryParse(sWeight, out var iWeight);

            int imt;
            try
            {
                imt = iWeight / (iGrowth * iGrowth);
                Console.WriteLine($"Body Mass Index (BMI) {imt.ToString(CultureInfo.InvariantCulture)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You entered an incorrect value. Height and weight must be > 0");
            }

            Console.ReadKey();
        }
    }
}