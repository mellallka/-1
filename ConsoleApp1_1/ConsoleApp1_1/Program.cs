using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        double x = random.NextDouble() * 100;
        double fractionalPart = x - Math.Floor(x); // получив целую часть числа отнимаем от вещественного
        int d = (int)(fractionalPart * 10); // умножаем чтобы оставить только первое число
        Console.WriteLine("Случайное число: " + x);
        Console.WriteLine("Первая цифра дробной части числа: " + d);
    }
}
