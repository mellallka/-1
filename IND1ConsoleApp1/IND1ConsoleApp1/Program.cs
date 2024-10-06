using System;

class Program
{
    static void Main()
    {
        // Данные для таблицы
        string[] names = new string[3];
        string[] types = new string[3];
        double[] prices = new double[3];
        int[] quantities = new int[3];

        // Ввод данных
        Console.WriteLine("Введите данные для Папки:");
        names[0] = "Папка";
        types[0] = "К";
        Console.Write("Цена за 1 шт (руб): ");
        prices[0] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Количество: ");
        quantities[0] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nВведите данные для Бумаги А4 (пачка):");
        names[1] = "Бумага А4 (пачка)";
        types[1] = "К";
        Console.Write("Цена за 1 шт (руб): ");
        prices[1] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Количество: ");
        quantities[1] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nВведите данные для Калькулятора:");
        names[2] = "Калькулятор";
        types[2] = "О";
        Console.Write("Цена за 1 шт (руб): ");
        prices[2] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Количество: ");
        quantities[2] = Convert.ToInt32(Console.ReadLine());

        // Вывод таблицы
        Console.WriteLine("\nПрайс-лист");
        Console.WriteLine("{0,-20} {1,-10} {2,-15} {3,-10}", "Наименование товара", "Тип товара", "Цена за 1 шт (грн)", "Количество");
        Console.WriteLine(new string('-', 60));

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0,-20} {1,-10} {2,-15} {3,-10}", names[i], types[i], prices[i], quantities[i]);
        }

        Console.WriteLine("\nПеречисляемый тип: К – канцтовары, О – оргтехника");
    }
}
