// делегаты 13.03.25 1 задание
using System;

public delegate int CalculationDelegate(Calculator calculator);

public struct Calculator
{
    public int FirstOperand { get; set; }
    public int SecondOperand { get; set; }

    public Calculator(int firstOperand, int secondOperand)
    {
        FirstOperand = firstOperand;
        SecondOperand = secondOperand;
    }

    public static int Add(int firstOperand, int secondOperand)
    {
        return firstOperand + secondOperand;
    }

    public static int Subtract(int firstOperand, int secondOperand)
    {
        return firstOperand - secondOperand;
    }

    public static int Multiply(int firstOperand, int secondOperand)
    {
        return firstOperand * secondOperand;
    }

    public static int Divide(int firstOperand, int secondOperand)
    {
        if (secondOperand == 0) return 0;
        return firstOperand / secondOperand;
    }
}

internal struct Program
{
    private static void Main(string[] args)
    {
        Calculator firstCalculator = new Calculator(10, 2);

        CalculationDelegate firstCalculation = delegate(Calculator calculator)
        {
            int result = Calculator.Add(calculator.FirstOperand, calculator.SecondOperand);
            result = Calculator.Subtract(result, calculator.SecondOperand);
            result = Calculator.Divide(result, calculator.SecondOperand);
            return result;
        };

        Calculator secondCalculator = new Calculator(5, 2);

        CalculationDelegate secondCalculation = delegate(Calculator calculator)
        {
            int result = Calculator.Multiply(calculator.FirstOperand, calculator.SecondOperand);
            result = Calculator.Add(result, calculator.FirstOperand);
            return result;
        };

        Console.WriteLine(firstCalculation(firstCalculator));
        Console.WriteLine(secondCalculation(secondCalculator));
    }
}