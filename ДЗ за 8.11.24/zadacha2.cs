using System; 

 
public class Program
{
    public static void Main() 
    {

        Console.WriteLine("колво столбцов в массиве:");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("колво элементов в столбце':");
        int lengthElem = int.Parse(Console.ReadLine());
        int [,] array = new int[length, lengthElem];
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Введите элементы массива №") ;
            for (int j = 0; j < lengthElem; j++)
            {
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }
        
        Maxmin(array);
        output(array);
    }
    public static void output(int[,] array)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
                if (j == (array.GetLength(1)-1)){
                    Console.Write(",");
                }
            }
        }
    }


    public static void Maxmin(int[,] array){
        int tempMax = array[0,0];
        int tempMin = array[0,0];
        int Min = 0;
        int Max = 0;
        for (int i=0; i<array.GetLength(0); i++){
            for (int j=0; j<array.GetLength(1); j++){
                    
                if (array[i,j]>tempMax){
                    Max = i;
                    tempMax = array[i,j];
                }
                if (array[i,j]<tempMin){
                    Min = i;
                    tempMin = array[i,j];
                }
                
            }
        }
        for (int i = 0; i<array.GetLength(1); i++){
            int temp = array[Max, i];
            array[Max, i] = array[Min, i];
            array[Min, i] = temp;
        }

        
    }
}