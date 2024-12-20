using System; 
public static class Program
{
    public static void Main() 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        int max = -10000000;
        for (int i = 0; i < n; i++)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            if (g % 2 == 0)
            {
                b+=g;
            }
            else
            {
                if (max < b && b!=0)
                {
                    max = b;
                }
                b = 0;
            }
            if (max < b && i==n-1)
            {
                max = b;
            }
        } 
        Console.WriteLine(max); 
    } 
}
