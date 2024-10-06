using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Длина первого катета:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Длина второго катет:");
        int b = int.Parse(Console.ReadLine());
        double area = 0.5 * a * b;
        double c = Math.Sqrt(a * a + b * b);
        double perimeter = a + b + c;
        Console.WriteLine("Площадь: " + area);
        Console.WriteLine("Периметр: " + perimeter);
    }
}
