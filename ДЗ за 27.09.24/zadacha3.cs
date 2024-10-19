using System;

public class HelloWorld{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        int max_second = 0;
        int max_first = 0;
        for (int i=0; i<n; i++){
            int g = Convert.ToInt32(Console.ReadLine());
            if (i==0){
                max_first=g;
            }
            if (g>max_first){
                max_second=max_first;
                max_first=g;
            }
            else if(g>max_second){
                max_second=g;
            }
        }
    Console.WriteLine(max_second);
    }
    
}
