using System;
 
internal class cars
{
    static void Main()
    {
        int s = 0;
        string[][] array = new string[0][];
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("1) добавить машину");
            Console.WriteLine("2) выборка по марке");
            Console.WriteLine("3) выборка по году");
            Console.WriteLine("4) выборка по стране");
            Console.WriteLine("5) вывести все машины");
            Console.WriteLine("0) выход");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.Write("->");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (s == 0) {break; } // выход
            switch (s)
            {
                case 1:
                    Console.WriteLine("Введите кол-во машин");
                    int n = int.Parse(Console.ReadLine());
                    array = new string[n][];
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
                    output(array);
                    break;
                case 0:
                    break;
            }
        }
    }
    public static void input(string[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите название машины №" + (i + 1));
            string g = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите марку машины");
            string m = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите год производства машины");
            string y = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите страну производства");
            string c = Convert.ToString(Console.ReadLine());
            array[i] = new string[4] { g, m, y, c };
        }
    }
     
    public static void count(string[][] array, int a)
    {
        Console.Clear();
        Console.WriteLine("Введите нужную характеристику");
        string property = Convert.ToString(Console.ReadLine());
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[j] == null) continue;
     
            if (array[j][a] == property)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(array[j][i] + " ");
                }
            }
        }
        Console.WriteLine();
    }
 
    public static void output(string[][] array)
    {
        Console.Clear();
        for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                        {
                            Console.Write(array[i][j] + " ");
                        }
                        Console.WriteLine();
                }
        
    }
 
}
