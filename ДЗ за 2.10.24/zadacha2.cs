using System;
class Second
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int min = 9999999;
        int minComparison = 0;
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                minComparison++;
            }
            else if (minComparison != 0)
            {
                min = Math.Min(min, minComparison);
                minComparison = 0;
            }
            else
            {
                minComparison = 0;
            }
        }
        if (minComparison != 0)
        {
            min = Math.Min(min, minComparison);

        }
        Console.WriteLine(min);
    }
}
