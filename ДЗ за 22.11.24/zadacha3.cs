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


        public static void count(int[][] array){
        
        for (int i=0; i<array.GetLength(0); i++){
            int shag = array[i][0]-array[i][1];
            int temp = 1;
            int Min = 0;

            for (int j=0; j<array[i].GetLength(0)-1; j++){
                if (array[i][j]-array[i][j+1] == shag && shag >=0){
                    temp++;
                }
                else{
                    if (temp > Min){
                        Min = temp;
                        temp=0;
                    }
                    shag = array[i][j]-array[i][j+1];
                    if (array[i][j]-array[i][j+1] == shag && shag >=0){
                        temp++;
                    }
                    
                }
                if (j == (array[i].GetLength(0)-2)){
                    if (temp > Min){
                        Min = temp;
                    }
                }
            }
            Console.WriteLine("Min = "+(Min));
        }      
    }
}
