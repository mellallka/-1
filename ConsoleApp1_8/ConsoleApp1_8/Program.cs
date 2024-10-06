using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите действительное число x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double result = x * (x * (x * (3 * x - 5) + 2) - 1) + 7;
        Console.WriteLine("Результат: " + result);
    }
}
