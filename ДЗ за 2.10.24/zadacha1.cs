using System;

public class HelloWorld{
    public static void Main(){
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int max = 0;
        int temp = 1;
        for (int i=0; i<n; i++){
            int g = Convert.ToInt32(Console.ReadLine());
            if (i == 0){
                a=g;
            }
            if (i<n && i>0){
                if (g==a){
                    temp+=1;
                }
                else if (g!=a){
                    if (max<temp){
                        max=temp;
                    }
                    temp=1;
                }
                a=g;
            }
            if (i == (n-1)){
                Console.WriteLine(max);
            }
        }
    }
    
}