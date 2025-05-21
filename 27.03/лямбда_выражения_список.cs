using System;
using System.Collections.Generic;
using System.Linq;

using System;

public struct HelloWorld
{
    public static void Main()
    {
        List<string> words = new List<string> { "tiger", "banana", "dog", "melon", "grape", "milk" };

        List<string> count = words.Where(word => word.StartsWith("m")).ToList();

        Console.WriteLine("Слова, начинающиеся на 'm':");
        foreach (var word in count)
        {
            Console.WriteLine(word);
        }
    }
}