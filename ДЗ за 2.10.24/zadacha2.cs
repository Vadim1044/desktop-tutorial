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