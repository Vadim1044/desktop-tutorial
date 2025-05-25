using System;

class program
{
    public static void Main()
    {
        Console.Write("Сколько чисел проверить?");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];
        
        Console.WriteLine($"Введите {count} чисел:");
        for (int i = 0; i < count; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nНайденные палиндромы:");
        foreach (int num in numbers)
        {
            if (IsPalindrome(num))
                Console.WriteLine(num);
        }
            
    }

    static bool IsPalindrome(int number)
    {
        string s = number.ToString();
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        
                
        return true;
    }
}