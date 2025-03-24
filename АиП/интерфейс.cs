using System;

// Базовый класс
public abstract class Shape
{
    public string Name { get; set; }

    protected Shape(string name)
    {
        Name = name;
    }
}

// Интерфейс
public interface IGeometricShape
{
    double Area();
    double Perimeter();
}

// Класс Окружность
public class Circle : Shape, IGeometricShape
{
    public double Radius { get; set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Класс Квадрат
public class Square : Shape, IGeometricShape
{
    public double SideLength { get; set; }

    public Square(double sideLength) : base("Square")
    {
        SideLength = sideLength;
    }

    public double Area()
    {
        return SideLength * SideLength;
    }

    public double Perimeter()
    {
        return 4 * SideLength;
    }
}

// Класс Равносторонний треугольник
public class EquilateralTriangle : Shape, IGeometricShape
{
    public double SideLength { get; set; }

    public EquilateralTriangle(double sideLength) : base("Equilateral Triangle")
    {
        SideLength = sideLength;
    }

    public double Area()
    {
        return (Math.Sqrt(3) / 4) * SideLength * SideLength;
    }

    public double Perimeter()
    {
        return 3 * SideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Пример использования
        Circle circle = new Circle(10);
        Console.WriteLine($"{circle.Name} - площадь: {circle.Area()}, периметр: {circle.Perimeter()}");

        Square square = new Square(4);
        Console.WriteLine($"{square.Name} - площадь: {square.Area()}, периметр: {square.Perimeter()}");

        EquilateralTriangle triangle = new EquilateralTriangle(3);
        Console.WriteLine($"{triangle.Name} - площадь: {triangle.Area()}, периметр: {triangle.Perimeter()}");
    }
}