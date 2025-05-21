// Мойка машин 13.03.25 задание 2
using System;
using System.Collections.Generic;
public struct Car{
    public string YearManufacture{get;set;}
    public string CarMake{get;set;}
    public string Owner{get;set;}
    public bool IsClean{get;set;}

    public Car(string yearManufacture, string carMake, string owner, bool isClean){
        YearManufacture = yearManufacture;
        CarMake = carMake;
        Owner = owner;
        IsClean = isClean;
    }
}

public delegate void CarWashDelegate(Car car);

struct Garage{
    public event CarWashDelegate DirtyCarEvent;
    public List<Car> Cars {get;set;} = new List<Car>();

    public Garage(){
        DirtyCarEvent += CarWash.Wash;
    }

    public void CheckCars(){
        foreach (Car car in Cars){
            if (!car.IsClean){
                DirtyCarEvent?.Invoke(car);
            }
        }
    }
}

struct CarWash{
    public static void Wash(Car car){
        car.IsClean = true;
    }
}

internal struct Program{
    private static void Main(string[] args){
        Garage garage = new Garage();
        garage.Cars.Add(new Car("2020","Toyota","мяу",true));
        garage.Cars.Add(new Car("2019", "Honda", "гав",false));
        garage.Cars.Add(new Car("2021", "Ford", "мууу",true));
        garage.Cars.Add(new Car("2018", "Chevrolet","уууу", false));
        garage.Cars.Add(new Car("2022", "BMW","ээээ", true));
        garage.CheckCars();
        foreach (Car car in garage.Cars){
        Console.WriteLine($"Марка: {car.CarMake}, год: {car.YearManufacture}, владелец: {car.Owner}, чистая: {car.IsClean}");
        }
    }
}