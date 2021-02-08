/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 14
 */

using System;
using System.Collections.Generic;

namespace HomeWork.Lesson1.Task14
{
    internal class Program
    {
        private static void Main()
        {
            var automorphic = new Automorphic(200);
            automorphic.ShowAutomorphic();
        }
    }

    internal class Automorphic
    {
        public List<int> Digits = new List<int>();

        public Automorphic(int count)
        {
            if(count <= 0)
                throw new Exception("Need more than 0");

            for (var i = count; i > 0; i--)
            {
                Digits.Add(i);
            }
        }

        public void ShowAutomorphic()
        {

            foreach (var i in Digits)
            {
                var pow = Math.Pow(i, 2);

                    if ((pow % (i >= 10 ? 100 : 10) ) == i)
                        Console.WriteLine(i);
            }

        }
    }


}
