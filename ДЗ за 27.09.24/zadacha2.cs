using System;

public class HelloWorld{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i=0; i<n; i++){
            int g = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(g)%10 == 2){
                count+=1;
            }
        }
    Console.WriteLine(count);
    }
    
}