/*
 * Author : Alexander Dolgosheev
 * Github : https://github.com/dolgosheev
 * Mailto : alexanderdolgosheev@gmail.com
 * Task 5
 */

using System;
using System.Collections.Generic;

namespace HomeWork.Lesson5.Task4
{
    internal class Program
    {
        private static void Main()
        {

            Console.Write($"Please input arithmetic expression : ");

            var infixString = Console.ReadLine();
            var postfixString = string.Empty;
            var lastChar = ' ';

            var stack = new Stack<char>();
            if (infixString != null)
                foreach (var ch in infixString)
                {
                    if (char.IsDigit(ch))
                    {
                        postfixString += ch;
                    }
                    else if (ch == '(')
                    {
                        stack.Push(ch);
                        lastChar = '(';
                    }
                    else if (ch == ')')
                    {
                        char temp;
                        do
                        {
                            temp = stack.Pop();
                            if (temp != '(')
                                postfixString += temp;
                        } while (temp != '(');
                    }
                    else
                    {
                        postfixString += ' ';
                        if (Priority(ch) <= Priority(lastChar))
                        {
                            postfixString += stack.Pop();
                            postfixString += ' ';
                        }

                        stack.Push(ch);
                        lastChar = ch;
                    }
                }

            while (stack.Count != 0)
            {
                postfixString += stack.Pop();
                postfixString += ' ';
            }

            Console.WriteLine($"Postfix expression is {postfixString}");
            Console.ReadKey();
        }

        private static int Priority(char ch)
        {
            switch (ch)
            {
                //case '(':
                //    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }
    }
}