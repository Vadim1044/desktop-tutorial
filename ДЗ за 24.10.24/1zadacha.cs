using System;

public class HelloWorld{
    public static void Main(){
        Console.Write("n=");
        int n = Convert.ToInt32(Console.ReadLine());
        int [] myArray = new int[n];
            
        
        Input(n, myArray);
        calculate(n, myArray);
        Output(myArray);
    }
    
    
    
    public static void Input(int a, int [] myArray){
        for (int i = 0; i<a; i++){
            Console.Write("A[{0}]=", i);
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    public static void calculate(int a, int [] myArray){
        for (int i = 0; i<a; i++){
            myArray[i] = myArray[i]*myArray[i];
        }
    }
    
    public static void Output(int [] myArray){
        foreach (int elem in myArray){
            Console.WriteLine("myArray={0}", elem);

        }
    }
}
