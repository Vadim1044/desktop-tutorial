using System;

public class HelloWorld{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int max = 0;
        for (int i=0; i<n; i++){
            int g = Convert.ToInt32(Console.ReadLine());
            if (g>max){
                a=max;
                max=g;
            }
        }
    Console.WriteLine(a);
    }
    
}