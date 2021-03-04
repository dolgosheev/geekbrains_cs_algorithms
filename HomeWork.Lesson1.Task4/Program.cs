/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 4
 */

using System;

namespace HomeWork.Lesson1.Task4
{
    internal class Program
    {
        private static void Main()
        {

            var sqeq1 = new SquareEquation(1,-3,-4);
            var sqeq2 = new SquareEquation(1,-6,9);
            var sqeq3 = new SquareEquation(5,2,3);


            Console.WriteLine($"sq eq 1:\n {sqeq1}\n***");
            Console.WriteLine($"sq eq 2:\n {sqeq2}\n***");
            Console.WriteLine($"sq eq 3:\n {sqeq3}");

            Console.ReadKey();
        }
    }

    internal class SquareEquation
    {
        private double _discriminant;
        private readonly int _a;
        private readonly int _b;
        private readonly int _c;
        private double _x1;
        private double _x2;

        public SquareEquation(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;

            GetDiscriminant();
        }

        private void GetDiscriminant()
        {
            try
            {
                _discriminant = Math.Pow(_b, 2) - 4 * _a * _c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Can't get discriminant");
            }
        }

        private string GetRoots()
        {
            if(_discriminant >= 0)
            {
                _x1 = (-_b + Math.Sqrt(_discriminant)) / 2 * _a;
                _x2 = (-_b - Math.Sqrt(_discriminant)) / 2 * _a;
            }

            if (_x1 == 0 && _x2 == 0)
                return "The equation has no roots";

            if (Math.Abs(_x1 - _x2) == 0)
                return string.Format($"Common root is {_x1}");

            return string.Format($"Root's are: \nx1- {_x1}\nx2- {_x2}");
        }

        public override string ToString()
        {
            return GetRoots();
        }
    }
}
