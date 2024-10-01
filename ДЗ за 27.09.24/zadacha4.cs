using System;

public class HelloWorld{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = 0;
        int max = 0;
        for (int i=0; i<n; i++){
            int a = Convert.ToInt32(Console.ReadLine());
            if (a%2 == 0){
                temp++;
            }
            if (max<temp){
                    max=temp;
                }
            else{
                temp=0;
            }
        }
    Console.WriteLine(max);
    }
    
}