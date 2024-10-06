using System;

class Program
{
    static void Main()
    {
        // Ввод произвольных значений для x, a и b
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Проверка условий допустимых значений
        if (x == 0)
        {
            Console.WriteLine("Ошибка: x не должен быть равен 0 для корректных расчетов.");
            return;
        }

        if (a * a + b * b == 0)
        {
            Console.WriteLine("Ошибка: значение a^2 + b^2 не должно быть равно 0.");
            return;
        }

        if (x * x + b < 0)
        {
            Console.WriteLine("Ошибка: значение под корнем в формуле для w не должно быть отрицательным.");
            return;
        }

        // Вычисление значений
        double w = Math.Sqrt(x * x + b) - (b * b * Math.Pow(Math.Sin(x + a), 3)) / x;
        double y = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - x / Math.Sqrt(a * a + b * b);

        // Вывод результата
        Console.WriteLine("\nРезультаты:");
        Console.WriteLine("w = " + w);
        Console.WriteLine("y = " + y);
    }
}
