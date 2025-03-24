using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "(1 + (2 * [3 / 4]) - 5)";
        bool isBalanced = CheckBrackets(input);

        if (isBalanced)
        {
            Console.WriteLine("True.");
        }
        else
        {
            Console.WriteLine("False.");
        }
    }

    static bool CheckBrackets(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
