using System; 

 
public class Program
{
    public static void Main() 
    {
        Console.WriteLine("Введите оклво массивов в массиве");
        int n = int.Parse(Console.ReadLine());
        int [][] array = new int [n][];
        for (int i = 0; i<n; i++){
            Console.WriteLine("Введите колво элементов массива №" + i);
            int g = int.Parse(Console.ReadLine());
            array[i] = new int [g];
            for ( int j = 0; j<g; j++){
                Console.WriteLine("Введите элементы массива №" + i);
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }
        
        count(array);
    }

    public static void count(int[][] arr){
        
        for (int i=0; i<arr.GetLength(0); i++){
            int sum = 0;
            int max = arr[i][0];
            for (int j=0; j<arr[i].GetLength(0); j++){
                    
                sum += arr[i][j];
                if ( max < arr[i][j]){
                    max = arr[i][j];
                }
                
            }
            if ( max>(sum-max)){
                    Console.WriteLine(i);
                }
        }      
    }
}
