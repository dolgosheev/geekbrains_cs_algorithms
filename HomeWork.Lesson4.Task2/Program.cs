/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 4
 */

using System;

namespace HomeWork.Lesson4.Task2
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("You should type 2 strings for matrix build, so\nfirst : ");
            var str1 = Console.ReadLine();
            Console.Write("second : ");
            var str2 = Console.ReadLine();

            Console.WriteLine($"Max sequention from matrix is {MatrixMaxSeq(str1,str2)}");
        }

        private static int MatrixMaxSeq(string str1, string str2)
        {
            var matrix = new string[str1.Length + 2][];

            for (var i = 0; i <= str1.Length + 1; i++)
            {
                matrix[i] = new string[str2.Length + 2];
            }

            for (var i = 2; i <= str1.Length + 1; i++) matrix[i][0] = str1[i - 2].ToString();

            for (var j = 2; j <= str2.Length + 1; j++) matrix[0][j] = str2[j - 2].ToString();

            for (var i = 1; i <= str1.Length + 1; i++)
            {
                for (var j = 1; j <= str2.Length + 1; j++) matrix[i][j] = "0";
            }

            for (var i = 2; i <= matrix.GetUpperBound(0); i++)
            {
                for (var j = 2; j <= matrix[i].GetUpperBound(0); j++)
                {
                    if (matrix[i][0] == matrix[0][j])
                    {
                        matrix[i][j] = (int.Parse(matrix[i - 1][j - 1]) + 1).ToString();
                    }
                    else matrix[i][j] = Max(matrix[i - 1][j], matrix[i][j - 1]);
                }
            }


            var i_max = matrix.GetUpperBound(0);
            var j_max = matrix[i_max].GetUpperBound(0);


            return int.Parse(matrix[i_max][j_max]);

        }

        private static string Max(string str1, string str2)
        {
            return int.Parse(str1) > int.Parse(str2) ? str1 : str2;
        }
    }
}
