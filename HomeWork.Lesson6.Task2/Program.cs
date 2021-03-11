/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 2
 */

using System;

namespace HomeWork.Lesson6.Task2
{
    internal class Program
    {
        private static void Main()
        {
            // Fill bin tree integer values
            var binTree = new BinTree<int>(9, 7, 5, 3, 1, 2, 4, 6, 8);

            // Show bentreee
            binTree.PrintTree();
            Console.WriteLine();

            // walk
            binTree.PrintTreeСircumvent(Type.RootLr); // root-left-right
            binTree.PrintTreeСircumvent(Type.LRootR); // left-root-right
            binTree.PrintTreeСircumvent(Type.LrRoot); // left-right-root

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
