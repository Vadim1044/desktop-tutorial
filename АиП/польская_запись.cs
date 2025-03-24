using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "12 4 + 4 + 4 + 4 +"; //
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
        return stack.Pop();
    }
}