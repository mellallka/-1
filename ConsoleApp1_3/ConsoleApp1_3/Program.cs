using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("часы:");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("минуты:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Cекунды:");
        int s = int.Parse(Console.ReadLine());

        double angle = (h * 30) + (m * 0.5) + (s * 0.5 / 60);
        Console.WriteLine("Угол между началом суток и положением часовой стрелки: " + angle + " градусов.");
    }
}