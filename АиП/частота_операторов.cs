using System;
using System.Collections.Generic;

public class Phone
{
    public string PhoneNumber { get; set; }
    public string Carrier { get; set; }

    public Phone(string phoneNumber, string carrier)
    {
        PhoneNumber = phoneNumber;
        Carrier = carrier;
    }
}

public class Program
{
    public static void Main()
    {
        // Пример списка экземпляров объектов типа Phone
        List<Phone> phones = new List<Phone>
        {
            new Phone("123-456-7890", "megafon"),
            new Phone("234-567-8901", "tele2"),
            new Phone("345-678-9012", "rostelecom"),
            new Phone("456-789-0123", "megafon"),
            new Phone("567-890-1234", "rostelecom"),
            new Phone("678-901-2345", "megafon")
        };

        // Словарь для подсчета частоты появления каждого оператора связи
        Dictionary<string, int> carrierFrequency = new Dictionary<string, int>();

        // Подсчет частоты появления каждого оператора связи
        foreach (var phone in phones)
        {
            if (carrierFrequency.ContainsKey(phone.Carrier))
            {
                carrierFrequency[phone.Carrier]++;
            }
            else
            {
                carrierFrequency[phone.Carrier] = 1;
            }
        }

        // Вывод результатов
        foreach (var elem in carrierFrequency)
        {
            Console.WriteLine($"Operator: {elem.Key}, Number of Phones: {elem.Value}");
        }
    }
}