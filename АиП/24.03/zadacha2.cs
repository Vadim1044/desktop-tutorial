using System;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] horseDistances = new int[3];
        Random rand = new Random();
        int finishDistance = 500;

        Console.WriteLine("Номера лошадей: 1 2 3\n");

        while (true)
        {
            for (int i = 0; i < horseDistances.Length; i++)
            {
                horseDistances[i] += rand.Next(0, 70);
                Console.Write(horseDistances[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < horseDistances.Length; i++)
            {
                if (horseDistances[i] >= finishDistance)
                {
                    Console.WriteLine("Победила лошадь под номером " + (i + 1));
                    return;
                }
            }
        }
    }
}