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

        nomer3(array);
    }
    public static void output(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0 && j != 0)
                {
                    Console.WriteLine(array[i, j]);
                }
                else
                {
                    Console.Write(array[i, j]);
                }
            }
        }
    }


    public static void nomer3(int[,] array){
        Console.WriteLine("Ответ");
        for (int i=0; i<array.GetLength(0); i++){
            int temp = 0;
            int shag = array[i,0]-array[i,1];
            for (int j=0; j<array.GetLength(1)-1; j++){
                if (array[i,j]<=array[i,j+1] || (array[i,j]-array[i,j+1])!=shag){
                    temp=1;
                }
            }
            if (temp==0){
                Console.WriteLine(i);
            }
        }
    }

}