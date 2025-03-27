using System;
public static void Main(string[] args)
{
    Func<double, double, string> sum = (x, y) => $"{x+y}";
    Func<double, double, string> minus = (x, y) => $"{x-y}";
    Func<double, double, string> multiply = (x, y) => $"{x*y}";
    Func<double, double, string> delenie = (x, y) => 
    {
        if (y!=0){
            return $"{x/y}";
        }
        else{
            return "деление невозможно";
        }
    };
    
    Console.WriteLine(sum(3,2));
    Console.WriteLine(minus(5,1)); 
    Console.WriteLine(multiply(7,2)); 
    Console.WriteLine(delenie(5,2)); 
}