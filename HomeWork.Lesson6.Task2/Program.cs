/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;

namespace HomeWork.Lesson6.Task2
{
    internal class Program
    {
        private static void Main()
        {
            var binTree = new BinTree<int>(9, 7, 5, 3, 1, 2, 4, 6, 8);


            binTree.PrintTree();
            Console.WriteLine();

            binTree.PrintTreeСircumvent(Type.RootLr);
            binTree.PrintTreeСircumvent(Type.LRootR);
            binTree.PrintTreeСircumvent(Type.LrRoot);

            #region examples

            Console.WriteLine(new string('-', 20));
            binTree.Remove(3);
            binTree.PrintTree();

            Console.WriteLine(new string('-', 20));
            binTree.Remove(8);
            binTree.PrintTree();

            #endregion
            Console.ReadLine();
        }
    }
}
