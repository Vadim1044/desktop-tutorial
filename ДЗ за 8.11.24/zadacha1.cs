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

        count(array);

    }
    public static void count(int[,] array)
    {
        Console.WriteLine("столбцы, в которых стоят одинаковые элементы:");
        int temp = 0;
        int first=0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp=i;
            for (int j = temp + 1; j < array.GetLength(0); j++)
            {
                int sum1 = 0;
                int sum2 = 0;
                int temp1 = 1;
                int temp2 = 1;

                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[temp, k] != 0 && array[j, k] != 0)
                    {
                        temp1 *= array[temp, k];
                        temp2 *= array[j, k];
                        sum1 += array[temp, k];
                        sum2 += array[j, k];

                    }
                }
                if (temp1 == temp2 && sum1 == sum2)
                    {
                        i = array.GetLength(0);
                        if (first == 0){
                            Console.WriteLine(temp);
                            first++;
                        }
                        Console.WriteLine(j);
                    }        
            }
        }
    }

}