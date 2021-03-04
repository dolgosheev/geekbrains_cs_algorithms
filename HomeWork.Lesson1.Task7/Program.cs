/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 7
 */

using System;

namespace HomeWork.Lesson1.Task7
{
    internal class Program
    {
        private static void Main()
        {

            while (true)
            {
                Console.WriteLine("Enter coordinates of 2 point ( like x1,y1,x2,y2 ) : \n * only positive, interval 1-8");

                var correctCoords = new int[4];
                var coordinates = Console.ReadLine();
                var coords = coordinates?.Split(',');

                if(coords?.Length > 4 || coords?.Length < 4)
                {
                    Console.WriteLine("\n ** Incorrect data,try agayn ** \n");
                    continue;
                }

                for (var i = 0; i < coords?.Length; i++)
                {
                    if (!int.TryParse(coords[i], out var rI))
                    {
                        Console.WriteLine("\n** this is not digit **\n");
                        continue;
                    }

                    correctCoords[i] = rI;
                }

                foreach (var r in correctCoords)
                {
                    if (r > 8 || r <= 0)
                    {
                        Console.WriteLine("The chessboard has dimension 8 x 8");
                        return;
                    }

                }

                var checkCoords = new Coords(correctCoords);
                Console.WriteLine(checkCoords);
            }
        }


        
    }

    internal class Coords
    {
        private readonly Ceil _p1;
        private readonly Ceil _p2;

        public Coords(int[] arr)
        {
            _p1 = new Ceil(arr[0], arr[1]);
            _p2 = new Ceil(arr[2], arr[3]);
        }

        internal class Ceil
        {
            //false = black (a1)
            private readonly double _x;
            private readonly double _y;

            internal Ceil(double x, double y)
            {
                _x = x;
                _y = y;
            }

            internal bool GetColor()
            {
                if(_x % 2 == 0 && _y % 2 != 0)
                    return true;

                return false;
            }
        }

        public override string ToString()
        {
            return (_p1.GetColor() == _p2.GetColor()) ? "similar ceils\n" : "different colors\n";
        }
    }
}
