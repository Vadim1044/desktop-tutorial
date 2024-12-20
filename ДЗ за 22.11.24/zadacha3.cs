using System; 

 
public class Program
{
    public static void Main() 
    {
        int [][] array = new int [5][];
        array[0] = new int[6] {4,5,8,6,4,2};
        array[1] = new int[5] {2,1,2,3,6};
        array[2] = new int[3] {11,22,33};
        array[3] = new int[11] {5, 4, 3, 2, 1, 6, 5, 4, 3, 2, 1};
        array[4] = new int[3] {11,22,33};
        
        // Console.WriteLine("Введите оклво массивов в массиве");
        // int n = int.Parse(Console.ReadLine());
        // int [][] array = new int [n][];
        // for (int i = 0; i<n; i++){
        //     Console.WriteLine("Введите элементы массива №" + i);
        //     int g = int.Parse(Console.ReadLine());
        //     array[i] = new int [g];
        //     for ( int j = 0; j<g; j++){
        //         Console.WriteLine("Введите элементы массива №" + i);
        //         array[i][j] = int.Parse(Console.ReadLine());
        //     }
        // }
        
        count(array);

    }


        public static void count(int[][] array){
        
        for (int i=0; i<array.GetLength(0); i++){
            
            
            int shag = array[i][0]-array[i][1];
            int temp = 1;
            int Min = 0;

            for (int j=0; j<array[i].GetLength(0)-1; j++){
                Console.Write("i = " + i + " ");
                Console.Write("j = " + j+ " ");
                Console.Write("shag = " + shag+ " ");
                
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
                    
                    Console.Write("shag = " + shag+ " ");
                }
                
                if (j == (array[i].GetLength(0)-2)){
                    Console.Write("sex");
                    if (temp > Min){
                        Console.Write("sexxxx");
                        Min = temp;
                    }
                }
                
                Console.Write("temp = "+temp+ " ");
                Console.WriteLine("Min = " + Min);
            }
            Console.WriteLine("kon Min = "+(Min));
        }      
    }
}