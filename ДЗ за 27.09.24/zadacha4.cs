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
            else if (a%2 != 0){
                temp=0;
            }
            if (max<temp){
                    max=temp;
                }
        }
    Console.WriteLine(max);
    }
    
}
