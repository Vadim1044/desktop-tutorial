using System;
using System.Collections.Generic;
using System.Linq;


public class Furniture
{
    public string Name {get;set;}
    public string ManufacturerCity {get; set;}
    public decimal Price {get; set;}

    public Furniture(string name,string manufacturerCity,decimal price)
    {
        Name = name;
        ManufacturerCity = manufacturerCity;
        Price = price;
    }
}

public class Chairs : Furniture
{
    public bool Soft {get; set;}
    public int NumberOfLegs { get; set; }

    public Chairs(string name, string manufacturerCity, decimal price,bool soft,int numberOfLegs)
    : base(name, manufacturerCity, price)
    {
        Soft = soft;
        NumberOfLegs = numberOfLegs;
    }
}


public class Tables : Furniture
{
    public int NumberOfLegs {get;set;}
    public string TabletopType {get; set;}

    public Tables(string name, string manufacturerCity, decimal price, int numberOfLegs, string tabletopType)
    : base(name, manufacturerCity, price)
    {
        NumberOfLegs = numberOfLegs;
        TabletopType = tabletopType;
    }
}

class Program
{
    static List<Furniture> database = new List<Furniture>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Furniture");
            Console.WriteLine("2. Query Furniture");
            Console.WriteLine("3. Exit");
            
            Console.WriteLine("***************************************");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    AddFurniture();
                    break;
                case "2":
                    QueryFurniture();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddFurniture()
    {
        Console.Write("Enter name (chair or table): ");
        string name = Console.ReadLine();
        Console.Write("Enter manufacturer city: ");
        string manufacturerCity = Console.ReadLine();
        Console.Write("Enter price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        if (name.ToLower()=="chair")
        {
            Console.Write("Enter soft (true/false): ");
            bool soft = bool.Parse(Console.ReadLine());
            Console.Write("Enter number of legs: ");
            int numberOfLegs = int.Parse(Console.ReadLine());
            database.Add(new Chairs(name, manufacturerCity, price, soft, numberOfLegs));
        }
        else if (name.ToLower()== "table")
        {
            Console.Write("Enter number of legs: ");
            int numberOfLegs = int.Parse(Console.ReadLine());
            Console.Write("Enter tabletop type: ");
            string tabletopType = Console.ReadLine();
            database.Add(new Tables(name, manufacturerCity, price, numberOfLegs, tabletopType));
        }
        else
        {
            Console.WriteLine("Invalid name. Please try again.");
        }
    }


    static void QueryFurniture()
    {
        Console.WriteLine();
        Console.WriteLine("***************************************");
        Console.WriteLine("Select query critery:");
        Console.WriteLine("1. By manufacturer city");
        Console.WriteLine("2.By number of legs");
        Console.WriteLine("3. By number of chairs");
        
        Console.WriteLine("***************************************");
        Console.Write("Select an option:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter manufacturer city: ");
                string city = Console.ReadLine();
                var result = database.Where(f => f.ManufacturerCity == city).ToList();
                DisplayResult(result);
                break;
            case "2":
                Console.Write("Enter number of legs table: ");
                int legs1 = int.Parse(Console.ReadLine());
                var result2 = database.Where(f =>
                f is Tables table&&table.NumberOfLegs == legs1).ToList();
                DisplayResult(result2);
                break;
            case "3":
                Console.Write("Enter number of legs chair: ");
                int legs2 = int.Parse(Console.ReadLine());
                var result3 = database.Where(f =>
                f is Chairs chair&&chair.NumberOfLegs == legs2).ToList();
                DisplayResult(result3);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void DisplayResult(List<Furniture> result)
    {
        foreach (var furniture in result)
        {
            Console.WriteLine($"Name: {furniture.Name}, City: {furniture.ManufacturerCity}, Price: {furniture.Price}");
            if (furniture is Chairs chair)
            {
                Console.WriteLine($"Soft: {chair.Soft}, Number of Legs: {chair.NumberOfLegs}");
            }
            else if (furniture is Tables table)
            {
                Console.WriteLine($"Number of Legs: {table.NumberOfLegs}, Tabletop Type: {table.TabletopType}");
            }
        }
    }
}
