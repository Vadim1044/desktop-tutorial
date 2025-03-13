using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "12 4 + 4 + 4 +"; //
        int result = EvaluatePostfix(input);
        Console.WriteLine($"Результат: {result}");
    }

    static int EvaluatePostfix(string expression)
    {
        Stack<int> stack = new Stack<int>();
        string[] tokens = expression.Split(' ');

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                // Если токен является числом, помещаем его в стек
                stack.Push(number);
            }
            else
            {
                // Если токен является оператором, выполняем соответствующую операцию
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(operand1 + operand2);
                        break;
                    case "-":
                        stack.Push(operand1 - operand2);
                        break;
                    case "*":
                        stack.Push(operand1 * operand2);
                        break;
                    case "/":
                        stack.Push(operand1 / operand2);
                        break;
                    default:
                        throw new InvalidOperationException($"Неизвестный оператор: {token}");
                }
            }
        }

        // Результат вычисления будет находиться на вершине стека
        return stack.Pop();
    }
}





//мой ебучий код
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
            if (c == '('  c == '['  c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')'  c == ']'  c == '}')
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