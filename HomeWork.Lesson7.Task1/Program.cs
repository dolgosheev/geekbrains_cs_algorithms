/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 1
 */

using System;

namespace HomeWork.Lesson7.Task1
{
    internal class Program
    {
        private static void Main()
        {
            // create new graph
            var graph = new Graph();

            // vortex addition
            graph.AddVertex("A","B","C","D","E","F","G","H","I","J","K");

            //добавление ребер
            graph.RibAddition("A", "B", 67);
            graph.RibAddition("A", "C", 17);
            graph.RibAddition("A", "D", 52);
            graph.RibAddition("A", "E", 36);

            graph.RibAddition("B", "C", 84);
            graph.RibAddition("B", "F", 13);

            graph.RibAddition("C", "D", 93);
            graph.RibAddition("C", "F", 12);
            graph.RibAddition("C", "G", 27);

            graph.RibAddition("D", "F", 32);
            graph.RibAddition("D", "G", 31);
            graph.RibAddition("D", "E", 26);

            graph.RibAddition("E", "G", 28);

            graph.RibAddition("F", "H", 25);
            graph.RibAddition("F", "I", 83);
            graph.RibAddition("F", "G", 38);


            graph.RibAddition("G", "I", 27);
            graph.RibAddition("G", "J", 67);

            graph.RibAddition("H", "K", 67);
            graph.RibAddition("H", "I", 67);

            graph.RibAddition("I", "K", 47);
            graph.RibAddition("I", "J", 91);

            graph.RibAddition("J", "K", 22);


            var dijkstraAlgorithm = new ShortestPath(graph);

            var calcedPath = dijkstraAlgorithm.FindShortestPath("A", "K");

            Console.WriteLine($"Shotes path is | {calcedPath}");
            Console.ReadLine();
        }
    }

    /*
    
              A
        /   |   |   \
        B - C - D - E
        \   | X |  /
           F  -  G
         /  \   / \
         H    I    J
          \   |   /
              K

     */
}
