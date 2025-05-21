using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        List<string[]> cars = new List<string[]>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1) Добавить машину");
            Console.WriteLine("2) Удалить последнюю машину");
            Console.WriteLine("3) Выборка по году выпуска");
            Console.WriteLine("4) Выборка по марке");
            Console.WriteLine("5) Выборка по городу регистрации");
            Console.WriteLine("6) Выход");

            string choice = Console.ReadLine();

            if (choice == "6"){break;} 

            switch (choice)
            {
                case "1": // Добавление машины
                    Console.WriteLine("Введите через пробел ");
                    Console.WriteLine("год_выпуска марка город_регистрации");
                    string[] carData = Console.ReadLine().Split(' ');
                    if (carData.Length < 3)
                    {
                        Console.WriteLine("Ошибка: нужно ввести 3 значения");
                        Console.ReadKey();
                        continue;
                    }
                    cars.Add(new[] { carData[0], carData[1], carData[2] });
                    break;

                case "2":
                    if (cars.Count == 0)
                    {
                        Console.WriteLine("Список машин пуст!");
                    }
                    else
                    {
                        cars.RemoveAt(cars.Count - 1);
                        Console.WriteLine("Последняя машина удалена.");
                    }
                    break;

                case "3":
                    Console.Write("Введите год: ");
                    string year = Console.ReadLine();
                    bool found = false;
                    foreach (var car in cars)
                    {
                        if (car[0] == year)
                        {
                            Console.WriteLine($"{car[0]} {car[1]} {car[2]}");
                            found = true;
                        }
                    }
                    if (!found) Console.WriteLine("Машин такого года нет.");
                    break;

                case "4":
                    Console.Write("Введите марку: ");
                    string mark = Console.ReadLine();
                    found = false;
                    foreach (var car in cars)
                    {
                        if (car[1] == mark)
                        {
                            Console.WriteLine($"{car[0]} {car[1]} {car[2]}");
                            found = true;
                        }
                    }
                    if (!found) Console.WriteLine("Машин такой марки нет.");
                    break;

                case "5":
                    Console.Write("Введите город: ");
                    string city = Console.ReadLine();
                    found = false;
                    foreach (var car in cars)
                    {
                        if (car[2] == city)
                        {
                            Console.WriteLine($"{car[0]} {car[1]} {car[2]}");
                            found = true;
                        }
                    }
                    if (!found) Console.WriteLine("Машин из этого города нет.");
                    break;

                default:
                    Console.WriteLine("Неверная команда!");
                    break;
            }
        }
    }
}