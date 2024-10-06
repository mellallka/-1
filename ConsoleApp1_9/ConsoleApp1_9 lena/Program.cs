using System;

class Program
{
    static void Main()
    {
        // Ввод коэффициентов
        Console.WriteLine("Введите коэффициенты для первого уравнения (a1, b1, c1, d1):");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());
        double c1 = Convert.ToDouble(Console.ReadLine());
        double d1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите коэффициенты для второго уравнения (a2, b2, c2, d2):");
        double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());
        double c2 = Convert.ToDouble(Console.ReadLine());
        double d2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите коэффициенты для третьего уравнения (a3, b3, c3, d3):");
        double a3 = Convert.ToDouble(Console.ReadLine());
        double b3 = Convert.ToDouble(Console.ReadLine());
        double c3 = Convert.ToDouble(Console.ReadLine());
        double d3 = Convert.ToDouble(Console.ReadLine());

        // Вычисление определителей
        double D = a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);
        double Dx = d1 * (b2 * c3 - b3 * c2) - b1 * (d2 * c3 - d3 * c2) + c1 * (d2 * b3 - d3 * b2);
        double Dy = a1 * (d2 * c3 - d3 * c2) - d1 * (a2 * c3 - a3 * c2) + c1 * (a2 * d3 - a3 * d2);
        double Dz = a1 * (b2 * d3 - b3 * d2) - b1 * (a2 * d3 - a3 * d2) + d1 * (a2 * b3 - a3 * b2);

        // Проверка что определитель не равен нулю
        if (D != 0)
        {
            // Вычисление решений
            double x = Dx / D;
            double y = Dy / D;
            double z = Dz / D;

            // Вывод
            Console.WriteLine("Решение системы: x = " + x + " y: " + y + " z: " + z);
        }
        else
        {
            Console.WriteLine("Система не имеет единственного решения (определитель равен 0).");
        }
    }
}
