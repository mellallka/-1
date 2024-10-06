using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int hours = x / 3600;
        int minute = (x - hours * 3600) / 60;
        int second = x % 60;
        Console.WriteLine("Из них часы: " + hours + ", минуты: " + minute + ", секунды: " + second);
    }
}