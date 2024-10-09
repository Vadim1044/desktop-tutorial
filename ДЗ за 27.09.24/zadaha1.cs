using System;

public class HelloWorld{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int b = 0;
        int min = 0;
        for (int i=0; i<n; i++){
            int g = Convert.ToInt32(Console.ReadLine());
            if (i == 0){
                a=g;
            }
            else if (i == 1){
                b=g;
            }
            if (i<n && i>1){
                if(g>b && a>b){
                    min+=1;
                }
            a=b;
            b=g;
            }
        }
    Console.WriteLine(min);
    }
    
}