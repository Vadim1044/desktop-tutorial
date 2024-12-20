using System; 

 
public class Program
{
    public static void Main() 
    {
        int [][] array = new int [3][];
        array[0] = new int[5];
        array[1] = new int[5];
        array[2] = new int[3];
        array[0] = new int[0] {1,3,5,7,9};
        array[1] = new int[0] {0,2,4,6,50};
        array[2] = new int[0] {11,22,13};
        
        
        count(array);
        output(array);
    }
    // public static void output(int[,] array)
    // {
    //     int temp = 0;
    //     for (int i = 0; i < array.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < array.GetLength(1); j++)
    //         {
    //             Console.Write(array[i, j]);
    //             if (j == (array.GetLength(1)-1)){
    //                 Console.Write(",");
    //             }
    //         }
    //     }
    // }


    public static void count(int[][] array){
        
        for (int i=0; i<array.GetLength(0); i++){
            int sum = 0;
            int Max = array[i][0];
            for (int j=0; j<array[0].GetLength(0); j++){
                    
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