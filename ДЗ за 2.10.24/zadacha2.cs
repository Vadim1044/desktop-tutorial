using System; 
 
public static class Program
{
    public static void Main() 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        int min = n;
        for (int i = 0; i < n; i++)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            if (g % 2 == 0)
            {
                b++;
            }
            if(g % 2 != 0 || i == (n-1)){
                if (min>b && b!=0){
                    min=b;
                }
                b=0;
            }
        } 
        Console.WriteLine(min);
    } 
}
