using System;

public interface ITriangle
{
    double Area();
    double Perimeter();
    string TriangleType();
}

public abstract class Shape
{
    public abstract void DisplayInfo();
}

public class Triangle : Shape, ITriangle
{
    private double sideA;
    private double sideB;
    private double sideC;
    private double angleA;
    private double angleB;
    private double angleC;

    public Triangle(double a, double b, double c, double angleA, double angleB, double angleC)
    {
        this.sideA = a;
        this.sideB = b;
        this.sideC = c;
        this.angleA = angleA;
        this.angleB = angleB;
        this.angleC = angleC;
    }

    ~Triangle()
    {
        Console.WriteLine("Треугольник");
    }

    public double Area()
    {
        // Используем формулу Герона
        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public double Perimeter()
    {
        return sideA + sideB + sideC;
    }

    public string TriangleType()
    {
        if (sideA == sideB && sideB == sideC)
            return "Равносторонний";
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
            return "Равнобедренный";
        else if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
                 Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2) ||
                 Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2))
            return "Прямоугольный";
        else
            return "Разносторонний";
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Стороны: a={sideA}, b={sideB}, c={sideC}");
        Console.WriteLine($"Углы: A={angleA}, B={angleB}, C={angleC}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()}");
        Console.WriteLine($"Тип: {TriangleType()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите стороны треугольника:");
            Console.Write("Сторона A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите в градусах углы треугольника:");
            Console.Write("Угол A: ");
            double angleA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Угол B: ");
            double angleB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Угол C: ");
            double angleC = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(sideA, sideB, sideC, angleA, angleB, angleC);
            triangle.DisplayInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Неверно введены данные");
        }
    }
}
