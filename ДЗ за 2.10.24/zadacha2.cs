using System; 
 
public static class Program
{
    public static void Main() 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        int max = n;
        for (int i = 0; i < n; i++)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            if (g % 2 == 0)
            {
                b++;
            }
            else{
                if (max>b){
                    max=b;
                }
                b=0;
            }
            if (i == (n-1)){
                if (max>b){
                    max=b;
                }
                Console.WriteLine(max);
            }
        } 
    } 
}



using System;
class Second
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int minima = 9999999;
        int minimaComparison = 0;
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                minimaComparison++;
            }
            else if (minimaComparison != 0)
            {
                minima = Math.Min(minima, minimaComparison);
                minimaComparison = 0;
            }
            else
            {
                minimaComparison = 0;
            }
        }
        if (minimaComparison != 0)
        {
            minima = Math.Min(minima, minimaComparison);

        }
        Console.WriteLine(minima);
    }
}