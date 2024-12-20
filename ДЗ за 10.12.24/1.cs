using System;

public class cars
{
    public static void Main()
    {
        // string[] atd = new string[]();
            int i = 0; int s = 0;
            string [,] array = new string[2, 4];
            array[0,0] = "mark2";
            array[0,1] = "toyota";
            array[0,2] = "2006";
            array[0,3] = "China";
            array[1,0] = "byxanka";
            array[1,1] = "vaz";
            array[1,2] = "1980";
            array[1,3] = "SSSR";

        //     while (i!=6){
            
            Console.WriteLine("Please, choose an active:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("1) add auto");
            Console.WriteLine("2) viborka po marke");
            Console.WriteLine("3) viborka po year");
            Console.WriteLine("4) viborka po country");
            Console.WriteLine("5) exit");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.Write("->"); 
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            // Console.WriteLine("i = " + i); 
            
            switch (s)
            {
                case 1:
                    input(array);
                    break;
                case 2:
                    count(array, 1);
                    break;
                case 3:
                    count(array, 2);
                    break;
                case 4:
                    count(array, 3);
                    break;
                case 5:
                    count(array, 4);
                    break;
            }
    }
    
    public  static void input(string [,] array)
    {
        Console.WriteLine("Введите колво машин");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите название машины №" + i+1);
            array[i,0] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите марку машины");
            array[i,1] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите год производства машины");
            array[i,2] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите страну производства");
            array[i,3] = Convert.ToString(Console.ReadLine());
        }
    }
    
    public  static void count(string [,] array, int a)
    {
        Console.Clear();
        Console.WriteLine("Введите нужную характеристику");
        string property = Convert.ToString(Console.ReadLine());
        for (int j = 0;j<array.GetLength(0); j++){
            if (array[j,a] == property){
                for (int i = 0; i<4; i++){
                    Console.Write(array[j,i] + " ");
                }
            }
        }
        Console.WriteLine();
    }
    
        public  static void output(string [,] array, int s)
    {
        Console.Clear();
        for (int j = 0; j<4; j++){
            Console.Write(array[s,j] + " ");
        }
        Console.WriteLine();
        Main();
    }
}