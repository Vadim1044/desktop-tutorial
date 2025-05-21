using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int minX = 0, minY = 0;
        int maxX = 500, maxY = 500;
        Random random = new Random();
        int pointX = random.Next(minX, maxX);
        int pointY = random.Next(minY, maxY);

        while (true)
        {
            Console.WriteLine($"X: {pointX}; Y: {pointY}");
            if (pointX < minX || pointX > maxX || pointY < minY || pointY > maxY)
            {
                Console.WriteLine("Точка вышла за пределы пространства");
                break;
            }
            pointX += random.Next(-50, 50);
            pointY += random.Next(-50, 50);
        }
    }
}