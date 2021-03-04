/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;
using System.Collections.Generic;

namespace HomeWork.Lesson5.Task2
{
    internal class Program
    {
        private static void Main()
        {
            

            Console.Write("Please input brackets sequentiion like ([]) : ");
            var getString = Console.ReadLine();

            var flag = true;

            var bracesStack = new Stack<char>();

            if (getString != null)
                foreach (var c in getString)
                {
                    if (IsLeft(c)) bracesStack.Push(c);
                    else if (WhoIs(c) != ' ')
                    {
                        if (bracesStack.Count == 0)
                        {
                            flag = false;
                            break;
                        }

                        if (WhoIs(c) != bracesStack.Pop())
                        {
                            flag = false;
                        }
                    }
                }

            if (bracesStack.Count != 0) flag = false;

            Console.WriteLine("Sequention is {0}", flag ? "right" : "wrong");
            Console.ReadLine();
        }

        private static bool IsLeft(char bracket)
        {
            switch (bracket)
            {
                case '{':
                    return true;
                case '[':
                    return true;
                case '(':
                    return true;
                default:
                    return false;
            }
        }

        private static char WhoIs(char bracket)
        {
            switch (bracket)
            {
                case '}':
                    return '{';
                case ']':
                    return '[';
                case ')':
                    return '(';
                default:
                    return ' ';
            }

        }
    }
}
