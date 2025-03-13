using System;
using System.Collections.Generic;
using System.Linq;

class PhoneEntry
{
    public string Number { get; set; }
    public string Operator { get; set; }
    public int YearRegistered { get; set; }

    public PhoneEntry(string number, string operatorName, int yearRegistered)
    {
        Number = number;
        Operator = operatorName;
        YearRegistered = yearRegistered;
    }

    public override string ToString()
    {
        return $"{Number} | {Operator} | {YearRegistered}";
    }
}

class Owner
{
    public string FullName { get; set; }
    public string City { get; set; }
    public List<string> PhoneNumbers { get; set; }

    public Owner(string fullName, string city)
    {
        FullName = fullName;
        City = city;
        PhoneNumbers = new List<string>();
    }

    public void AddPhoneNumber(string number)
    {
        PhoneNumbers.Add(number);
    }

    public override string ToString()
    {
        return $"{FullName} | {City} | Номера: {string.Join(", ", PhoneNumbers)}";
    }
}

class PhoneBook
{
    private List<PhoneEntry> phoneEntries = new List<PhoneEntry>();
    private List<Owner> owners = new List<Owner>();

    public void AddPhoneEntry(string number, string operatorName, int yearRegistered)
    {
        phoneEntries.Add(new PhoneEntry(number, operatorName, yearRegistered));
    }

    public void AddOwner(string fullName, string city, List<string> phoneNumbers)
    {
        Owner owner = new Owner(fullName, city);
        foreach (var number in phoneNumbers)
        {
            owner.AddPhoneNumber(number);
        }
        owners.Add(owner);
    }

    public List<PhoneEntry> GetEntriesByOperator(string operatorName)
    {
        return phoneEntries.Where(entry => entry.Operator.Equals(operatorName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<PhoneEntry> GetEntriesByYear(int year)
    {
        return phoneEntries.Where(entry => entry.YearRegistered == year).ToList();
    }

    public Owner GetOwnerByPhoneNumber(string number)
    {
        return owners.FirstOrDefault(owner => owner.PhoneNumbers.Contains(number));
    }

    public void DisplayAllEntries()
    {
        Console.WriteLine("Телефонные записи:");
        foreach (var entry in phoneEntries)
        {
            Console.WriteLine(entry);
        }
        
        Console.WriteLine("\nВладельцы:");
        foreach (var owner in owners)
        {
            Console.WriteLine(owner);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить телефонный номер");
            Console.WriteLine("2. Добавить владельца");
            Console.WriteLine("3. Поиск по оператору");
            Console.WriteLine("4. Поиск по году постановки на учет");
            Console.WriteLine("5. Поиск владельца по номеру телефона");
            Console.WriteLine("6. Показать все записи");
            Console.WriteLine("0. Выходные");
            Console.Write("Выберите действие: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Введите номер телефона: ");
                    string number = Console.ReadLine();
                    Console.Write("Введите название оператора: ");
                    string operatorName = Console.ReadLine();
                    Console.Write("Введите год постановки на учет: ");
                    int yearRegistered = int.Parse(Console.ReadLine());
                    phoneBook.AddPhoneEntry(number, operatorName, yearRegistered);
                    break;                case "2":
                    Console.Write("Введите ФИО владельца: ");
                    string fullName = Console.ReadLine();
                    Console.Write("Введите город проживания: ");
                    string city = Console.ReadLine();
                    Console.Write("Введите номера телефонов (через запятую): ");
                    List<string> phoneNumbers = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
                    phoneBook.AddOwner(fullName, city, phoneNumbers);
                    break;

                case "3":
                    Console.Write("Введите название оператора для поиска: ");
                    string searchOperator = Console.ReadLine();
                    var entriesByOperator = phoneBook.GetEntriesByOperator(searchOperator);
                    Console.WriteLine($"Записи для оператора '{searchOperator}':");
                    foreach (var entry in entriesByOperator)
                    {
                        Console.WriteLine(entry);
                    }
                    break;

                case "4":
                    Console.Write("Введите год для поиска: ");
                    int searchYear = int.Parse(Console.ReadLine());
                    var entriesByYear = phoneBook.GetEntriesByYear(searchYear);
                    Console.WriteLine($"Записи для года '{searchYear}':");
                    foreach (var entry in entriesByYear)
                    {
                        Console.WriteLine(entry);
                    }
                    break;

                case "5":
                    Console.Write("Введите номер телефона для поиска владельца: ");
                    string searchNumber = Console.ReadLine();
                    var owner = phoneBook.GetOwnerByPhoneNumber(searchNumber);
                    if (owner != null)
                    {
                        Console.WriteLine($"Владелец номера '{searchNumber}': {owner}");
                    }
                    else
                    {
                        Console.WriteLine($"Владелец номера '{searchNumber}' не найден.");
                    }
                    break;

                case "6":
                    phoneBook.DisplayAllEntries();
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }
        }
    }
}