using System;
using System.Collections.Generic;
using System.Linq;

public class Airplane
{
    public string DepartureCity {get; set;}
    public string ArrivalCity {get;set;}
    public TimeSpan FlightDuration {get; set;}
    public string AirplaneName {get; set;}

    public Airplane(string departureCity, string arrivalCity, TimeSpan flightDuration,string airplaneName)
    {
        DepartureCity = departureCity;
        ArrivalCity = arrivalCity;
        FlightDuration = flightDuration;
        AirplaneName = airplaneName;
    }
}


public class City
{
    public string Name {get; set;}
    public List<Airplane> Airplanes {get; set;}

    public City(string name)
    {
        Name = name;
        Airplanes = new List<Airplane>();
    }
}
class Program
{
    static List<City> cities = new List<City>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("menu:");
            Console.WriteLine("1. add city and plane");
            Console.WriteLine("2.query by arrival city or name of plane");
            Console.WriteLine("3. Exit");
            Console.WriteLine("***************************************");
            Console.Write("choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCityAndAirplanes();
                    break;
                case "2":
                    QueryAirplanes();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("invalid choice.");
                    break;
            }
        }
    }

    static void AddCityAndAirplanes()
    {
            Console.Write("enter departure city: ");
            string departureCity = Console.ReadLine();
            Console.Write("enter arrival city: ");
            string arrivalCity = Console.ReadLine();
            string cityName=arrivalCity;
            City city =new City(cityName);
            Console.Write("enter flight time (hours:minutes): ");
            TimeSpan flightDuration = TimeSpan.Parse(Console.ReadLine());
            Console.Write("enter name of plane: ");
            string airplaneName = Console.ReadLine();

            city.Airplanes.Add(new Airplane(departureCity, arrivalCity, flightDuration, airplaneName));
        cities.Add(city);
    }

    static void QueryAirplanes()
    {
        Console.WriteLine();
        Console.WriteLine("***************************************");
        Console.WriteLine("choose critery of query:");
        Console.WriteLine("1. by arrival city");
        Console.WriteLine("2. by name of plane ");
        Console.WriteLine("***************************************");
        Console.Write("Choose an option:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("enter arrival city: ");
                string arrivalCity = Console.ReadLine();
                var result = cities.SelectMany(c => c.Airplanes).Where(a => a.ArrivalCity == arrivalCity).ToList();
                DisplayResult(result);
                break;
            case "2":
                Console.Write("enter name of plane:");
                string airplaneType = Console.ReadLine();
                var result2 = cities.SelectMany(c => c.Airplanes).Where(a => a.AirplaneName == airplaneType).ToList();
                DisplayResult(result2);
                break;
            default:
                Console.WriteLine("invalid choice.");
                break;
        }
    }

    static void DisplayResult(List<Airplane> result)
    {
        foreach (var airplane in result)
        {
            Console.WriteLine($"departure city: {airplane.DepartureCity}, arrival city:{airplane.ArrivalCity}, flight time : {airplane.FlightDuration}, name: {airplane.AirplaneName}");
        }
    }
}
